using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PictureBoxScrollText
{
	public partial class Form1 : Form
	{
		Font textFont = new Font("Times New Roman", 24);
		
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Bitmap b = new Bitmap(600, 600);
			Graphics g = Graphics.FromImage(b);
			g.FillRectangle(
			  Brushes.White, new Rectangle(0, 0, b.Width, b.Height));
			g.DrawString("Hello, World", textFont, Brushes.Black, 40, 40);
			g.DrawString("Hello, World", textFont, Brushes.Red, 40, 240);
			g.DrawString("Hello, World", textFont, Brushes.Blue, 350, 40);
			g.DrawString("Hello, World", textFont, Brushes.Green, 350, 240);
			pictureBox1.BackgroundImage = b;
			pictureBox1.Size = b.Size;
		}
	}
}