using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Apress.GraphicsOutlineModel
{
	/// <summary>
	/// Specifies the four styles of raised or inset rectangles. Lines can have either
	/// Ridge or Groove appearance only.
	/// </summary>
	public enum ThreeDStyle
	{
		/// <summary>
		/// Inset, groove appearance.
		/// </summary>
		Groove,
		/// <summary>
		/// Inset appearance. Applies only to rectangles, not to lines.
		/// </summary>
		Inset,
		/// <summary>
		/// Raised appearance. Applies only to rectangles, not to lines.
		/// </summary>
		Raised,
		/// <summary>
		/// Raised, ridge appearance.
		/// </summary>
		Ridge,
	}

	/// <summary>
	/// Encapsulates the Outline Model GDI+ drawing surface. This class uses the decorator pattern
	/// to modify the functionality of the Graphics class.
	/// </summary>
	public class GraphicsOM
	{
		/// <summary>
		/// This is a private member variable that contains the associated
		/// Graphics object. It is not part of the programming interface of
		/// the GraphicsOM class.
		/// </summary>
		private Graphics _graphics;

		/// <summary>
		/// This constructor initializes a new instance of the GraphicsOM class with the
		/// specified Graphics object. Grid points are based on a grid where the lines
		/// are between the pixels, instead of through the centers of the pixels.
		/// </summary>
		/// <param name="graphics">Graphics object that is the drawing surface on which
		/// this GraphicsOM object draws.</param>
		public GraphicsOM(Graphics graphics) 
		{
			_graphics = graphics;
		}

		/// <summary>
		/// Draws a line connecting the two points specified by the coordinate pairs. If the line
		/// is horizontal, the pixels are drawn just below the specified grid line. If the line is
		/// vertical, the pixels are drawn just to the right of the the specified grid line. If the
		/// line is diagonal, the pixels are drawn from corner to corner of a rectangle where the
		/// corners are made up of the two points. The pixels will fall just inside the rectangle.
		/// </summary>
		/// <param name="pen">Pen object that determines the color, width, and style of the line.</param>
		/// <param name="p1">Point structure that specifies the first grid point to connect.</param>
		/// <param name="p2">Point structure that specifies the second grid point to connect.</param>
		public void DrawLine(Pen pen, Point p1, Point p2)
		{
			Point pp1 = new Point(p1.X, p1.Y);
			Point pp2 = new Point(p2.X, p2.Y);

			// to simplify the modifications that we have to make
			// if the second point is to the left of the first point,
			// switch the two points.
			if (pp2.X < pp1.X)
			{
				Point tempPoint = pp2;
				pp2 = pp1;
				pp1 = tempPoint;
			}

			if (pp1.Y == pp2.Y)  // if line is horizontal
			{
				pp2.X--;
			} 
			else if (pp1.X == pp2.X)  // if line is vertical
			{
				pp2.Y--;
			}
			else if (pp2.Y > pp1.Y) // if line is descending down and to right
			{
				pp2.X--;
				pp2.Y--;
			}
			else if (pp2.Y < pp1.Y) // if line is ascending up and to right
			{
				pp1.Y--;
				pp2.X--;
			}
			_graphics.DrawLine(pen, pp1, pp2);
		}

		/// <summary>
		/// Draws a line connecting the two points specified by the coordinate pairs. If the line
		/// is horizontal, the pixels are drawn just below the specified grid line. If the line is
		/// vertical, the pixels are drawn just to the right of the the specified grid line. If the
		/// line is diagonal, the pixels are drawn from corner to corner of a rectangle where the
		/// corners are made up of the two points. The pixels will fall just inside the rectangle.
		/// </summary>
		/// <param name="pen">Pen object that determines the color, width, and style of the line.</param>
		/// <param name="x1">x coordinate of the first grid point.</param>
		/// <param name="y1">y coordinate of the first grid point.</param>
		/// <param name="x2">x coordinate of the second grid point.</param>
		/// <param name="y2">y coordinate of the second grid point.</param>
		public void DrawLine(Pen pen, int x1, int y1, int x2, int y2)
		{
			this.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
		}

		/// <summary>
		/// Draws an inset or raised line connecting the two points specified by
		/// the coordinate pairs. This method draws only horizontal or vertical
		/// lines. If the line is not horizontal or vertical, this method throws an
		/// ArgumentException. If the line is horizontal, the pixels are
		/// drawn just below the specified grid line. If the line is
		/// vertical, the pixels are drawn just to the right of the
		/// the specified grid line.
		/// </summary>
		/// <param name="p1">Point structure that specifies the first grid point to connect.</param>
		/// <param name="p2">Point structure that specifies the second grid point to connect.</param>
		/// <param name="style">Specifies the raised or inset style.</param>
		/// <param name="depth">Specifies the depth of the raised or inset line or rectangle.
		/// Valid values are 1 and 2.</param>
		public void Draw3DLine(Point p1, Point p2, ThreeDStyle style, int depth)
		{
			if (p1.X != p2.X && p1.Y != p2.Y)
				throw new ArgumentException();
			if (depth != 1 && depth != 2)
				throw new ArgumentException();

			if (depth == 1) 
			{
				switch (style)
				{
					case ThreeDStyle.Inset:
					case ThreeDStyle.Groove:
						if (p1.Y == p2.Y)
						{
							DrawLine(SystemPens.ControlDark, p1, p2);
							Point pl1 = new Point(p1.X, p1.Y + 1);
							Point pl2 = new Point(p2.X, p2.Y + 1);
							DrawLine(SystemPens.ControlLightLight, pl1, pl2);
						} 
						else 
						{
							DrawLine(SystemPens.ControlDark, p1, p2);
							Point pl1 = new Point(p1.X + 1, p1.Y);
							Point pl2 = new Point(p2.X + 1, p2.Y);
							DrawLine(SystemPens.ControlLightLight, pl1, pl2);
						}
						break;
					case ThreeDStyle.Raised:
					case ThreeDStyle.Ridge:
						if  (p1.Y == p2.Y)
						{
							DrawLine(SystemPens.ControlLightLight, p1, p2);
							Point pd1 = new Point(p1.X, p1.Y + 1);
							Point pd2 = new Point(p2.X, p2.Y + 1);
							DrawLine(SystemPens.ControlDark, pd1, pd2);
						}
						else
						{
							DrawLine(SystemPens.ControlLightLight, p1, p2);
							Point pd1 = new Point(p1.X + 1, p1.Y);
							Point pd2 = new Point(p2.X + 1, p2.Y);
							DrawLine(SystemPens.ControlDark, pd1, pd2);
						}
						break;
				}
			}
			else if (depth == 2)
			{
				switch (style)
				{
					case ThreeDStyle.Inset:
					case ThreeDStyle.Groove:
						if (p1.Y == p2.Y)
						{
							DrawLine(SystemPens.ControlDarkDark, p1, p2);
							Point pp1 = new Point(p1.X, p1.Y + 1);
							Point pp2 = new Point(p2.X, p2.Y + 1);
							DrawLine(SystemPens.ControlDark, pp1, pp2);
							pp1.Y++;
							pp2.Y++;
							DrawLine(SystemPens.ControlLight, pp1, pp2);
							pp1.Y++;
							pp2.Y++;
							DrawLine(SystemPens.ControlLightLight, pp1, pp2);
						} 
						else 
						{
							DrawLine(SystemPens.ControlDarkDark, p1, p2);
							Point pp1 = new Point(p1.X + 1, p1.Y);
							Point pp2 = new Point(p2.X + 1, p2.Y);
							DrawLine(SystemPens.ControlDark, pp1, pp2);
							pp1.X++;
							pp2.X++;
							DrawLine(SystemPens.ControlLight, pp1, pp2);
							pp1.X++;
							pp2.X++;
							DrawLine(SystemPens.ControlLightLight, pp1, pp2);
						}
						break;
					case ThreeDStyle.Raised:
					case ThreeDStyle.Ridge:
						if  (p1.Y == p2.Y)
						{
							DrawLine(SystemPens.ControlLightLight, p1, p2);
							Point pp1 = new Point(p1.X, p1.Y + 1);
							Point pp2 = new Point(p2.X, p2.Y + 1);
							DrawLine(SystemPens.ControlLight, pp1, pp2);
							pp1.Y++;
							pp2.Y++;
							DrawLine(SystemPens.ControlDark, pp1, pp2);
							pp1.Y++;
							pp2.Y++;
							DrawLine(SystemPens.ControlDarkDark, pp1, pp2);
						}
						else
						{
							DrawLine(SystemPens.ControlLightLight, p1, p2);
							Point pp1 = new Point(p1.X + 1, p1.Y);
							Point pp2 = new Point(p2.X + 1, p2.Y);
							DrawLine(SystemPens.ControlLight, pp1, pp2);
							pp1.X++;
							pp2.X++;
							DrawLine(SystemPens.ControlDark, pp1, pp2);
							pp1.X++;
							pp2.X++;
							DrawLine(SystemPens.ControlDarkDark, pp1, pp2);
						}
						break;
				}
			}
		}

		/// <summary>
		/// Draws an inset or raised line connecting the two points specified by
		/// the coordinate pairs. This method draws only horizontal or vertical
		/// lines. If the line is not horizontal or vertical, this method throws an
		/// ArgumentException. If the line is horizontal, the pixels are
		/// drawn just below the specified grid line. If the line is
		/// vertical, the pixels are drawn just to the right of the
		/// the specified grid line.
		/// </summary>
		/// <param name="x1">x coordinate of the first grid point.</param>
		/// <param name="y1">y coordinate of the first grid point.</param>
		/// <param name="x2">x coordinate of the second grid point.</param>
		/// <param name="y2">y coordinate of the second grid point.</param>
		/// <param name="style">Specifies the raised or inset style.</param>
		/// <param name="depth">Specifies the depth of the raised or inset line or rectangle.
		/// Valid values are 1 and 2.</param>
		public void Draw3DLine(int x1, int y1, int x2, int y2, ThreeDStyle style, int depth)
		{
			this.Draw3DLine(new Point(x1, y1), new Point(x2, y2), style, depth);
		}

		/// <summary>
		/// This is a private utility method that is used by other drawing methods.
		/// It draws either a raised or an inset rectangle of depth one.
		/// It is not part of the programming interface of the GraphicsOM class.
		/// </summary>
		/// <param name="r">A Rectangle structure that specifies the rectangle to draw.</param>
		/// <param name="pen1">Light pen if raised, dark pen if inset.</param>
		/// <param name="pen2">Dark pen if raised, light pen if inset.</param>
		private void drawInsetOrRaisedDepthOne(Rectangle r, Pen pen1, Pen pen2)
		{
			// draw top side
			Point p1 = new Point(r.Left, r.Top);
			Point p2 = new Point(r.Left + r.Width, r.Top);
			DrawLine(pen1, p1, p2);

			// draw left side
			p1 = new Point(r.Left, r.Top);
			p2 = new Point(r.Left, r.Top + r.Height);
			DrawLine(pen1, p1, p2);

			// draw bottom side
			p1 = new Point(r.Left, r.Top + r.Height - 1);
			p2 = new Point(r.Left + r.Width, r.Top + r.Height - 1);
			DrawLine(pen2, p1, p2);

			// draw right side
			p1 = new Point(r.Left + r.Width - 1, r.Top);
			p2 = new Point(r.Left + r.Width - 1, r.Top + r.Height);
			DrawLine(pen2, p1, p2);
		}

		/// <summary>
		/// This is a private utility method that is used by other drawing methods.
		/// It draws either a ridge or a groove rectangle of depth one.
		/// It is not part of the programming interface of the GraphicsOM class.
		/// </summary>
		/// <param name="r">A Rectangle structure that specifies the rectangle to draw.</param>
		/// <param name="pen1">Light pen if ridge, dark pen if groove.</param>
		/// <param name="pen2">Dark pen if ridge, light pen if groove.</param>
		private void drawRidgeOrGrooveDepthOne(Rectangle r, Pen pen1, Pen pen2)
		{
			// draw top side
			Point p1 = new Point(r.Left, r.Top);
			Point p2 = new Point(r.Left + r.Width, r.Top);
			DrawLine(pen1, p1, p2);
			p1.X++;
			p2.X--;
			p1.Y++;
			p2.Y++;
			DrawLine(pen2, p1, p2);

			// draw left side
			p1 = new Point(r.Left, r.Top);
			p2 = new Point(r.Left, r.Top + r.Height);
			DrawLine(pen1, p1, p2);
			p1.X++;
			p2.X++;
			p1.Y++;
			p2.Y--;
			DrawLine(pen2, p1, p2);

			// draw bottom side
			p1 = new Point(r.Left, r.Top + r.Height - 1);
			p2 = new Point(r.Left + r.Width, r.Top + r.Height - 1);
			DrawLine(pen2, p1, p2);
			p1.X++;
			p2.X--;
			p1.Y--;
			p2.Y--;
			DrawLine(pen1, p1, p2);

			// draw right side
			p1 = new Point(r.Left + r.Width - 1, r.Top);
			p2 = new Point(r.Left + r.Width - 1, r.Top + r.Height);
			DrawLine(pen2, p1, p2);
			p1.X--;
			p2.X--;
			p1.Y++;
			p2.Y--;
			DrawLine(pen1, p1, p2);
		}

		/// <summary>
		/// This is a private utility method that is used by other drawing methods.
		/// It draws either a raised or a inset rectangle of depth two.
		/// It is not part of the programming interface of the GraphicsOM class.
		/// </summary>
		/// <param name="r">A Rectangle structure that specifies the rectangle to draw.</param>
		/// <param name="pen1">LightLight pen if raised, DarkDark pen if inset.</param>
		/// <param name="pen2">Light pen if raised, Dark pen if inset.</param>
		/// <param name="pen3">Dark pen if raised, Light pen if inset.</param>
		/// <param name="pen4">DarkDark pen if raised, LightLight pen if inset.</param>
		private void drawInsetOrRaisedDepthTwo(Rectangle r, Pen pen1, Pen pen2,
			Pen pen3, Pen pen4)
		{
			// draw top side
			Point p1 = new Point(r.Left, r.Top);
			Point p2 = new Point(r.Left + r.Width, r.Top);
			DrawLine(pen1, p1, p2);
			p1.X++;
			p2.X--;
			p1.Y++;
			p2.Y++;
			DrawLine(pen2, p1, p2);

			// draw left side
			p1 = new Point(r.Left, r.Top);
			p2 = new Point(r.Left, r.Top + r.Height);
			DrawLine(pen1, p1, p2);
			p1.X++;
			p2.X++;
			p1.Y++;
			p2.Y--;
			DrawLine(pen2, p1, p2);

			// draw bottom side
			p1 = new Point(r.Left, r.Top + r.Height - 1);
			p2 = new Point(r.Left + r.Width, r.Top + r.Height - 1);
			DrawLine(pen4, p1, p2);
			p1.X++;
			p2.X--;
			p1.Y--;
			p2.Y--;
			DrawLine(pen3, p1, p2);

			// draw right side
			p1 = new Point(r.Left + r.Width - 1, r.Top);
			p2 = new Point(r.Left + r.Width - 1, r.Top + r.Height);
			DrawLine(pen4, p1, p2);
			p1.X--;
			p2.X--;
			p1.Y++;
			p2.Y--;
			DrawLine(pen3, p1, p2);
		}

		/// <summary>
		/// This is a private utility method that is used by other drawing methods.
		/// It draws either a ridge or a groove rectangle of depth two.
		/// It is not part of the programming interface of the GraphicsOM class.
		/// </summary>
		/// <param name="r">A Rectangle structure that specifies the rectangle to draw.</param>
		/// <param name="pen1">LightLight pen if ridge, DarkDark pen if groove.</param>
		/// <param name="pen2">Light pen if ridge, Dark pen if groove.</param>
		/// <param name="pen3">Dark pen if ridge, Light pen if groove.</param>
		/// <param name="pen4">DarkDark pen if ridge, LightLight pen if groove.</param>
		private void drawRidgeOrGrooveDepthTwo(Rectangle r, Pen pen1, Pen pen2,
			Pen pen3, Pen pen4)
		{
			// draw top side
			Point p1 = new Point(r.Left, r.Top);
			Point p2 = new Point(r.Left + r.Width, r.Top);
			DrawLine(pen1, p1, p2);
			p1.X++;
			p2.X--;
			p1.Y++;
			p2.Y++;
			DrawLine(pen2, p1, p2);
			p1.X++;
			p2.X--;
			p1.Y++;
			p2.Y++;
			DrawLine(pen3, p1, p2);
			p1.X++;
			p2.X--;
			p1.Y++;
			p2.Y++;
			DrawLine(pen4, p1, p2);

			// draw left side
			p1 = new Point(r.Left, r.Top);
			p2 = new Point(r.Left, r.Top + r.Height);
			DrawLine(pen1, p1, p2);
			p1.X++;
			p2.X++;
			p1.Y++;
			p2.Y--;
			DrawLine(pen2, p1, p2);
			p1.X++;
			p2.X++;
			p1.Y++;
			p2.Y--;
			DrawLine(pen3, p1, p2);
			p1.X++;
			p2.X++;
			p1.Y++;
			p2.Y--;
			DrawLine(pen4, p1, p2);

			// draw bottom side
			p1 = new Point(r.Left, r.Top + r.Height - 1);
			p2 = new Point(r.Left + r.Width, r.Top + r.Height - 1);
			DrawLine(pen4, p1, p2);
			p1.X++;
			p2.X--;
			p1.Y--;
			p2.Y--;
			DrawLine(pen3, p1, p2);
			p1.X++;
			p2.X--;
			p1.Y--;
			p2.Y--;
			DrawLine(pen2, p1, p2);
			p1.X++;
			p2.X--;
			p1.Y--;
			p2.Y--;
			DrawLine(pen1, p1, p2);

			// draw right side
			p1 = new Point(r.Left + r.Width - 1, r.Top);
			p2 = new Point(r.Left + r.Width - 1, r.Top + r.Height);
			DrawLine(pen4, p1, p2);
			p1.X--;
			p2.X--;
			p1.Y++;
			p2.Y--;
			DrawLine(pen3, p1, p2);
			p1.X--;
			p2.X--;
			p1.Y++;
			p2.Y--;
			DrawLine(pen2, p1, p2);
			p1.X--;
			p2.X--;
			p1.Y++;
			p2.Y--;
			DrawLine(pen1, p1, p2);
		}

		/// <summary>
		/// Draws a inset or raised rectangle specified by the Rectangle structure. The
		/// rectangle is drawn just inside of the Outline Model grid lines.
		/// </summary>
		/// <param name="rect">A Rectangle structure that specifies the rectangle to draw.</param>
		/// <param name="style">Specifies the raised or inset style.</param>
		/// <param name="depth">Specifies the depth of the raised or inset line or rectangle.
		/// Valid values are 1 and 2.</param>
		public void Draw3DRectangle(Rectangle rect, ThreeDStyle style, int depth)
		{
			if (depth != 1 && depth != 2)
				throw new ArgumentException();

			if (depth == 1) 
			{
				switch (style)
				{
					case ThreeDStyle.Ridge:
						drawRidgeOrGrooveDepthOne(rect, SystemPens.ControlLightLight,
							SystemPens.ControlDark);
						break;
					case ThreeDStyle.Groove:
						drawRidgeOrGrooveDepthOne(rect, SystemPens.ControlDark,
							SystemPens.ControlLightLight);
						break;
					case ThreeDStyle.Raised:
						drawInsetOrRaisedDepthOne(rect, SystemPens.ControlLightLight,
							SystemPens.ControlDark);
						Rectangle r2 = new Rectangle(rect.Location, rect.Size);
						r2.Inflate(-1, -1);
						FillRectangle(SystemBrushes.Control, r2);
						break;
					case ThreeDStyle.Inset:
						drawInsetOrRaisedDepthOne(rect, SystemPens.ControlDark,
							SystemPens.ControlLightLight);
						Rectangle r3 = new Rectangle(rect.Location, rect.Size);
						r3.Inflate(-1, -1);
						FillRectangle(SystemBrushes.Control, r3);
						break;
				}
			}
			else if (depth == 2)
			{
				switch (style)
				{
					case ThreeDStyle.Ridge:
						drawRidgeOrGrooveDepthTwo(rect, SystemPens.ControlLightLight,
							SystemPens.ControlLight, SystemPens.ControlDark,
							SystemPens.ControlDarkDark);
						break;
					case ThreeDStyle.Groove:
						drawRidgeOrGrooveDepthTwo(rect, SystemPens.ControlDarkDark,
							SystemPens.ControlDark, SystemPens.ControlLight,
							SystemPens.ControlLightLight);
						break;
					case ThreeDStyle.Raised:
						drawInsetOrRaisedDepthTwo(rect, SystemPens.ControlLightLight,
							SystemPens.ControlLight, SystemPens.ControlDark,
							SystemPens.ControlDarkDark);
						Rectangle r2 = new Rectangle(rect.Location, rect.Size);
						r2.Inflate(-2, -2);
						FillRectangle(SystemBrushes.Control, r2);
						break;
					case ThreeDStyle.Inset:
						drawInsetOrRaisedDepthTwo(rect, SystemPens.ControlDarkDark,
							SystemPens.ControlDark, SystemPens.ControlLight,
							SystemPens.ControlLightLight);
						Rectangle r3 = new Rectangle(rect.Location, rect.Size);
						r3.Inflate(-2, -2);
						FillRectangle(SystemBrushes.Control, r3);
						break;
				}
			}
		}

		/// <summary>
		/// Draws a inset or raised rectangle specified by a coordinate pair, a width, and a height. The
		/// rectangle is drawn just inside of the Outline Model grid lines.
		/// </summary>
		/// <param name="left">x-coordinate of the upper-left corner of the rectangle to draw.</param>
		/// <param name="top">y-coordinate of the upper-left corner of the rectangle to draw.</param>
		/// <param name="width">Width of the rectangle to draw.</param>
		/// <param name="height">Height of the rectangle to draw. </param>
		/// <param name="style">Specifies the raised or inset style.</param>
		/// <param name="depth">Specifies the depth of the raised or inset line or rectangle.
		/// Valid values are 1 and 2.</param>
		public void Draw3DRectangle(int left, int top, int width, int height, ThreeDStyle style, int depth)
		{
			this.Draw3DRectangle(new Rectangle(left, top, width, height), style, depth);
		}

		/// <summary>
		/// Draws a rectangle specified by a Rectangle structure. The rectangle is drawn just inside
		/// of the Outline Model grid lines.
		/// </summary>
		/// <param name="pen">Pen object that determines the color, width, and style of the rectangle.</param>
		/// <param name="rect">Rectangle structure that specifies the location and size of the rectangle.</param>
		public void DrawRectangle(Pen pen, Rectangle rect)
		{
			if (pen.Width == 1)
			{
				Rectangle nr = rect;
				nr.Width--;
				nr.Height--;
				_graphics.DrawRectangle(pen, nr);
			} 
			else 
			{
				PenAlignment pa = pen.Alignment;
				pen.Alignment = PenAlignment.Inset;
				_graphics.DrawRectangle(pen, rect);
				pen.Alignment = pa;
			}
		}

		/// <summary>
		/// Draws a rectangle specified by a coordinate pair, a width, and a height.
		/// The rectangle is drawn just inside of the Outline Model grid lines.
		/// </summary>
		/// <param name="pen">Pen object that determines the color, width, and style of the rectangle.</param>
		/// <param name="left">x-coordinate of the upper-left corner of the rectangle to draw.</param>
		/// <param name="top">y-coordinate of the upper-left corner of the rectangle to draw.</param>
		/// <param name="width">Width of the rectangle to draw.</param>
		/// <param name="height">Height of the rectangle to draw.</param>
		public void DrawRectangle(Pen pen, int left, int top, int width, int height) 
		{
			Rectangle r = new Rectangle(left, top, width, height);
			this.DrawRectangle(pen, r);
		}

		/// <summary>
		/// Fills a rectangle specified by a Rectangle structure. The
		/// rectangle is filled just inside of the Outline Model grid lines.
		/// </summary>
		/// <param name="brush">A Brush object that determines the contents of the filled area.</param>
		/// <param name="rect">A Rectangle structure that specifies the rectangle to fill.</param>
		public void FillRectangle(Brush brush, Rectangle rect)
		{
			if (_graphics.SmoothingMode == SmoothingMode.AntiAlias)
			{
				RectangleF rf = new RectangleF(rect.Left - 0.5f, rect.Top - 0.5f, rect.Width, rect.Height);
				_graphics.FillRectangle(brush, rf);
			}
			else
				_graphics.FillRectangle(brush, rect);
		}

		/// <summary>
		/// Fills a rectangle specified by a coordinate pair, a width, and a height. The
		/// rectangle is filled just inside of the Outline Model grid lines.
		/// </summary>
		/// <param name="brush">A Brush object that determines the contents of the filled area.</param>
		/// <param name="left">x-coordinate of the upper-left corner of the rectangle to fill.</param>
		/// <param name="top">y-coordinate of the upper-left corner of the rectangle to fill.</param>
		/// <param name="width">Width of the rectangle to fill.</param>
		/// <param name="height">Height of the rectangle to fill.</param>
		public void FillRectangle(Brush brush, int left, int top, int width, int height)
		{
			Rectangle r = new Rectangle(left, top, width, height);

			if (_graphics.SmoothingMode == SmoothingMode.AntiAlias)
			{
				RectangleF rf = new RectangleF(r.Left - 0.5f, r.Top - 0.5f, r.Width, r.Height);
				_graphics.FillRectangle(brush, rf);
			}
			else
				_graphics.FillRectangle(brush, r);
		}

		/// <summary>
		/// Fills a rectangle specified by a RectangleF structure. The
		/// rectangle is filled just inside of the Outline Model grid lines.
		/// </summary>
		/// <param name="brush">A Brush object that determines the contents of the filled area.</param>
		/// <param name="rectf">A RectangleF structure that specifies the rectangle to fill.</param>
		public void FillRectangle(Brush brush, RectangleF rectf)
		{
			if (_graphics.SmoothingMode == SmoothingMode.AntiAlias)
			{
				RectangleF rf = new RectangleF(rectf.Left - 0.5f,
					rectf.Top - 0.5f, rectf.Width, rectf.Height);
				_graphics.FillRectangle(brush, rf);
			}
			else
				_graphics.FillRectangle(brush, rectf);
		}

		/// <summary>
		/// Fills a rectangle specified by a coordinate pair, a width, and a height. This
		/// method takes arguments of type float. The rectangle is filled just inside of
		/// the Outline Model grid lines.
		/// </summary>
		/// <param name="brush">A Brush object that determines the contents of the filled area.</param>
		/// <param name="left">x-coordinate of the upper-left corner of the rectangle to fill.</param>
		/// <param name="top">y-coordinate of the upper-left corner of the rectangle to fill.</param>
		/// <param name="width">Width of the rectangle to fill.</param>
		/// <param name="height">Height of the rectangle to fill.</param>
		public void FillRectangle(Brush brush, float left, float top, float width, float height)
		{
			RectangleF r = new RectangleF(left, top, width, height);

			if (_graphics.SmoothingMode == SmoothingMode.AntiAlias)
			{
				RectangleF rf = new RectangleF(r.Left - 0.5f, r.Top - 0.5f, r.Width, r.Height);
				_graphics.FillRectangle(brush, rf);
			}
			else
				_graphics.FillRectangle(brush, r);
		}
	}
}

