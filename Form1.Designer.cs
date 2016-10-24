namespace RFIDTimming
{
    partial class Form1
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPageCompetition = new System.Windows.Forms.TabPage();
            this.cmbEvents = new System.Windows.Forms.ComboBox();
            this.btnOpenEvent = new System.Windows.Forms.Button();
            this.tabPageRunners = new System.Windows.Forms.TabPage();
            this.tabPageCategories = new System.Windows.Forms.TabPage();
            this.tabPageClubs = new System.Windows.Forms.TabPage();
            this.tabPageAddEvent = new System.Windows.Forms.TabPage();
            this.btnSaveEvent = new System.Windows.Forms.Button();
            this.dtmEventDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxEventName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseEvent = new System.Windows.Forms.Button();
            this.tbxCatCatName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numCatLaps = new System.Windows.Forms.NumericUpDown();
            this.numCatMinLapTime = new System.Windows.Forms.NumericUpDown();
            this.numCatStartOffset = new System.Windows.Forms.NumericUpDown();
            this.btnCatSave = new System.Windows.Forms.Button();
            this.btnCatDelete = new System.Windows.Forms.Button();
            this.btnCatNew = new System.Windows.Forms.Button();
            this.tbxCatCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.tabPageStartNumbers = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dtgStartNumbers = new System.Windows.Forms.DataGridView();
            this.bibNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNumberTagBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eNumberTagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAssignTags = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.tabPageCompetition.SuspendLayout();
            this.tabPageCategories.SuspendLayout();
            this.tabPageAddEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCatLaps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCatMinLapTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCatStartOffset)).BeginInit();
            this.tabPageStartNumbers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStartNumbers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNumberTagBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNumberTagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPageCompetition);
            this.tabs.Controls.Add(this.tabPageRunners);
            this.tabs.Controls.Add(this.tabPageCategories);
            this.tabs.Controls.Add(this.tabPageClubs);
            this.tabs.Controls.Add(this.tabPageAddEvent);
            this.tabs.Controls.Add(this.tabPageStartNumbers);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1180, 500);
            this.tabs.TabIndex = 0;
            // 
            // tabPageCompetition
            // 
            this.tabPageCompetition.Controls.Add(this.cmbEvents);
            this.tabPageCompetition.Controls.Add(this.btnOpenEvent);
            this.tabPageCompetition.Location = new System.Drawing.Point(4, 22);
            this.tabPageCompetition.Name = "tabPageCompetition";
            this.tabPageCompetition.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompetition.Size = new System.Drawing.Size(1172, 474);
            this.tabPageCompetition.TabIndex = 0;
            this.tabPageCompetition.Text = "Zvoľ pretek";
            this.tabPageCompetition.UseVisualStyleBackColor = true;
            // 
            // cmbEvents
            // 
            this.cmbEvents.DisplayMember = "EventName";
            this.cmbEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvents.FormattingEnabled = true;
            this.cmbEvents.Location = new System.Drawing.Point(8, 29);
            this.cmbEvents.Name = "cmbEvents";
            this.cmbEvents.Size = new System.Drawing.Size(443, 21);
            this.cmbEvents.TabIndex = 2;
            this.cmbEvents.ValueMember = "EventID";
            // 
            // btnOpenEvent
            // 
            this.btnOpenEvent.Location = new System.Drawing.Point(376, 56);
            this.btnOpenEvent.Name = "btnOpenEvent";
            this.btnOpenEvent.Size = new System.Drawing.Size(75, 23);
            this.btnOpenEvent.TabIndex = 1;
            this.btnOpenEvent.Text = "Otvor";
            this.btnOpenEvent.UseVisualStyleBackColor = true;
            this.btnOpenEvent.Click += new System.EventHandler(this.btnOpenEvent_Click);
            // 
            // tabPageRunners
            // 
            this.tabPageRunners.Location = new System.Drawing.Point(4, 22);
            this.tabPageRunners.Name = "tabPageRunners";
            this.tabPageRunners.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRunners.Size = new System.Drawing.Size(1172, 474);
            this.tabPageRunners.TabIndex = 1;
            this.tabPageRunners.Text = "Bezci";
            this.tabPageRunners.UseVisualStyleBackColor = true;
            // 
            // tabPageCategories
            // 
            this.tabPageCategories.Controls.Add(this.lstCategories);
            this.tabPageCategories.Controls.Add(this.tbxCatCode);
            this.tabPageCategories.Controls.Add(this.label7);
            this.tabPageCategories.Controls.Add(this.btnCatNew);
            this.tabPageCategories.Controls.Add(this.btnCatDelete);
            this.tabPageCategories.Controls.Add(this.btnCatSave);
            this.tabPageCategories.Controls.Add(this.numCatStartOffset);
            this.tabPageCategories.Controls.Add(this.numCatMinLapTime);
            this.tabPageCategories.Controls.Add(this.numCatLaps);
            this.tabPageCategories.Controls.Add(this.label6);
            this.tabPageCategories.Controls.Add(this.label5);
            this.tabPageCategories.Controls.Add(this.label4);
            this.tabPageCategories.Controls.Add(this.tbxCatCatName);
            this.tabPageCategories.Controls.Add(this.label3);
            this.tabPageCategories.Location = new System.Drawing.Point(4, 22);
            this.tabPageCategories.Name = "tabPageCategories";
            this.tabPageCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategories.Size = new System.Drawing.Size(1172, 474);
            this.tabPageCategories.TabIndex = 2;
            this.tabPageCategories.Text = "Kategorie";
            this.tabPageCategories.UseVisualStyleBackColor = true;
            // 
            // tabPageClubs
            // 
            this.tabPageClubs.Location = new System.Drawing.Point(4, 22);
            this.tabPageClubs.Name = "tabPageClubs";
            this.tabPageClubs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClubs.Size = new System.Drawing.Size(1172, 474);
            this.tabPageClubs.TabIndex = 3;
            this.tabPageClubs.Text = "Kluby";
            this.tabPageClubs.UseVisualStyleBackColor = true;
            // 
            // tabPageAddEvent
            // 
            this.tabPageAddEvent.Controls.Add(this.btnCloseEvent);
            this.tabPageAddEvent.Controls.Add(this.btnSaveEvent);
            this.tabPageAddEvent.Controls.Add(this.dtmEventDate);
            this.tabPageAddEvent.Controls.Add(this.label2);
            this.tabPageAddEvent.Controls.Add(this.tbxEventName);
            this.tabPageAddEvent.Controls.Add(this.label1);
            this.tabPageAddEvent.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddEvent.Name = "tabPageAddEvent";
            this.tabPageAddEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddEvent.Size = new System.Drawing.Size(1172, 474);
            this.tabPageAddEvent.TabIndex = 4;
            this.tabPageAddEvent.Text = "Novy pretek";
            this.tabPageAddEvent.UseVisualStyleBackColor = true;
            // 
            // btnSaveEvent
            // 
            this.btnSaveEvent.Location = new System.Drawing.Point(369, 98);
            this.btnSaveEvent.Name = "btnSaveEvent";
            this.btnSaveEvent.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEvent.TabIndex = 5;
            this.btnSaveEvent.Text = "Ulož";
            this.btnSaveEvent.UseVisualStyleBackColor = true;
            this.btnSaveEvent.Click += new System.EventHandler(this.btnSaveEvent_Click);
            // 
            // dtmEventDate
            // 
            this.dtmEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmEventDate.Location = new System.Drawing.Point(69, 47);
            this.dtmEventDate.Name = "dtmEventDate";
            this.dtmEventDate.ShowUpDown = true;
            this.dtmEventDate.Size = new System.Drawing.Size(200, 20);
            this.dtmEventDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dátum";
            // 
            // tbxEventName
            // 
            this.tbxEventName.Location = new System.Drawing.Point(69, 15);
            this.tbxEventName.Name = "tbxEventName";
            this.tbxEventName.Size = new System.Drawing.Size(375, 20);
            this.tbxEventName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Názov";
            // 
            // btnCloseEvent
            // 
            this.btnCloseEvent.Location = new System.Drawing.Point(288, 98);
            this.btnCloseEvent.Name = "btnCloseEvent";
            this.btnCloseEvent.Size = new System.Drawing.Size(75, 23);
            this.btnCloseEvent.TabIndex = 6;
            this.btnCloseEvent.Text = "Zatvor";
            this.btnCloseEvent.UseVisualStyleBackColor = true;
            this.btnCloseEvent.Click += new System.EventHandler(this.btnCloseEvent_Click);
            // 
            // tbxCatCatName
            // 
            this.tbxCatCatName.Location = new System.Drawing.Point(376, 40);
            this.tbxCatCatName.Name = "tbxCatCatName";
            this.tbxCatCatName.Size = new System.Drawing.Size(284, 20);
            this.tbxCatCatName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(266, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Názov";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(266, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kolá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(266, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Min. čas kolo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(266, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Posun štartu";
            // 
            // numCatLaps
            // 
            this.numCatLaps.Location = new System.Drawing.Point(376, 72);
            this.numCatLaps.Name = "numCatLaps";
            this.numCatLaps.Size = new System.Drawing.Size(65, 20);
            this.numCatLaps.TabIndex = 7;
            // 
            // numCatMinLapTime
            // 
            this.numCatMinLapTime.Location = new System.Drawing.Point(376, 108);
            this.numCatMinLapTime.Name = "numCatMinLapTime";
            this.numCatMinLapTime.Size = new System.Drawing.Size(65, 20);
            this.numCatMinLapTime.TabIndex = 8;
            // 
            // numCatStartOffset
            // 
            this.numCatStartOffset.Location = new System.Drawing.Point(376, 143);
            this.numCatStartOffset.Name = "numCatStartOffset";
            this.numCatStartOffset.Size = new System.Drawing.Size(65, 20);
            this.numCatStartOffset.TabIndex = 9;
            // 
            // btnCatSave
            // 
            this.btnCatSave.Location = new System.Drawing.Point(585, 198);
            this.btnCatSave.Name = "btnCatSave";
            this.btnCatSave.Size = new System.Drawing.Size(75, 23);
            this.btnCatSave.TabIndex = 10;
            this.btnCatSave.Text = "Ulož";
            this.btnCatSave.UseVisualStyleBackColor = true;
            this.btnCatSave.Click += new System.EventHandler(this.btnCatSave_Click);
            // 
            // btnCatDelete
            // 
            this.btnCatDelete.Location = new System.Drawing.Point(401, 198);
            this.btnCatDelete.Name = "btnCatDelete";
            this.btnCatDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCatDelete.TabIndex = 11;
            this.btnCatDelete.Text = "Vymaž";
            this.btnCatDelete.UseVisualStyleBackColor = true;
            this.btnCatDelete.Click += new System.EventHandler(this.btnCatDelete_Click);
            // 
            // btnCatNew
            // 
            this.btnCatNew.Location = new System.Drawing.Point(493, 198);
            this.btnCatNew.Name = "btnCatNew";
            this.btnCatNew.Size = new System.Drawing.Size(75, 23);
            this.btnCatNew.TabIndex = 12;
            this.btnCatNew.Text = "Nový";
            this.btnCatNew.UseVisualStyleBackColor = true;
            this.btnCatNew.Click += new System.EventHandler(this.btnCatNew_Click);
            // 
            // tbxCatCode
            // 
            this.tbxCatCode.Location = new System.Drawing.Point(376, 6);
            this.tbxCatCode.Name = "tbxCatCode";
            this.tbxCatCode.Size = new System.Drawing.Size(284, 20);
            this.tbxCatCode.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(266, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Kod";
            // 
            // lstCategories
            // 
            this.lstCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.Location = new System.Drawing.Point(3, 3);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(257, 472);
            this.lstCategories.TabIndex = 15;
            this.lstCategories.SelectedIndexChanged += new System.EventHandler(this.lstCategories_SelectedIndexChanged);
            // 
            // tabPageStartNumbers
            // 
            this.tabPageStartNumbers.Controls.Add(this.btnAssignTags);
            this.tabPageStartNumbers.Controls.Add(this.numericUpDown1);
            this.tabPageStartNumbers.Controls.Add(this.label8);
            this.tabPageStartNumbers.Controls.Add(this.dtgStartNumbers);
            this.tabPageStartNumbers.Controls.Add(this.button1);
            this.tabPageStartNumbers.Controls.Add(this.button2);
            this.tabPageStartNumbers.Controls.Add(this.button3);
            this.tabPageStartNumbers.Location = new System.Drawing.Point(4, 22);
            this.tabPageStartNumbers.Name = "tabPageStartNumbers";
            this.tabPageStartNumbers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStartNumbers.Size = new System.Drawing.Size(1172, 474);
            this.tabPageStartNumbers.TabIndex = 5;
            this.tabPageStartNumbers.Text = "Čísla";
            this.tabPageStartNumbers.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Nový";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(551, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Vymaž";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(632, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Ulož";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dtgStartNumbers
            // 
            this.dtgStartNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgStartNumbers.AutoGenerateColumns = false;
            this.dtgStartNumbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStartNumbers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bibNumberDataGridViewTextBoxColumn,
            this.tagIDDataGridViewTextBoxColumn});
            this.dtgStartNumbers.DataSource = this.eNumberTagBindingSource1;
            this.dtgStartNumbers.Location = new System.Drawing.Point(-4, 0);
            this.dtgStartNumbers.Name = "dtgStartNumbers";
            this.dtgStartNumbers.Size = new System.Drawing.Size(396, 474);
            this.dtgStartNumbers.TabIndex = 26;
            // 
            // bibNumberDataGridViewTextBoxColumn
            // 
            this.bibNumberDataGridViewTextBoxColumn.DataPropertyName = "BibNumber";
            this.bibNumberDataGridViewTextBoxColumn.HeaderText = "BibNumber";
            this.bibNumberDataGridViewTextBoxColumn.Name = "bibNumberDataGridViewTextBoxColumn";
            // 
            // tagIDDataGridViewTextBoxColumn
            // 
            this.tagIDDataGridViewTextBoxColumn.DataPropertyName = "TagID";
            this.tagIDDataGridViewTextBoxColumn.HeaderText = "TagID";
            this.tagIDDataGridViewTextBoxColumn.Name = "tagIDDataGridViewTextBoxColumn";
            // 
            // eNumberTagBindingSource1
            // 
            this.eNumberTagBindingSource1.DataSource = typeof(RFIDTimming.Models.E_NumberTag);
            // 
            // eNumberTagBindingSource
            // 
            this.eNumberTagBindingSource.DataSource = typeof(RFIDTimming.Models.E_NumberTag);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(958, 383);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown1.TabIndex = 28;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(897, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Od čísla";
            // 
            // btnAssignTags
            // 
            this.btnAssignTags.Location = new System.Drawing.Point(1047, 380);
            this.btnAssignTags.Name = "btnAssignTags";
            this.btnAssignTags.Size = new System.Drawing.Size(75, 23);
            this.btnAssignTags.TabIndex = 29;
            this.btnAssignTags.Text = "Priradzuj";
            this.btnAssignTags.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 500);
            this.Controls.Add(this.tabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabs.ResumeLayout(false);
            this.tabPageCompetition.ResumeLayout(false);
            this.tabPageCategories.ResumeLayout(false);
            this.tabPageCategories.PerformLayout();
            this.tabPageAddEvent.ResumeLayout(false);
            this.tabPageAddEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCatLaps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCatMinLapTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCatStartOffset)).EndInit();
            this.tabPageStartNumbers.ResumeLayout(false);
            this.tabPageStartNumbers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStartNumbers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNumberTagBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNumberTagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPageCompetition;
        private System.Windows.Forms.TabPage tabPageRunners;
        private System.Windows.Forms.TabPage tabPageCategories;
        private System.Windows.Forms.TabPage tabPageClubs;
        private System.Windows.Forms.TabPage tabPageAddEvent;
        private System.Windows.Forms.DateTimePicker dtmEventDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxEventName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveEvent;
        private System.Windows.Forms.Button btnOpenEvent;
        private System.Windows.Forms.ComboBox cmbEvents;
        private System.Windows.Forms.Button btnCloseEvent;
        private System.Windows.Forms.TextBox tbxCatCatName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCatLaps;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numCatStartOffset;
        private System.Windows.Forms.NumericUpDown numCatMinLapTime;
        private System.Windows.Forms.Button btnCatSave;
        private System.Windows.Forms.Button btnCatNew;
        private System.Windows.Forms.Button btnCatDelete;
        private System.Windows.Forms.TextBox tbxCatCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.TabPage tabPageStartNumbers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dtgStartNumbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn bibNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource eNumberTagBindingSource;
        private System.Windows.Forms.BindingSource eNumberTagBindingSource1;
        private System.Windows.Forms.Button btnAssignTags;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
    }
}

