using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DataButtons
{
	public partial class DataButtons : UserControl
	{
		private string tableName;
		public event DataButtonsEventHandler DataButtonsEvent;

		public string TableName
		{
			get
			{
				return tableName;
			}
			set
			{
				tableName = value;
				btnAdd.Text = "Add " + tableName;
				btnChange.Text = "Change " + tableName;
				btnDelete.Text = "Delete " + tableName;
				btnSearch.Text = "Search " + tableName;
			}
		}
		
		public DataButtons()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			// Generate the event
			DataButtonsEventArgs args = new DataButtonsEventArgs(
			  DataButtonsEventArgs.DataButtonsEventType.Add);
			if (DataButtonsEvent != null)
				DataButtonsEvent(this, args);
		}

		private void btnChange_Click(object sender, EventArgs e)
		{
			// Generate the event
			DataButtonsEventArgs args = new DataButtonsEventArgs(
			  DataButtonsEventArgs.DataButtonsEventType.Change);
			if (DataButtonsEvent != null)
				DataButtonsEvent(this, args);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			// Generate the event
			DataButtonsEventArgs args = new DataButtonsEventArgs(
			  DataButtonsEventArgs.DataButtonsEventType.Delete);
			if (DataButtonsEvent != null)
				DataButtonsEvent(this, args);
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			// Generate the event
			DataButtonsEventArgs args = new DataButtonsEventArgs(
			  DataButtonsEventArgs.DataButtonsEventType.Search);
			if (DataButtonsEvent != null)
				DataButtonsEvent(this, args);
		}
	}

	public class DataButtonsEventArgs : EventArgs
	{
		public enum DataButtonsEventType
		{
			Add,
			Change,
			Delete,
			Search
		}

		private DataButtonsEventType eventType;

		public DataButtonsEventType EventType
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

		public DataButtonsEventArgs(DataButtonsEventType et)
		{
			eventType = et;
		}
	}

	public delegate void DataButtonsEventHandler(
	  object sender, DataButtonsEventArgs e);
}