namespace TestModifiedScrollAndSelectList
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
			this.modifiedScrollAndSelectList1 = new ModifiedScrollAndSelectList.ModifiedScrollAndSelectList();
			this.SuspendLayout();
			// 
			// modifiedScrollAndSelectList1
			// 
			this.modifiedScrollAndSelectList1.Location = new System.Drawing.Point(12, 12);
			this.modifiedScrollAndSelectList1.Name = "modifiedScrollAndSelectList1";
			this.modifiedScrollAndSelectList1.Size = new System.Drawing.Size(115, 244);
			this.modifiedScrollAndSelectList1.TabIndex = 0;
			this.modifiedScrollAndSelectList1.VirtualSpaceSize = new System.Drawing.Size(100, 1000);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(143, 269);
			this.Controls.Add(this.modifiedScrollAndSelectList1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private ModifiedScrollAndSelectList.ModifiedScrollAndSelectList modifiedScrollAndSelectList1;
	}
}

