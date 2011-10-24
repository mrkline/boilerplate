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
			MinimumSize = Size;
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
			else
			{
				return;
			}

			pnlFields.Controls.Clear();
			fieldBoxes.Clear();
			
			List<Label> labels = new List<Label>();
			const int xPadding = 10;
			const int windowPadding = 20;
			const int txtWidth = 150;

			int maxSize = 0;
			int txtX = 0;
			foreach(LetterField field in currLetter.Fields)
			{
				Label lbl = new Label();
				lbl.AutoSize = true;
				lbl.Text = field.Name + ":";
				labels.Add(lbl);

				int neededSize = lbl.PreferredWidth + txtWidth + 3 * xPadding + windowPadding;
				if (neededSize > maxSize)
				{
					maxSize = neededSize;
					txtX = lbl.PreferredWidth + 2 * xPadding;
				}
			}

			// The minimum size must be set first if the window is to shrink.
			MinimumSize = new Size(maxSize, Size.Height);
			Width = maxSize;

			const int offY = 30;
			int currY = 10;

			int numFields = currLetter.Fields.Count;
			for (int c = 0; c < numFields; ++c)
			{
				LetterField field = currLetter.Fields[c];

				Label lbl = labels[c];
				lbl.Location = new Point(xPadding, currY);

				TextBox txt = new TextBox();
				txt.Width = txtWidth;
				txt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
				txt.Location = new Point(txtX, currY);

				pnlFields.Controls.Add(lbl);
				pnlFields.Controls.Add(txt);

				fieldBoxes.Add(txt);

				currY += offY;
			}

			btnToClipboard.Enabled = true;
		}

		private void btnToClipboard_Click(object sender, EventArgs e)
		{
			int numFields = currLetter.Fields.Count;

			for (int c = 0; c < numFields; ++c)
			{
				if (fieldBoxes[c].Text.Length == 0)
				{
					MessageBox.Show(" The field " + currLetter.Fields[c].Name
						+ " hasn't been filled in.", "Empty Field",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					fieldBoxes[c].Focus();
					return;
				}
			}

			for (int c = 0; c < numFields; ++c)
			{
				currLetter.Fields[c].Text = fieldBoxes[c].Text;
			}

			Clipboard.SetText(currLetter.ToString());
		}
	}
}
