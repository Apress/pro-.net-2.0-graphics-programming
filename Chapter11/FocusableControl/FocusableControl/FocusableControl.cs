using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace FocusableControl
{
	public partial class FocusableControl : System.Windows.Forms.Control
	{
		private Color focusColor = Color.LightBlue;

		public Color FocusColor
		{
			get
			{
				return focusColor;
			}
			set
			{
				focusColor = value;
				Invalidate();
			}
		}

		public void ResetFocusColor()
		{
			FocusColor = Color.LightBlue;
		}

		public bool ShouldSerializeFocusColor()
		{
			return FocusColor != Color.LightBlue;
		}

		private void drawButton(Graphics g)
		{
			if (ContainsFocus)
			{
				// Draw in focus color
				Brush b = new SolidBrush(FocusColor);
				g.FillRectangle(b, ClientRectangle);
				b.Dispose();
			}
			else
			{
				// Draw in BackColor
				Brush b = new SolidBrush(BackColor);
				g.FillRectangle(b, ClientRectangle);
				b.Dispose();
			}

			// The StringFormat class centers the text in our custom
			// control. In addition, it handles the correct drawing of
			// the mnemonic character.
			StringFormat sf = new StringFormat();
			sf.Alignment = StringAlignment.Center;
			sf.LineAlignment = StringAlignment.Center;
			if (ShowKeyboardCues)
				sf.HotkeyPrefix = HotkeyPrefix.Show;
			else
				sf.HotkeyPrefix = HotkeyPrefix.Hide;
			if (Enabled)
			{
				// If the control is enabled, the color of the text is ForeColor
				Brush fb = new SolidBrush(ForeColor);
				g.DrawString(Text, Font, fb, ClientRectangle, sf);
				fb.Dispose();
			}
			else
			{
				// If the control is not enabled, first draw the text in white, offset
				// one pixel up and to the left, and then draw the text in DarkGray
				g.TranslateTransform(-1, -1);
				g.DrawString(Text, Font, Brushes.White, ClientRectangle, sf);
				g.ResetTransform();
				g.DrawString(Text, Font, Brushes.DarkGray, ClientRectangle, sf);
			}

			// Draw a dotted line inside the client rectangle
			if (ShowFocusCues && ContainsFocus)
			{
				Rectangle r = ClientRectangle;
				r.Inflate(-4, -4);
				r.Width--;
				r.Height--;
				Pen p = new Pen(Color.Black, 1);
				p.DashStyle = DashStyle.Dot;
				g.DrawRectangle(p, r);
			}
		}

		private void FocusableControl_GotFocus(
		  object sender, System.EventArgs e)
		{
			Graphics g = CreateGraphics();
			drawButton(g);
			g.Dispose();
		}

		private void FocusableControl_LostFocus(
		  object sender, System.EventArgs e)
		{
			Graphics g = CreateGraphics();
			drawButton(g);
			g.Dispose();
		}

		protected override bool ProcessMnemonic(char charCode)
		{
			if (Enabled && Visible && IsMnemonic(charCode, this.Text))
			{
				// Perform action associated with mnemonic
				// Moves focus to our control
				Focus();
				Graphics g = this.CreateGraphics();
				drawButton(g);
				g.Dispose();
				MessageBox.Show("Mnemonic pressed");
				return true;
			}
			return false;
		}
		
		public FocusableControl()
		{
			InitializeComponent();

			this.GotFocus += new EventHandler(FocusableControl_GotFocus);
			this.LostFocus += new EventHandler(FocusableControl_LostFocus);
		}

		private void FocusableControl_Paint(object sender, PaintEventArgs e)
		{
			drawButton(e.Graphics);
		}

		private void FocusableControl_ChangeUICues(object sender, UICuesEventArgs e)
		{
			if (e.ChangeFocus || e.ChangeKeyboard)
			{
				Graphics g = CreateGraphics();
				drawButton(g);
				g.Dispose();
			}
		}

		private void FocusableControl_Click(object sender, EventArgs e)
		{
			Focus();
			MessageBox.Show("Control clicked");
		}

		private void FocusableControl_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Alt == false &&
				e.Control == false &&
				e.Shift == false &&
				(e.KeyCode == Keys.Space ||
				e.KeyCode == Keys.Enter))
			{
				MessageBox.Show("Space or Enter pressed");
				e.Handled = true;
				return;
			}
		}
	}
}