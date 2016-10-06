using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace HitTestExample
{
	public partial class Form1 : Form
	{
		private GraphicsPath path1;
		private GraphicsPath path2;
		private Region reg;
		private Rectangle rect;
		private bool inPath = false;
		private bool inRegion = false;
		private bool inRect = false;

		public Form1()
		{
			InitializeComponent();
			path1 = new GraphicsPath();
			path1.AddLine(10, 10, 50, 10);
			path1.AddLine(50, 10, 50, 40);
			path1.AddLine(50, 40, 10, 50);
			path1.CloseFigure();
			path2 = new GraphicsPath();
			path2.AddLine(70, 10, 130, 10);
			path2.AddLine(130, 10, 130, 40);
			path2.AddLine(130, 40, 160, 40);
			path2.AddLine(160, 40, 160, 60);
			path2.AddLine(160, 60, 110, 60);
			path2.AddLine(110, 60, 110, 40);
			path2.AddLine(110, 40, 70, 40);
			path2.CloseFigure();
			reg = new Region(path2);
			rect = new Rectangle(10, 70, 80, 40);
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, ClientRectangle);
			g.DrawPath(Pens.Black, path1);
			g.DrawPath(Pens.Black, path2);
			g.DrawRectangle(Pens.Black, rect);
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			Graphics g = this.CreateGraphics();

			try
			{
				if (inPath)
				{
					if (!path1.IsVisible(e.X, e.Y))
					{
						g.FillPath(Brushes.White, path1);
						g.DrawPath(Pens.Black, path1);
						inPath = false;
						return;
					}
				}
				else if (inRegion)
				{
					if (!reg.IsVisible(e.X, e.Y))
					{
						g.FillRegion(Brushes.White, reg);
						g.DrawPath(Pens.Black, path2);
						inRegion = false;
						return;
					}
				}
				else if (inRect)
				{
					if (!rect.Contains(e.X, e.Y))
					{
						g.FillRectangle(Brushes.White, rect);
						g.DrawRectangle(Pens.Black, rect);
						inRect = false;
						return;
					}
				}
				if (!inPath)
				{
					if (path1.IsVisible(e.X, e.Y))
					{
						g.FillPath(Brushes.LightBlue, path1);
						g.DrawPath(Pens.Black, path1);
						inPath = true;
						return;
					}
				}
				if (!inRegion)
				{
					if (reg.IsVisible(e.X, e.Y))
					{
						g.FillRegion(Brushes.Pink, reg);
						g.DrawPath(Pens.Black, path2);
						inRegion = true;
						return;
					}
				}
				if (!inRect)
				{
					if (rect.Contains(e.X, e.Y))
					{
						g.FillRectangle(Brushes.LightGreen, rect);
						g.DrawRectangle(Pens.Black, rect);
						inRect = true;
						return;
					}
				}
			}
			finally
			{
				g.Dispose();
			}
		}
	}
}