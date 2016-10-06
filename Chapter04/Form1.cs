using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Chapter04
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			// uncomment each section to run the example





			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			FontFamily ff = new FontFamily("Times New Roman");
			Font f = new Font(ff, 12);
			String s = "Height: " + f.Height;
			SizeF sf = g.MeasureString(s, f, Int32.MaxValue,
									   StringFormat.GenericTypographic);
			RectangleF r = new RectangleF(0, 0, sf.Width, f.Height);

			g.DrawRectangle(Pens.Black, r.Left, r.Top, r.Width, r.Height);
			g.DrawString(s, f, Brushes.Black, r, StringFormat.GenericTypographic);

			f.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			// Create some Font objects
			Font font = new Font("Times New Roman", 12, FontStyle.Regular);
			Font bfont = new Font("Times New Roman", 12, FontStyle.Bold);
			Font ifont = new Font("Times New Roman", 12, FontStyle.Italic);
			Font bifont = new Font("Times New Roman", 12,
										 FontStyle.Bold | FontStyle.Italic);
			Font sfont = new Font("Times New Roman", 12, FontStyle.Strikeout);
			Font ufont = new Font("Times New Roman", 12, FontStyle.Underline);
			Font bsfont = new Font("Times New Roman", 12,
										 FontStyle.Bold | FontStyle.Strikeout);
			int h = font.Height;

			// Use each Font object to draw a line of text
			g.DrawString("Regular", font, Brushes.Black, 0, 0);
			g.DrawString("Bold", bfont, Brushes.Black, 0, h);
			g.DrawString("Italic", ifont, Brushes.Black, 0, h * 2);
			g.DrawString("Bold-Italic", bifont, Brushes.Black, 0, h * 3);
			g.DrawString("Strikeout", sfont, Brushes.Black, 0, h * 4);
			g.DrawString("Underline", ufont, Brushes.Black, 0, h * 5);
			g.DrawString("Bold & Strikeout", bsfont, Brushes.Black, 0, h * 6);

			// Finally, dispose of all the Font objects
			font.Dispose();
			bfont.Dispose();
			ifont.Dispose();
			bifont.Dispose();
			sfont.Dispose();
			ufont.Dispose();
			bsfont.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			// Declare a long text string
			String s = "This string is long enough to wrap. ";
			s += "With a 200px-width rectangle, and a 12pt font, ";
			s += "it requires six lines to display the string in its entirety.";

			// Declare a Font object and a Rectangle object
			Font f = new Font("Arial", 12);
			Rectangle r = new Rectangle(20, 20, 200, f.Height * 6);

			// Draw the rectangle
			// Also draw the string, using the rectangle as a bounding box
			g.DrawRectangle(Pens.Black, r);
			g.DrawString(s, f, Brushes.Black, r);

			f.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			// Declare a long text string
			String s = "This string is long enough to wrap. ";
			s += "We'll use a 12pt font, and assume ";
			s += "the text string must fit into a width of 150 pixels. ";

			// Declare a Font object and a Rectangle object
			Font f = new Font("Arial", 12);
			SizeF sf = g.MeasureString(s, f, 150);
			RectangleF rf = new RectangleF(20, 20, sf.Width, sf.Height);

			// Draw the rectangle
			// Also draw the string, using the rectangle as a bounding box
			g.DrawRectangle(Pens.Black, rf.Left, rf.Top, rf.Width, rf.Height);
			g.DrawString(s, f, Brushes.Black, rf); 

			f.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			// Declare a long text string
			String s = "This string is long enough to wrap. ";

			// Declare a Font object and a Rectangle object
			Font f = new Font("Arial", 12);
			Rectangle r = new Rectangle(20, 20, 150, f.Height * 4);

			// Declare the StringFormat object, and set the FormatFlags property
			StringFormat sf = new StringFormat();
			sf.FormatFlags = StringFormatFlags.NoWrap;

			// Draw the rectangle
			// Also draw the string, using the rectangle as a bounding box
			g.DrawRectangle(Pens.Black, r);
			g.DrawString(s, f, Brushes.Black, r, sf);
			f.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			// Create a text string, a Font object, and a StringFormat object
			String s = "This is a long string that will wrap. ";
			s += "It will be centered both vertically and horizontally.";
			Font f = new Font("Arial", 12);
			StringFormat sf = new StringFormat();

			// Center each line of text horizontally and vertically 
			sf.Alignment = StringAlignment.Center;        // horizontal alignment
			sf.LineAlignment = StringAlignment.Center;    // vertical alignment

			// Draw a rectangle and the text string
			Rectangle r = new Rectangle(10, 10, 300, f.Height * 4);
			g.DrawRectangle(Pens.Black, r);
			g.DrawString(s, f, Brushes.Black, r, sf);
			f.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			// Create a text string, a Font object, and a StringFormat object
			String s = "Accrington Stanley";
			StringFormat sf = new StringFormat(StringFormatFlags.DirectionVertical);
			Font f = new Font("Times New Roman", 14);

			// Calculate the size of the text string's containing rectangle 
			SizeF sizef = g.MeasureString(s, f, Int32.MaxValue, sf);

			// Create and draw the rectangle
			// Also draw the text string (using the StringFormat object) 
			RectangleF rf = new RectangleF(20, 20, sizef.Width, sizef.Height);
			g.DrawRectangle(Pens.Black, rf.Left, rf.Top, rf.Width, rf.Height);
			g.DrawString(s, f, Brushes.Black, rf, sf);

			f.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			// Create a couple of Font objects
			Font f = new Font("Times New Roman", 12);
			Font bf = new Font(f, FontStyle.Bold);

			// Create a StringFormat object, and set the tab stops, in pixels
			StringFormat sf = new StringFormat();
			float[] ts = { 10.0f, 70.0f, 100.0f, 90.0f };
			sf.SetTabStops(0.0f, ts);

			// Create some text strings
			// The \t escape-sequence in these lines specifies the tab
			string s1 = "\tName\tHair Color\tEye Color\tHeight";
			string s2 = "\tBob\tBrown\tBrown\t175cm";

			// Use the text string, Font, StringFormat, etc.
			// to draw the text strings
			g.DrawString(s1, bf, Brushes.Black, 20, 20, sf);
			g.DrawString(s2, f, Brushes.Blue, 20, 20 + bf.Height, sf);

			f.Dispose();
			bf.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			// Create a couple of Font objects
			Font f = new Font("Times New Roman", 12);
			Font bf = new Font(f, FontStyle.Bold);

			// Create a StringFormat object, and set the tab stops, in pixels
			StringFormat sf = new StringFormat();
			float[] ts = { 10.0f, 70.0f, 100.0f, 90.0f };
			sf.SetTabStops(0.0f, ts);

			// Create some text strings
			// The \t escape-sequence in these lines specifies the tab
			string s1 = "\tName\tHair Color\tEye Color\tHeight";
			string s2 = "\tBob\tBrown\tBrown\t175cm";
			string s3 =
				  "\tMary\tBlond\tHazel\t161cm\n\tBill\tBlack\tBlue\t168cm";

			// Use the text string, Font, StringFormat, etc. 
			//to draw the text strings
			g.DrawString(s1, bf, Brushes.Black, 20, 20, sf);
			g.DrawString(s2, f, Brushes.Blue, 20, 20 + bf.Height, sf);
			g.DrawString(s3, f, Brushes.Blue, 20,
											  20 + bf.Height + f.Height, sf);

			f.Dispose();
			bf.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			Font f = new Font("Courier New", 12);
			Font bf = new Font(f, FontStyle.Bold);

			// Create a StringFormat object, and set the tab stops, in pixels
			StringFormat sf = new StringFormat();
			float[] ts = { 100.0f, 100.0f, 90.0f };
			sf.SetTabStops(0.0f, ts);

			// Create a string that describes how the specified values 
			// should be formatted
			string fs = "{0}\t{1,8}\t{2,8}\t{3,8}";

			// Create some formatted text strings
			string s1 = String.Format(fs, "Month", "Revenue", "Expense", "Profit");
			string s2 = String.Format(fs, "January",
												 "900.00", "1050.00", "-150.00");
			string s3 = String.Format(fs, "February",
												 "1100.00", "990.00", "110.00");

			// Draw the text strings 
			g.DrawString(s1, bf, Brushes.Black, 20, 20, sf);
			g.DrawString(s2, f, Brushes.Blue, 20, 20 + bf.Height, sf);
			g.DrawString(s3, f, Brushes.Blue, 20, 20 + bf.Height + f.Height, sf);

			f.Dispose();
			bf.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			Font f = new Font("Times New Roman", 48, FontStyle.Bold);
			HatchBrush hb = new HatchBrush(HatchStyle.Cross,
													  Color.White, Color.Black);
			g.DrawString("Crazy Crosshatch", f, hb, 0, 0);
			f.Dispose();
			*/





			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			// Create the font family
			FontFamily ff = new FontFamily("Times New Roman");

			// Create the font, passing 24f as the emSize argument
			float emSizeInGU = 24f;
			Font f = new Font(ff, emSizeInGU);

			// Get the design unit metrics from the font family
			int emSizeInDU = ff.GetEmHeight(FontStyle.Regular);
			int ascentInDU = ff.GetCellAscent(FontStyle.Regular);
			int descentInDU = ff.GetCellDescent(FontStyle.Regular);
			int lineSpacingInDU = ff.GetLineSpacing(FontStyle.Regular);

			// Calculate the GraphicsUnit metrics from the font
			float ascentInGU = ascentInDU * (emSizeInGU / emSizeInDU);
			float descentInGU = descentInDU * (emSizeInGU / emSizeInDU);
			float lineSpacingInGU = lineSpacingInDU * (emSizeInGU / emSizeInDU);

			// Output the metrics to the console
			Console.WriteLine("emSize = " + emSizeInDU + " DesignUnits");
			Console.WriteLine("emSize = " + emSizeInGU + " GraphicsUnits");
			string format = "{0,-16}{1,12}{2,16}";
			Console.WriteLine(format,
				   "Font Metric", "DesignUnits", "GraphicsUnits");
			Console.WriteLine(format,
				   "Ascent", ascentInDU, ascentInGU);
			Console.WriteLine(format,
				   "Descent", descentInDU, descentInGU);
			Console.WriteLine(format,
				   "Line Spacing", lineSpacingInDU, lineSpacingInGU);

			// Draw two lines of the text string
			PointF textOrigin = new PointF(20, 20);
			PointF nextLineOrigin = new PointF(textOrigin.X,
											   textOrigin.Y + f.Height);

			g.DrawString("AxgQ", f, Brushes.Black, textOrigin);
			g.DrawString("AxgQ", f, Brushes.Black, nextLineOrigin);

			// Draw a line at the textOrigin
			int lineLen = 100;
			g.DrawLine(Pens.Blue,
				  textOrigin,
				  new PointF(textOrigin.X + lineLen, textOrigin.Y));
			g.DrawLine(Pens.Red,
				  nextLineOrigin,
				  new PointF(nextLineOrigin.X + lineLen, nextLineOrigin.Y));

			// Draw a line at the baseline
			PointF p = new PointF(textOrigin.X,
								  textOrigin.Y + lineSpacingInGU);
			g.DrawLine(Pens.Blue, p,
								  new PointF(p.X + lineLen, p.Y));

			p = new PointF(nextLineOrigin.X,
						   nextLineOrigin.Y + lineSpacingInGU);
			g.DrawLine(Pens.Red, p,
								 new PointF(p.X + lineLen, p.Y));

			// Draw a line at the top of the ascent
			p = new PointF(textOrigin.X,
						  textOrigin.Y + lineSpacingInGU - ascentInGU);
			g.DrawLine(Pens.Blue, p,
								  new PointF(p.X + lineLen, p.Y));

			p = new PointF(nextLineOrigin.X, nextLineOrigin.Y +
				lineSpacingInGU - ascentInGU);
			g.DrawLine(Pens.Red, p, new PointF(p.X + lineLen, p.Y));

			// Draw a line at the bottom of the descent
			p = new PointF(textOrigin.X,
						   textOrigin.Y + lineSpacingInGU + descentInGU);
			g.DrawLine(Pens.Blue, p,
								  new PointF(p.X + lineLen, p.Y));

			p = new PointF(nextLineOrigin.X,
						   nextLineOrigin.Y + lineSpacingInGU + descentInGU);
			g.DrawLine(Pens.Red, p,
								 new PointF(p.X + lineLen, p.Y));
			*/




			/*
			Graphics g = e.Graphics;
			g.PageUnit = GraphicsUnit.Inch;

			Pen p = new Pen(Color.Black, 1 / 96f);
			Font f = new Font("Times New Roman", 16);
			String s = "Abc";
			SizeF sf = g.MeasureString(s, f);

			g.DrawRectangle(p, 1, 1, sf.Width, sf.Height);
			g.DrawString(s, f, Brushes.Black, 1, 1);

			f.Dispose();
			p.Dispose();
			*/




		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// uncomment a section to run that example




			/*
			// Create the format string
			String formatString = "{0,-16}{1,8}{2,9}{3,10}{4,14}";

			// Write the first line of the table
			Console.WriteLine(formatString, "Font Family Name", "Ascent", "Descent",
											"EmHeight", "Line Spacing");

			// Write font metrics for Courier New font family
			FontFamily ff = new FontFamily("Courier New");
			Console.WriteLine(formatString, ff.GetName(0),
				ff.GetCellAscent(FontStyle.Regular),
				ff.GetCellDescent(FontStyle.Regular),
				ff.GetEmHeight(FontStyle.Regular),
				ff.GetLineSpacing(FontStyle.Regular));

			// Write font metrics for Arial font family
			ff = new FontFamily("Arial");
			Console.WriteLine(formatString, ff.GetName(0),
				ff.GetCellAscent(FontStyle.Regular),
				ff.GetCellDescent(FontStyle.Regular),
				ff.GetEmHeight(FontStyle.Regular),
				ff.GetLineSpacing(FontStyle.Regular));

			// Write font metrics for Times New Roman font family
			ff = new FontFamily("Times New Roman");
			Console.WriteLine(formatString, ff.GetName(0),
				ff.GetCellAscent(FontStyle.Regular),
				ff.GetCellDescent(FontStyle.Regular),
				ff.GetEmHeight(FontStyle.Regular),
				ff.GetLineSpacing(FontStyle.Regular));
			*/
		}
	}
}