namespace TestDesignDropDownNumberTextBox
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
			this.numberTextBoxC1 = new DesignDropDownNumberTextBox.NumberTextBoxC();
			this.numberTextBoxC2 = new DesignDropDownNumberTextBox.NumberTextBoxC();
			this.SuspendLayout();
			// 
			// numberTextBoxC1
			// 
			this.numberTextBoxC1.Location = new System.Drawing.Point(88, 23);
			this.numberTextBoxC1.Name = "numberTextBoxC1";
			this.numberTextBoxC1.Size = new System.Drawing.Size(100, 23);
			this.numberTextBoxC1.TabIndex = 0;
			// 
			// numberTextBoxC2
			// 
			this.numberTextBoxC2.Location = new System.Drawing.Point(88, 71);
			this.numberTextBoxC2.Name = "numberTextBoxC2";
			this.numberTextBoxC2.NumberRange = new DesignDropDownNumberTextBox.NumberRange(200, 0);
			this.numberTextBoxC2.Size = new System.Drawing.Size(100, 23);
			this.numberTextBoxC2.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 268);
			this.Controls.Add(this.numberTextBoxC2);
			this.Controls.Add(this.numberTextBoxC1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DesignDropDownNumberTextBox.NumberTextBoxC numberTextBoxC1;
		private DesignDropDownNumberTextBox.NumberTextBoxC numberTextBoxC2;
	}
}

