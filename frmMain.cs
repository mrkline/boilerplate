using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Boilerplate
{
	public partial class frmMain : Form
	{
		private Letter currLetter;

		public frmMain()
		{
			InitializeComponent();
		}

		private void tsiOpen_Click(object sender, EventArgs e)
		{
			if (dlgOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				try
				{
					currLetter = new Letter(dlgOpen.FileName);
				}
				catch (FormatException ex)
				{
					MessageBox.Show(ex.Message, "Format Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			// Temp test code:
			string test = "Fields:\n";
			foreach (LetterField field in currLetter.Fields)
			{
				test += field.Name + "\n";
			}
			MessageBox.Show(test);
		}
	}
}
