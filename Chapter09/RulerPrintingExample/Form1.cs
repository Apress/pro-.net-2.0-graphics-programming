using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace RulerPrintingExample
{
	public partial class Form1 : Form
	{
		private Font mainTextFont = new Font("Times New Roman", 14);
		private Font subTextFont = new Font("Times New Roman", 12);
		private PageSettings storedPageSettings;

		public Form1()
		{
			InitializeComponent();
		}

		private void PaintDocument(Graphics g)
		{
			g.PageUnit = GraphicsUnit.Inch;
			g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

			float offset = .75f;
			Pen p = new Pen(Color.Black, 1.0f / 96.0f);
			for (float rule = 0; rule <= 5.0f; rule += .25f)
			{
				float x = offset + rule;
				float len;
				if (rule == (int)rule)
				{
					String s = ((int)rule).ToString();
					len = 0.5f;
					System.Drawing.Font f =
						  new Font("Times New Roman", 0.25f, GraphicsUnit.Inch);
					StringFormat sf = new StringFormat();
					sf.Alignment = StringAlignment.Center;
					RectangleF mr = new RectangleF(x - .25f, 1.5f, .5f, f.Height);
					g.DrawString(s, f, Brushes.Black, mr, sf);
				}
				else if (rule * 2 == (int)(rule * 2))
					len = 0.375f;
				else
					len = 0.25f;
				g.DrawLine(p, x, .75f, x, .75f + len);
			}
		}
		
		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			PaintDocument(g);
		}

		private void menuFilePageSetup_Click(object sender, EventArgs e)
		{
			try
			{
				PageSetupDialog psDlg = new PageSetupDialog();

				// Create a PageSettings object if never before created
				if (this.storedPageSettings == null)
					this.storedPageSettings = new PageSettings();

				// Put up the dialog
				psDlg.PageSettings = this.storedPageSettings;
				psDlg.ShowDialog();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		protected void PrintPageEventHandler(Object obj, PrintPageEventArgs ev)
		{
			Graphics g = ev.Graphics;
			PaintDocument(g);
			ev.HasMorePages = false;
		}

		private void menuFilePrint_Click(object sender, EventArgs e)
		{
			try
			{
				PrintDocument pd = new PrintDocument();
				pd.PrintPage +=
						new PrintPageEventHandler(this.PrintPageEventHandler);

				// If the user has set page settings, then set the property
				// in the print document
				if (this.storedPageSettings != null)
					pd.DefaultPageSettings = this.storedPageSettings;
				PrintDialog dlg = new PrintDialog();
				dlg.Document = pd;
				DialogResult result = dlg.ShowDialog();
				if (result == System.Windows.Forms.DialogResult.OK)
					pd.Print();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void menuFilePrintPreview_Click(object sender, EventArgs e)
		{
			try
			{
				PrintDocument pd = new PrintDocument();
				pd.PrintPage +=
						new PrintPageEventHandler(this.PrintPageEventHandler);

				// If the user has set page settings, then set the property 
				// in the print document
				if (this.storedPageSettings != null)
					pd.DefaultPageSettings = this.storedPageSettings;
				PrintPreviewDialog dlg = new PrintPreviewDialog();
				dlg.Document = pd;
				dlg.ShowDialog();
				// No separate command to print. 
				// Preview dialog shows the print preview 
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}