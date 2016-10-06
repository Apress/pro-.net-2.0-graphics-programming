namespace DesignDropDownNumberTextBox
{
	partial class NumberRangeDropDown
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbLow = new System.Windows.Forms.TextBox();
			this.tbHigh = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Low";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "High";
			// 
			// tbLow
			// 
			this.tbLow.Location = new System.Drawing.Point(60, 9);
			this.tbLow.Name = "tbLow";
			this.tbLow.Size = new System.Drawing.Size(100, 22);
			this.tbLow.TabIndex = 2;
			this.tbLow.Validating += new System.ComponentModel.CancelEventHandler(this.tbLow_Validating);
			// 
			// tbHigh
			// 
			this.tbHigh.Location = new System.Drawing.Point(60, 40);
			this.tbHigh.Name = "tbHigh";
			this.tbHigh.Size = new System.Drawing.Size(100, 22);
			this.tbHigh.TabIndex = 3;
			this.tbHigh.Validating += new System.ComponentModel.CancelEventHandler(this.tbHigh_Validating);
			// 
			// NumberRangeDropDown
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.Controls.Add(this.tbHigh);
			this.Controls.Add(this.tbLow);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "NumberRangeDropDown";
			this.Size = new System.Drawing.Size(181, 78);
			this.Load += new System.EventHandler(this.NumberRangeDropDown_Load);
			this.Leave += new System.EventHandler(this.NumberRangeDropDown_Leave);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbLow;
		private System.Windows.Forms.TextBox tbHigh;
	}
}
