namespace TestNumberTextBox
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
			this.numberTextBox1 = new NumberTextBox.NumberTextBox();
			this.numberTextBox2 = new NumberTextBox.NumberTextBox();
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
			this.label2.Location = new System.Drawing.Point(12, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "2nd Box";
			// 
			// numberTextBox1
			// 
			this.numberTextBox1.Location = new System.Drawing.Point(92, 2);
			this.numberTextBox1.Name = "numberTextBox1";
			this.numberTextBox1.Size = new System.Drawing.Size(100, 22);
			this.numberTextBox1.TabIndex = 2;
			this.numberTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.validationTextBox_Validating);
			// 
			// numberTextBox2
			// 
			this.numberTextBox2.Location = new System.Drawing.Point(92, 37);
			this.numberTextBox2.Name = "numberTextBox2";
			this.numberTextBox2.RangeText = "200,0";
			this.numberTextBox2.Size = new System.Drawing.Size(100, 22);
			this.numberTextBox2.TabIndex = 3;
			this.numberTextBox2.Validating += new System.ComponentModel.CancelEventHandler(this.validationTextBox_Validating);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(243, 76);
			this.Controls.Add(this.numberTextBox2);
			this.Controls.Add(this.numberTextBox1);
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
		private NumberTextBox.NumberTextBox numberTextBox1;
		private NumberTextBox.NumberTextBox numberTextBox2;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}

