namespace TestDesignNumberTextBox
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numberTextBoxA1 = new DesignNumberTextBox.NumberTextBoxA();
			this.numberTextBoxA2 = new DesignNumberTextBox.NumberTextBoxA();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "1st Box";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "2nd Box";
			// 
			// numberTextBoxA1
			// 
			this.numberTextBoxA1.Location = new System.Drawing.Point(76, 6);
			this.numberTextBoxA1.Name = "numberTextBoxA1";
			this.numberTextBoxA1.Size = new System.Drawing.Size(100, 22);
			this.numberTextBoxA1.TabIndex = 2;
			this.numberTextBoxA1.Validating += new System.ComponentModel.CancelEventHandler(this.numberTextBoxA1_Validating);
			// 
			// numberTextBoxA2
			// 
			this.numberTextBoxA2.Location = new System.Drawing.Point(76, 32);
			this.numberTextBoxA2.Name = "numberTextBoxA2";
			this.numberTextBoxA2.NumberRange = new DesignNumberTextBox.NumberRange(200, 0);
			this.numberTextBoxA2.Size = new System.Drawing.Size(100, 22);
			this.numberTextBoxA2.TabIndex = 3;
			this.numberTextBoxA2.Validating += new System.ComponentModel.CancelEventHandler(this.numberTextBoxA2_Validating);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(277, 62);
			this.Controls.Add(this.numberTextBoxA2);
			this.Controls.Add(this.numberTextBoxA1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private DesignNumberTextBox.NumberTextBoxA numberTextBoxA1;
		private DesignNumberTextBox.NumberTextBoxA numberTextBoxA2;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}

