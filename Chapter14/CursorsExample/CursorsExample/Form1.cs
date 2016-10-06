using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CursorsExample
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			Point p = new Point(e.X, e.Y);
			Rectangle r;

			if (new Rectangle(0, 0, 100, 100).Contains(p))
				this.Cursor = new Cursor("MyCursor.cur");
			else if (new Rectangle(100, 0, 100, 100).Contains(p))
				this.Cursor = Cursors.Hand;
			else if (new Rectangle(0, 100, 100, 100).Contains(p))
				this.Cursor = Cursors.VSplit;
			else if (new Rectangle(100, 100, 100, 100).Contains(p))
				this.Cursor = Cursors.UpArrow;
			else
				this.Cursor = Cursors.Default;
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.Blue, 0, 0, 100, 100);
			g.FillRectangle(Brushes.Red, 100, 0, 100, 100);
			g.FillRectangle(Brushes.Yellow, 0, 100, 100, 100);
			g.FillRectangle(Brushes.Green, 100, 100, 100, 100);
		}
	}
}