using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace AlphaDragExample
{
	public partial class Form1 : Form
	{
		[DllImport("gdi32.dll")]
		private static extern bool BitBlt(
		  IntPtr hdcDest,     // handle to destination DC (device context)
		  int nXDest,         // x-coord of destination upper-left corner
		  int nYDest,         // y-coord of destination upper-left corner
		  int nWidth,         // width of destination rectangle
		  int nHeight,        // height of destination rectangle
		  IntPtr hdcSrc,      // handle to source DC
		  int nXSrc,          // x-coordinate of source upper-left corner
		  int nYSrc,          // y-coordinate of source upper-left corner
		  System.Int32 dwRop  // raster operation code
		  );

		[DllImport("gdi32.dll")]
		private static extern IntPtr CreateDC(
		  String driverName,
		  String deviceName,
		  String output,
		  IntPtr lpInitData
		  );

		[System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
		private static extern bool DeleteDC(
		  IntPtr dc
		  );

		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		private static extern unsafe bool ClientToScreen(
		  IntPtr hWnd,       // handle to window
		  Point* lpPoint     // screen coordinates
		  );

		const int SRCCOPY = 0xcc0020;
		private Point dragMePosition;
		private bool mouseDown = false;
		private Point mouseDelta;
		private Bitmap backingStore;
		private Point backingStorePos;
		private String dragString;
		private Graphics backingStoreGraphics;
		private IntPtr backingStoreDC;
		private Graphics displayGraphics;
		private IntPtr displayDC;
		private Size dragImageSize;
		private Font dragStringFont;
		
		public Form1()
		{
			InitializeComponent();
			dragString = "Drag Me!";
			dragMePosition = new Point(100, 100);
			dragStringFont = new Font("Times New Roman", 14, FontStyle.Bold);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Graphics g = this.CreateGraphics();
			SizeF temp = g.MeasureString(this.dragString, this.dragStringFont);
			dragImageSize = new Size((int)temp.Width, (int)temp.Height);
			g.Dispose();
		}

		private void getDisplayDC()
		{
			displayDC = CreateDC("DISPLAY", null, null, (System.IntPtr)null);
			displayGraphics = Graphics.FromHdc(displayDC);
		}

		private void disposeDisplayDC()
		{
			displayGraphics.Dispose();
			DeleteDC(displayDC);
		}

		private unsafe Point controlToScreen(int x, int y)
		{
			Point p = new Point(x, y);
			Point* pp = &p;
			ClientToScreen(Handle, pp);
			return p;
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.Bisque, ClientRectangle);
			Font bf = new Font("Times New Roman", 32);
			g.DrawString("Bonjour Le Monde", bf, Brushes.Blue, 10, 10);
			bf.Dispose();
			drawDragImage(
			  g, false, dragMePosition.X, dragMePosition.X, dragString);
		}

		private void drawDragImage(
	  Graphics g, bool alphablend, int x, int y, String s)
		{
			Rectangle r = new Rectangle(
			  x, y, dragImageSize.Width, dragImageSize.Height);

			// Draw background
			if (alphablend)
			{
				Color c1 = Color.FromArgb(0, Color.Red);
				Color c2 = Color.FromArgb(80, Color.Red);
				Rectangle r1 = new Rectangle(r.Left, r.Top, r.Width / 2, r.Height);
				Rectangle r2 = new Rectangle(
				  r.Left + r.Width / 2, r.Top, r.Width / 2, r.Height);
				LinearGradientBrush lgb1 = new LinearGradientBrush(r1, c1, c2, 0f);
				LinearGradientBrush lgb2 = new LinearGradientBrush(r2, c2, c1, 0f);
				g.FillRectangle(
				 lgb1, new Rectangle(r1.Left + 1, r1.Top, r1.Width + 1, r1.Height));
				g.FillRectangle(lgb2, r2);
				lgb1.Dispose();
				lgb2.Dispose();
			}
			else
				g.FillRectangle(Brushes.Red, r);

			// Draw the text
			Color c;
			if (alphablend)
				c = Color.FromArgb(80, Color.Black);
			else
				c = Color.Black;
			Brush blackBrush = new SolidBrush(c);
			g.DrawString(s, this.dragStringFont, blackBrush, r);
			blackBrush.Dispose();
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			Rectangle dragMeRectangle = new Rectangle(
			dragMePosition, new Size(dragImageSize.Width, dragImageSize.Height));
			if (dragMeRectangle.Contains(new Point(e.X, e.Y)))
			{
				mouseDown = true;
				mouseDelta = new Point(
				e.X - dragMePosition.X, e.Y - dragMePosition.Y);

				Point screenPoint = controlToScreen(e.X, e.Y);
				screenPoint.X -= mouseDelta.X;
				screenPoint.Y -= mouseDelta.Y;
				getDisplayDC();

				backingStore =
				new Bitmap(dragImageSize.Width, dragImageSize.Height);
				backingStoreGraphics = Graphics.FromImage(backingStore);
				backingStoreDC = backingStoreGraphics.GetHdc();
				BitBlt(backingStoreDC, 0, 0, backingStore.Width,
				backingStore.Height, displayDC, screenPoint.X,
				screenPoint.Y, SRCCOPY);
				backingStorePos = new Point(screenPoint.X, screenPoint.Y);

				drawDragImage(
				displayGraphics, true, screenPoint.X, screenPoint.Y, dragString);
			}
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if (mouseDown)
			{
				Point screenPoint = controlToScreen(e.X, e.Y);
				screenPoint.X -= mouseDelta.X;
				screenPoint.Y -= mouseDelta.Y;
				BitBlt(displayDC, backingStorePos.X, backingStorePos.Y,
				  backingStore.Width, backingStore.Height, backingStoreDC,
				  0, 0, SRCCOPY);
				BitBlt(backingStoreDC, 0, 0, backingStore.Width,
				  backingStore.Height, displayDC, screenPoint.X,
				  screenPoint.Y, SRCCOPY);
				backingStorePos = new Point(screenPoint.X, screenPoint.Y);
				drawDragImage(
				  displayGraphics, true, screenPoint.X, screenPoint.Y, dragString);
			}
		}

		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			if (mouseDown)
			{
				mouseDown = false;
				BitBlt(displayDC, backingStorePos.X, backingStorePos.Y,
				  backingStore.Width, backingStore.Height, backingStoreDC,
				  0, 0, SRCCOPY);

				disposeDisplayDC();

				backingStoreGraphics.ReleaseHdc(backingStoreDC);
				backingStoreGraphics.Dispose();

				backingStore.Dispose();
				backingStore = null;
			}
		}
	}
}