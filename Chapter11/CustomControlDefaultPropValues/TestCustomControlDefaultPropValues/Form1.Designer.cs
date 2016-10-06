namespace TestCustomControlDefaultPropValues
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.customControlDefaultPropValues1 = new CustomControlDefaultPropValues.CustomControlDefaultPropValues();
			this.SuspendLayout();
			// 
			// customControlDefaultPropValues1
			// 
			this.customControlDefaultPropValues1.Location = new System.Drawing.Point(12, 16);
			this.customControlDefaultPropValues1.Name = "customControlDefaultPropValues1";
			this.customControlDefaultPropValues1.Size = new System.Drawing.Size(268, 240);
			this.customControlDefaultPropValues1.TabIndex = 0;
			this.customControlDefaultPropValues1.Text = "customControlDefaultPropValues1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 268);
			this.Controls.Add(this.customControlDefaultPropValues1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private CustomControlDefaultPropValues.CustomControlDefaultPropValues customControlDefaultPropValues1;

	}
}

