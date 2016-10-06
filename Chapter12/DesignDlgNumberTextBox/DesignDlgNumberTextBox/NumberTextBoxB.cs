using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Design;
using System.Globalization;
using System.ComponentModel.Design.Serialization;

namespace DesignDlgNumberTextBox
{
	public partial class NumberTextBoxB : System.Windows.Forms.TextBox
	{
		private static readonly NumberRange defaultNumberRange =
		  new NumberRange(0, 100);
		private NumberRange numberRange = defaultNumberRange;

		[Category("Validation")]
		public NumberRange NumberRange
		{
			get
			{
				return numberRange;
			}
			set
			{
				numberRange = value;
			}
		}

		public void ResetNumberRange()
		{
			NumberRange = defaultNumberRange;
		}

		public bool ShouldSerializeNumberRange()
		{
			return !NumberRange.Equals(defaultNumberRange);
		}

		[Browsable(false)]
		public bool ContentsInRange
		{
			get
			{
				return this.NumberRange.Validate(this.Text);
			}
		}

		[Browsable(false)]
		public string ValidationErrorMessage
		{
			get
			{
				if (ContentsInRange)
					return "";
				if (numberRange.High >= NumberRange.Low)
					return "Value must lie between " + NumberRange.Low.ToString() +
					  " and " + NumberRange.High.ToString();
				else
					return "Value must NOT lie between " + NumberRange.High.ToString()
					  + " and " + NumberRange.Low.ToString();
			}
		}

		public NumberTextBoxB()
		{
			InitializeComponent();
		}

		private void NumberTextBoxB_Validating(object sender, CancelEventArgs e)
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

	public class NumberRangeConverter : System.ComponentModel.TypeConverter
	{
		public override bool CanConvertFrom(
		  ITypeDescriptorContext context, Type sourceType)
		{
			if (sourceType == typeof(string))
				return true;
			return base.CanConvertFrom(context, sourceType);
		}

		public override object ConvertFrom(
		  ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value is string)
			{
				string[] v = ((string)value).Split(new char[] { ',' });
				if (v.Length != 2)
					throw new ArgumentException(
					  "number range string must be of form <low limit>,<high limit>");
				NumberRange nr =
				  new NumberRange(double.Parse(v[0]), double.Parse(v[1]));
				return nr;
			}
			return base.ConvertFrom(context, culture, value);
		}

		public override bool CanConvertTo(
		  ITypeDescriptorContext context, Type destinationType)
		{
			if (destinationType == typeof(string))
				return true;
			if (destinationType == typeof(InstanceDescriptor))
				return true;
			return base.CanConvertTo(context, destinationType);
		}

		public override object ConvertTo(
		  ITypeDescriptorContext context, CultureInfo culture, object value,
			Type destinationType)
		{
			if (destinationType == typeof(string))
			{
				NumberRange nr = (NumberRange)value;
				return nr.Low + "," + nr.High;
			}
			if (destinationType == typeof(InstanceDescriptor))
			{
				NumberRange nr = (NumberRange)value;

				// Specify that we should use the two-parameter constructor
				return new InstanceDescriptor
				  (typeof(NumberRange).GetConstructor(
				  new Type[2] {
            typeof(double),
            typeof(double)
          }),
				  new double[2] {
            nr.Low,
            nr.High
          });
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		public override bool GetPropertiesSupported(
		  ITypeDescriptorContext context)
		{
			return true;
		}

		public override PropertyDescriptorCollection GetProperties(
		  ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			PropertyDescriptorCollection properties =
			  TypeDescriptor.GetProperties(typeof(NumberRange), attributes);
			return properties;
		}
	}

	[Editor(typeof(NumberRangeEditor), typeof(UITypeEditor))]
	[TypeConverter(typeof(NumberRangeConverter))]
	public struct NumberRange
	{
		private double low;
		private double high;

		public NumberRange(double low, double high)
		{
			this.low = low;
			this.high = high;
		}

		public double Low
		{
			get
			{
				return low;
			}
			set
			{
				low = value;
			}
		}

		public double High
		{
			get
			{
				return high;
			}
			set
			{
				high = value;
			}
		}

		public bool Validate(string s)
		{
			double val;
			// Check value is a number
			try
			{
				val = Double.Parse(s);
			}
			catch (FormatException)
			{
				return false;
			}

			// If high < low then check number is OUT of range
			if (high < low)
			{
				if (val < low && val > high)
					return false;
				else
					return true;
			}
			// If high >= low then check number is IN range
			if (val < low || val > high)
				return false;
			return true;
		}
	}
}