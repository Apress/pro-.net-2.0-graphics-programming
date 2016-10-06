using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace PrintingMetricsExample
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

		private void WriteMetricsToConsole(PrintPageEventArgs ev)
		{
			Graphics g = ev.Graphics;
			Console.WriteLine("Information about the printer:");
			Console.WriteLine("ev.PageSettings.PaperSize: " +
								  ev.PageSettings.PaperSize);
			Console.WriteLine("ev.PageSettings.PrinterResolution: " +
								  ev.PageSettings.PrinterResolution);
			Console.WriteLine("ev.PageSettings.PrinterSettings.LandscapeAngle: " +
								  ev.PageSettings.PrinterSettings.LandscapeAngle);
			Console.WriteLine("");
			Console.WriteLine("Information about the page: ");
			Console.WriteLine("ev.PageSettings.Bounds: " + ev.PageSettings.Bounds);
			Console.WriteLine("ev.PageBounds: " + ev.PageBounds);
			Console.WriteLine("ev.PageSettings.Margins: " +
								  ev.PageSettings.Margins);
			Console.WriteLine("ev.MarginBounds: " + ev.MarginBounds);
			Console.WriteLine("Horizontal resolution: " + g.DpiX);
			Console.WriteLine("Vertical resolution: " + g.DpiY);
			g.SetClip(ev.PageBounds);
			Console.WriteLine("g.VisibleClipBounds: " + g.VisibleClipBounds);
			SizeF drawingSurfaceSize = new SizeF(
							  g.VisibleClipBounds.Width * g.DpiX / 100,
							  g.VisibleClipBounds.Height * g.DpiY / 100);
			Console.WriteLine("Drawing Surface Size in Pixels: " +
							  drawingSurfaceSize);
		}

		protected void PrintPageEventHandler(Object obj, PrintPageEventArgs ev)
		{
			WriteMetricsToConsole(ev); 
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