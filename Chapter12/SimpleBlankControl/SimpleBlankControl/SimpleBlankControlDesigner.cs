using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;

namespace SimpleBlankControl
{
	public class SimpleBlankControlDesigner :
	  System.Windows.Forms.Design.ControlDesigner
	{
		public override DesignerVerbCollection Verbs
		{
			get
			{
				DesignerVerb[] verbs = new DesignerVerb[]
				{
					new DesignerVerb("&Make Square", new EventHandler(OnMakeSquare))
				};
				return new DesignerVerbCollection(verbs);
			}
		}

		private void OnMakeSquare(object sender, EventArgs e)
		{
			Size s = this.Control.Size;
			s.Width = Math.Max(s.Width, s.Height);
			s.Height = Math.Max(s.Width, s.Height);
			PropertyDescriptorCollection properties =
			  TypeDescriptor.GetProperties(this.Control.GetType());
			PropertyDescriptor sizeProp = properties["Size"];
			sizeProp.SetValue(this.Control, s);
		}
	}
}
