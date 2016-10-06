using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlayAnimation
{
	public partial class Form1 : Form
	{
		private Bitmap bmp;
		
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			bmp = new Bitmap("arrow.gif");
			ImageAnimator.Animate(bmp, new EventHandler(this.OnFrameChanged));
		}

		private void OnFrameChanged(object o, EventArgs e)
		{
			// Invalidate the window to force a call to the Paint event handler.
			// If we had more items in the window than just the animation, we could
			// invalidate just the area occupied by the animation.
			this.Invalidate();
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			//Get the next frame ready for rendering
			ImageAnimator.UpdateFrames();
			//Draw the next frame in the animation
			e.Graphics.DrawImage(this.bmp, new Point(0, 0));
		}
	}
}