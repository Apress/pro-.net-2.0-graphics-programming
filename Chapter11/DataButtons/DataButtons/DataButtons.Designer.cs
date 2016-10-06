namespace DataButtons
{
	partial class DataButtons
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
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnChange = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(13, 12);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(98, 39);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Add";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnChange
			// 
			this.btnChange.Location = new System.Drawing.Point(117, 12);
			this.btnChange.Name = "btnChange";
			this.btnChange.Size = new System.Drawing.Size(98, 39);
			this.btnChange.TabIndex = 1;
			this.btnChange.Text = "Change";
			this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(221, 12);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(98, 39);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "Delete";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(325, 12);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(98, 39);
			this.btnSearch.TabIndex = 3;
			this.btnSearch.Text = "Search";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// DataButtons
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnChange);
			this.Controls.Add(this.btnAdd);
			this.Name = "DataButtons";
			this.Size = new System.Drawing.Size(435, 62);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnChange;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnSearch;
	}
}
