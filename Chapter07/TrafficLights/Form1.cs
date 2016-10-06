using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrafficLights
{
	public partial class Form1 : Form
	{
		private string strColor;
		
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Click(object sender, EventArgs e)
		{
			// Change application state by altering value of strColor
			switch (strColor)
			{
				case "red":
					strColor = "yellow";
					break;
				case "yellow":
					strColor = "green";
					break;
				default:
					strColor = "red";
					break;
			}

			// Invalidate the region containing the traffic lights
			this.Invalidate(new Rectangle(10, 10, 50, 150));

		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			// Report dimensions of clipping rectangle to console
			Console.WriteLine("e.ClipRectangle = " + e.ClipRectangle);

			// Draw outline
			g.FillRectangle(Brushes.Black, 10, 10, 50, 150);
			g.DrawEllipse(Pens.White, 15, 15, 40, 40);
			g.DrawEllipse(Pens.White, 15, 60, 40, 40);
			g.DrawEllipse(Pens.White, 15, 105, 40, 40);

			// Use application state (strColor) to draw 
			// exactly one of the three lights
			switch (strColor)
			{
				case "red":
					g.FillEllipse(Brushes.Red, 15, 15, 40, 40);
					break;
				case "yellow":
					g.FillEllipse(Brushes.Yellow, 15, 60, 40, 40);
					break;
				case "green":
					g.FillEllipse(Brushes.Green, 15, 105, 40, 40);
					break;
				default:
					g.FillEllipse(Brushes.Red, 15, 15, 40, 40);
					break;
			}
		}
	}
}