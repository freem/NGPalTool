using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGPalTool.Dialogs
{
	public partial class ExportRangeASM : Form
	{
		/// <summary>
		/// Export range start point
		/// </summary>
		public int RangeStart = 0;

		/// <summary>
		/// Export range end point
		/// </summary>
		public int RangeEnd = 0;

		public ExportRangeASM()
		{
			InitializeComponent();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			RangeStart = (int)nudRangeStart.Value;
			RangeEnd = (int)nudRangeEnd.Value;

			if (RangeEnd < RangeStart)
			{
				// what are you doing trying to go backwards?
				MessageBox.Show("Range end point must be greater than range start point.\nI don't want to bother writing output backwards.","NGPalTool",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			// if RangeStart == RangeEnd, it's technically "export one palette: the one I asked for"
			// so we leave that up to the dialog caller to figure out.

			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
