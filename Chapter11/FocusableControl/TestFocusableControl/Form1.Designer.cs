namespace TestFocusableControl
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
			this.focusableControl1 = new FocusableControl.FocusableControl();
			this.btnEnableDisable = new System.Windows.Forms.Button();
			this.btnShowHide = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// focusableControl1
			// 
			this.focusableControl1.Location = new System.Drawing.Point(12, 12);
			this.focusableControl1.Name = "focusableControl1";
			this.focusableControl1.Size = new System.Drawing.Size(201, 78);
			this.focusableControl1.TabIndex = 0;
			this.focusableControl1.Text = "&Focus";
			// 
			// btnEnableDisable
			// 
			this.btnEnableDisable.Location = new System.Drawing.Point(232, 12);
			this.btnEnableDisable.Name = "btnEnableDisable";
			this.btnEnableDisable.Size = new System.Drawing.Size(110, 36);
			this.btnEnableDisable.TabIndex = 1;
			this.btnEnableDisable.Text = "&Disable";
			this.btnEnableDisable.Click += new System.EventHandler(this.btnEnableDisable_Click);
			// 
			// btnShowHide
			// 
			this.btnShowHide.Location = new System.Drawing.Point(232, 54);
			this.btnShowHide.Name = "btnShowHide";
			this.btnShowHide.Size = new System.Drawing.Size(110, 36);
			this.btnShowHide.TabIndex = 2;
			this.btnShowHide.Text = "&Hide";
			this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(355, 105);
			this.Controls.Add(this.btnShowHide);
			this.Controls.Add(this.btnEnableDisable);
			this.Controls.Add(this.focusableControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private FocusableControl.FocusableControl focusableControl1;
		private System.Windows.Forms.Button btnEnableDisable;
		private System.Windows.Forms.Button btnShowHide;
	}
}

