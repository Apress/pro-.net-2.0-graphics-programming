namespace TestSmoothScrollableControl
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
			this.smoothScrollableControl1 = new SmoothScrollableControl.SmoothScrollableControl();
			this.SuspendLayout();
			// 
			// smoothScrollableControl1
			// 
			this.smoothScrollableControl1.Location = new System.Drawing.Point(13, 13);
			this.smoothScrollableControl1.Name = "smoothScrollableControl1";
			this.smoothScrollableControl1.ScrollingImage = null;
			this.smoothScrollableControl1.Size = new System.Drawing.Size(342, 267);
			this.smoothScrollableControl1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(382, 302);
			this.Controls.Add(this.smoothScrollableControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private SmoothScrollableControl.SmoothScrollableControl smoothScrollableControl1;
	}
}

