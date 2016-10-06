namespace TestSimpleBlankControl
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
			this.simpleBlankControl1 = new SimpleBlankControl.SimpleBlankControl();
			this.SuspendLayout();
			// 
			// simpleBlankControl1
			// 
			this.simpleBlankControl1.BackColor = System.Drawing.Color.Yellow;
			this.simpleBlankControl1.Location = new System.Drawing.Point(35, 12);
			this.simpleBlankControl1.Name = "simpleBlankControl1";
			this.simpleBlankControl1.Size = new System.Drawing.Size(133, 94);
			this.simpleBlankControl1.TabIndex = 0;
			this.simpleBlankControl1.Text = "simpleBlankControl1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 268);
			this.Controls.Add(this.simpleBlankControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private SimpleBlankControl.SimpleBlankControl simpleBlankControl1;
	}
}

