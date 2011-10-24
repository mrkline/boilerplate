namespace Boilerplate
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.btnToClipboard = new System.Windows.Forms.Button();
			this.menu = new System.Windows.Forms.MenuStrip();
			this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
			this.tsiOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
			this.pnlFields = new System.Windows.Forms.Panel();
			this.lblFieldsWillAppear = new System.Windows.Forms.Label();
			this.menu.SuspendLayout();
			this.pnlFields.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnToClipboard
			// 
			this.btnToClipboard.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnToClipboard.Enabled = false;
			this.btnToClipboard.Location = new System.Drawing.Point(77, 227);
			this.btnToClipboard.Name = "btnToClipboard";
			this.btnToClipboard.Size = new System.Drawing.Size(130, 23);
			this.btnToClipboard.TabIndex = 0;
			this.btnToClipboard.Text = "Letter to Clipboard";
			this.btnToClipboard.UseVisualStyleBackColor = true;
			this.btnToClipboard.Click += new System.EventHandler(this.btnToClipboard_Click);
			// 
			// menu
			// 
			this.menu.BackColor = System.Drawing.SystemColors.Control;
			this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile});
			this.menu.Location = new System.Drawing.Point(0, 0);
			this.menu.Name = "menu";
			this.menu.Size = new System.Drawing.Size(284, 24);
			this.menu.TabIndex = 1;
			this.menu.Text = "menuStrip1";
			// 
			// tsmFile
			// 
			this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiOpen});
			this.tsmFile.Name = "tsmFile";
			this.tsmFile.Size = new System.Drawing.Size(37, 20);
			this.tsmFile.Text = "&File";
			// 
			// tsiOpen
			// 
			this.tsiOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsiOpen.Image")));
			this.tsiOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsiOpen.Name = "tsiOpen";
			this.tsiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.tsiOpen.Size = new System.Drawing.Size(152, 22);
			this.tsiOpen.Text = "&Open";
			this.tsiOpen.Click += new System.EventHandler(this.tsiOpen_Click);
			// 
			// dlgOpen
			// 
			this.dlgOpen.Filter = "Text files|*.txt|All files|*.*";
			// 
			// pnlFields
			// 
			this.pnlFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlFields.AutoScroll = true;
			this.pnlFields.Controls.Add(this.lblFieldsWillAppear);
			this.pnlFields.Location = new System.Drawing.Point(0, 27);
			this.pnlFields.Name = "pnlFields";
			this.pnlFields.Size = new System.Drawing.Size(284, 194);
			this.pnlFields.TabIndex = 2;
			// 
			// lblFieldsWillAppear
			// 
			this.lblFieldsWillAppear.AutoSize = true;
			this.lblFieldsWillAppear.Location = new System.Drawing.Point(4, 4);
			this.lblFieldsWillAppear.Name = "lblFieldsWillAppear";
			this.lblFieldsWillAppear.Size = new System.Drawing.Size(171, 26);
			this.lblFieldsWillAppear.TabIndex = 0;
			this.lblFieldsWillAppear.Text = "Fields will appear here\r\nwhen a boilerplate letter is opened.";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.pnlFields);
			this.Controls.Add(this.btnToClipboard);
			this.Controls.Add(this.menu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menu;
			this.Name = "frmMain";
			this.Text = "Boilerplate";
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			this.pnlFields.ResumeLayout(false);
			this.pnlFields.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnToClipboard;
		private System.Windows.Forms.MenuStrip menu;
		private System.Windows.Forms.ToolStripMenuItem tsmFile;
		private System.Windows.Forms.ToolStripMenuItem tsiOpen;
		private System.Windows.Forms.OpenFileDialog dlgOpen;
		private System.Windows.Forms.Panel pnlFields;
		private System.Windows.Forms.Label lblFieldsWillAppear;
	}
}

