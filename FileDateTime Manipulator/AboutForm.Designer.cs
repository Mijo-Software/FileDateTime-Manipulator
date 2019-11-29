namespace FileDateTimeManipulator
{
	partial class AboutForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelButtons = new System.Windows.Forms.Panel();
			this.buttonOkay = new System.Windows.Forms.Button();
			this.labelTitle = new System.Windows.Forms.Label();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.labelDescription = new System.Windows.Forms.Label();
			this.labelCopyright = new System.Windows.Forms.Label();
			this.labelVersion = new System.Windows.Forms.Label();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panelButtons.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::FileDateTimeManipulator.Properties.Resources.fdtm_logo_32;
			this.pictureBox1.Location = new System.Drawing.Point(13, 13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.pictureBox1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// panelButtons
			// 
			this.panelButtons.AccessibleDescription = "Panel for buttons";
			this.panelButtons.AccessibleName = "Button panel";
			this.panelButtons.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.panelButtons.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelButtons.Controls.Add(this.buttonOkay);
			this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelButtons.Location = new System.Drawing.Point(0, 126);
			this.panelButtons.Name = "panelButtons";
			this.panelButtons.Size = new System.Drawing.Size(487, 49);
			this.panelButtons.TabIndex = 6;
			// 
			// buttonOkay
			// 
			this.buttonOkay.AccessibleDescription = "Apply the changes";
			this.buttonOkay.AccessibleName = "Apply button";
			this.buttonOkay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOkay.Image = global::FileDateTimeManipulator.Properties.Resources.fatcow_tick_button_16;
			this.buttonOkay.Location = new System.Drawing.Point(407, 12);
			this.buttonOkay.Name = "buttonOkay";
			this.buttonOkay.Size = new System.Drawing.Size(67, 23);
			this.buttonOkay.TabIndex = 1;
			this.buttonOkay.Text = "&Ok";
			this.buttonOkay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonOkay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonOkay.UseCompatibleTextRendering = true;
			this.buttonOkay.UseVisualStyleBackColor = true;
			this.buttonOkay.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOkay.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonOkay.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOkay.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.BackColor = System.Drawing.Color.Transparent;
			this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(52, 13);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(62, 37);
			this.labelTitle.TabIndex = 7;
			this.labelTitle.Text = "Title";
			this.labelTitle.UseCompatibleTextRendering = true;
			this.labelTitle.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelTitle.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelTitle.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelTitle.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// statusStrip
			// 
			this.statusStrip.AccessibleDescription = "Show info texts";
			this.statusStrip.AccessibleName = "Statusbar";
			this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new System.Drawing.Size(487, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 8;
			this.statusStrip.Text = "statusStrip";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.AccessibleDescription = "Show some information";
			this.toolStripStatusLabel.AccessibleName = "Information text";
			this.toolStripStatusLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.toolStripStatusLabel.AutoToolTip = true;
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(92, 17);
			this.toolStripStatusLabel.Text = "Information text";
			this.toolStripStatusLabel.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripStatusLabel.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripContainer
			// 
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			this.toolStripContainer.ContentPanel.AutoScroll = true;
			this.toolStripContainer.ContentPanel.Controls.Add(this.labelDescription);
			this.toolStripContainer.ContentPanel.Controls.Add(this.labelCopyright);
			this.toolStripContainer.ContentPanel.Controls.Add(this.labelVersion);
			this.toolStripContainer.ContentPanel.Controls.Add(this.labelTitle);
			this.toolStripContainer.ContentPanel.Controls.Add(this.panelButtons);
			this.toolStripContainer.ContentPanel.Controls.Add(this.pictureBox1);
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(487, 175);
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer.Name = "toolStripContainer";
			this.toolStripContainer.Size = new System.Drawing.Size(487, 197);
			this.toolStripContainer.TabIndex = 8;
			this.toolStripContainer.Text = "toolStripContainer";
			// 
			// labelDescription
			// 
			this.labelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelDescription.BackColor = System.Drawing.Color.Transparent;
			this.labelDescription.Location = new System.Drawing.Point(58, 91);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(417, 31);
			this.labelDescription.TabIndex = 10;
			this.labelDescription.Text = "label1";
			this.labelDescription.UseCompatibleTextRendering = true;
			this.labelDescription.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDescription.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDescription.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDescription.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelCopyright
			// 
			this.labelCopyright.AutoSize = true;
			this.labelCopyright.BackColor = System.Drawing.Color.Transparent;
			this.labelCopyright.Location = new System.Drawing.Point(58, 65);
			this.labelCopyright.Name = "labelCopyright";
			this.labelCopyright.Size = new System.Drawing.Size(53, 17);
			this.labelCopyright.TabIndex = 9;
			this.labelCopyright.Text = "Copyright";
			this.labelCopyright.UseCompatibleTextRendering = true;
			this.labelCopyright.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCopyright.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelCopyright.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCopyright.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelVersion
			// 
			this.labelVersion.AutoSize = true;
			this.labelVersion.BackColor = System.Drawing.Color.Transparent;
			this.labelVersion.Location = new System.Drawing.Point(58, 48);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(43, 17);
			this.labelVersion.TabIndex = 8;
			this.labelVersion.Text = "Version";
			this.labelVersion.UseCompatibleTextRendering = true;
			this.labelVersion.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelVersion.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelVersion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelVersion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// AboutForm
			// 
			this.AcceptButton = this.buttonOkay;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(487, 197);
			this.Controls.Add(this.toolStripContainer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			this.Load += new System.EventHandler(this.AboutForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panelButtons.ResumeLayout(false);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.ContentPanel.PerformLayout();
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panelButtons;
		private System.Windows.Forms.Button buttonOkay;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.Label labelCopyright;
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.ToolTip toolTip;
	}
}