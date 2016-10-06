using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace NumberTextBox
{
	public partial class NumberTextBox : System.Windows.Forms.TextBox
	{
		private string rangeText = "0,100";
		private double low = 0, high = 100;

		[DefaultValue("0,100")]
		public string RangeText
		{
			get
			{
				return rangeText;
			}
			set
			{
				if (value == null)
					throw new InvalidRangeTextException("Range text cannot be null");
				string[] v = ((string)value).Split(new char[] {','});
				if (v.Length != 2)
					throw new InvalidRangeTextException(
					"Range text should have format <f>,<f> where <f>=floating-point number");
				try
				{
					low = double.Parse(v[0]);
					high = double.Parse(v[1]);
				}
				catch (FormatException)
				{
					throw new InvalidRangeTextException(
					"Validation parameters should have form <f>,<f> where <f>=floating point number");
				}
				rangeText = value;
			}
		}

		[Browsable(false)]
		public bool ContentsInRange
		{
			get
			{
				double textBoxValue;

				// Check value is a number
				try
				{
					textBoxValue = Double.Parse(this.Text);
				}
				catch (FormatException)
				{
					return false;
				}

				// If high < low, then check number is OUT of range
				if (high < low)
				{
					if (textBoxValue < low && textBoxValue > high)
						return false;
					else
						return true;
				}
				// If high >= low, then check number is IN range
				if (textBoxValue < low || textBoxValue > high)
					return false;
				return true;
			}
		}

		[Browsable(false)]
		public string ValidationErrorMessage
		{
			get
			{
				if (ContentsInRange)
					return "";
				if (high >= low)
					return "Value must lie between " + low.ToString() +
					  " and " + high.ToString();
				else
					return "Value must NOT lie between " + high.ToString() +
					  " and " + low.ToString();
			}
		}

		public NumberTextBox()
		{
			InitializeComponent();
		}

		private void NumberTextBox_Validating(object sender, CancelEventArgs e)
		{
			if (ContentsInRange)
			{
				this.BackColor = Color.White;
			}
			else
			{
				this.BackColor = Color.Yellow;
			}
			e.Cancel = false;
		}
	}

	public class InvalidRangeTextException : ApplicationException
	{
		public InvalidRangeTextException(string s)
			: base(s)
		{
		}
	}
}