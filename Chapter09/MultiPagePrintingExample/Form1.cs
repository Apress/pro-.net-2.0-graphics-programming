using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Diagnostics;

namespace MultiPagePrintingExample
{
	public partial class Form1 : Form
	{
		private Font mainTextFont = new Font("Times New Roman", 14);
		private Font subTextFont = new Font("Times New Roman", 12);
		private PageSettings storedPageSettings;
		uint currentPage;

		private void PaintDocument(Graphics g)
		{
			g.PageUnit = GraphicsUnit.Point;

			// Draw some items to the drawing surface
			g.DrawString("Simple Printing Sample",
						 this.mainTextFont,
						 Brushes.Black,
						 new Rectangle(10, 20, 180, 30));
			g.DrawString("This text and the box appear on the screen " +
						 "and can be printed too!",
						 this.subTextFont,
						 Brushes.Black,
						 new Rectangle(30, 50, 150, 50));
			g.DrawRectangle(Pens.Blue,
							new Rectangle(new Point(10, 100), new Size(100, 50)));
		}
		
		public Form1()
		{
			InitializeComponent();
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
			g.PageUnit = GraphicsUnit.Point;

			switch (currentPage)
			{
				case 1:
					g.DrawString("Simple Printing Example",
								 this.mainTextFont,
								 Brushes.Black,
								 new Rectangle(10, 10, 180, 30));
					g.DrawString("This text and the box appear on the screen " +
								 "and can be printed too!",
								 this.subTextFont,
								 Brushes.Black,
								 new Rectangle(30, 40, 150, 50));
					ev.HasMorePages = true;
					++currentPage;
					break;
				case 2:
					g.DrawRectangle(Pens.Blue,
							new Rectangle(new Point(10, 90), new Size(100, 50)));
					ev.HasMorePages = false;
					break;
				default:
					Debug.Assert(false);
					break;
			}
		}

		private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				this.currentPage = 1; 
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

		private void menuFilePrint_Click(object sender, EventArgs e)
		{
			try
			{
				this.currentPage = 1;
				PrintDocument pd = new PrintDocument();
				pd.PrintPage +=
						new PrintPageEventHandler(this.PrintPageEventHandler);
				// If the user has set page settings, then set the property 
				// in the print document
				if (this.storedPageSettings != null)
					pd.DefaultPageSettings = this.storedPageSettings;
				PrintDialog dlg = new PrintDialog();
				dlg.AllowSomePages = true;
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
	}
}