﻿namespace CLOC_Couter
{
	// Token: 0x0200000B RID: 11
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frmCounterLOC : global::System.Windows.Forms.Form
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00002D54 File Offset: 0x00000F54
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002DA4 File Offset: 0x00000FA4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.btnCount = new global::System.Windows.Forms.Button();
			this.GroupBox5 = new global::System.Windows.Forms.GroupBox();
			this.optSVN = new global::System.Windows.Forms.RadioButton();
			this.optFileSystem = new global::System.Windows.Forms.RadioButton();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.cboTypeSource = new global::System.Windows.Forms.ComboBox();
			this.Design = new global::System.Windows.Forms.GroupBox();
			this.txtDes = new global::System.Windows.Forms.CheckedListBox();
			this.btnAddDes = new global::System.Windows.Forms.Button();
			this.txtAddDes = new global::System.Windows.Forms.TextBox();
			this.GroupBox3 = new global::System.Windows.Forms.GroupBox();
			this.txtExt = new global::System.Windows.Forms.CheckedListBox();
			this.txtAddExt = new global::System.Windows.Forms.TextBox();
			this.btnAddExt = new global::System.Windows.Forms.Button();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.chkCodeAuto = new global::System.Windows.Forms.CheckBox();
			this.optListCounter = new global::System.Windows.Forms.RadioButton();
			this.btnSelectFolderFile = new global::System.Windows.Forms.Button();
			this.optDiff = new global::System.Windows.Forms.RadioButton();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.txtBasefolder = new global::System.Windows.Forms.TextBox();
			this.txtDifffolder = new global::System.Windows.Forms.TextBox();
			this.btnBase = new global::System.Windows.Forms.Button();
			this.btndiff = new global::System.Windows.Forms.Button();
			this.btnDelete = new global::System.Windows.Forms.Button();
			this.lstFolderFile = new global::System.Windows.Forms.ListBox();
			this.lstFileDiff = new global::System.Windows.Forms.ListBox();
			this.btnFile = new global::System.Windows.Forms.Button();
			this.chkDiff = new global::System.Windows.Forms.CheckBox();
			this.btnDeleteFile = new global::System.Windows.Forms.Button();
			this.lblRepository = new global::System.Windows.Forms.Label();
			this.txtRepository = new global::System.Windows.Forms.TextBox();
			this.optDiffVersion = new global::System.Windows.Forms.RadioButton();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.txtBase = new global::System.Windows.Forms.TextBox();
			this.txtDiff = new global::System.Windows.Forms.TextBox();
			this.chkHead = new global::System.Windows.Forms.CheckBox();
			this.lblpathfile = new global::System.Windows.Forms.Label();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.btnRefVersion = new global::System.Windows.Forms.Button();
			this.GroupBox5.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.Design.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			base.SuspendLayout();
			this.btnCount.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCount.Location = new global::System.Drawing.Point(754, 754);
			this.btnCount.Margin = new global::System.Windows.Forms.Padding(3, 5, 3, 5);
			this.btnCount.Name = "btnCount";
			this.btnCount.Size = new global::System.Drawing.Size(85, 28);
			this.btnCount.TabIndex = 74;
			this.btnCount.Text = "Tính LOC";
			this.btnCount.UseVisualStyleBackColor = true;
			this.GroupBox5.Controls.Add(this.optSVN);
			this.GroupBox5.Controls.Add(this.optFileSystem);
			this.GroupBox5.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.GroupBox5.Location = new global::System.Drawing.Point(15, 4);
			this.GroupBox5.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox5.Name = "GroupBox5";
			this.GroupBox5.Padding = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox5.Size = new global::System.Drawing.Size(201, 48);
			this.GroupBox5.TabIndex = 73;
			this.GroupBox5.TabStop = false;
			this.optSVN.AutoSize = true;
			this.optSVN.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.optSVN.Location = new global::System.Drawing.Point(102, 19);
			this.optSVN.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.optSVN.Name = "optSVN";
			this.optSVN.Size = new global::System.Drawing.Size(88, 17);
			this.optSVN.TabIndex = 15;
			this.optSVN.Text = "Tính qua SVN";
			this.optSVN.UseVisualStyleBackColor = true;
			this.optFileSystem.AutoSize = true;
			this.optFileSystem.Checked = true;
			this.optFileSystem.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.optFileSystem.Location = new global::System.Drawing.Point(5, 19);
			this.optFileSystem.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.optFileSystem.Name = "optFileSystem";
			this.optFileSystem.Size = new global::System.Drawing.Size(83, 17);
			this.optFileSystem.TabIndex = 15;
			this.optFileSystem.TabStop = true;
			this.optFileSystem.Text = "Tính qua file";
			this.optFileSystem.UseVisualStyleBackColor = true;
			this.GroupBox4.Controls.Add(this.cboTypeSource);
			this.GroupBox4.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.GroupBox4.Location = new global::System.Drawing.Point(226, 8);
			this.GroupBox4.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Padding = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox4.Size = new global::System.Drawing.Size(292, 44);
			this.GroupBox4.TabIndex = 72;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "Loại source";
			this.cboTypeSource.BackColor = global::System.Drawing.SystemColors.Window;
			this.cboTypeSource.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboTypeSource.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cboTypeSource.FormattingEnabled = true;
			this.cboTypeSource.Location = new global::System.Drawing.Point(18, 14);
			this.cboTypeSource.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cboTypeSource.Name = "cboTypeSource";
			this.cboTypeSource.Size = new global::System.Drawing.Size(266, 21);
			this.cboTypeSource.TabIndex = 12;
			this.Design.Controls.Add(this.txtDes);
			this.Design.Controls.Add(this.btnAddDes);
			this.Design.Controls.Add(this.txtAddDes);
			this.Design.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Design.Location = new global::System.Drawing.Point(471, 572);
			this.Design.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Design.Name = "Design";
			this.Design.Padding = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Design.Size = new global::System.Drawing.Size(368, 175);
			this.Design.TabIndex = 71;
			this.Design.TabStop = false;
			this.Design.Text = "Tính loại LOC giao diện (design) cho các Extension";
			this.txtDes.CheckOnClick = true;
			this.txtDes.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtDes.FormattingEnabled = true;
			this.txtDes.HorizontalScrollbar = true;
			this.txtDes.IntegralHeight = false;
			this.txtDes.Location = new global::System.Drawing.Point(9, 19);
			this.txtDes.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtDes.Name = "txtDes";
			this.txtDes.Size = new global::System.Drawing.Size(347, 116);
			this.txtDes.TabIndex = 39;
			this.btnAddDes.Location = new global::System.Drawing.Point(205, 137);
			this.btnAddDes.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnAddDes.Name = "btnAddDes";
			this.btnAddDes.Size = new global::System.Drawing.Size(50, 24);
			this.btnAddDes.TabIndex = 30;
			this.btnAddDes.Text = "Thêm";
			this.btnAddDes.UseVisualStyleBackColor = true;
			this.txtAddDes.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtAddDes.Location = new global::System.Drawing.Point(9, 140);
			this.txtAddDes.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtAddDes.Name = "txtAddDes";
			this.txtAddDes.Size = new global::System.Drawing.Size(190, 21);
			this.txtAddDes.TabIndex = 33;
			this.GroupBox3.Controls.Add(this.txtExt);
			this.GroupBox3.Controls.Add(this.txtAddExt);
			this.GroupBox3.Controls.Add(this.btnAddExt);
			this.GroupBox3.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.GroupBox3.Location = new global::System.Drawing.Point(15, 572);
			this.GroupBox3.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Padding = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox3.Size = new global::System.Drawing.Size(404, 175);
			this.GroupBox3.TabIndex = 70;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Không tính LOC các Extension";
			this.txtExt.CheckOnClick = true;
			this.txtExt.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtExt.FormattingEnabled = true;
			this.txtExt.HorizontalScrollbar = true;
			this.txtExt.Location = new global::System.Drawing.Point(6, 19);
			this.txtExt.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtExt.Name = "txtExt";
			this.txtExt.Size = new global::System.Drawing.Size(392, 116);
			this.txtExt.TabIndex = 40;
			this.txtAddExt.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtAddExt.Location = new global::System.Drawing.Point(5, 141);
			this.txtAddExt.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtAddExt.Name = "txtAddExt";
			this.txtAddExt.Size = new global::System.Drawing.Size(190, 21);
			this.txtAddExt.TabIndex = 41;
			this.btnAddExt.Location = new global::System.Drawing.Point(204, 138);
			this.btnAddExt.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnAddExt.Name = "btnAddExt";
			this.btnAddExt.Size = new global::System.Drawing.Size(50, 24);
			this.btnAddExt.TabIndex = 30;
			this.btnAddExt.Text = "Thêm";
			this.btnAddExt.UseVisualStyleBackColor = true;
			this.GroupBox1.Controls.Add(this.chkCodeAuto);
			this.GroupBox1.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.GroupBox1.Location = new global::System.Drawing.Point(524, 7);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox1.Size = new global::System.Drawing.Size(317, 45);
			this.GroupBox1.TabIndex = 68;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Visible = false;
			this.chkCodeAuto.AutoSize = true;
			this.chkCodeAuto.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.chkCodeAuto.Location = new global::System.Drawing.Point(14, 16);
			this.chkCodeAuto.Margin = new global::System.Windows.Forms.Padding(3, 5, 3, 5);
			this.chkCodeAuto.Name = "chkCodeAuto";
			this.chkCodeAuto.Size = new global::System.Drawing.Size(301, 17);
			this.chkCodeAuto.TabIndex = 8;
			this.chkCodeAuto.Text = "Không tính code sinh tự động (VD file design .designer...)";
			this.chkCodeAuto.UseVisualStyleBackColor = true;
			this.optListCounter.AutoSize = true;
			this.optListCounter.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.optListCounter.Location = new global::System.Drawing.Point(6, 42);
			this.optListCounter.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.optListCounter.Name = "optListCounter";
			this.optListCounter.Size = new global::System.Drawing.Size(107, 17);
			this.optListCounter.TabIndex = 14;
			this.optListCounter.TabStop = true;
			this.optListCounter.Text = "Thư mục - tập tin";
			this.optListCounter.UseVisualStyleBackColor = true;
			this.btnSelectFolderFile.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnSelectFolderFile.Location = new global::System.Drawing.Point(737, 120);
			this.btnSelectFolderFile.Margin = new global::System.Windows.Forms.Padding(3, 5, 3, 5);
			this.btnSelectFolderFile.Name = "btnSelectFolderFile";
			this.btnSelectFolderFile.Size = new global::System.Drawing.Size(67, 25);
			this.btnSelectFolderFile.TabIndex = 18;
			this.btnSelectFolderFile.Text = "Thêm";
			this.btnSelectFolderFile.UseVisualStyleBackColor = true;
			this.optDiff.AutoSize = true;
			this.optDiff.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.optDiff.Location = new global::System.Drawing.Point(7, 262);
			this.optDiff.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.optDiff.Name = "optDiff";
			this.optDiff.Size = new global::System.Drawing.Size(146, 17);
			this.optDiff.TabIndex = 19;
			this.optDiff.TabStop = true;
			this.optDiff.Text = "So sánh thư mục - tập tin";
			this.optDiff.UseVisualStyleBackColor = true;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(26, 292);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(62, 13);
			this.Label1.TabIndex = 20;
			this.Label1.Text = "Thư mục cũ";
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(26, 318);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(67, 13);
			this.Label2.TabIndex = 21;
			this.Label2.Text = "Thư mục mới";
			this.txtBasefolder.Enabled = false;
			this.txtBasefolder.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtBasefolder.Location = new global::System.Drawing.Point(111, 291);
			this.txtBasefolder.Margin = new global::System.Windows.Forms.Padding(3, 5, 3, 5);
			this.txtBasefolder.Name = "txtBasefolder";
			this.txtBasefolder.Size = new global::System.Drawing.Size(622, 21);
			this.txtBasefolder.TabIndex = 22;
			this.txtDifffolder.Enabled = false;
			this.txtDifffolder.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtDifffolder.Location = new global::System.Drawing.Point(111, 314);
			this.txtDifffolder.Margin = new global::System.Windows.Forms.Padding(3, 5, 3, 5);
			this.txtDifffolder.Name = "txtDifffolder";
			this.txtDifffolder.Size = new global::System.Drawing.Size(622, 21);
			this.txtDifffolder.TabIndex = 23;
			this.btnBase.Enabled = false;
			this.btnBase.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnBase.Location = new global::System.Drawing.Point(737, 291);
			this.btnBase.Margin = new global::System.Windows.Forms.Padding(3, 5, 3, 5);
			this.btnBase.Name = "btnBase";
			this.btnBase.Size = new global::System.Drawing.Size(67, 19);
			this.btnBase.TabIndex = 24;
			this.btnBase.Text = "...";
			this.btnBase.UseVisualStyleBackColor = true;
			this.btndiff.Enabled = false;
			this.btndiff.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btndiff.Location = new global::System.Drawing.Point(737, 314);
			this.btndiff.Margin = new global::System.Windows.Forms.Padding(3, 5, 3, 5);
			this.btndiff.Name = "btndiff";
			this.btndiff.Size = new global::System.Drawing.Size(67, 19);
			this.btndiff.TabIndex = 25;
			this.btndiff.Text = "...";
			this.btndiff.UseVisualStyleBackColor = true;
			this.btnDelete.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnDelete.Location = new global::System.Drawing.Point(737, 157);
			this.btnDelete.Margin = new global::System.Windows.Forms.Padding(3, 5, 3, 5);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new global::System.Drawing.Size(67, 25);
			this.btnDelete.TabIndex = 27;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.lstFolderFile.AllowDrop = true;
			this.lstFolderFile.BackColor = global::System.Drawing.SystemColors.Window;
			this.lstFolderFile.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstFolderFile.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.lstFolderFile.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lstFolderFile.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.lstFolderFile.FormattingEnabled = true;
			this.lstFolderFile.HorizontalScrollbar = true;
			this.lstFolderFile.Location = new global::System.Drawing.Point(50, 63);
			this.lstFolderFile.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.lstFolderFile.Name = "lstFolderFile";
			this.lstFolderFile.ScrollAlwaysVisible = true;
			this.lstFolderFile.SelectionMode = global::System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstFolderFile.Size = new global::System.Drawing.Size(681, 119);
			this.lstFolderFile.TabIndex = 29;
			this.lstFileDiff.BackColor = global::System.Drawing.SystemColors.Window;
			this.lstFileDiff.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstFileDiff.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.lstFileDiff.Enabled = false;
			this.lstFileDiff.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lstFileDiff.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.lstFileDiff.FormattingEnabled = true;
			this.lstFileDiff.HorizontalScrollbar = true;
			this.lstFileDiff.Location = new global::System.Drawing.Point(52, 369);
			this.lstFileDiff.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.lstFileDiff.Name = "lstFileDiff";
			this.lstFileDiff.ScrollAlwaysVisible = true;
			this.lstFileDiff.SelectionMode = global::System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstFileDiff.Size = new global::System.Drawing.Size(679, 119);
			this.lstFileDiff.TabIndex = 30;
			this.btnFile.Enabled = false;
			this.btnFile.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnFile.Location = new global::System.Drawing.Point(737, 419);
			this.btnFile.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnFile.Name = "btnFile";
			this.btnFile.Size = new global::System.Drawing.Size(67, 28);
			this.btnFile.TabIndex = 31;
			this.btnFile.Text = "Thêm";
			this.btnFile.UseVisualStyleBackColor = true;
			this.chkDiff.AutoSize = true;
			this.chkDiff.Enabled = false;
			this.chkDiff.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.chkDiff.Location = new global::System.Drawing.Point(29, 345);
			this.chkDiff.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.chkDiff.Name = "chkDiff";
			this.chkDiff.Size = new global::System.Drawing.Size(145, 17);
			this.chkDiff.TabIndex = 33;
			this.chkDiff.Text = "Chọn tập tin cần so sánh";
			this.chkDiff.UseVisualStyleBackColor = true;
			this.btnDeleteFile.Enabled = false;
			this.btnDeleteFile.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnDeleteFile.Location = new global::System.Drawing.Point(737, 459);
			this.btnDeleteFile.Margin = new global::System.Windows.Forms.Padding(3, 5, 3, 5);
			this.btnDeleteFile.Name = "btnDeleteFile";
			this.btnDeleteFile.Size = new global::System.Drawing.Size(66, 28);
			this.btnDeleteFile.TabIndex = 34;
			this.btnDeleteFile.Text = "Xóa";
			this.btnDeleteFile.UseVisualStyleBackColor = true;
			this.lblRepository.AutoSize = true;
			this.lblRepository.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblRepository.Location = new global::System.Drawing.Point(25, 18);
			this.lblRepository.Name = "lblRepository";
			this.lblRepository.Size = new global::System.Drawing.Size(81, 13);
			this.lblRepository.TabIndex = 35;
			this.lblRepository.Text = "Repository SVN";
			this.txtRepository.Enabled = false;
			this.txtRepository.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtRepository.Location = new global::System.Drawing.Point(112, 14);
			this.txtRepository.Margin = new global::System.Windows.Forms.Padding(3, 5, 3, 5);
			this.txtRepository.Name = "txtRepository";
			this.txtRepository.Size = new global::System.Drawing.Size(619, 21);
			this.txtRepository.TabIndex = 36;
			this.optDiffVersion.AutoSize = true;
			this.optDiffVersion.Enabled = false;
			this.optDiffVersion.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.optDiffVersion.Location = new global::System.Drawing.Point(7, 194);
			this.optDiffVersion.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.optDiffVersion.Name = "optDiffVersion";
			this.optDiffVersion.Size = new global::System.Drawing.Size(85, 17);
			this.optDiffVersion.TabIndex = 37;
			this.optDiffVersion.TabStop = true;
			this.optDiffVersion.Text = "So sánh SVN";
			this.optDiffVersion.UseVisualStyleBackColor = true;
			this.Label5.AutoSize = true;
			this.Label5.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label5.Location = new global::System.Drawing.Point(26, 216);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(68, 13);
			this.Label5.TabIndex = 38;
			this.Label5.Text = "Phiên bản cũ";
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.Location = new global::System.Drawing.Point(26, 240);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(73, 13);
			this.Label4.TabIndex = 39;
			this.Label4.Text = "Phiên bản mới";
			this.txtBase.Enabled = false;
			this.txtBase.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtBase.Location = new global::System.Drawing.Point(112, 214);
			this.txtBase.Margin = new global::System.Windows.Forms.Padding(3, 5, 3, 5);
			this.txtBase.Name = "txtBase";
			this.txtBase.Size = new global::System.Drawing.Size(114, 21);
			this.txtBase.TabIndex = 40;
			this.txtDiff.Enabled = false;
			this.txtDiff.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtDiff.Location = new global::System.Drawing.Point(112, 236);
			this.txtDiff.Margin = new global::System.Windows.Forms.Padding(3, 5, 3, 5);
			this.txtDiff.Name = "txtDiff";
			this.txtDiff.Size = new global::System.Drawing.Size(114, 21);
			this.txtDiff.TabIndex = 41;
			this.chkHead.AutoSize = true;
			this.chkHead.Enabled = false;
			this.chkHead.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.chkHead.Location = new global::System.Drawing.Point(238, 238);
			this.chkHead.Margin = new global::System.Windows.Forms.Padding(3, 5, 3, 5);
			this.chkHead.Name = "chkHead";
			this.chkHead.Size = new global::System.Drawing.Size(117, 17);
			this.chkHead.TabIndex = 42;
			this.chkHead.Text = "Phiên bản mới nhất";
			this.chkHead.UseVisualStyleBackColor = true;
			this.lblpathfile.AutoSize = true;
			this.lblpathfile.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblpathfile.ForeColor = global::System.Drawing.Color.Blue;
			this.lblpathfile.Location = new global::System.Drawing.Point(201, 46);
			this.lblpathfile.Name = "lblpathfile";
			this.lblpathfile.Size = new global::System.Drawing.Size(0, 13);
			this.lblpathfile.TabIndex = 61;
			this.GroupBox2.Controls.Add(this.btnRefVersion);
			this.GroupBox2.Controls.Add(this.lblpathfile);
			this.GroupBox2.Controls.Add(this.chkHead);
			this.GroupBox2.Controls.Add(this.txtDiff);
			this.GroupBox2.Controls.Add(this.txtBase);
			this.GroupBox2.Controls.Add(this.Label4);
			this.GroupBox2.Controls.Add(this.Label5);
			this.GroupBox2.Controls.Add(this.optDiffVersion);
			this.GroupBox2.Controls.Add(this.txtRepository);
			this.GroupBox2.Controls.Add(this.lblRepository);
			this.GroupBox2.Controls.Add(this.btnDeleteFile);
			this.GroupBox2.Controls.Add(this.chkDiff);
			this.GroupBox2.Controls.Add(this.btnFile);
			this.GroupBox2.Controls.Add(this.lstFileDiff);
			this.GroupBox2.Controls.Add(this.lstFolderFile);
			this.GroupBox2.Controls.Add(this.btnDelete);
			this.GroupBox2.Controls.Add(this.btndiff);
			this.GroupBox2.Controls.Add(this.btnBase);
			this.GroupBox2.Controls.Add(this.txtDifffolder);
			this.GroupBox2.Controls.Add(this.txtBasefolder);
			this.GroupBox2.Controls.Add(this.Label2);
			this.GroupBox2.Controls.Add(this.Label1);
			this.GroupBox2.Controls.Add(this.optDiff);
			this.GroupBox2.Controls.Add(this.btnSelectFolderFile);
			this.GroupBox2.Controls.Add(this.optListCounter);
			this.GroupBox2.Location = new global::System.Drawing.Point(12, 61);
			this.GroupBox2.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Padding = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GroupBox2.Size = new global::System.Drawing.Size(827, 503);
			this.GroupBox2.TabIndex = 69;
			this.GroupBox2.TabStop = false;
			this.btnRefVersion.Enabled = false;
			this.btnRefVersion.Location = new global::System.Drawing.Point(237, 214);
			this.btnRefVersion.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnRefVersion.Name = "btnRefVersion";
			this.btnRefVersion.Size = new global::System.Drawing.Size(126, 21);
			this.btnRefVersion.TabIndex = 62;
			this.btnRefVersion.Text = "Xem lịch sử phiên bản";
			this.btnRefVersion.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			base.ClientSize = new global::System.Drawing.Size(856, 784);
			base.Controls.Add(this.btnCount);
			base.Controls.Add(this.GroupBox5);
			base.Controls.Add(this.GroupBox4);
			base.Controls.Add(this.Design);
			base.Controls.Add(this.GroupBox3);
			base.Controls.Add(this.GroupBox2);
			base.Controls.Add(this.GroupBox1);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.KeyPreview = true;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.MaximizeBox = false;
			base.Name = "frmCounterLOC";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Line Of Code Counter";
			this.GroupBox5.ResumeLayout(false);
			this.GroupBox5.PerformLayout();
			this.GroupBox4.ResumeLayout(false);
			this.Design.ResumeLayout(false);
			this.Design.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400001B RID: 27
		private global::System.ComponentModel.IContainer components;
	}
}