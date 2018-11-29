namespace FileDateTime_Manipulator
{
	partial class FdtmForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelPath = new System.Windows.Forms.Label();
			this.textBoxPath = new System.Windows.Forms.TextBox();
			this.buttonSelectFile = new System.Windows.Forms.Button();
			this.labelCreationDate = new System.Windows.Forms.Label();
			this.labelLastAccessDate = new System.Windows.Forms.Label();
			this.labelLastWriteDate = new System.Windows.Forms.Label();
			this.textBoxCreationDate = new System.Windows.Forms.TextBox();
			this.textBoxLastAccessDate = new System.Windows.Forms.TextBox();
			this.textBoxLastWriteDate = new System.Windows.Forms.TextBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.labelNewWriteDate = new System.Windows.Forms.Label();
			this.labelNewAccessDate = new System.Windows.Forms.Label();
			this.labelNewCreationDate = new System.Windows.Forms.Label();
			this.tableLayoutPanelDate = new System.Windows.Forms.TableLayoutPanel();
			this.panelButtons = new System.Windows.Forms.Panel();
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonInfo = new System.Windows.Forms.Button();
			this.buttonApply = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.dateTimePickerCreated = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerAccessed = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerWrited = new System.Windows.Forms.DateTimePicker();
			this.tableLayoutPanelDate.SuspendLayout();
			this.panelButtons.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelPath
			// 
			this.labelPath.AutoSize = true;
			this.labelPath.Location = new System.Drawing.Point(9, 10);
			this.labelPath.Name = "labelPath";
			this.labelPath.Size = new System.Drawing.Size(32, 13);
			this.labelPath.TabIndex = 0;
			this.labelPath.Text = "&Path:";
			// 
			// textBoxPath
			// 
			this.textBoxPath.AllowDrop = true;
			this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxPath.Location = new System.Drawing.Point(40, 6);
			this.textBoxPath.Name = "textBoxPath";
			this.textBoxPath.ReadOnly = true;
			this.textBoxPath.Size = new System.Drawing.Size(357, 20);
			this.textBoxPath.TabIndex = 1;
			// 
			// buttonSelectFile
			// 
			this.buttonSelectFile.AllowDrop = true;
			this.buttonSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSelectFile.Location = new System.Drawing.Point(403, 6);
			this.buttonSelectFile.Name = "buttonSelectFile";
			this.buttonSelectFile.Size = new System.Drawing.Size(70, 20);
			this.buttonSelectFile.TabIndex = 2;
			this.buttonSelectFile.Text = "&Select file";
			this.buttonSelectFile.UseVisualStyleBackColor = true;
			this.buttonSelectFile.Click += new System.EventHandler(this.ButtonSelectFile_Click);
			// 
			// labelCreationDate
			// 
			this.labelCreationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelCreationDate.AutoSize = true;
			this.labelCreationDate.Location = new System.Drawing.Point(3, 0);
			this.labelCreationDate.Name = "labelCreationDate";
			this.labelCreationDate.Size = new System.Drawing.Size(147, 13);
			this.labelCreationDate.TabIndex = 0;
			this.labelCreationDate.Text = "Creation date (&1):";
			this.labelCreationDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelLastAccessDate
			// 
			this.labelLastAccessDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelLastAccessDate.AutoSize = true;
			this.labelLastAccessDate.Location = new System.Drawing.Point(156, 0);
			this.labelLastAccessDate.Name = "labelLastAccessDate";
			this.labelLastAccessDate.Size = new System.Drawing.Size(147, 13);
			this.labelLastAccessDate.TabIndex = 2;
			this.labelLastAccessDate.Text = "Last access date (&2):";
			this.labelLastAccessDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelLastWriteDate
			// 
			this.labelLastWriteDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelLastWriteDate.AutoSize = true;
			this.labelLastWriteDate.Location = new System.Drawing.Point(309, 0);
			this.labelLastWriteDate.Name = "labelLastWriteDate";
			this.labelLastWriteDate.Size = new System.Drawing.Size(148, 13);
			this.labelLastWriteDate.TabIndex = 4;
			this.labelLastWriteDate.Text = "Last write date (&3):";
			this.labelLastWriteDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// textBoxCreationDate
			// 
			this.textBoxCreationDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxCreationDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxCreationDate.Location = new System.Drawing.Point(3, 16);
			this.textBoxCreationDate.Name = "textBoxCreationDate";
			this.textBoxCreationDate.ReadOnly = true;
			this.textBoxCreationDate.Size = new System.Drawing.Size(147, 20);
			this.textBoxCreationDate.TabIndex = 1;
			this.textBoxCreationDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBoxLastAccessDate
			// 
			this.textBoxLastAccessDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxLastAccessDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxLastAccessDate.Location = new System.Drawing.Point(156, 16);
			this.textBoxLastAccessDate.Name = "textBoxLastAccessDate";
			this.textBoxLastAccessDate.ReadOnly = true;
			this.textBoxLastAccessDate.Size = new System.Drawing.Size(147, 20);
			this.textBoxLastAccessDate.TabIndex = 3;
			this.textBoxLastAccessDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBoxLastWriteDate
			// 
			this.textBoxLastWriteDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxLastWriteDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxLastWriteDate.Location = new System.Drawing.Point(309, 16);
			this.textBoxLastWriteDate.Name = "textBoxLastWriteDate";
			this.textBoxLastWriteDate.ReadOnly = true;
			this.textBoxLastWriteDate.Size = new System.Drawing.Size(148, 20);
			this.textBoxLastWriteDate.TabIndex = 5;
			this.textBoxLastWriteDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = "all files|*.*";
			// 
			// labelNewWriteDate
			// 
			this.labelNewWriteDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelNewWriteDate.AutoSize = true;
			this.labelNewWriteDate.Location = new System.Drawing.Point(309, 0);
			this.labelNewWriteDate.Name = "labelNewWriteDate";
			this.labelNewWriteDate.Size = new System.Drawing.Size(149, 13);
			this.labelNewWriteDate.TabIndex = 4;
			this.labelNewWriteDate.Text = "Set new write date (&6):";
			this.labelNewWriteDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelNewAccessDate
			// 
			this.labelNewAccessDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelNewAccessDate.AutoSize = true;
			this.labelNewAccessDate.Location = new System.Drawing.Point(156, 0);
			this.labelNewAccessDate.Name = "labelNewAccessDate";
			this.labelNewAccessDate.Size = new System.Drawing.Size(147, 13);
			this.labelNewAccessDate.TabIndex = 2;
			this.labelNewAccessDate.Text = "Set new access date (&5):";
			this.labelNewAccessDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelNewCreationDate
			// 
			this.labelNewCreationDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelNewCreationDate.AutoSize = true;
			this.labelNewCreationDate.Location = new System.Drawing.Point(3, 0);
			this.labelNewCreationDate.Name = "labelNewCreationDate";
			this.labelNewCreationDate.Size = new System.Drawing.Size(147, 13);
			this.labelNewCreationDate.TabIndex = 0;
			this.labelNewCreationDate.Text = "Set new creation date (&4):";
			this.labelNewCreationDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tableLayoutPanelDate
			// 
			this.tableLayoutPanelDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanelDate.ColumnCount = 3;
			this.tableLayoutPanelDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelDate.Controls.Add(this.labelCreationDate, 0, 0);
			this.tableLayoutPanelDate.Controls.Add(this.labelLastAccessDate, 1, 0);
			this.tableLayoutPanelDate.Controls.Add(this.textBoxLastWriteDate, 2, 1);
			this.tableLayoutPanelDate.Controls.Add(this.labelLastWriteDate, 2, 0);
			this.tableLayoutPanelDate.Controls.Add(this.textBoxLastAccessDate, 1, 1);
			this.tableLayoutPanelDate.Controls.Add(this.textBoxCreationDate, 0, 1);
			this.tableLayoutPanelDate.Location = new System.Drawing.Point(12, 32);
			this.tableLayoutPanelDate.Name = "tableLayoutPanelDate";
			this.tableLayoutPanelDate.RowCount = 2;
			this.tableLayoutPanelDate.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelDate.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelDate.Size = new System.Drawing.Size(460, 40);
			this.tableLayoutPanelDate.TabIndex = 3;
			// 
			// panelButtons
			// 
			this.panelButtons.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelButtons.Controls.Add(this.buttonClose);
			this.panelButtons.Controls.Add(this.buttonInfo);
			this.panelButtons.Controls.Add(this.buttonApply);
			this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelButtons.Location = new System.Drawing.Point(0, 122);
			this.panelButtons.Name = "panelButtons";
			this.panelButtons.Size = new System.Drawing.Size(484, 49);
			this.panelButtons.TabIndex = 5;
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonClose.Location = new System.Drawing.Point(402, 12);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(67, 23);
			this.buttonClose.TabIndex = 2;
			this.buttonClose.Text = "&Close";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
			// 
			// buttonInfo
			// 
			this.buttonInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonInfo.Location = new System.Drawing.Point(11, 12);
			this.buttonInfo.Name = "buttonInfo";
			this.buttonInfo.Size = new System.Drawing.Size(67, 23);
			this.buttonInfo.TabIndex = 0;
			this.buttonInfo.Text = "&Info";
			this.buttonInfo.UseVisualStyleBackColor = true;
			this.buttonInfo.Click += new System.EventHandler(this.ButtonInfo_Click);
			// 
			// buttonApply
			// 
			this.buttonApply.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonApply.Enabled = false;
			this.buttonApply.Location = new System.Drawing.Point(208, 12);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(67, 23);
			this.buttonApply.TabIndex = 1;
			this.buttonApply.Text = "&Apply";
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.ButtonApply_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.dateTimePickerCreated, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.dateTimePickerAccessed, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.dateTimePickerWrited, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.labelNewCreationDate, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelNewAccessDate, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelNewWriteDate, 2, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 74);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 40);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// dateTimePickerCreated
			// 
			this.dateTimePickerCreated.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePickerCreated.CustomFormat = "d.M.yyyy h:m:s";
			this.dateTimePickerCreated.Enabled = false;
			this.dateTimePickerCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.dateTimePickerCreated.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerCreated.Location = new System.Drawing.Point(3, 16);
			this.dateTimePickerCreated.Name = "dateTimePickerCreated";
			this.dateTimePickerCreated.ShowCheckBox = true;
			this.dateTimePickerCreated.ShowUpDown = true;
			this.dateTimePickerCreated.Size = new System.Drawing.Size(147, 20);
			this.dateTimePickerCreated.TabIndex = 1;
			// 
			// dateTimePickerAccessed
			// 
			this.dateTimePickerAccessed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePickerAccessed.CustomFormat = "d.M.yyyy h:m:s";
			this.dateTimePickerAccessed.Enabled = false;
			this.dateTimePickerAccessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.dateTimePickerAccessed.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerAccessed.Location = new System.Drawing.Point(156, 16);
			this.dateTimePickerAccessed.Name = "dateTimePickerAccessed";
			this.dateTimePickerAccessed.ShowCheckBox = true;
			this.dateTimePickerAccessed.ShowUpDown = true;
			this.dateTimePickerAccessed.Size = new System.Drawing.Size(147, 20);
			this.dateTimePickerAccessed.TabIndex = 3;
			// 
			// dateTimePickerWrited
			// 
			this.dateTimePickerWrited.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePickerWrited.CustomFormat = "d.M.yyyy h:m:s";
			this.dateTimePickerWrited.Enabled = false;
			this.dateTimePickerWrited.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.dateTimePickerWrited.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerWrited.Location = new System.Drawing.Point(309, 16);
			this.dateTimePickerWrited.Name = "dateTimePickerWrited";
			this.dateTimePickerWrited.ShowCheckBox = true;
			this.dateTimePickerWrited.ShowUpDown = true;
			this.dateTimePickerWrited.Size = new System.Drawing.Size(149, 20);
			this.dateTimePickerWrited.TabIndex = 5;
			// 
			// FdtmForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 171);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.panelButtons);
			this.Controls.Add(this.tableLayoutPanelDate);
			this.Controls.Add(this.buttonSelectFile);
			this.Controls.Add(this.textBoxPath);
			this.Controls.Add(this.labelPath);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(500, 210);
			this.Name = "FdtmForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FileDateTime Manipulator (FDTM)";
			this.Load += new System.EventHandler(this.FdtmForm_Load);
			this.tableLayoutPanelDate.ResumeLayout(false);
			this.tableLayoutPanelDate.PerformLayout();
			this.panelButtons.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelPath;
		private System.Windows.Forms.TextBox textBoxPath;
		private System.Windows.Forms.Button buttonSelectFile;
		private System.Windows.Forms.Label labelCreationDate;
		private System.Windows.Forms.Label labelLastAccessDate;
		private System.Windows.Forms.Label labelLastWriteDate;
		private System.Windows.Forms.TextBox textBoxCreationDate;
		private System.Windows.Forms.TextBox textBoxLastAccessDate;
		private System.Windows.Forms.TextBox textBoxLastWriteDate;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Label labelNewWriteDate;
		private System.Windows.Forms.Label labelNewCreationDate;
		private System.Windows.Forms.Label labelNewAccessDate;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDate;
		private System.Windows.Forms.Panel panelButtons;
		private System.Windows.Forms.Button buttonApply;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Button buttonInfo;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.DateTimePicker dateTimePickerCreated;
		private System.Windows.Forms.DateTimePicker dateTimePickerAccessed;
		private System.Windows.Forms.DateTimePicker dateTimePickerWrited;
	}
}

