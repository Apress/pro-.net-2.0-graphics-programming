using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Globalization;
using System.ComponentModel.Design.Serialization;

namespace DesignDlgNumberTextBox
{
	public class NumberRangeEditor : System.Drawing.Design.UITypeEditor
	{
		public override UITypeEditorEditStyle GetEditStyle(
		    ITypeDescriptorContext context)
		{
			if (context != null && context.Instance != null)
			{
				return UITypeEditorEditStyle.Modal;
			}
			return base.GetEditStyle(context);
		}

		public override object EditValue(
			ITypeDescriptorContext context, IServiceProvider provider, object value)
		{
			IWindowsFormsEditorService edSvc = null;

			if (context != null
			  && context.Instance != null
			  && provider != null)
			{

				edSvc = (IWindowsFormsEditorService)
				  provider.GetService(typeof(IWindowsFormsEditorService));

				if (edSvc != null)
				{
					NumberTextBoxB originalControl = (NumberTextBoxB)context.Instance;
					NumberRangeDialog editingDialog =
					  new NumberRangeDialog(originalControl.NumberRange);

					DialogResult dr = edSvc.ShowDialog(editingDialog);

					// This method could take different actions based on
					// the return value of the dialog
					if (dr == DialogResult.OK)
					{
						value = editingDialog.EditedNumberRange;
						return value;
					}
				}
			}
			return value;
		}
	}
}
