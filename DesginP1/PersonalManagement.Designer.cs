namespace DesginP1
{
    partial class DesginP1
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lvPersonTable = new System.Windows.Forms.ListView();
			this.no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ICustNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.strName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.strNameKana = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.dtBirthDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.strSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.txtNumberRows = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnSelect = new System.Windows.Forms.Button();
			this.txtSelectCustNo = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpEndDay = new System.Windows.Forms.DateTimePicker();
			this.dtpStartDay = new System.Windows.Forms.DateTimePicker();
			this.txtSearchCustNo = new System.Windows.Forms.TextBox();
			this.lblSearchBirthDay = new System.Windows.Forms.Label();
			this.lblSearchCustNo = new System.Windows.Forms.Label();
			this.txtTimeNow = new System.Windows.Forms.TextBox();
			this.txtDateNow = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dmcbSex = new System.Windows.Forms.CheckBox();
			this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
			this.txtNameKana = new System.Windows.Forms.TextBox();
			this.txtCountCustNo = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtCusNo = new System.Windows.Forms.TextBox();
			this.lblBirthDay = new System.Windows.Forms.Label();
			this.lblSex = new System.Windows.Forms.Label();
			this.lblCustNoChkDgt = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblNameKana = new System.Windows.Forms.Label();
			this.lblCustNo = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.lvPersonTable);
			this.groupBox1.Controls.Add(this.txtNumberRows);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.btnSelect);
			this.groupBox1.Controls.Add(this.txtSelectCustNo);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.btnSearch);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.dtpEndDay);
			this.groupBox1.Controls.Add(this.dtpStartDay);
			this.groupBox1.Controls.Add(this.txtSearchCustNo);
			this.groupBox1.Controls.Add(this.lblSearchBirthDay);
			this.groupBox1.Controls.Add(this.lblSearchCustNo);
			this.groupBox1.Location = new System.Drawing.Point(12, 58);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(987, 357);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Condition Search (o)";
			// 
			// lvPersonTable
			// 
			this.lvPersonTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvPersonTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.no,
            this.ICustNo,
            this.strName,
            this.strNameKana,
            this.dtBirthDay,
            this.strSex});
			this.lvPersonTable.FullRowSelect = true;
			this.lvPersonTable.GridLines = true;
			this.lvPersonTable.Location = new System.Drawing.Point(15, 87);
			this.lvPersonTable.Name = "lvPersonTable";
			this.lvPersonTable.Size = new System.Drawing.Size(951, 211);
			this.lvPersonTable.TabIndex = 13;
			this.lvPersonTable.UseCompatibleStateImageBehavior = false;
			this.lvPersonTable.View = System.Windows.Forms.View.Details;
			this.lvPersonTable.SelectedIndexChanged += new System.EventHandler(this.lvPersonTable_SelectedIndexChanged);
			// 
			// no
			// 
			this.no.Text = "No.";
			this.no.Width = 40;
			// 
			// ICustNo
			// 
			this.ICustNo.Text = "CustNo";
			this.ICustNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// strName
			// 
			this.strName.Text = "Name";
			this.strName.Width = 200;
			// 
			// strNameKana
			// 
			this.strNameKana.Text = "Name Kana";
			this.strNameKana.Width = 200;
			// 
			// dtBirthDay
			// 
			this.dtBirthDay.Text = "BirthDay";
			this.dtBirthDay.Width = 150;
			// 
			// strSex
			// 
			this.strSex.Text = "Sex";
			this.strSex.Width = 100;
			// 
			// txtNumberRows
			// 
			this.txtNumberRows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNumberRows.Location = new System.Drawing.Point(864, 320);
			this.txtNumberRows.Name = "txtNumberRows";
			this.txtNumberRows.Size = new System.Drawing.Size(102, 19);
			this.txtNumberRows.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(771, 325);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 12);
			this.label5.TabIndex = 11;
			this.label5.Text = "Number Rows:";
			// 
			// btnSelect
			// 
			this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelect.Location = new System.Drawing.Point(668, 318);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(85, 23);
			this.btnSelect.TabIndex = 10;
			this.btnSelect.Text = "Select (s)";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// txtSelectCustNo
			// 
			this.txtSelectCustNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSelectCustNo.Location = new System.Drawing.Point(540, 322);
			this.txtSelectCustNo.Name = "txtSelectCustNo";
			this.txtSelectCustNo.Size = new System.Drawing.Size(100, 19);
			this.txtSelectCustNo.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(430, 325);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 12);
			this.label4.TabIndex = 8;
			this.label4.Text = "Selected CustNo:";
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSearch.Location = new System.Drawing.Point(788, 42);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(157, 23);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "Search (F1)";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label3.Location = new System.Drawing.Point(232, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(14, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "~";
			// 
			// dtpEndDay
			// 
			this.dtpEndDay.CustomFormat = " ";
			this.dtpEndDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEndDay.Location = new System.Drawing.Point(252, 53);
			this.dtpEndDay.Name = "dtpEndDay";
			this.dtpEndDay.Size = new System.Drawing.Size(118, 19);
			this.dtpEndDay.TabIndex = 4;
			this.dtpEndDay.ValueChanged += new System.EventHandler(this.dtpEndDay_ValueChanged);
			// 
			// dtpStartDay
			// 
			this.dtpStartDay.CustomFormat = " ";
			this.dtpStartDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpStartDay.Location = new System.Drawing.Point(93, 53);
			this.dtpStartDay.Name = "dtpStartDay";
			this.dtpStartDay.Size = new System.Drawing.Size(118, 19);
			this.dtpStartDay.TabIndex = 3;
			this.dtpStartDay.ValueChanged += new System.EventHandler(this.dtpStartDay_ValueChanged);
			// 
			// txtSearchCustNo
			// 
			this.txtSearchCustNo.ForeColor = System.Drawing.Color.Black;
			this.txtSearchCustNo.Location = new System.Drawing.Point(93, 21);
			this.txtSearchCustNo.Name = "txtSearchCustNo";
			this.txtSearchCustNo.Size = new System.Drawing.Size(192, 19);
			this.txtSearchCustNo.TabIndex = 2;
			this.txtSearchCustNo.TextChanged += new System.EventHandler(this.txtSearchCustNo_TextChanged);
			// 
			// lblSearchBirthDay
			// 
			this.lblSearchBirthDay.AutoSize = true;
			this.lblSearchBirthDay.Location = new System.Drawing.Point(23, 53);
			this.lblSearchBirthDay.Name = "lblSearchBirthDay";
			this.lblSearchBirthDay.Size = new System.Drawing.Size(56, 12);
			this.lblSearchBirthDay.TabIndex = 1;
			this.lblSearchBirthDay.Text = "Birth Day:";
			// 
			// lblSearchCustNo
			// 
			this.lblSearchCustNo.AutoSize = true;
			this.lblSearchCustNo.ForeColor = System.Drawing.Color.Black;
			this.lblSearchCustNo.Location = new System.Drawing.Point(23, 28);
			this.lblSearchCustNo.Name = "lblSearchCustNo";
			this.lblSearchCustNo.Size = new System.Drawing.Size(49, 12);
			this.lblSearchCustNo.TabIndex = 0;
			this.lblSearchCustNo.Text = "Cust No:";
			// 
			// txtTimeNow
			// 
			this.txtTimeNow.Enabled = false;
			this.txtTimeNow.Location = new System.Drawing.Point(699, 33);
			this.txtTimeNow.Name = "txtTimeNow";
			this.txtTimeNow.Size = new System.Drawing.Size(160, 19);
			this.txtTimeNow.TabIndex = 0;
			// 
			// txtDateNow
			// 
			this.txtDateNow.Enabled = false;
			this.txtDateNow.Location = new System.Drawing.Point(507, 33);
			this.txtDateNow.Name = "txtDateNow";
			this.txtDateNow.Size = new System.Drawing.Size(175, 19);
			this.txtDateNow.TabIndex = 1;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(876, 33);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(102, 19);
			this.textBox3.TabIndex = 2;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.dmcbSex);
			this.groupBox2.Controls.Add(this.dtpBirthDay);
			this.groupBox2.Controls.Add(this.txtNameKana);
			this.groupBox2.Controls.Add(this.txtCountCustNo);
			this.groupBox2.Controls.Add(this.txtName);
			this.groupBox2.Controls.Add(this.txtCusNo);
			this.groupBox2.Controls.Add(this.lblBirthDay);
			this.groupBox2.Controls.Add(this.lblSex);
			this.groupBox2.Controls.Add(this.lblCustNoChkDgt);
			this.groupBox2.Controls.Add(this.lblName);
			this.groupBox2.Controls.Add(this.lblNameKana);
			this.groupBox2.Controls.Add(this.lblCustNo);
			this.groupBox2.Location = new System.Drawing.Point(12, 439);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(987, 270);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "`";
			// 
			// dmcbSex
			// 
			this.dmcbSex.AutoSize = true;
			this.dmcbSex.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.dmcbSex.Location = new System.Drawing.Point(121, 235);
			this.dmcbSex.Name = "dmcbSex";
			this.dmcbSex.Size = new System.Drawing.Size(15, 14);
			this.dmcbSex.TabIndex = 12;
			this.dmcbSex.UseVisualStyleBackColor = true;
			// 
			// dtpBirthDay
			// 
			this.dtpBirthDay.CalendarForeColor = System.Drawing.Color.Black;
			this.dtpBirthDay.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText;
			this.dtpBirthDay.CustomFormat = " ";
			this.dtpBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpBirthDay.Location = new System.Drawing.Point(121, 196);
			this.dtpBirthDay.Name = "dtpBirthDay";
			this.dtpBirthDay.Size = new System.Drawing.Size(144, 19);
			this.dtpBirthDay.TabIndex = 11;
			this.dtpBirthDay.ValueChanged += new System.EventHandler(this.dtpBirthDay_ValueChanged);
			// 
			// txtNameKana
			// 
			this.txtNameKana.Location = new System.Drawing.Point(121, 157);
			this.txtNameKana.Name = "txtNameKana";
			this.txtNameKana.Size = new System.Drawing.Size(144, 19);
			this.txtNameKana.TabIndex = 9;
			this.txtNameKana.TextChanged += new System.EventHandler(this.txtNameKana_TextChanged);
			// 
			// txtCountCustNo
			// 
			this.txtCountCustNo.Location = new System.Drawing.Point(121, 72);
			this.txtCountCustNo.Name = "txtCountCustNo";
			this.txtCountCustNo.Size = new System.Drawing.Size(144, 19);
			this.txtCountCustNo.TabIndex = 8;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(121, 115);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(144, 19);
			this.txtName.TabIndex = 7;
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// txtCusNo
			// 
			this.txtCusNo.Location = new System.Drawing.Point(121, 27);
			this.txtCusNo.Name = "txtCusNo";
			this.txtCusNo.Size = new System.Drawing.Size(144, 19);
			this.txtCusNo.TabIndex = 6;
			// 
			// lblBirthDay
			// 
			this.lblBirthDay.AutoSize = true;
			this.lblBirthDay.Location = new System.Drawing.Point(23, 196);
			this.lblBirthDay.Name = "lblBirthDay";
			this.lblBirthDay.Size = new System.Drawing.Size(50, 12);
			this.lblBirthDay.TabIndex = 5;
			this.lblBirthDay.Text = "BirthDay";
			// 
			// lblSex
			// 
			this.lblSex.AutoSize = true;
			this.lblSex.Location = new System.Drawing.Point(23, 235);
			this.lblSex.Name = "lblSex";
			this.lblSex.Size = new System.Drawing.Size(24, 12);
			this.lblSex.TabIndex = 4;
			this.lblSex.Text = "Sex";
			// 
			// lblCustNoChkDgt
			// 
			this.lblCustNoChkDgt.AutoSize = true;
			this.lblCustNoChkDgt.Location = new System.Drawing.Point(23, 75);
			this.lblCustNoChkDgt.Name = "lblCustNoChkDgt";
			this.lblCustNoChkDgt.Size = new System.Drawing.Size(81, 12);
			this.lblCustNoChkDgt.TabIndex = 3;
			this.lblCustNoChkDgt.Text = "CustNoChkDgt";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(23, 118);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(34, 12);
			this.lblName.TabIndex = 2;
			this.lblName.Text = "Name";
			// 
			// lblNameKana
			// 
			this.lblNameKana.AutoSize = true;
			this.lblNameKana.Location = new System.Drawing.Point(23, 157);
			this.lblNameKana.Name = "lblNameKana";
			this.lblNameKana.Size = new System.Drawing.Size(63, 12);
			this.lblNameKana.TabIndex = 1;
			this.lblNameKana.Text = "Name Kana";
			// 
			// lblCustNo
			// 
			this.lblCustNo.AutoSize = true;
			this.lblCustNo.Location = new System.Drawing.Point(23, 34);
			this.lblCustNo.Name = "lblCustNo";
			this.lblCustNo.Size = new System.Drawing.Size(43, 12);
			this.lblCustNo.TabIndex = 0;
			this.lblCustNo.Text = "CustNo";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUpdate.Location = new System.Drawing.Point(430, 732);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(112, 23);
			this.btnUpdate.TabIndex = 4;
			this.btnUpdate.Text = "Update (F11)";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.button3_Click);
			// 
			// btnBack
			// 
			this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBack.Location = new System.Drawing.Point(876, 732);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(112, 23);
			this.btnBack.TabIndex = 5;
			this.btnBack.Text = "Back (Pause)";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.button4_Click);
			// 
			// btnClear
			// 
			this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClear.Location = new System.Drawing.Point(729, 732);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(112, 23);
			this.btnClear.TabIndex = 6;
			this.btnClear.Text = "Clear (F8)";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.button5_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.Location = new System.Drawing.Point(583, 732);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(112, 23);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "Delete (D)";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.button6_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.Location = new System.Drawing.Point(270, 732);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(112, 23);
			this.btnAdd.TabIndex = 8;
			this.btnAdd.Text = "Add (F12)";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.button8_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// DesginP1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1020, 767);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.txtTimeNow);
			this.Controls.Add(this.txtDateNow);
			this.Controls.Add(this.groupBox1);
			this.Name = "DesginP1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MST020160P";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumberRows;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtSelectCustNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEndDay;
        private System.Windows.Forms.DateTimePicker dtpStartDay;
        private System.Windows.Forms.TextBox txtSearchCustNo;
        private System.Windows.Forms.Label lblSearchBirthDay;
        private System.Windows.Forms.Label lblSearchCustNo;
        private System.Windows.Forms.TextBox txtTimeNow;
        private System.Windows.Forms.TextBox txtDateNow;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.TextBox txtNameKana;
        private System.Windows.Forms.TextBox txtCountCustNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCusNo;
        private System.Windows.Forms.Label lblBirthDay;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblCustNoChkDgt;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameKana;
        private System.Windows.Forms.Label lblCustNo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView lvPersonTable;
        private System.Windows.Forms.ColumnHeader no;
        private System.Windows.Forms.ColumnHeader ICustNo;
        private System.Windows.Forms.ColumnHeader strName;
        private System.Windows.Forms.ColumnHeader strNameKana;
        private System.Windows.Forms.ColumnHeader dtBirthDay;
		private System.Windows.Forms.ColumnHeader strSex;
		private System.Windows.Forms.CheckBox dmcbSex;
    }
}

