using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestDesignNumberTextBox
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void numberTextBoxA1_Validating(object sender, CancelEventArgs e)
		{
			DesignNumberTextBox.NumberTextBoxA tbSender = (DesignNumberTextBox.NumberTextBoxA)sender;
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

		private void numberTextBoxA2_Validating(object sender, CancelEventArgs e)
		{
			DesignNumberTextBox.NumberTextBoxA tbSender = (DesignNumberTextBox.NumberTextBoxA)sender;
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