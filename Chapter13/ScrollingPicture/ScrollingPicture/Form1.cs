using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScrollingPicture
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			this.panel1.AutoScrollMinSize = this.panel1.BackgroundImage.Size;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			int midX = this.panel1.AutoScrollMinSize.Width / 2;
			int midY = this.panel1.AutoScrollMinSize.Height / 2;
			int halfSizeX = this.panel1.Size.Width / 2;
			int halfSizeY = this.panel1.Size.Height / 2;
			int startPosX = midX - halfSizeX;
			if (startPosX < 0) startPosX = 0;
			int startPosY = midY - halfSizeY;
			if (startPosY < 0) startPosY = 0;

			this.panel1.AutoScrollPosition = new Point(startPosX, startPosY);
		}
	}
}