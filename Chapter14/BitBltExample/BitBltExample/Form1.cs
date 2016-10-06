using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BitBltExample
{
	public partial class Form1 : Form
	{
		const int SRCCOPY = 0xcc0020;

		[System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
		private static extern int BitBlt(
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
		
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, ClientRectangle);
			g.DrawRectangle(Pens.Black, 10, 10, 40, 40);
			IntPtr dc = g.GetHdc();
			BitBlt(dc, 70, 0, 60, 60, dc, 0, 0, SRCCOPY);
			// WinGdi.H contains constants for BitBlt
			// 0xCC0020 is the SRCCOPY raster operation
			g.ReleaseHdc(dc);
		}
	}
}