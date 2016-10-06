namespace TestScrollingText
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
			this.scrollingText1 = new ScrollingText.ScrollingText();
			this.SuspendLayout();
			// 
			// scrollingText1
			// 
			this.scrollingText1.AutoScroll = true;
			this.scrollingText1.AutoScrollMinSize = new System.Drawing.Size(600, 400);
			this.scrollingText1.BackColor = System.Drawing.SystemColors.Window;
			this.scrollingText1.Location = new System.Drawing.Point(13, 13);
			this.scrollingText1.Name = "scrollingText1";
			this.scrollingText1.Size = new System.Drawing.Size(267, 243);
			this.scrollingText1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 268);
			this.Controls.Add(this.scrollingText1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private ScrollingText.ScrollingText scrollingText1;
	}
}

