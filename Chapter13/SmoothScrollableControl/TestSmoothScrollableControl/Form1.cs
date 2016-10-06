using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestSmoothScrollableControl
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Bitmap b = new Bitmap(600, 600);
			Graphics g = Graphics.FromImage(b);
			g.FillRectangle(Brushes.White,
			  new Rectangle(0, 0, b.Width, b.Height));
			g.DrawString("Hello, World",
			  new Font("Times New Roman", 24), Brushes.Black, 40, 40);
			g.DrawString("Hello, World",
			  new Font("Times New Roman", 24), Brushes.Red, 350, 40);
			g.DrawString("Hello, World",
			  new Font("Times New Roman", 24), Brushes.Blue, 40, 240);
			g.DrawString("Hello, World",
			  new Font("Times New Roman", 24), Brushes.Green, 350, 240);
			g.DrawString("Hello, World",
			  new Font("Times New Roman", 24), Brushes.Aquamarine, 40, 440);
			g.DrawString("Hello, World",
			  new Font("Times New Roman", 24), Brushes.Magenta, 350, 440);
			smoothScrollableControl1.ScrollingImage = b;
		}
	}
}