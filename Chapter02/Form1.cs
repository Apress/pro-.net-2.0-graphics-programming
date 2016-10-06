using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chapter02
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			// Create two color instances with different alpha components
			Color c1 = Color.FromArgb(100, Color.Blue);
			Color c2 = Color.FromArgb(50, Color.Green);

			// Now draw a red opaque ellipse
			g.FillEllipse(Brushes.Red, 20, 20, 80, 80);

			// Now draw a rectangle, filled with the semitransparent blue
			g.FillRectangle(new SolidBrush(c1), 60, 80, 60, 60);

			// Now draw a polygon, filled with the almost-transparent green
			Point[] pa = new Point[] {
                        new Point(150, 40), 
                        new Point(90, 40), 
                        new Point(90, 120)};
			g.FillPolygon(new SolidBrush(c2), pa);
		}
	}
}