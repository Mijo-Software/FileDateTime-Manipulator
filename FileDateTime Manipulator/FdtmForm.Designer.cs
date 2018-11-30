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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FdtmForm));
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.radioButtonNewCreationDateUtc = new System.Windows.Forms.RadioButton();
			this.radioButtonNewCreationDateLocalTime = new System.Windows.Forms.RadioButton();
			this.radioButtonNewLastAccessDateUtc = new System.Windows.Forms.RadioButton();
			this.radioButtonNewLastAccessDateLocalTime = new System.Windows.Forms.RadioButton();
			this.radioButtonNewLastWriteDateUtc = new System.Windows.Forms.RadioButton();
			this.radioButtonNewLastWriteDateLocalTime = new System.Windows.Forms.RadioButton();
			this.dateTimePickerWrited = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerAccessed = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerCreated = new System.Windows.Forms.DateTimePicker();
			this.radioButtonLastWriteDateUtc = new System.Windows.Forms.RadioButton();
			this.radioButtonLastWriteDateLocalTime = new System.Windows.Forms.RadioButton();
			this.radioButtonCreationDateUtc = new System.Windows.Forms.RadioButton();
			this.radioButtonCreationDateLocalTime = new System.Windows.Forms.RadioButton();
			this.textBoxLastWriteDate = new System.Windows.Forms.TextBox();
			this.textBoxLastAccessDate = new System.Windows.Forms.TextBox();
			this.textBoxCreationDate = new System.Windows.Forms.TextBox();
			this.radioButtonLastAccessDateUtc = new System.Windows.Forms.RadioButton();
			this.radioButtonLastAccessDateLocalTime = new System.Windows.Forms.RadioButton();
			this.textBoxPath = new System.Windows.Forms.TextBox();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.tableLayoutPanelSetDate = new System.Windows.Forms.TableLayoutPanel();
			this.labelNewCreationDate = new System.Windows.Forms.Label();
			this.tableLayoutPanelSetLastWriteDateFormat = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanelSetLastAccessDateFormat = new System.Windows.Forms.TableLayoutPanel();
			this.labelNewWriteDate = new System.Windows.Forms.Label();
			this.labelNewAccessDate = new System.Windows.Forms.Label();
			this.tableLayoutPanelSetCreationDateFormat = new System.Windows.Forms.TableLayoutPanel();
			this.panelButtons = new System.Windows.Forms.Panel();
			this.tableLayoutPanelGetDate = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanelGetLastWriteDateFormat = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanelGetCreationDateFormat = new System.Windows.Forms.TableLayoutPanel();
			this.labelCreationDate = new System.Windows.Forms.Label();
			this.labelLastAccessDate = new System.Windows.Forms.Label();
			this.labelLastWriteDate = new System.Windows.Forms.Label();
			this.tableLayoutPanelGetLastAccessDateFormat = new System.Windows.Forms.TableLayoutPanel();
			this.labelPath = new System.Windows.Forms.Label();
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonInfo = new System.Windows.Forms.Button();
			this.buttonApply = new System.Windows.Forms.Button();
			this.buttonSelectFile = new System.Windows.Forms.Button();
			this.statusStrip.SuspendLayout();
			this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			this.tableLayoutPanelSetDate.SuspendLayout();
			this.tableLayoutPanelSetLastWriteDateFormat.SuspendLayout();
			this.tableLayoutPanelSetLastAccessDateFormat.SuspendLayout();
			this.tableLayoutPanelSetCreationDateFormat.SuspendLayout();
			this.panelButtons.SuspendLayout();
			this.tableLayoutPanelGetDate.SuspendLayout();
			this.tableLayoutPanelGetLastWriteDateFormat.SuspendLayout();
			this.tableLayoutPanelGetCreationDateFormat.SuspendLayout();
			this.tableLayoutPanelGetLastAccessDateFormat.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = "all files|*.*";
			this.openFileDialog.SupportMultiDottedExtensions = true;
			this.openFileDialog.Title = "Select file";
			// 
			// radioButtonNewCreationDateUtc
			// 
			this.radioButtonNewCreationDateUtc.AccessibleDescription = "Convert the creation date preview to the universal time";
			this.radioButtonNewCreationDateUtc.AccessibleName = "Convert the creation date preview to the universal time";
			this.radioButtonNewCreationDateUtc.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
			this.radioButtonNewCreationDateUtc.AutoSize = true;
			this.radioButtonNewCreationDateUtc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radioButtonNewCreationDateUtc.Enabled = false;
			this.radioButtonNewCreationDateUtc.Location = new System.Drawing.Point(78, 3);
			this.radioButtonNewCreationDateUtc.Name = "radioButtonNewCreationDateUtc";
			this.radioButtonNewCreationDateUtc.Size = new System.Drawing.Size(66, 17);
			this.radioButtonNewCreationDateUtc.TabIndex = 1;
			this.radioButtonNewCreationDateUtc.Text = "UTC";
			this.toolTip.SetToolTip(this.radioButtonNewCreationDateUtc, "Convert the creation date preview to the universal time");
			this.radioButtonNewCreationDateUtc.UseVisualStyleBackColor = true;
			this.radioButtonNewCreationDateUtc.CheckedChanged += new System.EventHandler(this.RadioButtonNewCreationDateUtc_CheckedChanged);
			this.radioButtonNewCreationDateUtc.Enter += new System.EventHandler(this.SetStatusLabelForRadioButton);
			this.radioButtonNewCreationDateUtc.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.radioButtonNewCreationDateUtc.MouseEnter += new System.EventHandler(this.SetStatusLabelForRadioButton);
			this.radioButtonNewCreationDateUtc.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// radioButtonNewCreationDateLocalTime
			// 
			this.radioButtonNewCreationDateLocalTime.AccessibleDescription = "Convert the creation date preview to the local time";
			this.radioButtonNewCreationDateLocalTime.AccessibleName = "Convert the creation date preview to the local time";
			this.radioButtonNewCreationDateLocalTime.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
			this.radioButtonNewCreationDateLocalTime.AutoSize = true;
			this.radioButtonNewCreationDateLocalTime.Checked = true;
			this.radioButtonNewCreationDateLocalTime.Dock = System.Windows.Forms.DockStyle.Fill;
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
			this.radioButtonNewCreationDateLocalTime.Enter += new System.EventHandler(this.SetStatusLabelForRadioButton);
			this.radioButtonNewCreationDateLocalTime.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.radioButtonNewCreationDateLocalTime.MouseEnter += new System.EventHandler(this.SetStatusLabelForRadioButton);
			this.radioButtonNewCreationDateLocalTime.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// radioButtonNewLastAccessDateUtc
			// 
			this.radioButtonNewLastAccessDateUtc.AccessibleDescription = "Convert the last access date preview to the universal time";
			this.radioButtonNewLastAccessDateUtc.AccessibleName = "Convert the last access date preview to the universal time";
			this.radioButtonNewLastAccessDateUtc.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
			this.radioButtonNewLastAccessDateUtc.AutoSize = true;
			this.radioButtonNewLastAccessDateUtc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radioButtonNewLastAccessDateUtc.Enabled = false;
			this.radioButtonNewLastAccessDateUtc.Location = new System.Drawing.Point(78, 3);
			this.radioButtonNewLastAccessDateUtc.Name = "radioButtonNewLastAccessDateUtc";
			this.radioButtonNewLastAccessDateUtc.Size = new System.Drawing.Size(66, 17);
			this.radioButtonNewLastAccessDateUtc.TabIndex = 1;
			this.radioButtonNewLastAccessDateUtc.Text = "UTC";
			this.toolTip.SetToolTip(this.radioButtonNewLastAccessDateUtc, "Convert the last access date preview to the universal time");
			this.radioButtonNewLastAccessDateUtc.UseVisualStyleBackColor = true;
			this.radioButtonNewLastAccessDateUtc.CheckedChanged += new System.EventHandler(this.RadioButtonNewLastAccessDateUtc_CheckedChanged);
			this.radioButtonNewLastAccessDateUtc.Enter += new System.EventHandler(this.SetStatusLabelForRadioButton);
			this.radioButtonNewLastAccessDateUtc.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.radioButtonNewLastAccessDateUtc.MouseEnter += new System.EventHandler(this.SetStatusLabelForRadioButton);
			this.radioButtonNewLastAccessDateUtc.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// radioButtonNewLastAccessDateLocalTime
			// 
			this.radioButtonNewLastAccessDateLocalTime.AccessibleDescription = "Convert the last access date preview to the local time";
			this.radioButtonNewLastAccessDateLocalTime.AccessibleName = "Convert the last access date preview to the local time";
			this.radioButtonNewLastAccessDateLocalTime.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
			this.radioButtonNewLastAccessDateLocalTime.AutoSize = true;
			this.radioButtonNewLastAccessDateLocalTime.Checked = true;
			this.radioButtonNewLastAccessDateLocalTime.Dock = System.Windows.Forms.DockStyle.Fill;
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
			this.radioButtonNewLastAccessDateLocalTime.Enter += new System.EventHandler(this.SetStatusLabelForRadioButton);
			this.radioButtonNewLastAccessDateLocalTime.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.radioButtonNewLastAccessDateLocalTime.MouseEnter += new System.EventHandler(this.SetStatusLabelForRadioButton);
			this.radioButtonNewLastAccessDateLocalTime.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// radioButtonNewLastWriteDateUtc
			// 
			this.radioButtonNewLastWriteDateUtc.AccessibleDescription = "Convert the last write date preview to the universal time";
			this.radioButtonNewLastWriteDateUtc.AccessibleName = "Convert the last write date preview to the universal time";
			this.radioButtonNewLastWriteDateUtc.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
			this.radioButtonNewLastWriteDateUtc.AutoSize = true;
			this.radioButtonNewLastWriteDateUtc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radioButtonNewLastWriteDateUtc.Enabled = false;
			this.radioButtonNewLastWriteDateUtc.Location = new System.Drawing.Point(78, 3);
			this.radioButtonNewLastWriteDateUtc.Name = "radioButtonNewLastWriteDateUtc";
			this.radioButtonNewLastWriteDateUtc.Size = new System.Drawing.Size(66, 17);
			this.radioButtonNewLastWriteDateUtc.TabIndex = 1;
			this.radioButtonNewLastWriteDateUtc.Text = "UTC";
			this.toolTip.SetToolTip(this.radioButtonNewLastWriteDateUtc, "Convert the last write date preview to the universal time");
			this.radioButtonNewLastWriteDateUtc.UseVisualStyleBackColor = true;
			this.radioButtonNewLastWriteDateUtc.CheckedChanged += new System.EventHandler(this.RadioButtonNewLastWriteDateUtc_CheckedChanged);
			this.radioButtonNewLastWriteDateUtc.Enter += new System.EventHandler(this.SetStatusLabelForRadioButton);
			this.radioButtonNewLastWriteDateUtc.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.radioButtonNewLastWriteDateUtc.MouseEnter += new System.EventHandler(this.SetStatusLabelForRadioButton);
			this.radioButtonNewLastWriteDateUtc.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// radioButtonNewLastWriteDateLocalTime
			// 
			this.radioButtonNewLastWriteDateLocalTime.AccessibleDescription = "Convert the last write date preview to the local time";
			this.radioButtonNewLastWriteDateLocalTime.AccessibleName = "Convert the last write date preview to the local time";
			this.radioButtonNewLastWriteDateLocalTime.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
			this.radioButtonNewLastWriteDateLocalTime.AutoSize = true;
			this.radioButtonNewLastWriteDateLocalTime.Checked = true;
			this.radioButtonNewLastWriteDateLocalTime.Dock = System.Windows.Forms.DockStyle.Fill;
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
			this.radioButtonNewLastWriteDateLocalTime.Enter += new System.EventHandler(this.SetStatusLabelForRadioButton);
			this.radioButtonNewLastWriteDateLocalTime.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.radioButtonNewLastWriteDateLocalTime.MouseEnter += new System.EventHandler(this.SetStatusLabelForRadioButton);
			this.radioButtonNewLastWriteDateLocalTime.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// dateTimePickerWrited
			// 
			this.dateTimePickerWrited.AccessibleDescription = "Set the last write date of the file";
			this.dateTimePickerWrited.AccessibleName = "Last write date preview of the file";
			this.dateTimePickerWrited.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePickerWrited.CustomFormat = "dd.MM.yyyy HH:mm:ss";
			this.dateTimePickerWrited.Enabled = false;
			this.dateTimePickerWrited.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.dateTimePickerWrited.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerWrited.Location = new System.Drawing.Point(351, 16);
			this.dateTimePickerWrited.Name = "dateTimePickerWrited";
			this.dateTimePickerWrited.ShowCheckBox = true;
			this.dateTimePickerWrited.ShowUpDown = true;
			this.dateTimePickerWrited.Size = new System.Drawing.Size(168, 20);
			this.dateTimePickerWrited.TabIndex = 7;
			this.toolTip.SetToolTip(this.dateTimePickerWrited, "Last write date preview of the file");
			this.dateTimePickerWrited.Enter += new System.EventHandler(this.SetStatusLabelForDateTimePicker);
			this.dateTimePickerWrited.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.dateTimePickerWrited.MouseEnter += new System.EventHandler(this.SetStatusLabelForDateTimePicker);
			this.dateTimePickerWrited.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// dateTimePickerAccessed
			// 
			this.dateTimePickerAccessed.AccessibleDescription = "Set the last access date of the file";
			this.dateTimePickerAccessed.AccessibleName = "Last access date preview of the file";
			this.dateTimePickerAccessed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePickerAccessed.CustomFormat = "dd.MM.yyyy HH:mm:ss";
			this.dateTimePickerAccessed.Enabled = false;
			this.dateTimePickerAccessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.dateTimePickerAccessed.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerAccessed.Location = new System.Drawing.Point(177, 16);
			this.dateTimePickerAccessed.Name = "dateTimePickerAccessed";
			this.dateTimePickerAccessed.ShowCheckBox = true;
			this.dateTimePickerAccessed.ShowUpDown = true;
			this.dateTimePickerAccessed.Size = new System.Drawing.Size(168, 20);
			this.dateTimePickerAccessed.TabIndex = 4;
			this.toolTip.SetToolTip(this.dateTimePickerAccessed, "Last access date preview of the file");
			this.dateTimePickerAccessed.Enter += new System.EventHandler(this.SetStatusLabelForDateTimePicker);
			this.dateTimePickerAccessed.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.dateTimePickerAccessed.MouseEnter += new System.EventHandler(this.SetStatusLabelForDateTimePicker);
			this.dateTimePickerAccessed.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// dateTimePickerCreated
			// 
			this.dateTimePickerCreated.AccessibleDescription = "Set the creation date of the file";
			this.dateTimePickerCreated.AccessibleName = "Creation date preview of the file";
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
			this.dateTimePickerCreated.Size = new System.Drawing.Size(168, 20);
			this.dateTimePickerCreated.TabIndex = 1;
			this.toolTip.SetToolTip(this.dateTimePickerCreated, "Creation date preview of the file");
			this.dateTimePickerCreated.Enter += new System.EventHandler(this.SetStatusLabelForDateTimePicker);
			this.dateTimePickerCreated.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.dateTimePickerCreated.MouseEnter += new System.EventHandler(this.SetStatusLabelForDateTimePicker);
			this.dateTimePickerCreated.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// radioButtonLastWriteDateUtc
			// 
			this.radioButtonLastWriteDateUtc.AccessibleDescription = "Convert the last write date to the universal time";
			this.radioButtonLastWriteDateUtc.AccessibleName = "Convert the last write date to the universal time";
			this.radioButtonLastWriteDateUtc.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
			this.radioButtonLastWriteDateUtc.AutoSize = true;
			this.radioButtonLastWriteDateUtc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radioButtonLastWriteDateUtc.Enabled = false;
			this.radioButtonLastWriteDateUtc.Location = new System.Drawing.Point(78, 3);
			this.radioButtonLastWriteDateUtc.Name = "radioButtonLastWriteDateUtc";
			this.radioButtonLastWriteDateUtc.Size = new System.Drawing.Size(66, 19);
			this.radioButtonLastWriteDateUtc.TabIndex = 1;
			this.radioButtonLastWriteDateUtc.Text = "UTC";
			this.toolTip.SetToolTip(this.radioButtonLastWriteDateUtc, "Convert the last write date to the universal time");
			this.radioButtonLastWriteDateUtc.UseVisualStyleBackColor = true;
			this.radioButtonLastWriteDateUtc.CheckedChanged += new System.EventHandler(this.RadioButtonLastWriteDateUtc_CheckedChanged);
			this.radioButtonLastWriteDateUtc.Enter += new System.EventHandler(this.SetStatusLabelForRadioButton);
			this.radioButtonLastWriteDateUtc.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.radioButtonLastWriteDateUtc.MouseEnter += new System.EventHandler(this.SetStatusLabelForRadioButton);
			this.radioButtonLastWriteDateUtc.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// radioButtonLastWriteDateLocalTime
			// 
			this.radioButtonLastWriteDateLocalTime.AccessibleDescription = "Convert the last write date to the local time";
			this.radioButtonLastWriteDateLocalTime.AccessibleName = "Convert the last write date to the local time";
			this.radioButtonLastWriteDateLocalTime.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
			this.radioButtonLastWriteDateLocalTime.AutoSize = true;
			this.radioButtonLastWriteDateLocalTime.Checked = true;
			this.radioButtonLastWriteDateLocalTime.Dock = System.Windows.Forms.DockStyle.Fill;
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
			this.radioButtonLastWriteDateLocalTime.Enter += new System.EventHandler(this.SetStatusLabelForRadioButton);
			this.radioButtonLastWriteDateLocalTime.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.radioButtonLastWriteDateLocalTime.MouseEnter += new System.EventHandler(this.SetStatusLabelForRadioButton);
			this.radioButtonLastWriteDateLocalTime.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// radioButtonCreationDateUtc
			// 
			this.radioButtonCreationDateUtc.AccessibleDescription = "Convert the creation date to the universal time";
			this.radioButtonCreationDateUtc.AccessibleName = "Convert the creation date to the universal time";
			this.radioButtonCreationDateUtc.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
			this.radioButtonCreationDateUtc.AutoSize = true;
			this.radioButtonCreationDateUtc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radioButtonCreationDateUtc.Enabled = false;
			this.radioButtonCreationDateUtc.Location = new System.Drawing.Point(78, 3);
			this.radioButtonCreationDateUtc.Name = "radioButtonCreationDateUtc";
			this.radioButtonCreationDateUtc.Size = new System.Drawing.Size(66, 19);
			this.radioButtonCreationDateUtc.TabIndex = 1;
			this.radioButtonCreationDateUtc.Text = "UTC";
			this.toolTip.SetToolTip(this.radioButtonCreationDateUtc, "Convert the creation date to the universal time");
			this.radioButtonCreationDateUtc.UseVisualStyleBackColor = true;
			this.radioButtonCreationDateUtc.CheckedChanged += new System.EventHandler(this.RadioButtonCreationDateUtc_CheckedChanged);
			this.radioButtonCreationDateUtc.Enter += new System.EventHandler(this.SetStatusLabelForRadioButton);
			this.radioButtonCreationDateUtc.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.radioButtonCreationDateUtc.MouseEnter += new System.EventHandler(this.SetStatusLabelForRadioButton);
			this.radioButtonCreationDateUtc.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// radioButtonCreationDateLocalTime
			// 
			this.radioButtonCreationDateLocalTime.AccessibleDescription = "Convert the creation date to the local time";
			this.radioButtonCreationDateLocalTime.AccessibleName = "Convert the creation date to the local time";
			this.radioButtonCreationDateLocalTime.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
			this.radioButtonCreationDateLocalTime.AutoSize = true;
			this.radioButtonCreationDateLocalTime.Checked = true;
			this.radioButtonCreationDateLocalTime.Dock = System.Windows.Forms.DockStyle.Fill;
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
			this.radioButtonCreationDateLocalTime.Enter += new System.EventHandler(this.SetStatusLabelForRadioButton);
			this.radioButtonCreationDateLocalTime.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.radioButtonCreationDateLocalTime.MouseEnter += new System.EventHandler(this.SetStatusLabelForRadioButton);
			this.radioButtonCreationDateLocalTime.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// textBoxLastWriteDate
			// 
			this.textBoxLastWriteDate.AccessibleDescription = "Last write date of the file";
			this.textBoxLastWriteDate.AccessibleName = "Last write date of the file";
			this.textBoxLastWriteDate.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.textBoxLastWriteDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxLastWriteDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxLastWriteDate.Location = new System.Drawing.Point(351, 16);
			this.textBoxLastWriteDate.Name = "textBoxLastWriteDate";
			this.textBoxLastWriteDate.ReadOnly = true;
			this.textBoxLastWriteDate.Size = new System.Drawing.Size(168, 20);
			this.textBoxLastWriteDate.TabIndex = 7;
			this.textBoxLastWriteDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip.SetToolTip(this.textBoxLastWriteDate, "Last write date of the file");
			this.textBoxLastWriteDate.Enter += new System.EventHandler(this.SetStatusLabelForTextBox);
			this.textBoxLastWriteDate.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.textBoxLastWriteDate.MouseEnter += new System.EventHandler(this.SetStatusLabelForTextBox);
			this.textBoxLastWriteDate.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// textBoxLastAccessDate
			// 
			this.textBoxLastAccessDate.AccessibleDescription = "Last access date of the file";
			this.textBoxLastAccessDate.AccessibleName = "Last access date of the file";
			this.textBoxLastAccessDate.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.textBoxLastAccessDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxLastAccessDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxLastAccessDate.Location = new System.Drawing.Point(177, 16);
			this.textBoxLastAccessDate.Name = "textBoxLastAccessDate";
			this.textBoxLastAccessDate.ReadOnly = true;
			this.textBoxLastAccessDate.Size = new System.Drawing.Size(168, 20);
			this.textBoxLastAccessDate.TabIndex = 4;
			this.textBoxLastAccessDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip.SetToolTip(this.textBoxLastAccessDate, "Last access date of the file");
			this.textBoxLastAccessDate.Enter += new System.EventHandler(this.SetStatusLabelForTextBox);
			this.textBoxLastAccessDate.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.textBoxLastAccessDate.MouseEnter += new System.EventHandler(this.SetStatusLabelForTextBox);
			this.textBoxLastAccessDate.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// textBoxCreationDate
			// 
			this.textBoxCreationDate.AccessibleDescription = "Creation date of the file";
			this.textBoxCreationDate.AccessibleName = "Creation date of the file";
			this.textBoxCreationDate.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.textBoxCreationDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxCreationDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxCreationDate.Location = new System.Drawing.Point(3, 16);
			this.textBoxCreationDate.Name = "textBoxCreationDate";
			this.textBoxCreationDate.ReadOnly = true;
			this.textBoxCreationDate.Size = new System.Drawing.Size(168, 20);
			this.textBoxCreationDate.TabIndex = 1;
			this.textBoxCreationDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip.SetToolTip(this.textBoxCreationDate, "Creation date of the file");
			this.textBoxCreationDate.Enter += new System.EventHandler(this.SetStatusLabelForTextBox);
			this.textBoxCreationDate.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.textBoxCreationDate.MouseEnter += new System.EventHandler(this.SetStatusLabelForTextBox);
			this.textBoxCreationDate.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// radioButtonLastAccessDateUtc
			// 
			this.radioButtonLastAccessDateUtc.AccessibleDescription = "Convert the last access date to the universal time";
			this.radioButtonLastAccessDateUtc.AccessibleName = "Convert the last access date to the universal time";
			this.radioButtonLastAccessDateUtc.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
			this.radioButtonLastAccessDateUtc.AutoSize = true;
			this.radioButtonLastAccessDateUtc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radioButtonLastAccessDateUtc.Enabled = false;
			this.radioButtonLastAccessDateUtc.Location = new System.Drawing.Point(78, 3);
			this.radioButtonLastAccessDateUtc.Name = "radioButtonLastAccessDateUtc";
			this.radioButtonLastAccessDateUtc.Size = new System.Drawing.Size(66, 19);
			this.radioButtonLastAccessDateUtc.TabIndex = 1;
			this.radioButtonLastAccessDateUtc.Text = "UTC";
			this.toolTip.SetToolTip(this.radioButtonLastAccessDateUtc, "Convert the last access date to the universal time");
			this.radioButtonLastAccessDateUtc.UseVisualStyleBackColor = true;
			this.radioButtonLastAccessDateUtc.CheckedChanged += new System.EventHandler(this.RadioButtonLastAccessDateUtc_CheckedChanged);
			this.radioButtonLastAccessDateUtc.Enter += new System.EventHandler(this.SetStatusLabelForRadioButton);
			this.radioButtonLastAccessDateUtc.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.radioButtonLastAccessDateUtc.MouseEnter += new System.EventHandler(this.SetStatusLabelForRadioButton);
			this.radioButtonLastAccessDateUtc.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// radioButtonLastAccessDateLocalTime
			// 
			this.radioButtonLastAccessDateLocalTime.AccessibleDescription = "Convert the last access date to the locla time";
			this.radioButtonLastAccessDateLocalTime.AccessibleName = "Convert the last access date to the local time";
			this.radioButtonLastAccessDateLocalTime.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
			this.radioButtonLastAccessDateLocalTime.AutoSize = true;
			this.radioButtonLastAccessDateLocalTime.Checked = true;
			this.radioButtonLastAccessDateLocalTime.Dock = System.Windows.Forms.DockStyle.Fill;
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
			this.radioButtonLastAccessDateLocalTime.Enter += new System.EventHandler(this.SetStatusLabelForRadioButton);
			this.radioButtonLastAccessDateLocalTime.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.radioButtonLastAccessDateLocalTime.MouseEnter += new System.EventHandler(this.SetStatusLabelForRadioButton);
			this.radioButtonLastAccessDateLocalTime.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// textBoxPath
			// 
			this.textBoxPath.AccessibleDescription = "Show the full path name";
			this.textBoxPath.AccessibleName = "Full path name";
			this.textBoxPath.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.textBoxPath.AllowDrop = true;
			this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxPath.Location = new System.Drawing.Point(40, 10);
			this.textBoxPath.Name = "textBoxPath";
			this.textBoxPath.ReadOnly = true;
			this.textBoxPath.Size = new System.Drawing.Size(401, 20);
			this.textBoxPath.TabIndex = 7;
			this.toolTip.SetToolTip(this.textBoxPath, "Full path name");
			this.textBoxPath.Enter += new System.EventHandler(this.SetStatusLabelForTextBox);
			this.textBoxPath.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.textBoxPath.MouseEnter += new System.EventHandler(this.SetStatusLabelForTextBox);
			this.textBoxPath.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
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
			this.statusStrip.Size = new System.Drawing.Size(546, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 10;
			this.statusStrip.Text = "statusStrip";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(112, 17);
			this.toolStripStatusLabel.Text = "toolStripStatusLabel";
			// 
			// toolStripContainer
			// 
			this.toolStripContainer.AccessibleDescription = "Application panel";
			this.toolStripContainer.AccessibleName = "Application panel";
			this.toolStripContainer.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			this.toolStripContainer.ContentPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.toolStripContainer.ContentPanel.Controls.Add(this.tableLayoutPanelSetDate);
			this.toolStripContainer.ContentPanel.Controls.Add(this.panelButtons);
			this.toolStripContainer.ContentPanel.Controls.Add(this.tableLayoutPanelGetDate);
			this.toolStripContainer.ContentPanel.Controls.Add(this.buttonSelectFile);
			this.toolStripContainer.ContentPanel.Controls.Add(this.textBoxPath);
			this.toolStripContainer.ContentPanel.Controls.Add(this.labelPath);
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(546, 231);
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer.Name = "toolStripContainer";
			this.toolStripContainer.Size = new System.Drawing.Size(546, 253);
			this.toolStripContainer.TabIndex = 11;
			this.toolStripContainer.Text = "toolStripContainer";
			// 
			// tableLayoutPanelSetDate
			// 
			this.tableLayoutPanelSetDate.AccessibleDescription = "Panel for the date preview of the file";
			this.tableLayoutPanelSetDate.AccessibleName = "Date preview panel";
			this.tableLayoutPanelSetDate.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.tableLayoutPanelSetDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanelSetDate.ColumnCount = 3;
			this.tableLayoutPanelSetDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelSetDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelSetDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelSetDate.Controls.Add(this.labelNewCreationDate, 0, 0);
			this.tableLayoutPanelSetDate.Controls.Add(this.tableLayoutPanelSetLastWriteDateFormat, 2, 2);
			this.tableLayoutPanelSetDate.Controls.Add(this.tableLayoutPanelSetLastAccessDateFormat, 1, 2);
			this.tableLayoutPanelSetDate.Controls.Add(this.dateTimePickerWrited, 0, 1);
			this.tableLayoutPanelSetDate.Controls.Add(this.dateTimePickerAccessed, 0, 1);
			this.tableLayoutPanelSetDate.Controls.Add(this.dateTimePickerCreated, 0, 1);
			this.tableLayoutPanelSetDate.Controls.Add(this.labelNewWriteDate, 2, 0);
			this.tableLayoutPanelSetDate.Controls.Add(this.labelNewAccessDate, 1, 0);
			this.tableLayoutPanelSetDate.Controls.Add(this.tableLayoutPanelSetCreationDateFormat, 0, 2);
			this.tableLayoutPanelSetDate.Location = new System.Drawing.Point(12, 112);
			this.tableLayoutPanelSetDate.Name = "tableLayoutPanelSetDate";
			this.tableLayoutPanelSetDate.RowCount = 3;
			this.tableLayoutPanelSetDate.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelSetDate.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelSetDate.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelSetDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelSetDate.Size = new System.Drawing.Size(522, 67);
			this.tableLayoutPanelSetDate.TabIndex = 10;
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
			this.labelNewCreationDate.Size = new System.Drawing.Size(168, 13);
			this.labelNewCreationDate.TabIndex = 0;
			this.labelNewCreationDate.Text = "Set new creation date (&4):";
			this.labelNewCreationDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.labelNewCreationDate.Enter += new System.EventHandler(this.SetStatusLabelForLabel);
			this.labelNewCreationDate.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.labelNewCreationDate.MouseEnter += new System.EventHandler(this.SetStatusLabelForLabel);
			this.labelNewCreationDate.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// tableLayoutPanelSetLastWriteDateFormat
			// 
			this.tableLayoutPanelSetLastWriteDateFormat.AccessibleDescription = "Panel for the last write date preview format of the file";
			this.tableLayoutPanelSetLastWriteDateFormat.AccessibleName = "Last write date preview format panel";
			this.tableLayoutPanelSetLastWriteDateFormat.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.tableLayoutPanelSetLastWriteDateFormat.ColumnCount = 2;
			this.tableLayoutPanelSetLastWriteDateFormat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelSetLastWriteDateFormat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelSetLastWriteDateFormat.Controls.Add(this.radioButtonNewLastWriteDateUtc, 1, 0);
			this.tableLayoutPanelSetLastWriteDateFormat.Controls.Add(this.radioButtonNewLastWriteDateLocalTime, 0, 0);
			this.tableLayoutPanelSetLastWriteDateFormat.Location = new System.Drawing.Point(351, 42);
			this.tableLayoutPanelSetLastWriteDateFormat.Name = "tableLayoutPanelSetLastWriteDateFormat";
			this.tableLayoutPanelSetLastWriteDateFormat.RowCount = 1;
			this.tableLayoutPanelSetLastWriteDateFormat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelSetLastWriteDateFormat.Size = new System.Drawing.Size(147, 23);
			this.tableLayoutPanelSetLastWriteDateFormat.TabIndex = 8;
			// 
			// tableLayoutPanelSetLastAccessDateFormat
			// 
			this.tableLayoutPanelSetLastAccessDateFormat.AccessibleDescription = "Panel for the last access date preview format of the file";
			this.tableLayoutPanelSetLastAccessDateFormat.AccessibleName = "Last access date preview format panel";
			this.tableLayoutPanelSetLastAccessDateFormat.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.tableLayoutPanelSetLastAccessDateFormat.ColumnCount = 2;
			this.tableLayoutPanelSetLastAccessDateFormat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelSetLastAccessDateFormat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelSetLastAccessDateFormat.Controls.Add(this.radioButtonNewLastAccessDateUtc, 1, 0);
			this.tableLayoutPanelSetLastAccessDateFormat.Controls.Add(this.radioButtonNewLastAccessDateLocalTime, 0, 0);
			this.tableLayoutPanelSetLastAccessDateFormat.Location = new System.Drawing.Point(177, 42);
			this.tableLayoutPanelSetLastAccessDateFormat.Name = "tableLayoutPanelSetLastAccessDateFormat";
			this.tableLayoutPanelSetLastAccessDateFormat.RowCount = 1;
			this.tableLayoutPanelSetLastAccessDateFormat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelSetLastAccessDateFormat.Size = new System.Drawing.Size(147, 23);
			this.tableLayoutPanelSetLastAccessDateFormat.TabIndex = 5;
			// 
			// labelNewWriteDate
			// 
			this.labelNewWriteDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelNewWriteDate.AutoSize = true;
			this.labelNewWriteDate.Enabled = false;
			this.labelNewWriteDate.Location = new System.Drawing.Point(351, 0);
			this.labelNewWriteDate.Name = "labelNewWriteDate";
			this.labelNewWriteDate.Size = new System.Drawing.Size(168, 13);
			this.labelNewWriteDate.TabIndex = 6;
			this.labelNewWriteDate.Text = "Set new write date (&6):";
			this.labelNewWriteDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.labelNewWriteDate.Enter += new System.EventHandler(this.SetStatusLabelForLabel);
			this.labelNewWriteDate.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.labelNewWriteDate.MouseEnter += new System.EventHandler(this.SetStatusLabelForLabel);
			this.labelNewWriteDate.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// labelNewAccessDate
			// 
			this.labelNewAccessDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelNewAccessDate.AutoSize = true;
			this.labelNewAccessDate.Enabled = false;
			this.labelNewAccessDate.Location = new System.Drawing.Point(177, 0);
			this.labelNewAccessDate.Name = "labelNewAccessDate";
			this.labelNewAccessDate.Size = new System.Drawing.Size(168, 13);
			this.labelNewAccessDate.TabIndex = 3;
			this.labelNewAccessDate.Text = "Set new access date (&5):";
			this.labelNewAccessDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.labelNewAccessDate.Enter += new System.EventHandler(this.SetStatusLabelForLabel);
			this.labelNewAccessDate.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.labelNewAccessDate.MouseEnter += new System.EventHandler(this.SetStatusLabelForLabel);
			this.labelNewAccessDate.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// tableLayoutPanelSetCreationDateFormat
			// 
			this.tableLayoutPanelSetCreationDateFormat.AccessibleDescription = "Panel for the creation date preview format of the file";
			this.tableLayoutPanelSetCreationDateFormat.AccessibleName = "Creation date preview format panel";
			this.tableLayoutPanelSetCreationDateFormat.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.tableLayoutPanelSetCreationDateFormat.ColumnCount = 2;
			this.tableLayoutPanelSetCreationDateFormat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelSetCreationDateFormat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelSetCreationDateFormat.Controls.Add(this.radioButtonNewCreationDateUtc, 1, 0);
			this.tableLayoutPanelSetCreationDateFormat.Controls.Add(this.radioButtonNewCreationDateLocalTime, 0, 0);
			this.tableLayoutPanelSetCreationDateFormat.Location = new System.Drawing.Point(3, 42);
			this.tableLayoutPanelSetCreationDateFormat.Name = "tableLayoutPanelSetCreationDateFormat";
			this.tableLayoutPanelSetCreationDateFormat.RowCount = 1;
			this.tableLayoutPanelSetCreationDateFormat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelSetCreationDateFormat.Size = new System.Drawing.Size(147, 23);
			this.tableLayoutPanelSetCreationDateFormat.TabIndex = 2;
			// 
			// panelButtons
			// 
			this.panelButtons.AccessibleDescription = "Panel for buttons";
			this.panelButtons.AccessibleName = "Button panel";
			this.panelButtons.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.panelButtons.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelButtons.Controls.Add(this.buttonClose);
			this.panelButtons.Controls.Add(this.buttonInfo);
			this.panelButtons.Controls.Add(this.buttonApply);
			this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelButtons.Location = new System.Drawing.Point(0, 182);
			this.panelButtons.Name = "panelButtons";
			this.panelButtons.Size = new System.Drawing.Size(546, 49);
			this.panelButtons.TabIndex = 11;
			// 
			// tableLayoutPanelGetDate
			// 
			this.tableLayoutPanelGetDate.AccessibleDescription = "Panel for the date of the file";
			this.tableLayoutPanelGetDate.AccessibleName = "Date Panel";
			this.tableLayoutPanelGetDate.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.tableLayoutPanelGetDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanelGetDate.ColumnCount = 3;
			this.tableLayoutPanelGetDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelGetDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelGetDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelGetDate.Controls.Add(this.tableLayoutPanelGetLastWriteDateFormat, 2, 2);
			this.tableLayoutPanelGetDate.Controls.Add(this.tableLayoutPanelGetCreationDateFormat, 0, 2);
			this.tableLayoutPanelGetDate.Controls.Add(this.labelCreationDate, 0, 0);
			this.tableLayoutPanelGetDate.Controls.Add(this.labelLastAccessDate, 1, 0);
			this.tableLayoutPanelGetDate.Controls.Add(this.textBoxLastWriteDate, 2, 1);
			this.tableLayoutPanelGetDate.Controls.Add(this.labelLastWriteDate, 2, 0);
			this.tableLayoutPanelGetDate.Controls.Add(this.textBoxLastAccessDate, 1, 1);
			this.tableLayoutPanelGetDate.Controls.Add(this.textBoxCreationDate, 0, 1);
			this.tableLayoutPanelGetDate.Controls.Add(this.tableLayoutPanelGetLastAccessDateFormat, 1, 2);
			this.tableLayoutPanelGetDate.Location = new System.Drawing.Point(12, 36);
			this.tableLayoutPanelGetDate.Name = "tableLayoutPanelGetDate";
			this.tableLayoutPanelGetDate.RowCount = 3;
			this.tableLayoutPanelGetDate.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelGetDate.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelGetDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanelGetDate.Size = new System.Drawing.Size(522, 70);
			this.tableLayoutPanelGetDate.TabIndex = 9;
			// 
			// tableLayoutPanelGetLastWriteDateFormat
			// 
			this.tableLayoutPanelGetLastWriteDateFormat.AccessibleDescription = "Panel for the last write date format of the file";
			this.tableLayoutPanelGetLastWriteDateFormat.AccessibleName = "Last write date format Panel";
			this.tableLayoutPanelGetLastWriteDateFormat.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.tableLayoutPanelGetLastWriteDateFormat.ColumnCount = 2;
			this.tableLayoutPanelGetLastWriteDateFormat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelGetLastWriteDateFormat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelGetLastWriteDateFormat.Controls.Add(this.radioButtonLastWriteDateUtc, 1, 0);
			this.tableLayoutPanelGetLastWriteDateFormat.Controls.Add(this.radioButtonLastWriteDateLocalTime, 0, 0);
			this.tableLayoutPanelGetLastWriteDateFormat.Location = new System.Drawing.Point(351, 42);
			this.tableLayoutPanelGetLastWriteDateFormat.Name = "tableLayoutPanelGetLastWriteDateFormat";
			this.tableLayoutPanelGetLastWriteDateFormat.RowCount = 1;
			this.tableLayoutPanelGetLastWriteDateFormat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelGetLastWriteDateFormat.Size = new System.Drawing.Size(147, 25);
			this.tableLayoutPanelGetLastWriteDateFormat.TabIndex = 8;
			// 
			// tableLayoutPanelGetCreationDateFormat
			// 
			this.tableLayoutPanelGetCreationDateFormat.AccessibleDescription = "Panel for the creation date format of the file";
			this.tableLayoutPanelGetCreationDateFormat.AccessibleName = "Creation date format panel";
			this.tableLayoutPanelGetCreationDateFormat.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.tableLayoutPanelGetCreationDateFormat.ColumnCount = 2;
			this.tableLayoutPanelGetCreationDateFormat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelGetCreationDateFormat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelGetCreationDateFormat.Controls.Add(this.radioButtonCreationDateUtc, 1, 0);
			this.tableLayoutPanelGetCreationDateFormat.Controls.Add(this.radioButtonCreationDateLocalTime, 0, 0);
			this.tableLayoutPanelGetCreationDateFormat.Location = new System.Drawing.Point(3, 42);
			this.tableLayoutPanelGetCreationDateFormat.Name = "tableLayoutPanelGetCreationDateFormat";
			this.tableLayoutPanelGetCreationDateFormat.RowCount = 1;
			this.tableLayoutPanelGetCreationDateFormat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelGetCreationDateFormat.Size = new System.Drawing.Size(147, 25);
			this.tableLayoutPanelGetCreationDateFormat.TabIndex = 2;
			// 
			// labelCreationDate
			// 
			this.labelCreationDate.AccessibleDescription = "Indicate the show the creation date of the file";
			this.labelCreationDate.AccessibleName = "Creation date";
			this.labelCreationDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelCreationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelCreationDate.AutoSize = true;
			this.labelCreationDate.Location = new System.Drawing.Point(3, 0);
			this.labelCreationDate.Name = "labelCreationDate";
			this.labelCreationDate.Size = new System.Drawing.Size(168, 13);
			this.labelCreationDate.TabIndex = 0;
			this.labelCreationDate.Text = "Creation date (&1):";
			this.labelCreationDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.labelCreationDate.Enter += new System.EventHandler(this.SetStatusLabelForLabel);
			this.labelCreationDate.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.labelCreationDate.MouseEnter += new System.EventHandler(this.SetStatusLabelForLabel);
			this.labelCreationDate.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// labelLastAccessDate
			// 
			this.labelLastAccessDate.AccessibleDescription = "Indicate the show the last access date of the file";
			this.labelLastAccessDate.AccessibleName = "Last access date";
			this.labelLastAccessDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLastAccessDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelLastAccessDate.AutoSize = true;
			this.labelLastAccessDate.Location = new System.Drawing.Point(177, 0);
			this.labelLastAccessDate.Name = "labelLastAccessDate";
			this.labelLastAccessDate.Size = new System.Drawing.Size(168, 13);
			this.labelLastAccessDate.TabIndex = 3;
			this.labelLastAccessDate.Text = "Last access date (&2):";
			this.labelLastAccessDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.labelLastAccessDate.Enter += new System.EventHandler(this.SetStatusLabelForLabel);
			this.labelLastAccessDate.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.labelLastAccessDate.MouseEnter += new System.EventHandler(this.SetStatusLabelForLabel);
			this.labelLastAccessDate.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// labelLastWriteDate
			// 
			this.labelLastWriteDate.AccessibleDescription = "Indicate the show the last write date of the file";
			this.labelLastWriteDate.AccessibleName = "Last write date";
			this.labelLastWriteDate.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelLastWriteDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelLastWriteDate.AutoSize = true;
			this.labelLastWriteDate.Location = new System.Drawing.Point(351, 0);
			this.labelLastWriteDate.Name = "labelLastWriteDate";
			this.labelLastWriteDate.Size = new System.Drawing.Size(168, 13);
			this.labelLastWriteDate.TabIndex = 6;
			this.labelLastWriteDate.Text = "Last write date (&3):";
			this.labelLastWriteDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.labelLastWriteDate.Enter += new System.EventHandler(this.SetStatusLabelForLabel);
			this.labelLastWriteDate.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.labelLastWriteDate.MouseEnter += new System.EventHandler(this.SetStatusLabelForLabel);
			this.labelLastWriteDate.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// tableLayoutPanelGetLastAccessDateFormat
			// 
			this.tableLayoutPanelGetLastAccessDateFormat.AccessibleDescription = "Panel for the last access date format of the file";
			this.tableLayoutPanelGetLastAccessDateFormat.AccessibleName = "Last access date format panel";
			this.tableLayoutPanelGetLastAccessDateFormat.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.tableLayoutPanelGetLastAccessDateFormat.ColumnCount = 2;
			this.tableLayoutPanelGetLastAccessDateFormat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelGetLastAccessDateFormat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelGetLastAccessDateFormat.Controls.Add(this.radioButtonLastAccessDateUtc, 1, 0);
			this.tableLayoutPanelGetLastAccessDateFormat.Controls.Add(this.radioButtonLastAccessDateLocalTime, 0, 0);
			this.tableLayoutPanelGetLastAccessDateFormat.Location = new System.Drawing.Point(177, 42);
			this.tableLayoutPanelGetLastAccessDateFormat.Name = "tableLayoutPanelGetLastAccessDateFormat";
			this.tableLayoutPanelGetLastAccessDateFormat.RowCount = 1;
			this.tableLayoutPanelGetLastAccessDateFormat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelGetLastAccessDateFormat.Size = new System.Drawing.Size(147, 25);
			this.tableLayoutPanelGetLastAccessDateFormat.TabIndex = 5;
			// 
			// labelPath
			// 
			this.labelPath.AccessibleDescription = "Inidicate to show the full path name";
			this.labelPath.AccessibleName = "Path";
			this.labelPath.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelPath.AutoSize = true;
			this.labelPath.Location = new System.Drawing.Point(9, 14);
			this.labelPath.Name = "labelPath";
			this.labelPath.Size = new System.Drawing.Size(32, 13);
			this.labelPath.TabIndex = 6;
			this.labelPath.Text = "&Path:";
			this.labelPath.Enter += new System.EventHandler(this.SetStatusLabelForLabel);
			this.labelPath.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.labelPath.MouseEnter += new System.EventHandler(this.SetStatusLabelForLabel);
			this.labelPath.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// buttonClose
			// 
			this.buttonClose.AccessibleDescription = "Close the application";
			this.buttonClose.AccessibleName = "Exit Button";
			this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonClose.Image = global::FileDateTime_Manipulator.Properties.Resources.door_in;
			this.buttonClose.Location = new System.Drawing.Point(464, 12);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(67, 23);
			this.buttonClose.TabIndex = 2;
			this.buttonClose.Text = "&Close";
			this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonClose, "Close the application");
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
			this.buttonClose.Enter += new System.EventHandler(this.SetStatusLabelForButton);
			this.buttonClose.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.buttonClose.MouseEnter += new System.EventHandler(this.SetStatusLabelForButton);
			this.buttonClose.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// buttonInfo
			// 
			this.buttonInfo.AccessibleDescription = "Show some information";
			this.buttonInfo.AccessibleName = "Info button";
			this.buttonInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonInfo.Image = global::FileDateTime_Manipulator.Properties.Resources.information;
			this.buttonInfo.Location = new System.Drawing.Point(11, 12);
			this.buttonInfo.Name = "buttonInfo";
			this.buttonInfo.Size = new System.Drawing.Size(67, 23);
			this.buttonInfo.TabIndex = 0;
			this.buttonInfo.Text = "&Info";
			this.buttonInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonInfo, "Show some information");
			this.buttonInfo.UseVisualStyleBackColor = true;
			this.buttonInfo.Click += new System.EventHandler(this.ButtonInfo_Click);
			this.buttonInfo.Enter += new System.EventHandler(this.SetStatusLabelForButton);
			this.buttonInfo.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.buttonInfo.MouseEnter += new System.EventHandler(this.SetStatusLabelForButton);
			this.buttonInfo.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// buttonApply
			// 
			this.buttonApply.AccessibleDescription = "Apply the changes";
			this.buttonApply.AccessibleName = "Apply button";
			this.buttonApply.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonApply.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonApply.Enabled = false;
			this.buttonApply.Image = global::FileDateTime_Manipulator.Properties.Resources.tick_button;
			this.buttonApply.Location = new System.Drawing.Point(239, 12);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(67, 23);
			this.buttonApply.TabIndex = 1;
			this.buttonApply.Text = "&Apply";
			this.buttonApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonApply, "Apply the changes");
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.ButtonApply_Click);
			this.buttonApply.Enter += new System.EventHandler(this.SetStatusLabelForButton);
			this.buttonApply.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.buttonApply.MouseEnter += new System.EventHandler(this.SetStatusLabelForButton);
			this.buttonApply.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// buttonSelectFile
			// 
			this.buttonSelectFile.AccessibleDescription = "Click to selected a file";
			this.buttonSelectFile.AccessibleName = "Select file";
			this.buttonSelectFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonSelectFile.AllowDrop = true;
			this.buttonSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSelectFile.Image = global::FileDateTime_Manipulator.Properties.Resources.page_white;
			this.buttonSelectFile.Location = new System.Drawing.Point(447, 9);
			this.buttonSelectFile.Name = "buttonSelectFile";
			this.buttonSelectFile.Size = new System.Drawing.Size(84, 23);
			this.buttonSelectFile.TabIndex = 8;
			this.buttonSelectFile.Text = "&Select file";
			this.buttonSelectFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonSelectFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonSelectFile, "Click to selected a file");
			this.buttonSelectFile.UseVisualStyleBackColor = true;
			this.buttonSelectFile.Click += new System.EventHandler(this.ButtonSelectFile_Click);
			this.buttonSelectFile.Enter += new System.EventHandler(this.SetStatusLabelForButton);
			this.buttonSelectFile.Leave += new System.EventHandler(this.ClearStatusLabel);
			this.buttonSelectFile.MouseEnter += new System.EventHandler(this.SetStatusLabelForButton);
			this.buttonSelectFile.MouseLeave += new System.EventHandler(this.ClearStatusLabel);
			// 
			// FdtmForm
			// 
			this.AccessibleDescription = "Application";
			this.AccessibleName = "Application";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(546, 253);
			this.Controls.Add(this.toolStripContainer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FdtmForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FileDateTime Manipulator (FDTM)";
			this.Load += new System.EventHandler(this.FdtmForm_Load);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.ContentPanel.PerformLayout();
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.tableLayoutPanelSetDate.ResumeLayout(false);
			this.tableLayoutPanelSetDate.PerformLayout();
			this.tableLayoutPanelSetLastWriteDateFormat.ResumeLayout(false);
			this.tableLayoutPanelSetLastWriteDateFormat.PerformLayout();
			this.tableLayoutPanelSetLastAccessDateFormat.ResumeLayout(false);
			this.tableLayoutPanelSetLastAccessDateFormat.PerformLayout();
			this.tableLayoutPanelSetCreationDateFormat.ResumeLayout(false);
			this.tableLayoutPanelSetCreationDateFormat.PerformLayout();
			this.panelButtons.ResumeLayout(false);
			this.tableLayoutPanelGetDate.ResumeLayout(false);
			this.tableLayoutPanelGetDate.PerformLayout();
			this.tableLayoutPanelGetLastWriteDateFormat.ResumeLayout(false);
			this.tableLayoutPanelGetLastWriteDateFormat.PerformLayout();
			this.tableLayoutPanelGetCreationDateFormat.ResumeLayout(false);
			this.tableLayoutPanelGetCreationDateFormat.PerformLayout();
			this.tableLayoutPanelGetLastAccessDateFormat.ResumeLayout(false);
			this.tableLayoutPanelGetLastAccessDateFormat.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSetDate;
		private System.Windows.Forms.Label labelNewCreationDate;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSetLastWriteDateFormat;
		private System.Windows.Forms.RadioButton radioButtonNewLastWriteDateUtc;
		private System.Windows.Forms.RadioButton radioButtonNewLastWriteDateLocalTime;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSetLastAccessDateFormat;
		private System.Windows.Forms.RadioButton radioButtonNewLastAccessDateUtc;
		private System.Windows.Forms.RadioButton radioButtonNewLastAccessDateLocalTime;
		private System.Windows.Forms.DateTimePicker dateTimePickerWrited;
		private System.Windows.Forms.DateTimePicker dateTimePickerAccessed;
		private System.Windows.Forms.DateTimePicker dateTimePickerCreated;
		private System.Windows.Forms.Label labelNewWriteDate;
		private System.Windows.Forms.Label labelNewAccessDate;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSetCreationDateFormat;
		private System.Windows.Forms.RadioButton radioButtonNewCreationDateUtc;
		private System.Windows.Forms.RadioButton radioButtonNewCreationDateLocalTime;
		private System.Windows.Forms.Panel panelButtons;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Button buttonInfo;
		private System.Windows.Forms.Button buttonApply;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGetDate;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGetLastWriteDateFormat;
		private System.Windows.Forms.RadioButton radioButtonLastWriteDateUtc;
		private System.Windows.Forms.RadioButton radioButtonLastWriteDateLocalTime;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGetCreationDateFormat;
		private System.Windows.Forms.RadioButton radioButtonCreationDateUtc;
		private System.Windows.Forms.RadioButton radioButtonCreationDateLocalTime;
		private System.Windows.Forms.Label labelCreationDate;
		private System.Windows.Forms.Label labelLastAccessDate;
		private System.Windows.Forms.TextBox textBoxLastWriteDate;
		private System.Windows.Forms.Label labelLastWriteDate;
		private System.Windows.Forms.TextBox textBoxLastAccessDate;
		private System.Windows.Forms.TextBox textBoxCreationDate;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGetLastAccessDateFormat;
		private System.Windows.Forms.RadioButton radioButtonLastAccessDateUtc;
		private System.Windows.Forms.RadioButton radioButtonLastAccessDateLocalTime;
		private System.Windows.Forms.Button buttonSelectFile;
		private System.Windows.Forms.TextBox textBoxPath;
		private System.Windows.Forms.Label labelPath;
	}
}

