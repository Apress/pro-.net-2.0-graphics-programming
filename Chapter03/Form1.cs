using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace Chapter03
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

			Pen p = new Pen(Color.Black);
			g.DrawLine(p, 0, 0, 100, 100);
			p.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			Pen p = new Pen(Color.Black);
			g.DrawRectangle(p, 3, 3, 8, 7);
			p.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			Pen p = new Pen(Color.Black, 3);
			p.Alignment = PenAlignment.Center;
			g.DrawRectangle(p, 3, 3, 8, 7);
			p.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			Pen p = new Pen(Color.Black, 3);
			p.Alignment = PenAlignment.Inset;
			g.DrawRectangle(p, 3, 3, 8, 7);
			p.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);
			Pen p = new Pen(Color.Black, 1);

			p.DashStyle = DashStyle.Dash;
			g.DrawLine(p, 3, 3, 100, 3);
			p.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);
			Pen p = new Pen(Color.Black, 1);

			// The following line creates the custom dash pattern:
			float[] f = { 15, 5, 10, 5 };

			p.DashPattern = f;
			g.DrawRectangle(p, 10, 10, 80, 100);
			p.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			Pen p = new Pen(Color.Black, 2);

			// The following line creates the custom dash pattern:
			float[] f = { 15, 5, 10, 5 };

			p.DashPattern = f;
			g.DrawRectangle(p, 10, 10, 80, 100);
			p.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			g.SmoothingMode = SmoothingMode.AntiAlias;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			Pen p = new Pen(Color.Black, 10);
			p.StartCap = LineCap.Round;
			p.EndCap = LineCap.ArrowAnchor;
			g.DrawLine(p, 30, 30, 80, 30);
			p.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			g.SmoothingMode = SmoothingMode.AntiAlias;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			Pen p = new Pen(Color.Black, 10);
			p.LineJoin = LineJoin.Bevel;
			e.Graphics.DrawRectangle(p, 20, 20, 60, 60);
			p.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			Bitmap bmp = new Bitmap("alphabet.gif");
			TextureBrush tb = new TextureBrush(bmp);

			g.FillRectangle(tb, 20, 20, 200, 70);
			bmp.Dispose();
			tb.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			Bitmap bmp = new Bitmap("alphabet.gif");
			TextureBrush tb = new TextureBrush(bmp);

			g.FillRectangle(tb, 20, 20, 200, 70);
			g.FillRectangle(tb, 45, 45, 70, 150);
			bmp.Dispose();
			tb.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			Bitmap bmp = new Bitmap("alphabet.gif");
			TextureBrush tb = new TextureBrush(bmp, new Rectangle(0, 0, 25, 25));

			g.FillRectangle(tb, 20, 20, 200, 70);
			g.FillRectangle(tb, 45, 45, 70, 150);
			bmp.Dispose();
			tb.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			Bitmap bmp = new Bitmap("alphabet.gif");
			TextureBrush tb = new TextureBrush(bmp);

			tb.WrapMode = WrapMode.Tile;
			g.FillRectangle(tb, this.ClientRectangle);
			bmp.Dispose();
			tb.Dispose();
			*/





			/*
			Bitmap bmp = new Bitmap("alphabet.gif");
			Graphics g = e.Graphics;
			// Use a color matrix to change the color properties of the image
			float[][] matrixItems = {
                        new float[] {0.2f, 0, 0, 0, 0},
                        new float[] {0, 0.8f, 0, 0, 0},
                        new float[] {0, 0, 1, 0, 0},
                        new float[] {0, 0, 0, 1, 0}, 
                        new float[] {0, 0, 0, 0, 1}};
			ColorMatrix colorMatrix = new ColorMatrix(matrixItems);

			// Create an ImageAttributes object and set its color matrix
			ImageAttributes imageAtt = new ImageAttributes();
			imageAtt.SetColorMatrix(
								colorMatrix,
								ColorMatrixFlag.Default,
								ColorAdjustType.Bitmap);

			// Create a TextureBrush object using the alphabet.gif image, 
			// adjusted by the attributes in the ImageAttributes object
			TextureBrush tb = new TextureBrush(
						bmp,
						new Rectangle(0, 0, bmp.Width, bmp.Height),
						imageAtt);
			tb.WrapMode = WrapMode.Tile;
			g.FillRectangle(tb, this.ClientRectangle);
			bmp.Dispose();
			tb.Dispose();
			*/





			/*
			Graphics g = e.Graphics;

			LinearGradientBrush lgb = new LinearGradientBrush(
												 new Point(0, 0),
												 new Point(50, 10),
												 Color.White,
												 Color.Black);
			g.FillRectangle(lgb, this.ClientRectangle);
			lgb.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			GraphicsPath gp = new GraphicsPath();

			gp.AddLine(10, 10, 110, 15);
			gp.AddLine(110, 15, 100, 96);
			gp.AddLine(100, 96, 15, 110);
			gp.CloseFigure();

			g.FillRectangle(Brushes.White, this.ClientRectangle);
			g.DrawPath(Pens.Black, gp);
			gp.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			GraphicsPath gp = new GraphicsPath();

			gp.AddLine(10, 10, 110, 15);
			gp.AddLine(110, 15, 100, 96);
			gp.AddLine(100, 96, 15, 110);
			gp.CloseFigure();

			g.FillRectangle(Brushes.White, this.ClientRectangle);
			g.SmoothingMode = SmoothingMode.AntiAlias;

			PathGradientBrush pgb = new PathGradientBrush(gp);
			pgb.CenterColor = Color.White;
			pgb.SurroundColors = new Color[]
				{
				Color.Blue
				};
			g.FillPath(pgb, gp);

			g.DrawPath(Pens.Black, gp);
			pgb.Dispose();
			gp.Dispose();
			*/





			/*
			Graphics g = e.Graphics;

			HatchBrush hb = new HatchBrush(
							  HatchStyle.Cross,
							  Color.White,
							  Color.Black);
			g.FillRectangle(hb, this.ClientRectangle);
			hb.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);
			HatchBrush hb = new HatchBrush(
					 HatchStyle.WideUpwardDiagonal,
					 Color.White,
					 Color.Black);
			Pen hp = new Pen(hb, 8);
			g.DrawRectangle(hp, 15, 15, 70, 70);
			hb.Dispose();
			hp.Dispose();
			*/




		}
	}
}