using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestFocusableControl
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
  focusableControl1.Enabled ? "&Enable" : "&Disable";
			focusableControl1.Enabled = !focusableControl1.Enabled;
		}

		private void btnShowHide_Click(object sender, EventArgs e)
		{
			btnShowHide.Text = focusableControl1.Visible ? "&Show" : "&Hide";
			focusableControl1.Visible = !focusableControl1.Visible;
		}
	}
}