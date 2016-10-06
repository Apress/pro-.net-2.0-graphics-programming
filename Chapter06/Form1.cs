using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Chapter06
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			// uncomment a section to run that example





			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			// Create a new GraphicsPath object
			GraphicsPath gp = new GraphicsPath();

			// Create a figure
			gp.AddLine(10, 10, 10, 50);
			gp.AddBezier(10, 50, 10, 55, 25, 70, 30, 70);
			gp.AddLine(30, 70, 60, 70);
			gp.AddBezier(60, 70, 85, 70, 90, 55, 90, 50);
			gp.AddLine(90, 50, 90, 30);
			gp.AddLine(90, 30, 120, 10);
			gp.AddLine(120, 10, 150, 10);
			gp.AddLine(150, 10, 170, 30);
			gp.AddLine(170, 30, 170, 70);

			// Create another figure
			gp.StartFigure();
			gp.AddLine(60, 110, 40, 160);
			gp.AddLine(40, 160, 60, 180);
			gp.AddLine(60, 180, 140, 150);
			gp.AddLine(140, 150, 120, 110);

			// Draw the path
			g.DrawPath(Pens.Black, gp);

			// Clean up
			gp.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			// Create a new GraphicsPath object
			GraphicsPath gp = new GraphicsPath();

			// Create a figure
			gp.AddLine(10, 10, 10, 50);
			gp.AddBezier(10, 50, 10, 55, 25, 70, 30, 70);
			gp.AddLine(30, 70, 60, 70);
			// Close this figure
			gp.CloseFigure();

			// Create another figure
			gp.StartFigure();
			gp.AddLine(60, 110, 40, 160);
			gp.AddLine(40, 160, 60, 180);
			gp.AddLine(60, 180, 140, 150);
			gp.AddLine(140, 150, 120, 110);

			// Draw the path
			g.DrawPath(Pens.Black, gp);

			// Clean up
			gp.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			// Create a new GraphicsPath object
			GraphicsPath gp = new GraphicsPath();

			// Create a figure
			gp.AddLine(10, 10, 10, 50);
			gp.AddBezier(10, 50, 10, 55, 25, 70, 30, 70);
			gp.AddLine(30, 70, 60, 70);

			// Create another figure
			gp.StartFigure();
			gp.AddLine(60, 110, 40, 160);
			gp.AddLine(40, 160, 60, 180);
			gp.AddLine(60, 180, 140, 150);
			gp.AddLine(140, 150, 120, 110);

			// Close all figures
			gp.CloseAllFigures();

			// Draw the path
			g.DrawPath(Pens.Black, gp);

			// Clean up
			gp.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			// Create a new GraphicsPath object
			GraphicsPath gp = new GraphicsPath();

			// Create a figure
			gp.AddRectangle(new Rectangle(10, 50, 80, 20));

			// Create another figure
			gp.AddEllipse(50, 10, 20, 80);

			// Draw the path
			g.DrawPath(Pens.Black, gp);

			// Clean up
			gp.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			GraphicsPath gp = new GraphicsPath();

			// Create an open figure
			gp.AddLine(10, 10, 10, 50);
			gp.AddLine(10, 50, 50, 50);
			gp.AddLine(50, 50, 50, 10);

			// Start a new figure
			gp.StartFigure();
			gp.AddLine(60, 10, 60, 50);
			gp.AddLine(60, 50, 100, 50);
			gp.AddLine(100, 50, 100, 10);
			gp.CloseFigure();

			// Add a geometric shape (a rectangle) to the path
			Rectangle r = new Rectangle(110, 10, 40, 40);
			gp.AddEllipse(r);

			// Fill the area 'bounded' by the path
			g.FillPath(Brushes.Orange, gp);

			// Draw the path
			g.DrawPath(Pens.Black, gp);

			// Clean up
			gp.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			// Create a GraphicsPath
			GraphicsPath gp = new GraphicsPath();

			// Create an open figure
			gp.AddLine(10, 10, 10, 50);
			gp.AddLine(10, 50, 50, 50);
			gp.AddLine(50, 50, 50, 10);

			// Start a new figure
			gp.StartFigure();
			gp.AddLine(60, 10, 60, 50);
			gp.AddLine(60, 50, 100, 50);
			gp.AddLine(100, 50, 100, 10);
			gp.CloseFigure();

			// Add a geometric shape (a rectangle) to the path
			Rectangle r = new Rectangle(110, 10, 40, 40);
			gp.AddEllipse(r);

			// Create a Region whose boundary is the above GraphicsPath 
			Region reg = new Region(gp);

			// Fill the Region
			g.FillRegion(Brushes.Green, reg);

			// Clean up
			reg.Dispose();
			gp.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			// Create a GraphicsPath
			GraphicsPath gp = new GraphicsPath();

			// Create a figure
			gp.AddLine(10, 10, 10, 50);
			gp.AddBezier(10, 50, 10, 55, 25, 70, 30, 70);
			gp.AddLine(30, 70, 60, 70);
			gp.AddBezier(60, 70, 85, 70, 90, 55, 90, 50);
			gp.AddLine(90, 50, 90, 30);
			gp.AddLine(90, 30, 120, 10);
			gp.AddLine(120, 10, 150, 10);
			gp.AddLine(150, 10, 170, 30);
			gp.AddLine(170, 30, 170, 70);

			// Create another figure
			gp.StartFigure();
			gp.AddLine(60, 110, 40, 160);
			gp.AddLine(40, 160, 60, 180);
			gp.AddLine(60, 180, 140, 150);
			gp.AddLine(140, 150, 120, 110);

			// Create a Region whose boundary is the above GraphicsPath 
			Region reg = new Region(gp);

			// Fill the Region
			g.FillRegion(Brushes.Green, reg);

			// Clean up
			reg.Dispose();
			gp.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			// Create a Region object, cut a rectangular hole in it, and fill it
			Region r = new Region(new Rectangle(30, 30, 30, 60));
			r.Exclude(new Rectangle(40, 40, 10, 10));
			g.FillRegion(Brushes.Orange, r);

			// Tell us about the Region
			Console.WriteLine("This Region: ");
			Console.WriteLine(r.IsInfinite(g) ? " - is infinite"
											  : " - is finite");
			Console.WriteLine(r.IsEmpty(g) ? " - is empty"
										   : " - is non-empty");

			PointF pf = new PointF(35.0f, 30.0f);
			Console.WriteLine((r.IsVisible(pf) ? " - includes"
											   : " - excludes")
							  + " the point (35.0, 50.0)");

			Rectangle rect = new Rectangle(25, 65, 15, 15);
			g.DrawRectangle(Pens.Black, rect);
			Console.WriteLine((r.IsVisible(rect) ? " - is visible"
												 : " - is invisible")
							  + " in the rectangle shown");

			r.Dispose();
			*/




		}
	}
}