using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Chapter07
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

			// Define the rectangle that we'll use to define our clipping region
			Rectangle rect = new Rectangle(10, 10, 80, 50);

			// Draw the clipping region
			g.DrawRectangle(Pens.Black, rect);

			// Now apply the clipping region
			g.SetClip(rect);

			// Now draw something onto the drawing surface 
			// (with the clipping region applied)
			g.FillEllipse(Brushes.Blue, 20, 20, 100, 100);
			*/





			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			// Create a Region object and make sure it's empty
			Region reg = new Region();
			reg.MakeEmpty();

			// Create an irregular Region...
			// ... add a circle to the region
			GraphicsPath gp = new GraphicsPath();
			gp.AddEllipse(10, 10, 50, 50);
			reg.Union(gp);
			// ... add a triangle to the region
			gp.Reset();
			gp.AddLine(40, 40, 70, 10);
			gp.AddLine(70, 10, 100, 40);
			gp.CloseFigure();
			reg.Union(gp);
			// ... add a rectangle to the region
			reg.Union(new Rectangle(40, 50, 60, 60));

			// Set the clipping region
			g.SetClip(reg, CombineMode.Replace);

			// Paint the client rectangle green.
			// Only the clipped region will be affected
			g.FillRectangle(Brushes.Green, this.ClientRectangle);

			gp.Dispose();
			reg.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			// Prepare text string
			GraphicsPath gp = new GraphicsPath();
			gp.AddString("Swirly", new FontFamily("Times New Roman"),
						(int)(FontStyle.Bold | FontStyle.Italic),
						144, new Point(5, 5), StringFormat.GenericTypographic);

			// Set clipping region
			g.SetClip(gp);

			// Paint the client rectangle using an image.
			// Only the clipped region will be affected
			g.DrawImage(new Bitmap("swirly.jpg"), this.ClientRectangle);

			gp.Dispose();
			*/




			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			// Create the necessary objects to draw the text string
			String s = "When writing GDI+ code, there are three basic target environments for the resulting graphics: a window on a screen (a form), a page being sent to a printer, and a bitmap or image in memory. Each environment presents a drawing surface – a pixel-based representation of the form, image or page. The defining characteristics of each drawing surface are the same (size, pixel resolution and color depth) but the manifestation of these characteristics, and the way in which we can control them, is different in each case. In this chapter, we will explore these drawing surfaces, and their differences, in detail – in order that you may produce correct and efficient code for each environment.";
			s += "In addition to this, we must also have a detailed understanding of the coordinate system used to describe the points of our drawing surface, and through which we define the size, shape and position of each element of our graphic. When writing GDI+ code to produce complex and intricate graphics – and particularly when producing custom controls – you will find that a single misplaced pixel can greatly impair the visual impact of your work. By gaining an understanding the coordinate system of the surface (and some of the side-issues, such as anti-aliasing), you will come to know exactly which pixels will be affected when you invoke a drawing operation in your code – and consequently, you will be able to produce precise and effective graphics.";
			Font f = new Font("Times New Roman", 12);
			SizeF sf = g.MeasureString(s, f, 400);
			RectangleF rf = new RectangleF(10, 10, sf.Width, sf.Height);

			// Draw the text string
			g.DrawString(s, f, Brushes.Black, rf);
			f.Dispose();

			// Write info about the clipping rectangle to the console window
			Console.WriteLine("Clipping region painted: " + e.ClipRectangle);
			*/




			/*
			Graphics g = e.Graphics;

			g.FillRectangle(Brushes.White, this.ClientRectangle);

			// Create essential objects for painting text strings
			SizeF sizeF = g.MeasureString("Test", this.Font);
			StringFormat sf = new StringFormat();
			sf.LineAlignment = StringAlignment.Center;

			// Set properties of the grid
			int cellHeight = (int)sizeF.Height + 4;
			int cellWidth = 80;
			int nbrColumns = 50;
			int nbrRows = 50;

			// Output general info to console
			Console.WriteLine("-------------------------------------------");
			Console.WriteLine("e.ClipRectangle = " + e.ClipRectangle);
			Console.WriteLine("The following cells need to be redrawn " +
							  "(in whole or in part):");
			// Draw the cells and the output to console
			for (int row = 0; row < nbrRows; ++row)
			{
				for (int col = 0; col < nbrColumns; ++col)
				{
					Point cellLocation = new Point(col * cellWidth,
													   row * cellHeight);
					Rectangle cellRect = new Rectangle(cellLocation.X,
													   cellLocation.Y,
													   cellWidth, cellHeight);
					if (cellRect.IntersectsWith(e.ClipRectangle))
					{
						Console.WriteLine("Row:{0} Col:{1}", row, col);
						g.FillRectangle(Brushes.LightGray, cellRect);
						g.DrawRectangle(Pens.Black, cellRect);
						String s = String.Format("{0},{1}", col, row);
						g.DrawString(s, this.Font, Brushes.Black, cellRect, sf);
					}
					else
					{
						// Do nothing...
					}
				}
			}
			*/






		}
	}
}