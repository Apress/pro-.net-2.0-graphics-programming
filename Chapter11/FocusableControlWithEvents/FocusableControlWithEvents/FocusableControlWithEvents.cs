using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace FocusableControlWithEvents
{
	public partial class FocusableControlWithEvents : System.Windows.Forms.Control
	{
		private string displayText = "Hello, World";
		private int displayCount = 3;
		private Color textColor = Color.Red;
		private Font textFont = new Font("Times New Roman", 12);
		private Orientation textOrientation = Orientation.Vertical;
		private Point startingDisplayPoint = new Point(6, 6);
		private Color focusColor = Color.LightBlue;
		public event FocusableControlEventHandler FocusableControlClick;

		[DefaultValue("Hello, World")]
		public string DisplayText
		{
			get
			{
				return displayText;
			}
			set
			{
				displayText = value;
				Invalidate();
			}
		}

		[DefaultValue(3)]
		public int DisplayCount
		{
			get
			{
				return displayCount;
			}
			set
			{
				displayCount = value;
				Invalidate();
			}
		}

		public void ResetTextColor()
		{
			TextColor = Color.Red;
		}

		public bool ShouldSerializeTextColor()
		{
			return TextColor != Color.Red;
		}

		public void ResetTextFont()
		{
			TextFont = new Font("Times New Roman", 12);
		}

		public bool ShouldSerializeTextFont()
		{
			return !TextFont.Equals(new Font("Times New Roman", 12));
		}

		public void ResetStartingDisplayPoint()
		{
			StartingDisplayPoint = new Point(6, 6);
		}

		public bool ShouldSerializeStartingDisplayPoint()
		{
			return StartingDisplayPoint != new Point(6, 6);
		}
		
		public Color TextColor
		{
			get
			{
				return textColor;
			}
			set
			{
				textColor = value;
				Invalidate();
			}
		}

		public Font TextFont
		{
			get
			{
				return textFont;
			}
			set
			{
				textFont = value;
				Invalidate();
			}
		}

		[DefaultValue(Orientation.Vertical)]
		public Orientation TextOrientation
		{
			get
			{
				return textOrientation;
			}
			set
			{
				textOrientation = value;
				Invalidate();
			}
		}

		public Point StartingDisplayPoint
		{
			get
			{
				return startingDisplayPoint;
			}
			set
			{
				startingDisplayPoint = value;
				Invalidate();
			}
		}

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
		
		public enum Orientation
		{
			Vertical,
			Horizontal
		};

		public FocusableControlWithEvents()
		{
			InitializeComponent();

			this.GotFocus += new EventHandler(FocusableControl_GotFocus);
			this.LostFocus += new EventHandler(FocusableControl_LostFocus);
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
				// Perform action associated with mnemonic.
				// Moves focus to our control.
				Focus();
				Graphics g = this.CreateGraphics();
				drawButton(g);
				g.Dispose();
				// Raise the event
				FocusableControlEventArgs args = new FocusableControlEventArgs(
				  FocusableControlEventArgs.FocusableControlEventType.Mnemonic);
				if (FocusableControlClick != null)
					FocusableControlClick(this, args);
				return true;
			}
			return false;
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

		private void FocusableControlWithEvents_Paint(object sender, PaintEventArgs e)
		{
			drawButton(e.Graphics);
		}

		private void FocusableControlWithEvents_ChangeUICues(object sender, UICuesEventArgs e)
		{
			if (e.ChangeFocus || e.ChangeKeyboard)
			{
				Graphics g = CreateGraphics();
				drawButton(g);
				g.Dispose();
			}
		}

		private void FocusableControlWithEvents_Click(object sender, EventArgs e)
		{
			Focus();
			// Generate the event
			FocusableControlEventArgs args = new FocusableControlEventArgs(
			  FocusableControlEventArgs.FocusableControlEventType.Mouse);
			if (FocusableControlClick != null)
				FocusableControlClick(this, args);
		}

		private void FocusableControlWithEvents_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Alt == false &&
			  e.Control == false &&
			  e.Shift == false &&
			  (e.KeyCode == Keys.Space ||
			  e.KeyCode == Keys.Enter))
			{
				// Generate the event
				FocusableControlEventArgs args;
				if (e.KeyCode == Keys.Space)
					args = new FocusableControlEventArgs(
					  FocusableControlEventArgs.FocusableControlEventType.SpaceBar);
				else
					args = new FocusableControlEventArgs(
					  FocusableControlEventArgs.FocusableControlEventType.Enter);
				if (FocusableControlClick != null)
					FocusableControlClick(this, args);
				e.Handled = true;
				return;
			}
		}
	}

	public delegate void FocusableControlEventHandler(
	  object sender, FocusableControlEventArgs e);

	public class FocusableControlEventArgs : EventArgs
	{
		public enum FocusableControlEventType
		{
			Mouse,
			SpaceBar,
			Enter,
			Mnemonic
		}

		private FocusableControlEventType eventType;

		public FocusableControlEventType EventType
		{
			get
			{
				return eventType;
			}
			set
			{
				eventType = value;
			}
		}

		public FocusableControlEventArgs(FocusableControlEventType et)
		{
			eventType = et;
		}
	}
}