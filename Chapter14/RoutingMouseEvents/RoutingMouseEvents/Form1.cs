using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Apress.GraphicsOutlineModel;

namespace RoutingMouseEvents
{
	public partial class Form1 : Form
	{
		private Rectangle buttonRect;
		private bool mouseDownInButton;
		private bool buttonDown;
		CaptureChangedWindow ccw;

		private void CaptureChangedEventHandler()
		{
			mouseDownInButton = false;
		}

		public Form1()
		{
			InitializeComponent();
			buttonRect = new Rectangle(10, 10, 100, 40);

			ccw = new CaptureChangedWindow();
			ccw.AssignHandle(Handle);
			ccw.OnCaptureChanged +=
			  new CaptureChanged(CaptureChangedEventHandler);
		}

		private void drawButton(Rectangle rect, Graphics g, bool up)
		{
			bool disposeGraphics = false;
			if (g == null)
			{
				g = this.CreateGraphics();
				disposeGraphics = true;
			}
			GraphicsOM g2 = new GraphicsOM(g);
			g2.DrawRectangle(Pens.Black, rect);
			Rectangle innerRect = new Rectangle(rect.Location, rect.Size);
			innerRect.Inflate(new Size(-1, -1));
			if (up)
				g2.Draw3DRectangle(innerRect, ThreeDStyle.Raised, 2);
			else
				g2.FillRectangle(Brushes.LightGray, innerRect);
			if (disposeGraphics)
				g.Dispose();
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			drawButton(buttonRect, g, true);
			// Draw the rectangle that simulates
			// "Your battery is fully charged."
			g.FillRectangle(Brushes.Red, new Rectangle(10, 150, 100, 40));
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && buttonRect.Contains(e.X, e.Y))
			{
				mouseDownInButton = true;
				buttonDown = true;
				drawButton(buttonRect, null, false);
			}
		}

		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			if (mouseDownInButton && e.Button == MouseButtons.Left)
			{
				drawButton(buttonRect, null, true);
				mouseDownInButton = false;
				if (buttonRect.Contains(e.X, e.Y))
					MessageBox.Show("Button was pressed");
			}
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if (mouseDownInButton)
			{
				if (buttonRect.Contains(e.X, e.Y))
				{
					if (!buttonDown)
					{
						drawButton(buttonRect, null, false);
						buttonDown = true;
					}
				}
				else
				{
					if (buttonDown)
					{
						drawButton(buttonRect, null, true);
						buttonDown = false;
					}
				}
			}
			if (new Rectangle(10, 150, 100, 40).Contains(new Point(e.X, e.Y)))
				MessageBox.Show("Your battery is fully charged.");
		}

		public delegate void CaptureChanged();

		class CaptureChangedWindow : NativeWindow
		{
			public CaptureChanged OnCaptureChanged;

			protected override void WndProc(ref Message m)
			{
				if (m.Msg == 533)     // WM_CAPTURECHANGED
					OnCaptureChanged();
				base.WndProc(ref m);
			}
		}

	}
}