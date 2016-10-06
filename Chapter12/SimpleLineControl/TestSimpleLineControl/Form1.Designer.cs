namespace TestSimpleLineControl
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
			this.simpleLineControl1 = new SimpleLineControl.SimpleLineControl();
			this.SuspendLayout();
			// 
			// simpleLineControl1
			// 
			this.simpleLineControl1.BackColor = System.Drawing.Color.Yellow;
			this.simpleLineControl1.LinePosition = 54;
			this.simpleLineControl1.Location = new System.Drawing.Point(27, 29);
			this.simpleLineControl1.Name = "simpleLineControl1";
			this.simpleLineControl1.Size = new System.Drawing.Size(234, 189);
			this.simpleLineControl1.TabIndex = 0;
			this.simpleLineControl1.Text = "simpleLineControl1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 268);
			this.Controls.Add(this.simpleLineControl1);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private SimpleLineControl.SimpleLineControl simpleLineControl1;
	}
}

