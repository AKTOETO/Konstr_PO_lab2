namespace csWinFkey
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			label1 = new Label();
			textBox1 = new TextBox();
			panel1 = new Panel();
			splitContainer2 = new SplitContainer();
			splitContainer1 = new SplitContainer();
			contextMenuStrip1 = new ContextMenuStrip(components);
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
			splitContainer2.Panel1.SuspendLayout();
			splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Dock = DockStyle.Fill;
			label1.Location = new Point(0, 0);
			label1.Name = "label1";
			label1.Size = new Size(87, 23);
			label1.TabIndex = 0;
			label1.Text = "Введите ФИО";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			textBox1.Dock = DockStyle.Fill;
			textBox1.Location = new Point(0, 0);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(200, 23);
			textBox1.TabIndex = 1;
			textBox1.KeyPress += textBox1_KeyPress;
			textBox1.KeyUp += textBox1_KeyUp;
			// 
			// panel1
			// 
			panel1.Controls.Add(splitContainer2);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(295, 66);
			panel1.TabIndex = 2;
			// 
			// splitContainer2
			// 
			splitContainer2.Dock = DockStyle.Fill;
			splitContainer2.FixedPanel = FixedPanel.Panel1;
			splitContainer2.IsSplitterFixed = true;
			splitContainer2.Location = new Point(0, 0);
			splitContainer2.Name = "splitContainer2";
			splitContainer2.Orientation = Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			splitContainer2.Panel1.Controls.Add(splitContainer1);
			splitContainer2.Size = new Size(295, 66);
			splitContainer2.SplitterDistance = 25;
			splitContainer2.TabIndex = 0;
			// 
			// splitContainer1
			// 
			splitContainer1.BorderStyle = BorderStyle.FixedSingle;
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.FixedPanel = FixedPanel.Panel1;
			splitContainer1.IsSplitterFixed = true;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(label1);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(textBox1);
			splitContainer1.Size = new Size(295, 25);
			splitContainer1.SplitterDistance = 89;
			splitContainer1.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(61, 4);
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(295, 26);
			Controls.Add(panel1);
			Name = "Form1";
			Text = "Form1";
			panel1.ResumeLayout(false);
			splitContainer2.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
			splitContainer2.ResumeLayout(false);
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private TextBox textBox1;
		private Panel panel1;
		private SplitContainer splitContainer1;
		private ContextMenuStrip contextMenuStrip1;
		private SplitContainer splitContainer2;
	}
}
