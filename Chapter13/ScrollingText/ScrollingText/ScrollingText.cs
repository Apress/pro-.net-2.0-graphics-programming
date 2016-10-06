using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ScrollingText
{
	public partial class ScrollingText : System.Windows.Forms.Panel
	{
		Font textFont = new Font("Times New Roman", 24);
		
		public ScrollingText()
		{
			InitializeComponent();
		}

		private void ScrollingText_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.TranslateTransform(
			  this.AutoScrollPosition.X, this.AutoScrollPosition.Y);
			g.DrawString("Hello, World", textFont, Brushes.Black, 40, 40);
			g.DrawString("Hello, World", textFont, Brushes.Red, 40, 240);
			g.DrawString("Hello, World", textFont, Brushes.Blue, 350, 40);
			g.DrawString("Hello, World", textFont, Brushes.Green, 350, 240);
		}
	}
}