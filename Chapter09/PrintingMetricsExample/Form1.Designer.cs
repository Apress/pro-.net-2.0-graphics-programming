namespace PrintingMetricsExample
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFilePageSetup = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFilePrintPreview = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFilePrint = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(292, 25);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFilePageSetup,
            this.menuFilePrintPreview,
            this.menuFilePrint});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Text = "File";
			// 
			// menuFilePageSetup
			// 
			this.menuFilePageSetup.Name = "menuFilePageSetup";
			this.menuFilePageSetup.Text = "Page Setup";
			this.menuFilePageSetup.Click += new System.EventHandler(this.menuFilePageSetup_Click);
			// 
			// menuFilePrintPreview
			// 
			this.menuFilePrintPreview.Name = "menuFilePrintPreview";
			this.menuFilePrintPreview.Text = "Print Preview";
			this.menuFilePrintPreview.Click += new System.EventHandler(this.menuFilePrintPreview_Click);
			// 
			// menuFilePrint
			// 
			this.menuFilePrint.Name = "menuFilePrint";
			this.menuFilePrint.Text = "Print";
			this.menuFilePrint.Click += new System.EventHandler(this.menuFilePrint_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(292, 268);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "SimplePrintingExample";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.menuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuFilePageSetup;
		private System.Windows.Forms.ToolStripMenuItem menuFilePrintPreview;
		private System.Windows.Forms.ToolStripMenuItem menuFilePrint;
	}
}

