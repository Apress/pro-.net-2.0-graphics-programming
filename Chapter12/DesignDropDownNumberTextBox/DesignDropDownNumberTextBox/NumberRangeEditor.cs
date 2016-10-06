using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.Design;
using System.Drawing.Design;
using System.Globalization;
using System.ComponentModel.Design.Serialization;
using System.ComponentModel;

namespace DesignDropDownNumberTextBox
{
  // Remember to put this class at the end of the namespace
  /// <summary>
  /// Summary description for NumberRangeEditor.
  /// </summary>
	public class NumberRangeEditor : System.Drawing.Design.UITypeEditor
	{
		public override
		  UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
		{
			if (context != null && context.Instance != null)
			{
				return UITypeEditorEditStyle.DropDown;
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
				edSvc = (IWindowsFormsEditorService)provider.GetService(
				  typeof(IWindowsFormsEditorService));

				if (edSvc != null)
				{
					NumberTextBoxC originalControl = (NumberTextBoxC)context.Instance;
					NumberRangeDropDown editingDropDown =
					  new NumberRangeDropDown
					  (originalControl.NumberRange);
					edSvc.DropDownControl(editingDropDown);
					value = editingDropDown.NewNumberRange;
					return value;
				}
			}
			return value;
		}
	}
}
