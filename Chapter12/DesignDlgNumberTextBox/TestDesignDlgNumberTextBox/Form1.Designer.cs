namespace TestDesignDlgNumberTextBox
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
			this.numberTextBoxB1 = new DesignDlgNumberTextBox.NumberTextBoxB();
			this.numberTextBoxB2 = new DesignDlgNumberTextBox.NumberTextBoxB();
			this.SuspendLayout();
			// 
			// numberTextBoxB1
			// 
			this.numberTextBoxB1.Location = new System.Drawing.Point(95, 21);
			this.numberTextBoxB1.Name = "numberTextBoxB1";
			this.numberTextBoxB1.Size = new System.Drawing.Size(100, 22);
			this.numberTextBoxB1.TabIndex = 0;
			// 
			// numberTextBoxB2
			// 
			this.numberTextBoxB2.Location = new System.Drawing.Point(95, 66);
			this.numberTextBoxB2.Name = "numberTextBoxB2";
			this.numberTextBoxB2.NumberRange = new DesignDlgNumberTextBox.NumberRange(200, 0);
			this.numberTextBoxB2.Size = new System.Drawing.Size(100, 22);
			this.numberTextBoxB2.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 136);
			this.Controls.Add(this.numberTextBoxB2);
			this.Controls.Add(this.numberTextBoxB1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DesignDlgNumberTextBox.NumberTextBoxB numberTextBoxB1;
		private DesignDlgNumberTextBox.NumberTextBoxB numberTextBoxB2;
	}
}

