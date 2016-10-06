using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesignDlgNumberTextBox
{
	public partial class NumberRangeDialog : Form
	{
		private NumberRange editedNR;

		public NumberRange EditedNumberRange
		{
			get
			{
				return editedNR;
			}
			set
			{
				editedNR = value;
			}
		}

		public NumberRangeDialog(NumberRange editedNR)
		{
			this.editedNR = editedNR; 
			InitializeComponent();
		}

		private void NumberRangeDialog_Load(object sender, EventArgs e)
		{
			tbLow.Text = editedNR.Low.ToString();
			tbHigh.Text = editedNR.High.ToString();
		}

		private void tbLow_Validating(object sender, CancelEventArgs e)
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

		private void tbHigh_Validating(object sender, CancelEventArgs e)
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

		private void btnOK_Click(object sender, EventArgs e)
		{
			editedNR.High = Double.Parse(tbHigh.Text);
			editedNR.Low = Double.Parse(tbLow.Text);
		}
	}
}