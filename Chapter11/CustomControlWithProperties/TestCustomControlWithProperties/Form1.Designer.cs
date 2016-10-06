namespace TestCustomControlWithProperties
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
			this.customControlWithProperties1 = new CustomControlWithProperties.CustomControlWithProperties();
			this.SuspendLayout();
			// 
			// customControlWithProperties1
			// 
			this.customControlWithProperties1.DisplayCount = 3;
			this.customControlWithProperties1.DisplayText = "Hello, World";
			this.customControlWithProperties1.Location = new System.Drawing.Point(12, 12);
			this.customControlWithProperties1.Name = "customControlWithProperties1";
			this.customControlWithProperties1.Size = new System.Drawing.Size(268, 244);
			this.customControlWithProperties1.StartingDisplayPoint = new System.Drawing.Point(6, 6);
			this.customControlWithProperties1.TabIndex = 0;
			this.customControlWithProperties1.TextColor = System.Drawing.Color.Red;
			this.customControlWithProperties1.TextFont = new System.Drawing.Font("Times New Roman", 12F);
			this.customControlWithProperties1.TextOrientation = CustomControlWithProperties.CustomControlWithProperties.Orientation.Vertical;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 268);
			this.Controls.Add(this.customControlWithProperties1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private CustomControlWithProperties.CustomControlWithProperties customControlWithProperties1;
	}
}

