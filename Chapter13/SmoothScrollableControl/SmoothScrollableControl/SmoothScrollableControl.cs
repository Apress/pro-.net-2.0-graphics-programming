using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SmoothScrollableControl
{
	public partial class SmoothScrollableControl : UserControl
	{
		private Image scrollingImage;
		private Point originOfImage = new Point(0, 0);

		public Image ScrollingImage
		{
			get
			{
				return scrollingImage;
			}
			set
			{
				scrollingImage = value;
				adjustScrollBars();
			}
		}

		public Rectangle ScrollingImageRectangle
		{
			get
			{
				return new Rectangle(0, 0, this.vScrollBar.Left,
				  this.hScrollBar.Top);
			}
		}
		
		public SmoothScrollableControl()
		{
			InitializeComponent();

			this.SetStyle(ControlStyles.Opaque, true);
		}

		private void drawImage(Graphics g, int x, int y)
		{
			g.SetClip(ScrollingImageRectangle);

			Rectangle drawRect =
			  new Rectangle(new Point(x, y), ScrollingImageRectangle.Size);
			g.DrawImage(this.scrollingImage,
			  ScrollingImageRectangle, drawRect, GraphicsUnit.Pixel);
		}

		private void SmoothScrollableControl_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			Brush bgb = new SolidBrush(this.BackColor);

			if (this.scrollingImage != null)
			{
				drawImage(g, this.originOfImage.X, this.originOfImage.Y);

				g.ResetClip();

				Rectangle r;

				// Paint area to right of image and left of the vertical scroll bar
				r = new Rectangle(scrollingImage.Width, 0,
				  this.vScrollBar.Left - scrollingImage.Width,
					this.ScrollingImageRectangle.Height);
				if (!r.IsEmpty)
					g.FillRectangle(bgb, r);

				// Paint area below image and above horizontal scroll bar
				r = new Rectangle(0, scrollingImage.Height,
				  this.ScrollingImageRectangle.Width,
					this.hScrollBar.Top - scrollingImage.Height);
				if (!r.IsEmpty)
					g.FillRectangle(bgb, r);

				// Paint the small rectangle at the bottom right of the control
				r = new Rectangle(this.hScrollBar.Right, this.vScrollBar.Bottom,
				 this.ClientRectangle.Width - this.hScrollBar.Right,
				 this.ClientRectangle.Height - this.vScrollBar.Bottom);
				g.FillRectangle(bgb, r);
			}
			else
			{
				g.FillRectangle(bgb, this.ClientRectangle);
			}
		}

		private void adjustScrollBars()
		{
			if (scrollingImage != null)
			{
				hScrollBar.Minimum = 0;
				hScrollBar.Maximum = scrollingImage.Width;
				hScrollBar.LargeChange = ScrollingImageRectangle.Width;
				hScrollBar.SmallChange = ScrollingImageRectangle.Width / 10;
				hScrollBar.Value = originOfImage.X;
				vScrollBar.Minimum = 0;
				vScrollBar.Maximum = scrollingImage.Height;
				vScrollBar.LargeChange = ScrollingImageRectangle.Height;
				vScrollBar.SmallChange = ScrollingImageRectangle.Height / 10;
				vScrollBar.Value = originOfImage.Y;
			}
		}

		private void slide(Point oldP, Point newP)
		{
			Graphics g = this.CreateGraphics();

			if (oldP.X != newP.X)
			{
				// Slide horizontally
				bool goingUp = newP.X - oldP.X > 0;
				int delta = (newP.X - oldP.X) / 12;
				if (goingUp && delta < 1)
					delta = 1;
				if (!goingUp && delta > -1)
					delta = -1;
				int i = oldP.X;
				while (true)
				{
					if (i == newP.X)
						break;
					i += delta;
					if (goingUp && i > newP.X)
					{
						i = newP.X;
						continue;
					}
					if (!goingUp && i < newP.X)
					{
						i = newP.X;
						continue;
					}
					drawImage(g, i, oldP.Y);
					if (i != newP.X)
						Thread.Sleep(10);
				}
			}
			if (oldP.Y != newP.Y)
			{
				// Slide horizontally
				bool goingUp = newP.Y - oldP.Y > 0;
				int delta = (newP.Y - oldP.Y) / 12;
				if (goingUp && delta < 1)
					delta = 1;
				if (!goingUp && delta > -1)
					delta = -1;
				int i = oldP.Y;
				while (true)
				{
					if (i == newP.Y)
						break;
					i += delta;
					if (goingUp && i > newP.Y)
					{
						i = newP.Y;
						continue;
					}
					if (!goingUp && i < newP.Y)
					{
						i = newP.Y;
						continue;
					}
					drawImage(g, oldP.X, i);
					if (i != newP.Y)
						Thread.Sleep(10);
				}
			}
		}

		private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
		{
			switch (e.Type)
			{
				case ScrollEventType.SmallIncrement:
					goto case ScrollEventType.LargeDecrement;
				case ScrollEventType.LargeIncrement:
					goto case ScrollEventType.LargeDecrement;
				case ScrollEventType.SmallDecrement:
					goto case ScrollEventType.LargeDecrement;
				case ScrollEventType.LargeDecrement:
					Point oldOrigin = originOfImage;
					originOfImage = new Point(originOfImage.X, e.NewValue);
					slide(oldOrigin, originOfImage);
					break;
				default:
					originOfImage = new Point(originOfImage.X, e.NewValue);
					this.Invalidate();
					break;
			}
		}

		private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
		{
			switch (e.Type)
			{
				case ScrollEventType.SmallIncrement:
					goto case ScrollEventType.LargeDecrement;
				case ScrollEventType.LargeIncrement:
					goto case ScrollEventType.LargeDecrement;
				case ScrollEventType.SmallDecrement:
					goto case ScrollEventType.LargeDecrement;
				case ScrollEventType.LargeDecrement:
					Point oldOrigin = originOfImage;
					originOfImage = new Point(e.NewValue, originOfImage.Y);
					slide(oldOrigin, originOfImage);
					break;
				default:
					originOfImage = new Point(e.NewValue, originOfImage.Y);
					this.Invalidate();
					break;
			}
		}

		private void SmoothScrollableControl_Resize(object sender, EventArgs e)
		{
			if (scrollingImage != null)
			{
				int x = Math.Min(originOfImage.X,
				  scrollingImage.Width - ScrollingImageRectangle.Width);
				x = Math.Max(x, 0);
				int y = Math.Min(originOfImage.Y,
				  scrollingImage.Height - ScrollingImageRectangle.Height);
				y = Math.Max(y, 0);
				originOfImage = new Point(x, y);
			}
			adjustScrollBars();
			this.Invalidate();
		}
	}
}