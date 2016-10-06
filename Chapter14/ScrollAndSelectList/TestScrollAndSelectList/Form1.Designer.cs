namespace TestScrollAndSelectList
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
			this.scrollAndSelectList1 = new ScrollAndSelectList.ScrollAndSelectList();
			this.SuspendLayout();
			// 
			// scrollAndSelectList1
			// 
			this.scrollAndSelectList1.Location = new System.Drawing.Point(13, 13);
			this.scrollAndSelectList1.Name = "scrollAndSelectList1";
			this.scrollAndSelectList1.Size = new System.Drawing.Size(119, 243);
			this.scrollAndSelectList1.TabIndex = 0;
			this.scrollAndSelectList1.VirtualSpaceSize = new System.Drawing.Size(100, 1000);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(149, 273);
			this.Controls.Add(this.scrollAndSelectList1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private ScrollAndSelectList.ScrollAndSelectList scrollAndSelectList1;
	}
}

