using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SimpleBlankControl
{
	[Designer(typeof(SimpleBlankControlDesigner))]
	public partial class SimpleBlankControl : System.Windows.Forms.Control
	{
		public SimpleBlankControl()
		{
			InitializeComponent();
		}
	}
}