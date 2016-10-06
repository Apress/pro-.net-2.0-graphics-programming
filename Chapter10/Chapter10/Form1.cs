using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Apress.GraphicsOutlineModel;

namespace Chapter10
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			GraphicsOM gOM = new GraphicsOM(g);

			// uncomment a section to run that example




			/*
			gOM.Draw3DLine(0, 10, 500, 10, ThreeDStyle.Ridge, 1);
			gOM.Draw3DLine(0, 20, 500, 20, ThreeDStyle.Groove, 1);
			gOM.Draw3DLine(0, 30, 500, 30, ThreeDStyle.Ridge, 2);
			gOM.Draw3DLine(0, 40, 500, 40, ThreeDStyle.Groove, 2);
			gOM.Draw3DLine(0, 50, 500, 50, ThreeDStyle.Raised, 1);
			gOM.Draw3DLine(0, 60, 500, 60, ThreeDStyle.Inset, 1);
			gOM.Draw3DLine(0, 70, 500, 70, ThreeDStyle.Raised, 2);
			gOM.Draw3DLine(0, 80, 500, 80, ThreeDStyle.Inset, 2);
			*/




			/*
			gOM.Draw3DRectangle(10, 10, 50, 20, ThreeDStyle.Ridge, 1);
			gOM.Draw3DRectangle(80, 10, 50, 20, ThreeDStyle.Groove, 1);
			gOM.Draw3DRectangle(10, 50, 50, 20, ThreeDStyle.Ridge, 2);
			gOM.Draw3DRectangle(80, 50, 50, 20, ThreeDStyle.Groove, 2);
			gOM.Draw3DRectangle(10, 90, 50, 20, ThreeDStyle.Raised, 1);
			gOM.Draw3DRectangle(80, 90, 50, 20, ThreeDStyle.Inset, 1);
			gOM.Draw3DRectangle(10, 130, 50, 20, ThreeDStyle.Raised, 2);
			gOM.Draw3DRectangle(80, 130, 50, 20, ThreeDStyle.Inset, 2);
			*/




		}
	}
}