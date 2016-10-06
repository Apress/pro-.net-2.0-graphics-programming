using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DesignDropDownNumberTextBox
{
	public partial class NumberRangeDropDown : UserControl
	{
		private NumberRange originalNR;
		private NumberRange newNR;
		private bool canceling;

		public NumberRange NewNumberRange
		{
			get
			{
				return newNR;
			}
		}

		public NumberRangeDropDown(NumberRange originalNR)
		{
			this.originalNR = originalNR;
			InitializeComponent();
		}

		private void NumberRangeDropDown_Load(object sender, EventArgs e)
		{
			// Save a copy of NumberRange, so that if the user presses the
			// Esc key, we can revert to the previous values
			newNR = originalNR;

			// Load up the TextBox controls
			this.tbHigh.Text = originalNR.High.ToString();
			this.tbLow.Text = originalNR.Low.ToString();
		}

		private void tbLow_Validating(object sender, CancelEventArgs e)
		{
			try
			{
				Double.Parse(tbLow.Text);
			}
			catch (FormatException)
			{
				MessageBox.Show("Invalid value", "Validation Error",
				  MessageBoxButtons.OK, MessageBoxIcon.Error);
				e.Cancel = true;
				return;
			}
		}

		private void tbHigh_Validating(object sender, CancelEventArgs e)
		{
			try
			{
				Double.Parse(tbHigh.Text);
			}
			catch (FormatException)
			{
				MessageBox.Show("Invalid value", "Validation Error",
				  MessageBoxButtons.OK, MessageBoxIcon.Error);
				e.Cancel = true;
				return;
			}
		}

		protected override bool ProcessDialogKey(Keys keyData)
		{
			if (keyData == Keys.Escape)
			{
				originalNR = newNR;
				canceling = true;
			}
			return base.ProcessDialogKey(keyData);
		}

		private void NumberRangeDropDown_Leave(object sender, EventArgs e)
		{
			if (!canceling)
			{
				newNR.Low = Double.Parse(tbLow.Text);
				newNR.High = Double.Parse(tbHigh.Text);
			}
		}
	}
}
