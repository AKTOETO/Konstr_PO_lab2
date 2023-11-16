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
			// ���� ��������� ������ ����� ��� ������
			if (Char.IsLetter(e.KeyChar) || (e.KeyChar == ' '))
			{
				// ���� ������ � ������ ������
				if (textBox1.SelectionStart == 0)
				{// ��������� ������ - ������, �������, ��� ������� ����������
					if (e.KeyChar == ' ') e.Handled = true;
					// ����� ��������� ������� ����� � ������ �������
					else e.KeyChar = Char.ToUpper(e.KeyChar);
				}
				// ���� �� ������ �� � ������ ������ �
				// ������� ������ - ������
				else if (e.KeyChar == ' ')
				{
					// ���� �������� ��� �� ����, �������� ���� ������
					if (space == 0) space = 1;
					// ����� �������, ��� ������� ����������
					else e.Handled = true;
				}
				// ���� �� ������ ��� ��� ���������
				else if (space > 0)
				{
					// ��������� ������� ������ � ������� �������
					e.KeyChar = Char.ToUpper(e.KeyChar);
					// ����������� ���������� ��������
					space++;
				}
				else { }
			}
			// �������, ��� ������� ����������
			else e.Handled = true;
		}

		private void textBox1_KeyUp(object sender, KeyEventArgs e)
		{
			// ����� ����� �����
			if (space == 2)
			{
				textBox1.AppendText(".");
				textBox1.SelectionStart = textBox1.Text.Length;
				textBox1.SelectionLength = 0;
			}
			// ����� ����� ��������
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
