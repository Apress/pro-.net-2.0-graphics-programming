namespace ScrollAndSelectList
{
	partial class ScrollAndSelectList
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
			bitmap.Dispose(); 
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
			this.vScrollBar1.Location = new System.Drawing.Point(130, 0);
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.Size = new System.Drawing.Size(20, 150);
			this.vScrollBar1.TabIndex = 0;
			this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
			// 
			// ScrollAndSelectList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.vScrollBar1);
			this.Name = "ScrollAndSelectList";
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScrollAndSelectList_MouseMove);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.ScrollAndSelectList_Paint);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScrollAndSelectList_MouseUp);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScrollAndSelectList_MouseDown);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.VScrollBar vScrollBar1;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}
