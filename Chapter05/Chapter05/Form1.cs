using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace Chapter05
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public bool ThumbnailCallback()
		{
			return false;
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			// uncomment a section to run that example




			/*
			Graphics g = e.Graphics;
			Bitmap bmp = new Bitmap("rama.jpg");
			g.DrawImage(bmp, 0, 0);
			*/





			/*
			Graphics g = e.Graphics;
			Bitmap bmp = new Bitmap("rama.jpg");
			g.DrawImage(bmp, 0, 0);

			Console.WriteLine("Screen resolution: " + g.DpiX + "DPI");
			Console.WriteLine("Image resolution: " +
									bmp.HorizontalResolution + "DPI");
			Console.WriteLine("Image Width: " + bmp.Width);
			Console.WriteLine("Image Height: " + bmp.Height);

			SizeF s = new SizeF(bmp.Width * (g.DpiX / bmp.HorizontalResolution),
								bmp.Height * (g.DpiY / bmp.VerticalResolution));
			Console.WriteLine("Display size of image: " + s);
			*/





			/*
			Graphics g = e.Graphics;
			Bitmap bmp = new Bitmap("rama.jpg");

			Rectangle r = new Rectangle(0, 0, bmp.Width, bmp.Height);
			g.DrawImage(bmp, r, r, GraphicsUnit.Pixel);
			*/





			/*
			Graphics g = e.Graphics;
			Bitmap bmp = new Bitmap("rama.jpg");

			Rectangle r = new Rectangle(0, 0, bmp.Width, bmp.Height);
			g.DrawImage(bmp, this.ClientRectangle);
			*/





			/*
			Graphics g = e.Graphics;
			Bitmap bmp = new Bitmap("rama.jpg");

			g.FillRectangle(Brushes.White, this.ClientRectangle);
			bmp.SetResolution(600f, 600f);
			g.DrawImage(bmp, 0, 0);
			bmp.SetResolution(1200f, 1200f);
			g.DrawImage(bmp, 180, 0);
			*/





			/*
			Graphics g = e.Graphics;
			Bitmap bmp = new Bitmap("rama.jpg");
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			int width = bmp.Width;
			int height = bmp.Height;

			// Resize the image using the lowest quality interpolation mode
			g.InterpolationMode = InterpolationMode.NearestNeighbor;
			g.DrawImage(
				bmp,
				new Rectangle(10, 10, 120, 120),    // source rectangle
				new Rectangle(0, 0, width, height), // destination rectangle
				GraphicsUnit.Pixel);

			// Resize the image using the highest quality interpolation mode
			g.InterpolationMode = InterpolationMode.HighQualityBicubic;
			g.DrawImage(
				bmp,
				new Rectangle(130, 10, 120, 120),   // source rectangle
				new Rectangle(0, 0, width, height), // destination rectangle
				GraphicsUnit.Pixel);
			*/





			/*
			Graphics g = e.Graphics;
			Bitmap bmp = new Bitmap("rama.jpg");
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			Rectangle sr = new Rectangle(80, 60, 400, 400);
			Rectangle dr = new Rectangle(0, 0, 200, 200);
			g.DrawImage(bmp, dr, sr, GraphicsUnit.Pixel);
			*/





			/*
			Graphics g = e.Graphics;
			Bitmap bmp = new Bitmap("rama.jpg");
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			Point[] destinationPoints = {
				new Point(0, 0),    // destination for upper-left point of original
				new Point(100, 0),  // destination for upper-right point of original
				new Point(50, 100)};// destination for lower-left point of original
			g.DrawImage(bmp, destinationPoints);
			*/





			/*
			Graphics g = e.Graphics;
			Bitmap bmp = new Bitmap("rama.jpg");
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			Rectangle r = new Rectangle(120, 120, 400, 400);
			Bitmap bmp2 = bmp.Clone(r, System.Drawing.Imaging.PixelFormat.DontCare);
			g.DrawImage(bmp, new Rectangle(0, 0, 200, 200));
			g.DrawImage(bmp2, new Rectangle(210, 0, 200, 200));
			bmp2.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			Bitmap bmp = new Bitmap("rama.jpg");
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			Image.GetThumbnailImageAbort thumbnailCallback =
						   new Image.GetThumbnailImageAbort(ThumbnailCallback);
			Image tn = bmp.GetThumbnailImage(
						   40, 40, thumbnailCallback, IntPtr.Zero);
			g.DrawImage(tn, 0, 0, tn.Width, tn.Height);
			tn.Dispose();
			*/





			/*
			Bitmap bmp = new Bitmap(100, 100);
			Graphics gImage = Graphics.FromImage(bmp);
			gImage.FillRectangle(Brushes.Red, 0, 0, bmp.Width, bmp.Height);
			gImage.DrawRectangle(Pens.Black, 10, 10, bmp.Width - 20, bmp.Height - 20);

			Graphics gScreen = e.Graphics;
			gScreen.FillRectangle(Brushes.White, this.ClientRectangle);
			gScreen.DrawImage(bmp, new Rectangle(10, 10, bmp.Width, bmp.Height));
			*/





			/*
			Graphics gForm = e.Graphics;
			gForm.FillRectangle(Brushes.White, this.ClientRectangle);
			for (int i = 1; i <= 7; ++i)
			{
				Rectangle r = new Rectangle(i * 40 - 15, 0, 15,
											this.ClientRectangle.Height);
				gForm.FillRectangle(Brushes.Orange, r);
			}

			// Create a Bitmap image in memory and set its CompositingMode
			Bitmap bmp = new Bitmap(260, 260,
				System.Drawing.Imaging.PixelFormat.Format32bppArgb);
			Graphics gBmp = Graphics.FromImage(bmp);
			gBmp.CompositingMode =
				System.Drawing.Drawing2D.CompositingMode.SourceCopy;

			// Create a red color with an alpha component
			// then draw a red circle to the bitmap in memory
			Color red = Color.FromArgb(0x60, 0xff, 0, 0);
			Brush redBrush = new SolidBrush(red);
			gBmp.FillEllipse(redBrush, 70, 70, 160, 160);

			// Create a green color with an alpha component
			// then draw a green rectangle to the bitmap in memory
			Color green = Color.FromArgb(0x40, 0, 0xff, 0);
			Brush greenBrush = new SolidBrush(green);
			gBmp.FillRectangle(greenBrush, 10, 10, 140, 140);
			// Now draw the bitmap on our window
			gForm.DrawImage(bmp, 20, 20, bmp.Width, bmp.Height);

			// Dispose of all objects that consume resources
			bmp.Dispose();
			gBmp.Dispose();
			redBrush.Dispose();
			greenBrush.Dispose();
			*/





			/*
			Graphics gForm = e.Graphics;
			gForm.FillRectangle(Brushes.White, this.ClientRectangle);

			// Create a bitmap in memory
			Bitmap bmp = new Bitmap(6, 6);
			Graphics gBmp = Graphics.FromImage(bmp);

			// Give the bitmap a white background
			gBmp.FillRectangle(Brushes.White, 0, 0, bmp.Width, bmp.Height);

			// Draw a red diagonal line in the bitmap
			gBmp.DrawLine(Pens.Red, 0, 0, 5, 5);

			// Now draw the bitmap on our window
			gForm.DrawImage(bmp, 20, 20, bmp.Width, bmp.Height);

			// Finally, write the pixel information to the console window
			for (int y = 0; y < bmp.Height; ++y)
			{
				for (int x = 0; x < bmp.Width; ++x)
				{
					Color c = bmp.GetPixel(x, y);
					Console.Write("{0,2:x}{1,2:x}{2,2:x}{3,2:x}  ",
						c.A, c.R, c.G, c.G);
				}
				Console.WriteLine();
			}
			bmp.Dispose();
			*/




			/*
			Graphics g = e.Graphics;
			Bitmap bmp = new Bitmap("rama.jpg");
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			// Draw a set of gray vertical bars on the form
			for (int i = 1; i <= 7; ++i)
			{
				Rectangle r = new Rectangle(i * 40 - 15, 0, 15,
					this.ClientRectangle.Height);
				g.FillRectangle(Brushes.Gray, r);
			}

			// Create a color matrix
			// The value 0.6 in row 4, column 4 specifies the alpha value
			float[][] matrixItems = {
                                new float[] {1, 0, 0, 0, 0},
                                new float[] {0, 1, 0, 0, 0},
                                new float[] {0, 0, 1, 0, 0},
                                new float[] {0, 0, 0, 0.6f, 0}, 
                                new float[] {0, 0, 0, 0, 1}};
			ColorMatrix colorMatrix = new ColorMatrix(matrixItems);

			// Create an ImageAttributes object and set its color matrix
			ImageAttributes imageAtt = new ImageAttributes();
			imageAtt.SetColorMatrix(
				colorMatrix,
				ColorMatrixFlag.Default,
				ColorAdjustType.Bitmap);

			// Now draw the semitransparent bitmap image.
			g.DrawImage(
				bmp,
				this.ClientRectangle,  // destination rectangle
				0.0f,             // source rectangle x 
				0.0f,             // source rectangle y
				bmp.Width,        // source rectangle width
				bmp.Height,       // source rectangle height
				GraphicsUnit.Pixel,
				imageAtt);

			imageAtt.Dispose();
			*/




		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// uncomment a section to run that example





			/*
			// Get an array of available codecs
			ImageCodecInfo[] availableCodecs;
			availableCodecs = ImageCodecInfo.GetImageEncoders();
			int numCodecs = availableCodecs.Length;

			for (int i = 0; i < numCodecs; i++)
			{
				Console.WriteLine("Codec Name = " + availableCodecs[i].CodecName);
				Console.WriteLine("Class ID = " + availableCodecs[i].Clsid.ToString());
				Console.WriteLine("Filename Extension = " +
					availableCodecs[i].FilenameExtension);
				Console.WriteLine("Flags = " +
					availableCodecs[i].Flags.ToString());
				Console.WriteLine("Format Description = " +
					availableCodecs[i].FormatDescription);
				Console.WriteLine("Format ID = " +
					availableCodecs[i].FormatID.ToString());
				Console.WriteLine("MimeType = " + availableCodecs[i].MimeType);
				Console.WriteLine("Version = " +
					availableCodecs[i].Version.ToString());
				Console.WriteLine();
			}
			*/





			/*
			// Create two new bitmap images
			Bitmap bmp1 = new Bitmap(100, 100, PixelFormat.Format32bppArgb);
			Bitmap bmp2 = new Bitmap(100, 100, PixelFormat.Format24bppRgb);

			// Test for alpha 
			bool b1 = ((bmp1.PixelFormat & PixelFormat.Alpha) != 0);
			bool b2 = ((bmp2.PixelFormat & PixelFormat.Alpha) != 0);

			// Output results to console window
			Console.WriteLine("bmp1 has alpha?: " + b1);
			Console.WriteLine("bmp2 has alpha?: " + b2);

			// Clean up
			bmp1.Dispose();
			bmp2.Dispose();
			*/





		}
	}
}