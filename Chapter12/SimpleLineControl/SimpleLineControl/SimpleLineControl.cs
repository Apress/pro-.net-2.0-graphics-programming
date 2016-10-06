using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SimpleLineControl
{
	[Designer(typeof(SimpleLineControlDesigner))]
	public partial class SimpleLineControl : System.Windows.Forms.Control
	{
		private int linePosition = 5;

		[Category("Appearance")]
		[DefaultValue(5)]
		public int LinePosition
		{
			get
			{
				return linePosition;
			}
			set
			{
				linePosition = value;
			}
		}

		public SimpleLineControl()
		{
			InitializeComponent();
		}

		private void SimpleLineControl_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.DrawLine(Pens.Black, LinePosition, 0,
			  LinePosition, ClientRectangle.Height);
		}
	}
}