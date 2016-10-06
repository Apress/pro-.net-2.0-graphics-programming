using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CustomControlWithProperties
{
	public partial class CustomControlWithProperties : UserControl
	{
		private string displayText;
		private int displayCount;
		private Color textColor;
		private Font textFont;
		private Orientation textOrientation;
		private Point startingDisplayPoint;

		public string DisplayText
		{
			get
			{
				return displayText;
			}
			set
			{
				displayText = value;
				Invalidate();
			}
		}

		public int DisplayCount
		{
			get
			{
				return displayCount;
			}
			set
			{
				displayCount = value;
				Invalidate();
			}
		}

		public Color TextColor
		{
			get
			{
				return textColor;
			}
			set
			{
				textColor = value;
				Invalidate();
			}
		}

		public Font TextFont
		{
			get
			{
				return textFont;
			}
			set
			{
				textFont = value;
				Invalidate();
			}
		}

		public Orientation TextOrientation
		{
			get
			{
				return textOrientation;
			}
			set
			{
				textOrientation = value;
				Invalidate();
			}
		}

		public Point StartingDisplayPoint
		{
			get
			{
				return startingDisplayPoint;
			}
			set
			{
				startingDisplayPoint = value;
				Invalidate();
			}
		}
		
		public enum Orientation
		{
			Vertical,
			Horizontal
		};

		public CustomControlWithProperties()
		{
			InitializeComponent();
		}

		private void CustomControlWithProperties_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, ClientRectangle);
			PointF point = StartingDisplayPoint;
			Brush brush = new SolidBrush(TextColor);
			StringFormat sf = new StringFormat();
			if (TextFont == null)
				TextFont = new Font("Times New Roman", 12);
			if (textOrientation == Orientation.Vertical)
				sf.FormatFlags = StringFormatFlags.DirectionVertical;
			for (int count = 0; count < DisplayCount; ++count)
			{
				g.DrawString(DisplayText, TextFont, brush, point.X, point.Y, sf);
				if (textOrientation == Orientation.Vertical)
					point.X += TextFont.GetHeight();
				else
					point.Y += TextFont.GetHeight();
			}
		}
	}
}