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
		private List<TextBox> fieldBoxes;

		public frmMain()
		{
			InitializeComponent();
			fieldBoxes = new List<TextBox>();
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
					return;
				}
			}

			pnlFields.Controls.Clear();
			fieldBoxes.Clear();
			
			const int xPadding = 10;
			const int txtWidth = 150;
			const int offY = 30;
			int currY = 10;

			foreach (LetterField field in currLetter.Fields)
			{
				Label lbl = new Label();
				lbl.Text = field.Name + ":";
				lbl.Location = new Point(xPadding, currY);

				TextBox txt = new TextBox();
				txt.Width = txtWidth;
				txt.Anchor = AnchorStyles.Top | AnchorStyles.Left |
					AnchorStyles.Right;
				txt.Location = new Point(pnlFields.Width - xPadding - txtWidth,
					currY);

				pnlFields.Controls.Add(lbl);
				pnlFields.Controls.Add(txt);

				fieldBoxes.Add(txt);

				currY += offY;
			}

		}
	}
}
