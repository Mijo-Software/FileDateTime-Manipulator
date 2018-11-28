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
			this.tableLayoutPanelSetDate = new System.Windows.Forms.TableLayoutPanel();
			this.numericUpDownWriteDateSecond = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownAccessDateSecond = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownWriteDateMinute = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownAccessDateMinute = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownWriteDateHour = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownAccessDateHour = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownCreationDateHour = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownCreationDateMinute = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownCreationDateSecond = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownWriteDateDay = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownAccessDateDay = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownCreationDateDay = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownWriteDateMonth = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownAccessDateMonth = new System.Windows.Forms.NumericUpDown();
			this.h = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDownWriteDateYear = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownAccessDateYear = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownCreationDateYear = new System.Windows.Forms.NumericUpDown();
			this.labelNewWriteDate = new System.Windows.Forms.Label();
			this.labelNewAccessDate = new System.Windows.Forms.Label();
			this.labelNewCreationDate = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.m = new System.Windows.Forms.Label();
			this.numericUpDownCreationDateMonth = new System.Windows.Forms.NumericUpDown();
			this.tableLayoutPanelDate = new System.Windows.Forms.TableLayoutPanel();
			this.panelButtons = new System.Windows.Forms.Panel();
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonInfo = new System.Windows.Forms.Button();
			this.buttonApply = new System.Windows.Forms.Button();
			this.tableLayoutPanelSetDate.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWriteDateSecond)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccessDateSecond)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWriteDateMinute)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccessDateMinute)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWriteDateHour)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccessDateHour)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreationDateHour)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreationDateMinute)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreationDateSecond)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWriteDateDay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccessDateDay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreationDateDay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWriteDateMonth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccessDateMonth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWriteDateYear)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccessDateYear)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreationDateYear)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreationDateMonth)).BeginInit();
			this.tableLayoutPanelDate.SuspendLayout();
			this.panelButtons.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelPath
			// 
			this.labelPath.AutoSize = true;
			this.labelPath.Location = new System.Drawing.Point(9, 10);
			this.labelPath.Name = "labelPath";
			this.labelPath.Size = new System.Drawing.Size(26, 13);
			this.labelPath.TabIndex = 0;
			this.labelPath.Text = "&File:";
			// 
			// textBoxPath
			// 
			this.textBoxPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxPath.Location = new System.Drawing.Point(41, 6);
			this.textBoxPath.Name = "textBoxPath";
			this.textBoxPath.ReadOnly = true;
			this.textBoxPath.Size = new System.Drawing.Size(323, 20);
			this.textBoxPath.TabIndex = 1;
			// 
			// buttonSelectFile
			// 
			this.buttonSelectFile.Location = new System.Drawing.Point(370, 6);
			this.buttonSelectFile.Name = "buttonSelectFile";
			this.buttonSelectFile.Size = new System.Drawing.Size(63, 20);
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
			this.labelCreationDate.Size = new System.Drawing.Size(134, 13);
			this.labelCreationDate.TabIndex = 0;
			this.labelCreationDate.Text = "Creation date (&1):";
			this.labelCreationDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelLastAccessDate
			// 
			this.labelLastAccessDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelLastAccessDate.AutoSize = true;
			this.labelLastAccessDate.Location = new System.Drawing.Point(143, 0);
			this.labelLastAccessDate.Name = "labelLastAccessDate";
			this.labelLastAccessDate.Size = new System.Drawing.Size(134, 13);
			this.labelLastAccessDate.TabIndex = 2;
			this.labelLastAccessDate.Text = "Last access date (&2):";
			this.labelLastAccessDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelLastWriteDate
			// 
			this.labelLastWriteDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelLastWriteDate.AutoSize = true;
			this.labelLastWriteDate.Location = new System.Drawing.Point(283, 0);
			this.labelLastWriteDate.Name = "labelLastWriteDate";
			this.labelLastWriteDate.Size = new System.Drawing.Size(135, 13);
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
			this.textBoxCreationDate.Size = new System.Drawing.Size(134, 20);
			this.textBoxCreationDate.TabIndex = 1;
			this.textBoxCreationDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBoxLastAccessDate
			// 
			this.textBoxLastAccessDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxLastAccessDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxLastAccessDate.Location = new System.Drawing.Point(143, 16);
			this.textBoxLastAccessDate.Name = "textBoxLastAccessDate";
			this.textBoxLastAccessDate.ReadOnly = true;
			this.textBoxLastAccessDate.Size = new System.Drawing.Size(134, 20);
			this.textBoxLastAccessDate.TabIndex = 3;
			this.textBoxLastAccessDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBoxLastWriteDate
			// 
			this.textBoxLastWriteDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxLastWriteDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxLastWriteDate.Location = new System.Drawing.Point(283, 16);
			this.textBoxLastWriteDate.Name = "textBoxLastWriteDate";
			this.textBoxLastWriteDate.ReadOnly = true;
			this.textBoxLastWriteDate.Size = new System.Drawing.Size(135, 20);
			this.textBoxLastWriteDate.TabIndex = 5;
			this.textBoxLastWriteDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = "all files|*.*";
			// 
			// tableLayoutPanelSetDate
			// 
			this.tableLayoutPanelSetDate.ColumnCount = 8;
			this.tableLayoutPanelSetDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelSetDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelSetDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelSetDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelSetDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelSetDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelSetDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelSetDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelSetDate.Controls.Add(this.numericUpDownWriteDateSecond, 7, 3);
			this.tableLayoutPanelSetDate.Controls.Add(this.numericUpDownAccessDateSecond, 7, 2);
			this.tableLayoutPanelSetDate.Controls.Add(this.numericUpDownWriteDateMinute, 6, 3);
			this.tableLayoutPanelSetDate.Controls.Add(this.numericUpDownAccessDateMinute, 6, 2);
			this.tableLayoutPanelSetDate.Controls.Add(this.numericUpDownWriteDateHour, 5, 3);
			this.tableLayoutPanelSetDate.Controls.Add(this.numericUpDownAccessDateHour, 5, 2);
			this.tableLayoutPanelSetDate.Controls.Add(this.numericUpDownCreationDateHour, 5, 1);
			this.tableLayoutPanelSetDate.Controls.Add(this.numericUpDownCreationDateMinute, 6, 1);
			this.tableLayoutPanelSetDate.Controls.Add(this.numericUpDownCreationDateSecond, 7, 1);
			this.tableLayoutPanelSetDate.Controls.Add(this.numericUpDownWriteDateDay, 3, 3);
			this.tableLayoutPanelSetDate.Controls.Add(this.numericUpDownAccessDateDay, 3, 2);
			this.tableLayoutPanelSetDate.Controls.Add(this.numericUpDownCreationDateDay, 3, 1);
			this.tableLayoutPanelSetDate.Controls.Add(this.numericUpDownWriteDateMonth, 2, 3);
			this.tableLayoutPanelSetDate.Controls.Add(this.numericUpDownAccessDateMonth, 2, 2);
			this.tableLayoutPanelSetDate.Controls.Add(this.h, 5, 0);
			this.tableLayoutPanelSetDate.Controls.Add(this.label3, 3, 0);
			this.tableLayoutPanelSetDate.Controls.Add(this.label1, 1, 0);
			this.tableLayoutPanelSetDate.Controls.Add(this.numericUpDownWriteDateYear, 1, 3);
			this.tableLayoutPanelSetDate.Controls.Add(this.numericUpDownAccessDateYear, 1, 2);
			this.tableLayoutPanelSetDate.Controls.Add(this.numericUpDownCreationDateYear, 1, 1);
			this.tableLayoutPanelSetDate.Controls.Add(this.labelNewWriteDate, 0, 3);
			this.tableLayoutPanelSetDate.Controls.Add(this.labelNewAccessDate, 0, 2);
			this.tableLayoutPanelSetDate.Controls.Add(this.labelNewCreationDate, 0, 1);
			this.tableLayoutPanelSetDate.Controls.Add(this.label2, 2, 0);
			this.tableLayoutPanelSetDate.Controls.Add(this.label4, 7, 0);
			this.tableLayoutPanelSetDate.Controls.Add(this.m, 6, 0);
			this.tableLayoutPanelSetDate.Controls.Add(this.numericUpDownCreationDateMonth, 2, 1);
			this.tableLayoutPanelSetDate.Location = new System.Drawing.Point(12, 78);
			this.tableLayoutPanelSetDate.Name = "tableLayoutPanelSetDate";
			this.tableLayoutPanelSetDate.RowCount = 4;
			this.tableLayoutPanelSetDate.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelSetDate.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelSetDate.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelSetDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelSetDate.Size = new System.Drawing.Size(431, 92);
			this.tableLayoutPanelSetDate.TabIndex = 3;
			// 
			// numericUpDownWriteDateSecond
			// 
			this.numericUpDownWriteDateSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDownWriteDateSecond.Enabled = false;
			this.numericUpDownWriteDateSecond.Location = new System.Drawing.Point(381, 68);
			this.numericUpDownWriteDateSecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.numericUpDownWriteDateSecond.Name = "numericUpDownWriteDateSecond";
			this.numericUpDownWriteDateSecond.Size = new System.Drawing.Size(40, 20);
			this.numericUpDownWriteDateSecond.TabIndex = 26;
			this.numericUpDownWriteDateSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// numericUpDownAccessDateSecond
			// 
			this.numericUpDownAccessDateSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDownAccessDateSecond.Enabled = false;
			this.numericUpDownAccessDateSecond.Location = new System.Drawing.Point(381, 42);
			this.numericUpDownAccessDateSecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.numericUpDownAccessDateSecond.Name = "numericUpDownAccessDateSecond";
			this.numericUpDownAccessDateSecond.Size = new System.Drawing.Size(40, 20);
			this.numericUpDownAccessDateSecond.TabIndex = 19;
			this.numericUpDownAccessDateSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// numericUpDownWriteDateMinute
			// 
			this.numericUpDownWriteDateMinute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDownWriteDateMinute.Enabled = false;
			this.numericUpDownWriteDateMinute.Location = new System.Drawing.Point(335, 68);
			this.numericUpDownWriteDateMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.numericUpDownWriteDateMinute.Name = "numericUpDownWriteDateMinute";
			this.numericUpDownWriteDateMinute.Size = new System.Drawing.Size(40, 20);
			this.numericUpDownWriteDateMinute.TabIndex = 25;
			this.numericUpDownWriteDateMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// numericUpDownAccessDateMinute
			// 
			this.numericUpDownAccessDateMinute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDownAccessDateMinute.Enabled = false;
			this.numericUpDownAccessDateMinute.Location = new System.Drawing.Point(335, 42);
			this.numericUpDownAccessDateMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.numericUpDownAccessDateMinute.Name = "numericUpDownAccessDateMinute";
			this.numericUpDownAccessDateMinute.Size = new System.Drawing.Size(40, 20);
			this.numericUpDownAccessDateMinute.TabIndex = 18;
			this.numericUpDownAccessDateMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// numericUpDownWriteDateHour
			// 
			this.numericUpDownWriteDateHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDownWriteDateHour.Enabled = false;
			this.numericUpDownWriteDateHour.Location = new System.Drawing.Point(289, 68);
			this.numericUpDownWriteDateHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
			this.numericUpDownWriteDateHour.Name = "numericUpDownWriteDateHour";
			this.numericUpDownWriteDateHour.Size = new System.Drawing.Size(40, 20);
			this.numericUpDownWriteDateHour.TabIndex = 24;
			this.numericUpDownWriteDateHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// numericUpDownAccessDateHour
			// 
			this.numericUpDownAccessDateHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDownAccessDateHour.Enabled = false;
			this.numericUpDownAccessDateHour.Location = new System.Drawing.Point(289, 42);
			this.numericUpDownAccessDateHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
			this.numericUpDownAccessDateHour.Name = "numericUpDownAccessDateHour";
			this.numericUpDownAccessDateHour.Size = new System.Drawing.Size(40, 20);
			this.numericUpDownAccessDateHour.TabIndex = 17;
			this.numericUpDownAccessDateHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// numericUpDownCreationDateHour
			// 
			this.numericUpDownCreationDateHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDownCreationDateHour.Enabled = false;
			this.numericUpDownCreationDateHour.Location = new System.Drawing.Point(289, 16);
			this.numericUpDownCreationDateHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
			this.numericUpDownCreationDateHour.Name = "numericUpDownCreationDateHour";
			this.numericUpDownCreationDateHour.Size = new System.Drawing.Size(40, 20);
			this.numericUpDownCreationDateHour.TabIndex = 10;
			this.numericUpDownCreationDateHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// numericUpDownCreationDateMinute
			// 
			this.numericUpDownCreationDateMinute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDownCreationDateMinute.Enabled = false;
			this.numericUpDownCreationDateMinute.Location = new System.Drawing.Point(335, 16);
			this.numericUpDownCreationDateMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.numericUpDownCreationDateMinute.Name = "numericUpDownCreationDateMinute";
			this.numericUpDownCreationDateMinute.Size = new System.Drawing.Size(40, 20);
			this.numericUpDownCreationDateMinute.TabIndex = 11;
			this.numericUpDownCreationDateMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// numericUpDownCreationDateSecond
			// 
			this.numericUpDownCreationDateSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDownCreationDateSecond.Enabled = false;
			this.numericUpDownCreationDateSecond.Location = new System.Drawing.Point(381, 16);
			this.numericUpDownCreationDateSecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.numericUpDownCreationDateSecond.Name = "numericUpDownCreationDateSecond";
			this.numericUpDownCreationDateSecond.Size = new System.Drawing.Size(40, 20);
			this.numericUpDownCreationDateSecond.TabIndex = 12;
			this.numericUpDownCreationDateSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// numericUpDownWriteDateDay
			// 
			this.numericUpDownWriteDateDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDownWriteDateDay.Enabled = false;
			this.numericUpDownWriteDateDay.Location = new System.Drawing.Point(243, 68);
			this.numericUpDownWriteDateDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
			this.numericUpDownWriteDateDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownWriteDateDay.Name = "numericUpDownWriteDateDay";
			this.numericUpDownWriteDateDay.Size = new System.Drawing.Size(40, 20);
			this.numericUpDownWriteDateDay.TabIndex = 23;
			this.numericUpDownWriteDateDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownWriteDateDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numericUpDownAccessDateDay
			// 
			this.numericUpDownAccessDateDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDownAccessDateDay.Enabled = false;
			this.numericUpDownAccessDateDay.Location = new System.Drawing.Point(243, 42);
			this.numericUpDownAccessDateDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
			this.numericUpDownAccessDateDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownAccessDateDay.Name = "numericUpDownAccessDateDay";
			this.numericUpDownAccessDateDay.Size = new System.Drawing.Size(40, 20);
			this.numericUpDownAccessDateDay.TabIndex = 16;
			this.numericUpDownAccessDateDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownAccessDateDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numericUpDownCreationDateDay
			// 
			this.numericUpDownCreationDateDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDownCreationDateDay.Enabled = false;
			this.numericUpDownCreationDateDay.Location = new System.Drawing.Point(243, 16);
			this.numericUpDownCreationDateDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
			this.numericUpDownCreationDateDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownCreationDateDay.Name = "numericUpDownCreationDateDay";
			this.numericUpDownCreationDateDay.Size = new System.Drawing.Size(40, 20);
			this.numericUpDownCreationDateDay.TabIndex = 9;
			this.numericUpDownCreationDateDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownCreationDateDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numericUpDownWriteDateMonth
			// 
			this.numericUpDownWriteDateMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDownWriteDateMonth.Enabled = false;
			this.numericUpDownWriteDateMonth.Location = new System.Drawing.Point(197, 68);
			this.numericUpDownWriteDateMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
			this.numericUpDownWriteDateMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownWriteDateMonth.Name = "numericUpDownWriteDateMonth";
			this.numericUpDownWriteDateMonth.Size = new System.Drawing.Size(40, 20);
			this.numericUpDownWriteDateMonth.TabIndex = 22;
			this.numericUpDownWriteDateMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownWriteDateMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numericUpDownAccessDateMonth
			// 
			this.numericUpDownAccessDateMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDownAccessDateMonth.Enabled = false;
			this.numericUpDownAccessDateMonth.Location = new System.Drawing.Point(197, 42);
			this.numericUpDownAccessDateMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
			this.numericUpDownAccessDateMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownAccessDateMonth.Name = "numericUpDownAccessDateMonth";
			this.numericUpDownAccessDateMonth.Size = new System.Drawing.Size(40, 20);
			this.numericUpDownAccessDateMonth.TabIndex = 15;
			this.numericUpDownAccessDateMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownAccessDateMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// h
			// 
			this.h.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.h.AutoSize = true;
			this.h.Location = new System.Drawing.Point(289, 0);
			this.h.Name = "h";
			this.h.Size = new System.Drawing.Size(40, 13);
			this.h.TabIndex = 3;
			this.h.Text = "h";
			this.h.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(243, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "D";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(138, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Y";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// numericUpDownWriteDateYear
			// 
			this.numericUpDownWriteDateYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDownWriteDateYear.Enabled = false;
			this.numericUpDownWriteDateYear.Location = new System.Drawing.Point(138, 68);
			this.numericUpDownWriteDateYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.numericUpDownWriteDateYear.Name = "numericUpDownWriteDateYear";
			this.numericUpDownWriteDateYear.Size = new System.Drawing.Size(53, 20);
			this.numericUpDownWriteDateYear.TabIndex = 21;
			this.numericUpDownWriteDateYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// numericUpDownAccessDateYear
			// 
			this.numericUpDownAccessDateYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDownAccessDateYear.Enabled = false;
			this.numericUpDownAccessDateYear.Location = new System.Drawing.Point(138, 42);
			this.numericUpDownAccessDateYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.numericUpDownAccessDateYear.Name = "numericUpDownAccessDateYear";
			this.numericUpDownAccessDateYear.Size = new System.Drawing.Size(53, 20);
			this.numericUpDownAccessDateYear.TabIndex = 14;
			this.numericUpDownAccessDateYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// numericUpDownCreationDateYear
			// 
			this.numericUpDownCreationDateYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDownCreationDateYear.Enabled = false;
			this.numericUpDownCreationDateYear.Location = new System.Drawing.Point(138, 16);
			this.numericUpDownCreationDateYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.numericUpDownCreationDateYear.Name = "numericUpDownCreationDateYear";
			this.numericUpDownCreationDateYear.Size = new System.Drawing.Size(53, 20);
			this.numericUpDownCreationDateYear.TabIndex = 7;
			this.numericUpDownCreationDateYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labelNewWriteDate
			// 
			this.labelNewWriteDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelNewWriteDate.AutoSize = true;
			this.labelNewWriteDate.Location = new System.Drawing.Point(3, 65);
			this.labelNewWriteDate.Name = "labelNewWriteDate";
			this.labelNewWriteDate.Size = new System.Drawing.Size(129, 27);
			this.labelNewWriteDate.TabIndex = 20;
			this.labelNewWriteDate.Text = "Set new write date (&6):";
			this.labelNewWriteDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelNewAccessDate
			// 
			this.labelNewAccessDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelNewAccessDate.AutoSize = true;
			this.labelNewAccessDate.Location = new System.Drawing.Point(3, 39);
			this.labelNewAccessDate.Name = "labelNewAccessDate";
			this.labelNewAccessDate.Size = new System.Drawing.Size(129, 26);
			this.labelNewAccessDate.TabIndex = 13;
			this.labelNewAccessDate.Text = "Set new access date (&5):";
			this.labelNewAccessDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelNewCreationDate
			// 
			this.labelNewCreationDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelNewCreationDate.AutoSize = true;
			this.labelNewCreationDate.Location = new System.Drawing.Point(3, 13);
			this.labelNewCreationDate.Name = "labelNewCreationDate";
			this.labelNewCreationDate.Size = new System.Drawing.Size(129, 26);
			this.labelNewCreationDate.TabIndex = 6;
			this.labelNewCreationDate.Text = "Set new creation date (&4):";
			this.labelNewCreationDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(197, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "M";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(381, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "s";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// m
			// 
			this.m.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.m.AutoSize = true;
			this.m.Location = new System.Drawing.Point(335, 0);
			this.m.Name = "m";
			this.m.Size = new System.Drawing.Size(40, 13);
			this.m.TabIndex = 4;
			this.m.Text = "m";
			this.m.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// numericUpDownCreationDateMonth
			// 
			this.numericUpDownCreationDateMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDownCreationDateMonth.Enabled = false;
			this.numericUpDownCreationDateMonth.Location = new System.Drawing.Point(197, 16);
			this.numericUpDownCreationDateMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
			this.numericUpDownCreationDateMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownCreationDateMonth.Name = "numericUpDownCreationDateMonth";
			this.numericUpDownCreationDateMonth.Size = new System.Drawing.Size(40, 20);
			this.numericUpDownCreationDateMonth.TabIndex = 8;
			this.numericUpDownCreationDateMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownCreationDateMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// tableLayoutPanelDate
			// 
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
			this.tableLayoutPanelDate.Size = new System.Drawing.Size(421, 40);
			this.tableLayoutPanelDate.TabIndex = 10;
			// 
			// panelButtons
			// 
			this.panelButtons.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelButtons.Controls.Add(this.buttonClose);
			this.panelButtons.Controls.Add(this.buttonInfo);
			this.panelButtons.Controls.Add(this.buttonApply);
			this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelButtons.Location = new System.Drawing.Point(0, 175);
			this.panelButtons.Name = "panelButtons";
			this.panelButtons.Size = new System.Drawing.Size(443, 49);
			this.panelButtons.TabIndex = 4;
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonClose.Location = new System.Drawing.Point(361, 12);
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
			this.buttonApply.Location = new System.Drawing.Point(187, 12);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(67, 23);
			this.buttonApply.TabIndex = 1;
			this.buttonApply.Text = "&Apply";
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.ButtonApply_Click);
			// 
			// FdtmForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(443, 224);
			this.Controls.Add(this.panelButtons);
			this.Controls.Add(this.tableLayoutPanelDate);
			this.Controls.Add(this.tableLayoutPanelSetDate);
			this.Controls.Add(this.buttonSelectFile);
			this.Controls.Add(this.textBoxPath);
			this.Controls.Add(this.labelPath);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FdtmForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FileDateTime Manipulator (FDTM)";
			this.Load += new System.EventHandler(this.FdtmForm_Load);
			this.tableLayoutPanelSetDate.ResumeLayout(false);
			this.tableLayoutPanelSetDate.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWriteDateSecond)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccessDateSecond)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWriteDateMinute)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccessDateMinute)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWriteDateHour)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccessDateHour)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreationDateHour)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreationDateMinute)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreationDateSecond)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWriteDateDay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccessDateDay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreationDateDay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWriteDateMonth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccessDateMonth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWriteDateYear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccessDateYear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreationDateYear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreationDateMonth)).EndInit();
			this.tableLayoutPanelDate.ResumeLayout(false);
			this.tableLayoutPanelDate.PerformLayout();
			this.panelButtons.ResumeLayout(false);
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
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSetDate;
		private System.Windows.Forms.Label labelNewWriteDate;
		private System.Windows.Forms.Label labelNewCreationDate;
		private System.Windows.Forms.Label labelNewAccessDate;
		private System.Windows.Forms.NumericUpDown numericUpDownCreationDateYear;
		private System.Windows.Forms.Label h;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDownWriteDateYear;
		private System.Windows.Forms.NumericUpDown numericUpDownAccessDateYear;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label m;
		private System.Windows.Forms.NumericUpDown numericUpDownCreationDateHour;
		private System.Windows.Forms.NumericUpDown numericUpDownCreationDateMinute;
		private System.Windows.Forms.NumericUpDown numericUpDownCreationDateSecond;
		private System.Windows.Forms.NumericUpDown numericUpDownWriteDateDay;
		private System.Windows.Forms.NumericUpDown numericUpDownAccessDateDay;
		private System.Windows.Forms.NumericUpDown numericUpDownCreationDateDay;
		private System.Windows.Forms.NumericUpDown numericUpDownWriteDateMonth;
		private System.Windows.Forms.NumericUpDown numericUpDownAccessDateMonth;
		private System.Windows.Forms.NumericUpDown numericUpDownCreationDateMonth;
		private System.Windows.Forms.NumericUpDown numericUpDownWriteDateSecond;
		private System.Windows.Forms.NumericUpDown numericUpDownAccessDateSecond;
		private System.Windows.Forms.NumericUpDown numericUpDownWriteDateMinute;
		private System.Windows.Forms.NumericUpDown numericUpDownAccessDateMinute;
		private System.Windows.Forms.NumericUpDown numericUpDownWriteDateHour;
		private System.Windows.Forms.NumericUpDown numericUpDownAccessDateHour;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDate;
		private System.Windows.Forms.Panel panelButtons;
		private System.Windows.Forms.Button buttonApply;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Button buttonInfo;
	}
}

