using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestNumberTextBox
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void validationTextBox_Validating(
			object sender, System.ComponentModel.CancelEventArgs e)
		{
			NumberTextBox.NumberTextBox tbSender = (NumberTextBox.NumberTextBox)sender;
			if (!tbSender.ContentsInRange)
			{
				this.errorProvider1.SetError(
				  tbSender, tbSender.ValidationErrorMessage);
			}
			else
			{
				this.errorProvider1.SetError(tbSender, "");
			}
		}
	}
}