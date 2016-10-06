using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Apress.GraphicsOutlineModel;

namespace ScrollAndSelectList
{
	public partial class ScrollAndSelectList : UserControl
	{
		private Point originOfImage = new Point(0, 0);
		private Size virSpaceSize = new Size(100, 1000);
		private Bitmap bitmap;
		private int startingSelectedRow = -1;
		private int endingSelectedRow = -1;
		private int lineSpacing;
		private int nbrRows;
		private bool mouseDown = false;
		private int draggingStartedRow;
		private int old_startingSelectedRow = -1;
		private int old_endingSelectedRow = -1;

		private Rectangle ScrollingImageRectangle
		{
			get
			{
				return new Rectangle(0, 0, this.vScrollBar1.Left,
				  this.Height);
			}
		}

		private void adjustScrollBars()
		{
			vScrollBar1.Minimum = 0;
			vScrollBar1.Maximum = this.virSpaceSize.Height - 2;
			vScrollBar1.LargeChange = ScrollingImageRectangle.Height - 1;
			vScrollBar1.SmallChange = lineSpacing;
			vScrollBar1.Value = originOfImage.Y;
		}

		private void drawIntoImage()
		{
			int y;

			Graphics g = Graphics.FromImage(bitmap);
			g.FillRectangle(Brushes.White, new Rectangle(
			  0, 0, bitmap.Width, bitmap.Height));
			GraphicsOM g2 = new GraphicsOM(g);
			for (int i = 0; i < nbrRows; ++i)
			{
				y = i * lineSpacing;
				g2.DrawLine(Pens.Black, 0, y, virSpaceSize.Width, y);
				Rectangle r = new Rectangle(
				  0, y, virSpaceSize.Width, lineSpacing - 1);
				if (i >= startingSelectedRow && i <= endingSelectedRow)
					g2.FillRectangle(Brushes.LightBlue, new Rectangle(
					  r.Left, r.Top + 1, r.Width, r.Height));
				g.DrawString("line: " + i, Font, Brushes.Black, r);
			}
			y = lineSpacing * nbrRows;
			g2.DrawLine(Pens.Black, 0, y, virSpaceSize.Width, y);
			g.Dispose();
		}
		
		public Size VirtualSpaceSize
		{
			get
			{
				return virSpaceSize;
			}
			set
			{
				// Adjust size so that there is an integral number of rows.
				lineSpacing = (int)Font.Height;
				virSpaceSize = value;
				nbrRows = virSpaceSize.Height / lineSpacing;
				virSpaceSize.Height = nbrRows * lineSpacing + 1;
				bitmap = new Bitmap(
				  this.virSpaceSize.Width, this.virSpaceSize.Height);
				drawIntoImage();
				Invalidate();
				adjustScrollBars();
			}
		}

		public ScrollAndSelectList()
		{
			InitializeComponent();

			this.SetStyle(ControlStyles.Opaque, true);
		}

		private void drawImage(Graphics g, int x, int y)
		{
			if (bitmap != null)
			{
				g.SetClip(ScrollingImageRectangle);
				Rectangle drawRect = new Rectangle(new Point(x, y),
				  ScrollingImageRectangle.Size);
				g.DrawImage(bitmap, ScrollingImageRectangle,
				  drawRect, GraphicsUnit.Pixel);
			}
		}

		private int getRowFromHitTest(System.Windows.Forms.MouseEventArgs e)
		{
			Point newPoint = new Point(e.X, e.Y + originOfImage.Y);
			int row = newPoint.Y / lineSpacing;
			return row;
		}
		
		private void ScrollAndSelectList_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			if (bitmap != null)
			{
				lineSpacing = (int)Font.Height;
				nbrRows = virSpaceSize.Height / lineSpacing;
				drawIntoImage();
				drawImage(g, this.originOfImage.X, this.originOfImage.Y);
			}
			else
			{
				lineSpacing = (int)Font.Height;
				nbrRows = virSpaceSize.Height / lineSpacing;
				bitmap = new Bitmap(virSpaceSize.Width,
				  virSpaceSize.Height);
				drawIntoImage();
				adjustScrollBars();
			}
		}

		private void ScrollAndSelectList_MouseDown(object sender, MouseEventArgs e)
		{
			int row = getRowFromHitTest(e);
			this.startingSelectedRow = row;
			this.endingSelectedRow = row;
			draggingStartedRow = row;
			drawIntoImage();
			this.Invalidate();
			mouseDown = true;
		}

		private void processMouseMove(System.Windows.Forms.MouseEventArgs e)
		{
			if (mouseDown)
			{
				if (e.Y >= ScrollingImageRectangle.Size.Height)
				{
					int delta = e.Y - ScrollingImageRectangle.Size.Height;
					delta = (delta / lineSpacing + 1) * lineSpacing;
					Point oldOrigin = originOfImage;
					originOfImage = new Point(
					  originOfImage.X, Math.Min(
						bitmap.Height - ScrollingImageRectangle.Size.Height,
						oldOrigin.Y + delta));
					slide(oldOrigin, originOfImage);
				}
				if (e.Y < 0)
				{
					int delta = -e.Y;
					delta = (delta / lineSpacing + 1) * lineSpacing;
					Point oldOrigin = originOfImage;
					originOfImage = new Point(
					  originOfImage.X, Math.Max(0, oldOrigin.Y - delta));
					slide(oldOrigin, originOfImage);
				}
				adjustScrollBars();

				int row = getRowFromHitTest(e);
				if (row < draggingStartedRow)
				{
					this.startingSelectedRow = row;
					this.endingSelectedRow = draggingStartedRow;
				}
				else
				{
					this.startingSelectedRow = draggingStartedRow;
					this.endingSelectedRow = row;
				}
				if (old_startingSelectedRow !=
				  startingSelectedRow || old_endingSelectedRow != endingSelectedRow)
				{
					drawIntoImage();
					this.Invalidate();
				}
				old_startingSelectedRow = startingSelectedRow;
				old_endingSelectedRow = endingSelectedRow;
			}
		}

		private void ScrollAndSelectList_MouseMove(object sender, MouseEventArgs e)
		{
			processMouseMove(e);
		}

		private void ScrollAndSelectList_MouseUp(object sender, MouseEventArgs e)
		{
			mouseDown = false;
			old_startingSelectedRow = -1;
			old_endingSelectedRow = -1;
		}


		private void slide(Point oldP, Point newP)
		{
			Graphics g = this.CreateGraphics();

			if (oldP.Y != newP.Y)
			{
				// Slide vertically.
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

		private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
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
	}
}