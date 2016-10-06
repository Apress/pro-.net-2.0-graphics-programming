namespace TestFocusableControlWithEvents
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
			this.btnEnableDisable = new System.Windows.Forms.Button();
			this.btnShowHide = new System.Windows.Forms.Button();
			this.focusableControlWithEvents1 = new FocusableControlWithEvents.FocusableControlWithEvents();
			this.SuspendLayout();
			// 
			// btnEnableDisable
			// 
			this.btnEnableDisable.Location = new System.Drawing.Point(235, 12);
			this.btnEnableDisable.Name = "btnEnableDisable";
			this.btnEnableDisable.Size = new System.Drawing.Size(116, 37);
			this.btnEnableDisable.TabIndex = 1;
			this.btnEnableDisable.Text = "&Disable";
			this.btnEnableDisable.Click += new System.EventHandler(this.btnEnableDisable_Click);
			// 
			// btnShowHide
			// 
			this.btnShowHide.Location = new System.Drawing.Point(235, 55);
			this.btnShowHide.Name = "btnShowHide";
			this.btnShowHide.Size = new System.Drawing.Size(116, 37);
			this.btnShowHide.TabIndex = 2;
			this.btnShowHide.Text = "&Hide";
			this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
			// 
			// focusableControlWithEvents1
			// 
			this.focusableControlWithEvents1.Location = new System.Drawing.Point(12, 12);
			this.focusableControlWithEvents1.Name = "focusableControlWithEvents1";
			this.focusableControlWithEvents1.Size = new System.Drawing.Size(206, 80);
			this.focusableControlWithEvents1.TabIndex = 0;
			this.focusableControlWithEvents1.Text = "&Focus";
			this.focusableControlWithEvents1.FocusableControlClick += new FocusableControlWithEvents.FocusableControlEventHandler(this.focusableControlWithEvents1_FocusableControlClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(363, 102);
			this.Controls.Add(this.btnShowHide);
			this.Controls.Add(this.btnEnableDisable);
			this.Controls.Add(this.focusableControlWithEvents1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private FocusableControlWithEvents.FocusableControlWithEvents focusableControlWithEvents1;
		private System.Windows.Forms.Button btnEnableDisable;
		private System.Windows.Forms.Button btnShowHide;
	}
}

