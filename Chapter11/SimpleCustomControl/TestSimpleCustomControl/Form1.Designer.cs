namespace TestSimpleCustomControl
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
			this.simpleCustomControl1 = new SimpleCustomControl.SimpleCustomControl();
			this.SuspendLayout();
			// 
			// simpleCustomControl1
			// 
			this.simpleCustomControl1.Location = new System.Drawing.Point(12, 12);
			this.simpleCustomControl1.Name = "simpleCustomControl1";
			this.simpleCustomControl1.Size = new System.Drawing.Size(178, 110);
			this.simpleCustomControl1.TabIndex = 0;
			this.simpleCustomControl1.Text = "simpleCustomControl1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 268);
			this.Controls.Add(this.simpleCustomControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private SimpleCustomControl.SimpleCustomControl simpleCustomControl1;
	}
}

