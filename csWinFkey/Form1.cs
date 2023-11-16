namespace csWinFkey
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		int space = 0;
		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			// если введенный символ буква или пробел
			if (Char.IsLetter(e.KeyChar) || (e.KeyChar == ' '))
			{
				// если курсор в начале строки
				if (textBox1.SelectionStart == 0)
				{// введенный символ - пробел, говорим, что событие обработано
					if (e.KeyChar == ' ') e.Handled = true;
					// иначе переводим текущую букву в ерхний регистр
					else e.KeyChar = Char.ToUpper(e.KeyChar);
				}
				// если же курсор не в начале строки и
				// текущий символ - пробел
				else if (e.KeyChar == ' ')
				{
					// если пробелов еще не было, отмечаем один пробел
					if (space == 0) space = 1;
					// иначе говорим, что событие обработано
					else e.Handled = true;
				}
				// если же пробел уже был поставлен
				else if (space > 0)
				{
					// переводим текущий символ в верхний регистр
					e.KeyChar = Char.ToUpper(e.KeyChar);
					// увеличиваем количество пробелов
					space++;
				}
				else { }
			}
			// говорим, что событие обработано
			else e.Handled = true;
		}

		private void textBox1_KeyUp(object sender, KeyEventArgs e)
		{
			// точка после имени
			if (space == 2)
			{
				textBox1.AppendText(".");
				textBox1.SelectionStart = textBox1.Text.Length;
				textBox1.SelectionLength = 0;
			}
			// точка после отчества
			if (space == 3)
			{
				textBox1.AppendText(".");
				textBox1.SelectionStart = 0;
				textBox1.SelectionLength = textBox1.Text.Length;
				space = 0;
			}
		}
	}
}
