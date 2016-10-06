using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestFocusableControlWithEvents
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnEnableDisable_Click(object sender, EventArgs e)
		{
			btnEnableDisable.Text =
  focusableControlWithEvents1.Enabled ? "&Enable" : "&Disable";
			focusableControlWithEvents1.Enabled = !focusableControlWithEvents1.Enabled;
		}

		private void btnShowHide_Click(object sender, EventArgs e)
		{
			btnShowHide.Text = focusableControlWithEvents1.Visible ? "&Show" : "&Hide";
			focusableControlWithEvents1.Visible = !focusableControlWithEvents1.Visible;
		}

		private void focusableControlWithEvents1_FocusableControlClick(object sender, FocusableControlWithEvents.FocusableControlEventArgs e)
		{
			MessageBox.Show("Source of event is: " + e.EventType);
		}
	}
}