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
			this.components = new System.ComponentModel.Container();
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
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.radioButtonLastWriteDateUtc = new System.Windows.Forms.RadioButton();
			this.radioButtonLastWriteDateLocalTime = new System.Windows.Forms.RadioButton();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.radioButtonCreationDateUtc = new System.Windows.Forms.RadioButton();
			this.radioButtonCreationDateLocalTime = new System.Windows.Forms.RadioButton();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.radioButtonLastAccessDateUtc = new System.Windows.Forms.RadioButton();
			this.radioButtonLastAccessDateLocalTime = new System.Windows.Forms.RadioButton();
			this.panelButtons = new System.Windows.Forms.Panel();
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonInfo = new System.Windows.Forms.Button();
			this.buttonApply = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
			this.radioButtonNewCreationDateUtc = new System.Windows.Forms.RadioButton();
			this.radioButtonNewCreationDateLocalTime = new System.Windows.Forms.RadioButton();
			this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.radioButtonNewLastAccessDateUtc = new System.Windows.Forms.RadioButton();
			this.radioButtonNewLastAccessDateLocalTime = new System.Windows.Forms.RadioButton();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.radioButtonNewLastWriteDateUtc = new System.Windows.Forms.RadioButton();
			this.radioButtonNewLastWriteDateLocalTime = new System.Windows.Forms.RadioButton();
			this.dateTimePickerWrited = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerAccessed = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerCreated = new System.Windows.Forms.DateTimePicker();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.tableLayoutPanelDate.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.panelButtons.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel7.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
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
			this.toolTip.SetToolTip(this.textBoxPath, "Full path name");
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
			this.toolTip.SetToolTip(this.buttonSelectFile, "Click to selected a file");
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
			this.labelLastAccessDate.TabIndex = 3;
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
			this.labelLastWriteDate.TabIndex = 6;
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
			this.toolTip.SetToolTip(this.textBoxCreationDate, "Creation date of the file");
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
			this.textBoxLastAccessDate.TabIndex = 4;
			this.textBoxLastAccessDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip.SetToolTip(this.textBoxLastAccessDate, "Last access date of the file");
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
			this.textBoxLastWriteDate.TabIndex = 7;
			this.textBoxLastWriteDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip.SetToolTip(this.textBoxLastWriteDate, "Last write date of the file");
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
			this.labelNewWriteDate.Enabled = false;
			this.labelNewWriteDate.Location = new System.Drawing.Point(309, 0);
			this.labelNewWriteDate.Name = "labelNewWriteDate";
			this.labelNewWriteDate.Size = new System.Drawing.Size(149, 13);
			this.labelNewWriteDate.TabIndex = 6;
			this.labelNewWriteDate.Text = "Set new write date (&6):";
			this.labelNewWriteDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelNewAccessDate
			// 
			this.labelNewAccessDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelNewAccessDate.AutoSize = true;
			this.labelNewAccessDate.Enabled = false;
			this.labelNewAccessDate.Location = new System.Drawing.Point(156, 0);
			this.labelNewAccessDate.Name = "labelNewAccessDate";
			this.labelNewAccessDate.Size = new System.Drawing.Size(147, 13);
			this.labelNewAccessDate.TabIndex = 3;
			this.labelNewAccessDate.Text = "Set new access date (&5):";
			this.labelNewAccessDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelNewCreationDate
			// 
			this.labelNewCreationDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelNewCreationDate.AutoSize = true;
			this.labelNewCreationDate.Enabled = false;
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
			this.tableLayoutPanelDate.Controls.Add(this.tableLayoutPanel4, 2, 2);
			this.tableLayoutPanelDate.Controls.Add(this.tableLayoutPanel3, 0, 2);
			this.tableLayoutPanelDate.Controls.Add(this.labelCreationDate, 0, 0);
			this.tableLayoutPanelDate.Controls.Add(this.labelLastAccessDate, 1, 0);
			this.tableLayoutPanelDate.Controls.Add(this.textBoxLastWriteDate, 2, 1);
			this.tableLayoutPanelDate.Controls.Add(this.labelLastWriteDate, 2, 0);
			this.tableLayoutPanelDate.Controls.Add(this.textBoxLastAccessDate, 1, 1);
			this.tableLayoutPanelDate.Controls.Add(this.textBoxCreationDate, 0, 1);
			this.tableLayoutPanelDate.Controls.Add(this.tableLayoutPanel2, 1, 2);
			this.tableLayoutPanelDate.Location = new System.Drawing.Point(12, 32);
			this.tableLayoutPanelDate.Name = "tableLayoutPanelDate";
			this.tableLayoutPanelDate.RowCount = 3;
			this.tableLayoutPanelDate.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelDate.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanelDate.Size = new System.Drawing.Size(460, 70);
			this.tableLayoutPanelDate.TabIndex = 3;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.Controls.Add(this.radioButtonLastWriteDateUtc, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.radioButtonLastWriteDateLocalTime, 0, 0);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(309, 42);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(147, 25);
			this.tableLayoutPanel4.TabIndex = 8;
			// 
			// radioButtonLastWriteDateUtc
			// 
			this.radioButtonLastWriteDateUtc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonLastWriteDateUtc.AutoSize = true;
			this.radioButtonLastWriteDateUtc.Enabled = false;
			this.radioButtonLastWriteDateUtc.Location = new System.Drawing.Point(78, 3);
			this.radioButtonLastWriteDateUtc.Name = "radioButtonLastWriteDateUtc";
			this.radioButtonLastWriteDateUtc.Size = new System.Drawing.Size(66, 19);
			this.radioButtonLastWriteDateUtc.TabIndex = 1;
			this.radioButtonLastWriteDateUtc.Text = "UTC";
			this.toolTip.SetToolTip(this.radioButtonLastWriteDateUtc, "Convert the last write date to the universal time");
			this.radioButtonLastWriteDateUtc.UseVisualStyleBackColor = true;
			this.radioButtonLastWriteDateUtc.CheckedChanged += new System.EventHandler(this.RadioButtonLastWriteDateUtc_CheckedChanged);
			// 
			// radioButtonLastWriteDateLocalTime
			// 
			this.radioButtonLastWriteDateLocalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonLastWriteDateLocalTime.AutoSize = true;
			this.radioButtonLastWriteDateLocalTime.Checked = true;
			this.radioButtonLastWriteDateLocalTime.Enabled = false;
			this.radioButtonLastWriteDateLocalTime.Location = new System.Drawing.Point(3, 3);
			this.radioButtonLastWriteDateLocalTime.Name = "radioButtonLastWriteDateLocalTime";
			this.radioButtonLastWriteDateLocalTime.Size = new System.Drawing.Size(69, 19);
			this.radioButtonLastWriteDateLocalTime.TabIndex = 0;
			this.radioButtonLastWriteDateLocalTime.TabStop = true;
			this.radioButtonLastWriteDateLocalTime.Text = "local time";
			this.toolTip.SetToolTip(this.radioButtonLastWriteDateLocalTime, "Convert the last write date to the local time");
			this.radioButtonLastWriteDateLocalTime.UseVisualStyleBackColor = true;
			this.radioButtonLastWriteDateLocalTime.CheckedChanged += new System.EventHandler(this.RadioButtonLastWriteDateLocalTime_CheckedChanged);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.Controls.Add(this.radioButtonCreationDateUtc, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.radioButtonCreationDateLocalTime, 0, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 42);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(147, 25);
			this.tableLayoutPanel3.TabIndex = 2;
			// 
			// radioButtonCreationDateUtc
			// 
			this.radioButtonCreationDateUtc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonCreationDateUtc.AutoSize = true;
			this.radioButtonCreationDateUtc.Enabled = false;
			this.radioButtonCreationDateUtc.Location = new System.Drawing.Point(78, 3);
			this.radioButtonCreationDateUtc.Name = "radioButtonCreationDateUtc";
			this.radioButtonCreationDateUtc.Size = new System.Drawing.Size(66, 19);
			this.radioButtonCreationDateUtc.TabIndex = 1;
			this.radioButtonCreationDateUtc.Text = "UTC";
			this.toolTip.SetToolTip(this.radioButtonCreationDateUtc, "Convert the creation date to the universal time");
			this.radioButtonCreationDateUtc.UseVisualStyleBackColor = true;
			this.radioButtonCreationDateUtc.CheckedChanged += new System.EventHandler(this.RadioButtonCreationDateUtc_CheckedChanged);
			// 
			// radioButtonCreationDateLocalTime
			// 
			this.radioButtonCreationDateLocalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonCreationDateLocalTime.AutoSize = true;
			this.radioButtonCreationDateLocalTime.Checked = true;
			this.radioButtonCreationDateLocalTime.Enabled = false;
			this.radioButtonCreationDateLocalTime.Location = new System.Drawing.Point(3, 3);
			this.radioButtonCreationDateLocalTime.Name = "radioButtonCreationDateLocalTime";
			this.radioButtonCreationDateLocalTime.Size = new System.Drawing.Size(69, 19);
			this.radioButtonCreationDateLocalTime.TabIndex = 0;
			this.radioButtonCreationDateLocalTime.TabStop = true;
			this.radioButtonCreationDateLocalTime.Text = "local time";
			this.toolTip.SetToolTip(this.radioButtonCreationDateLocalTime, "Convert the creation date to the local time");
			this.radioButtonCreationDateLocalTime.UseVisualStyleBackColor = true;
			this.radioButtonCreationDateLocalTime.CheckedChanged += new System.EventHandler(this.RadioButtonCreationDateLocalTime_CheckedChanged);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.radioButtonLastAccessDateUtc, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.radioButtonLastAccessDateLocalTime, 0, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(156, 42);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(147, 25);
			this.tableLayoutPanel2.TabIndex = 5;
			// 
			// radioButtonLastAccessDateUtc
			// 
			this.radioButtonLastAccessDateUtc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonLastAccessDateUtc.AutoSize = true;
			this.radioButtonLastAccessDateUtc.Enabled = false;
			this.radioButtonLastAccessDateUtc.Location = new System.Drawing.Point(78, 3);
			this.radioButtonLastAccessDateUtc.Name = "radioButtonLastAccessDateUtc";
			this.radioButtonLastAccessDateUtc.Size = new System.Drawing.Size(66, 19);
			this.radioButtonLastAccessDateUtc.TabIndex = 1;
			this.radioButtonLastAccessDateUtc.Text = "UTC";
			this.toolTip.SetToolTip(this.radioButtonLastAccessDateUtc, "Convert the last access date to the universal time");
			this.radioButtonLastAccessDateUtc.UseVisualStyleBackColor = true;
			this.radioButtonLastAccessDateUtc.CheckedChanged += new System.EventHandler(this.RadioButtonLastAccessDateUtc_CheckedChanged);
			// 
			// radioButtonLastAccessDateLocalTime
			// 
			this.radioButtonLastAccessDateLocalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonLastAccessDateLocalTime.AutoSize = true;
			this.radioButtonLastAccessDateLocalTime.Checked = true;
			this.radioButtonLastAccessDateLocalTime.Enabled = false;
			this.radioButtonLastAccessDateLocalTime.Location = new System.Drawing.Point(3, 3);
			this.radioButtonLastAccessDateLocalTime.Name = "radioButtonLastAccessDateLocalTime";
			this.radioButtonLastAccessDateLocalTime.Size = new System.Drawing.Size(69, 19);
			this.radioButtonLastAccessDateLocalTime.TabIndex = 0;
			this.radioButtonLastAccessDateLocalTime.TabStop = true;
			this.radioButtonLastAccessDateLocalTime.Text = "local time";
			this.toolTip.SetToolTip(this.radioButtonLastAccessDateLocalTime, "Convert the last access date to the local time");
			this.radioButtonLastAccessDateLocalTime.UseVisualStyleBackColor = true;
			this.radioButtonLastAccessDateLocalTime.CheckedChanged += new System.EventHandler(this.RadioButtonLastAccessDateLocalTime_CheckedChanged);
			// 
			// panelButtons
			// 
			this.panelButtons.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelButtons.Controls.Add(this.buttonClose);
			this.panelButtons.Controls.Add(this.buttonInfo);
			this.panelButtons.Controls.Add(this.buttonApply);
			this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelButtons.Location = new System.Drawing.Point(0, 183);
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
			this.toolTip.SetToolTip(this.buttonClose, "Close the application");
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
			this.toolTip.SetToolTip(this.buttonInfo, "Show some information");
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
			this.toolTip.SetToolTip(this.buttonApply, "Apply the changes");
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
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.dateTimePickerWrited, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.dateTimePickerAccessed, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.dateTimePickerCreated, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.labelNewCreationDate, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelNewAccessDate, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelNewWriteDate, 2, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 108);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 68);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// tableLayoutPanel7
			// 
			this.tableLayoutPanel7.ColumnCount = 2;
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel7.Controls.Add(this.radioButtonNewCreationDateUtc, 1, 0);
			this.tableLayoutPanel7.Controls.Add(this.radioButtonNewCreationDateLocalTime, 0, 0);
			this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 42);
			this.tableLayoutPanel7.Name = "tableLayoutPanel7";
			this.tableLayoutPanel7.RowCount = 1;
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel7.Size = new System.Drawing.Size(147, 23);
			this.tableLayoutPanel7.TabIndex = 2;
			// 
			// radioButtonNewCreationDateUtc
			// 
			this.radioButtonNewCreationDateUtc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonNewCreationDateUtc.AutoSize = true;
			this.radioButtonNewCreationDateUtc.Enabled = false;
			this.radioButtonNewCreationDateUtc.Location = new System.Drawing.Point(78, 3);
			this.radioButtonNewCreationDateUtc.Name = "radioButtonNewCreationDateUtc";
			this.radioButtonNewCreationDateUtc.Size = new System.Drawing.Size(66, 17);
			this.radioButtonNewCreationDateUtc.TabIndex = 1;
			this.radioButtonNewCreationDateUtc.Text = "UTC";
			this.toolTip.SetToolTip(this.radioButtonNewCreationDateUtc, "Convert the creation date preview to the universal time");
			this.radioButtonNewCreationDateUtc.UseVisualStyleBackColor = true;
			this.radioButtonNewCreationDateUtc.CheckedChanged += new System.EventHandler(this.RadioButtonNewCreationDateUtc_CheckedChanged);
			// 
			// radioButtonNewCreationDateLocalTime
			// 
			this.radioButtonNewCreationDateLocalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonNewCreationDateLocalTime.AutoSize = true;
			this.radioButtonNewCreationDateLocalTime.Checked = true;
			this.radioButtonNewCreationDateLocalTime.Enabled = false;
			this.radioButtonNewCreationDateLocalTime.Location = new System.Drawing.Point(3, 3);
			this.radioButtonNewCreationDateLocalTime.Name = "radioButtonNewCreationDateLocalTime";
			this.radioButtonNewCreationDateLocalTime.Size = new System.Drawing.Size(69, 17);
			this.radioButtonNewCreationDateLocalTime.TabIndex = 0;
			this.radioButtonNewCreationDateLocalTime.TabStop = true;
			this.radioButtonNewCreationDateLocalTime.Text = "local time";
			this.toolTip.SetToolTip(this.radioButtonNewCreationDateLocalTime, "Convert the creation date preview to the local time");
			this.radioButtonNewCreationDateLocalTime.UseVisualStyleBackColor = true;
			this.radioButtonNewCreationDateLocalTime.CheckedChanged += new System.EventHandler(this.RadioButtonNewCreationDateLocalTime_CheckedChanged);
			// 
			// tableLayoutPanel6
			// 
			this.tableLayoutPanel6.ColumnCount = 2;
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel6.Controls.Add(this.radioButtonNewLastAccessDateUtc, 1, 0);
			this.tableLayoutPanel6.Controls.Add(this.radioButtonNewLastAccessDateLocalTime, 0, 0);
			this.tableLayoutPanel6.Location = new System.Drawing.Point(156, 42);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 1;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(147, 23);
			this.tableLayoutPanel6.TabIndex = 5;
			// 
			// radioButtonNewLastAccessDateUtc
			// 
			this.radioButtonNewLastAccessDateUtc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonNewLastAccessDateUtc.AutoSize = true;
			this.radioButtonNewLastAccessDateUtc.Enabled = false;
			this.radioButtonNewLastAccessDateUtc.Location = new System.Drawing.Point(78, 3);
			this.radioButtonNewLastAccessDateUtc.Name = "radioButtonNewLastAccessDateUtc";
			this.radioButtonNewLastAccessDateUtc.Size = new System.Drawing.Size(66, 17);
			this.radioButtonNewLastAccessDateUtc.TabIndex = 1;
			this.radioButtonNewLastAccessDateUtc.Text = "UTC";
			this.toolTip.SetToolTip(this.radioButtonNewLastAccessDateUtc, "Convert the last access date preview to the universal time");
			this.radioButtonNewLastAccessDateUtc.UseVisualStyleBackColor = true;
			this.radioButtonNewLastAccessDateUtc.CheckedChanged += new System.EventHandler(this.RadioButtonNewLastAccessDateUtc_CheckedChanged);
			// 
			// radioButtonNewLastAccessDateLocalTime
			// 
			this.radioButtonNewLastAccessDateLocalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonNewLastAccessDateLocalTime.AutoSize = true;
			this.radioButtonNewLastAccessDateLocalTime.Checked = true;
			this.radioButtonNewLastAccessDateLocalTime.Enabled = false;
			this.radioButtonNewLastAccessDateLocalTime.Location = new System.Drawing.Point(3, 3);
			this.radioButtonNewLastAccessDateLocalTime.Name = "radioButtonNewLastAccessDateLocalTime";
			this.radioButtonNewLastAccessDateLocalTime.Size = new System.Drawing.Size(69, 17);
			this.radioButtonNewLastAccessDateLocalTime.TabIndex = 0;
			this.radioButtonNewLastAccessDateLocalTime.TabStop = true;
			this.radioButtonNewLastAccessDateLocalTime.Text = "local time";
			this.toolTip.SetToolTip(this.radioButtonNewLastAccessDateLocalTime, "Convert the last access date preview to the local time");
			this.radioButtonNewLastAccessDateLocalTime.UseVisualStyleBackColor = true;
			this.radioButtonNewLastAccessDateLocalTime.CheckedChanged += new System.EventHandler(this.RadioButtonNewLastAccessDateLocalTime_CheckedChanged);
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 2;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel5.Controls.Add(this.radioButtonNewLastWriteDateUtc, 1, 0);
			this.tableLayoutPanel5.Controls.Add(this.radioButtonNewLastWriteDateLocalTime, 0, 0);
			this.tableLayoutPanel5.Location = new System.Drawing.Point(309, 42);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 1;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(147, 23);
			this.tableLayoutPanel5.TabIndex = 8;
			// 
			// radioButtonNewLastWriteDateUtc
			// 
			this.radioButtonNewLastWriteDateUtc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonNewLastWriteDateUtc.AutoSize = true;
			this.radioButtonNewLastWriteDateUtc.Enabled = false;
			this.radioButtonNewLastWriteDateUtc.Location = new System.Drawing.Point(78, 3);
			this.radioButtonNewLastWriteDateUtc.Name = "radioButtonNewLastWriteDateUtc";
			this.radioButtonNewLastWriteDateUtc.Size = new System.Drawing.Size(66, 17);
			this.radioButtonNewLastWriteDateUtc.TabIndex = 1;
			this.radioButtonNewLastWriteDateUtc.Text = "UTC";
			this.toolTip.SetToolTip(this.radioButtonNewLastWriteDateUtc, "Convert the last write date preview to the universal time");
			this.radioButtonNewLastWriteDateUtc.UseVisualStyleBackColor = true;
			this.radioButtonNewLastWriteDateUtc.CheckedChanged += new System.EventHandler(this.RadioButtonNewLastWriteDateUtc_CheckedChanged);
			// 
			// radioButtonNewLastWriteDateLocalTime
			// 
			this.radioButtonNewLastWriteDateLocalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonNewLastWriteDateLocalTime.AutoSize = true;
			this.radioButtonNewLastWriteDateLocalTime.Checked = true;
			this.radioButtonNewLastWriteDateLocalTime.Enabled = false;
			this.radioButtonNewLastWriteDateLocalTime.Location = new System.Drawing.Point(3, 3);
			this.radioButtonNewLastWriteDateLocalTime.Name = "radioButtonNewLastWriteDateLocalTime";
			this.radioButtonNewLastWriteDateLocalTime.Size = new System.Drawing.Size(69, 17);
			this.radioButtonNewLastWriteDateLocalTime.TabIndex = 0;
			this.radioButtonNewLastWriteDateLocalTime.TabStop = true;
			this.radioButtonNewLastWriteDateLocalTime.Text = "local time";
			this.toolTip.SetToolTip(this.radioButtonNewLastWriteDateLocalTime, "Convert the last write date preview to the local time");
			this.radioButtonNewLastWriteDateLocalTime.UseVisualStyleBackColor = true;
			this.radioButtonNewLastWriteDateLocalTime.CheckedChanged += new System.EventHandler(this.RadioButtonNewLastWriteDateLocalTime_CheckedChanged);
			// 
			// dateTimePickerWrited
			// 
			this.dateTimePickerWrited.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePickerWrited.CustomFormat = "dd.MM.yyyy HH:mm:ss";
			this.dateTimePickerWrited.Enabled = false;
			this.dateTimePickerWrited.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.dateTimePickerWrited.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerWrited.Location = new System.Drawing.Point(309, 16);
			this.dateTimePickerWrited.Name = "dateTimePickerWrited";
			this.dateTimePickerWrited.ShowCheckBox = true;
			this.dateTimePickerWrited.ShowUpDown = true;
			this.dateTimePickerWrited.Size = new System.Drawing.Size(149, 20);
			this.dateTimePickerWrited.TabIndex = 7;
			this.toolTip.SetToolTip(this.dateTimePickerWrited, "Last write date preview of the file");
			// 
			// dateTimePickerAccessed
			// 
			this.dateTimePickerAccessed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePickerAccessed.CustomFormat = "dd.MM.yyyy HH:mm:ss";
			this.dateTimePickerAccessed.Enabled = false;
			this.dateTimePickerAccessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.dateTimePickerAccessed.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerAccessed.Location = new System.Drawing.Point(156, 16);
			this.dateTimePickerAccessed.Name = "dateTimePickerAccessed";
			this.dateTimePickerAccessed.ShowCheckBox = true;
			this.dateTimePickerAccessed.ShowUpDown = true;
			this.dateTimePickerAccessed.Size = new System.Drawing.Size(147, 20);
			this.dateTimePickerAccessed.TabIndex = 4;
			this.toolTip.SetToolTip(this.dateTimePickerAccessed, "Last access date preview of the file");
			// 
			// dateTimePickerCreated
			// 
			this.dateTimePickerCreated.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePickerCreated.CustomFormat = "dd.MM.yyyy HH:mm:ss";
			this.dateTimePickerCreated.Enabled = false;
			this.dateTimePickerCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.dateTimePickerCreated.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerCreated.Location = new System.Drawing.Point(3, 16);
			this.dateTimePickerCreated.Name = "dateTimePickerCreated";
			this.dateTimePickerCreated.ShowCheckBox = true;
			this.dateTimePickerCreated.ShowUpDown = true;
			this.dateTimePickerCreated.Size = new System.Drawing.Size(147, 20);
			this.dateTimePickerCreated.TabIndex = 1;
			this.toolTip.SetToolTip(this.dateTimePickerCreated, "Creation date preview of the file");
			// 
			// FdtmForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 232);
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
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.panelButtons.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel7.ResumeLayout(false);
			this.tableLayoutPanel7.PerformLayout();
			this.tableLayoutPanel6.ResumeLayout(false);
			this.tableLayoutPanel6.PerformLayout();
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel5.PerformLayout();
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
		private System.Windows.Forms.DateTimePicker dateTimePickerWrited;
		private System.Windows.Forms.DateTimePicker dateTimePickerAccessed;
		private System.Windows.Forms.DateTimePicker dateTimePickerCreated;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.RadioButton radioButtonLastWriteDateUtc;
		private System.Windows.Forms.RadioButton radioButtonLastWriteDateLocalTime;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.RadioButton radioButtonCreationDateUtc;
		private System.Windows.Forms.RadioButton radioButtonCreationDateLocalTime;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.RadioButton radioButtonLastAccessDateUtc;
		private System.Windows.Forms.RadioButton radioButtonLastAccessDateLocalTime;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
		private System.Windows.Forms.RadioButton radioButtonNewCreationDateUtc;
		private System.Windows.Forms.RadioButton radioButtonNewCreationDateLocalTime;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
		private System.Windows.Forms.RadioButton radioButtonNewLastAccessDateUtc;
		private System.Windows.Forms.RadioButton radioButtonNewLastAccessDateLocalTime;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.RadioButton radioButtonNewLastWriteDateUtc;
		private System.Windows.Forms.RadioButton radioButtonNewLastWriteDateLocalTime;
		private System.Windows.Forms.ToolTip toolTip;
	}
}

