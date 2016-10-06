using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestDataButtons
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void dataButtons1_DataButtonsEvent(object sender, DataButtons.DataButtonsEventArgs e)
		{
			MessageBox.Show(e.EventType.ToString());
		}
	}
}