using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chapter08
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			// uncomment a section to run that example




			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			// First, draw a nonscaled rectangle and circle
			g.DrawRectangle(Pens.Black, 10, 10, 50, 50);
			g.DrawEllipse(Pens.Black, 10, 10, 10, 10);

			// Now apply the scaling transformation
			// This will scale subsequent operations by 2x horizontally
			// and 3x vertically
			g.ScaleTransform(2.0f, 3.0f);

			// Now draw the same rectangle and circle, 
			// but with the scaling transformation 
			g.DrawRectangle(Pens.Black, 10, 10, 50, 50);
			g.DrawEllipse(Pens.Black, 10, 10, 10, 10);
			*/




			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);
			Font f = new Font("Times New Roman", 24);

			// Draw text to the surface
			g.DrawString("Translation", f, Brushes.Black, 0, 0);

			// Translate the text 150 pixels horizontally and 75 vertically
			g.TranslateTransform(150, 75);

			// Draw the translated text
			g.DrawString("Translation", f, Brushes.Black, 0, 0);
			*/




			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);

			for (int i = 1; i <= 5; ++i)
			{
				// First, draw a rectangle with the current translation
				g.DrawRectangle(Pens.Black, 10, 10, 30, 50);

				// Add a translation to the existing transformation
				g.TranslateTransform(2, 10);
			}
			*/




			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, ClientRectangle);

			// First, draw a rectangle with no translation
			g.DrawEllipse(Pens.Black, 20, 20, 30, 50);

			// Translate by -15 pixels in horizontal direction
			g.TranslateTransform(-15, 0);
			g.DrawEllipse(Pens.Black, 20, 20, 30, 50);

			// Reset the transformation
			// Translate by 30 pixels in vertical direction
			g.ResetTransform();
			g.TranslateTransform(0, 30);
			g.DrawEllipse(Pens.Black, 20, 20, 30, 50);
			*/




			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);
			Font f = new Font("Times New Roman", 24);

			// Draw text to the surface
			g.DrawString("Rotation", f, Brushes.Black, 0, 0);

			// Rotate the text through 45 degrees
			g.RotateTransform(45);

			// Draw the rotated text
			g.DrawString("Rotation", f, Brushes.Black, 0, 0);
			*/




			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);
			Font f = new Font("Times New Roman", 24);

			// Draw text to the surface
			g.DrawString("Translate then Rotate", f, Brushes.Black, 0, 0);

			// Translate the text 150 pixels horizontally 
			g.TranslateTransform(150, 0);

			// Rotate the text 45 degrees clockwise
			g.RotateTransform(45);

			// Draw the transformed text
			g.DrawString("Translate then Rotate ", f, Brushes.Black, 0, 0);
			*/




			/*
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);
			Font f = new Font("Times New Roman", 24);

			// Draw text to the surface
			g.DrawString("Rotate then Translate", f, Brushes.Black, 0, 0);

			// Rotate the text 45 degrees clockwise
			g.RotateTransform(45);

			// Translate the text 150 pixels horizontally 
			g.TranslateTransform(150, 0);

			// Draw the transformed text
			g.DrawString("Rotate  then Translate ", f, Brushes.Black, 0, 0);
			*/




			/*
			// for this example, uncomment the section in the Load event
			Graphics g = e.Graphics;
			g.FillRectangle(Brushes.White, this.ClientRectangle);
			Font f = new Font("Times New Roman", 16);
			for (float angle = 0; angle < 360; angle += 45)
			{
				g.ResetTransform();
				g.TranslateTransform(ClientRectangle.Width / 2,
									 ClientRectangle.Height / 2);
				g.RotateTransform(angle);
				g.DrawString("Hello, World", f, Brushes.Black, 50, 0);
			}
			*/
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			/*
			this.ResizeRedraw = true;
			*/
		}
	}
}