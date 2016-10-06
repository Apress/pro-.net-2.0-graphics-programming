using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CustomControlDefaultPropValues
{
	public partial class CustomControlDefaultPropValues : System.Windows.Forms.Control 
	{
		private string displayText = "Hello, World";
		private int displayCount = 3;
		private Color textColor = Color.Red;
		private Font textFont = new Font("Times New Roman", 12);
		private Orientation textOrientation = Orientation.Vertical;
		private Point startingDisplayPoint = new Point(6, 6);

		[DefaultValue("Hello, World")]
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

		[DefaultValue(3)]
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

		public void ResetTextColor()
		{
			TextColor = Color.Red;
		}

		public bool ShouldSerializeTextColor()
		{
			return TextColor != Color.Red;
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

		public void ResetTextFont()
		{
			TextFont = new Font("Times New Roman", 12);
		}

		public bool ShouldSerializeTextFont()
		{
			return !TextFont.Equals(new Font("Times New Roman", 12));
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

		[DefaultValue(Orientation.Vertical)]
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

		public void ResetStartingDisplayPoint()
		{
			StartingDisplayPoint = new Point(6, 6);
		}

		public bool ShouldSerializeStartingDisplayPoint()
		{
			return StartingDisplayPoint != new Point(6, 6);
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

		public CustomControlDefaultPropValues()
		{
			InitializeComponent();
		}

		private void CustomControlDefaultPropValues_Paint(object sender, PaintEventArgs e)
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