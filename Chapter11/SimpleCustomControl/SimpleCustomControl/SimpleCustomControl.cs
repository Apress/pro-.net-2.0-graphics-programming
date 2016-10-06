using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SimpleCustomControl
{
	public partial class SimpleCustomControl : System.Windows.Forms.Control
	{
		public SimpleCustomControl()
		{
			InitializeComponent();
		}

		private void SimpleCustomControl_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.Yellow, ClientRectangle);
			g.DrawString("Hello, world", Font, Brushes.Black, 0, 0);
		}
	}
}