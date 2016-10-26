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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPageCompetition = new System.Windows.Forms.TabPage();
            this.cmbEvents = new System.Windows.Forms.ComboBox();
            this.btnOpenEvent = new System.Windows.Forms.Button();
            this.tabPageRunners = new System.Windows.Forms.TabPage();
            this.tbxRunnerSearch = new System.Windows.Forms.TextBox();
            this.tbxRunnerStartNumber = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnNewRunner = new System.Windows.Forms.Button();
            this.btnDeleteRunner = new System.Windows.Forms.Button();
            this.btnRunnerSave = new System.Windows.Forms.Button();
            this.tbxRunnerResultTime = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbRunnerCategory = new System.Windows.Forms.ComboBox();
            this.lstRunners = new System.Windows.Forms.ListBox();
            this.tbxRunnerName = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.tabPageCategories = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.tbxCatCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCatNew = new System.Windows.Forms.Button();
            this.btnCatDelete = new System.Windows.Forms.Button();
            this.btnCatSave = new System.Windows.Forms.Button();
            this.numCatStartOffset = new System.Windows.Forms.NumericUpDown();
            this.numCatMinLapTime = new System.Windows.Forms.NumericUpDown();
            this.numCatLaps = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCatCatName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageClubs = new System.Windows.Forms.TabPage();
            this.tabPageAddEvent = new System.Windows.Forms.TabPage();
            this.btnCloseEvent = new System.Windows.Forms.Button();
            this.btnSaveEvent = new System.Windows.Forms.Button();
            this.dtmEventDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxEventName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageStartNumbers = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblReadMessage = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxReadTime = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxReadRunner = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxReadStartNumber = new System.Windows.Forms.TextBox();
            this.tbxReadTag = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbRFIDMode = new System.Windows.Forms.ComboBox();
            this.btnConnectToRFID = new System.Windows.Forms.Button();
            this.btnAssignTags = new System.Windows.Forms.Button();
            this.nmrFromStartNumber = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgStartNumbers = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabResults = new System.Windows.Forms.TabPage();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabs.SuspendLayout();
            this.tabPageCompetition.SuspendLayout();
            this.tabPageRunners.SuspendLayout();
            this.tabPageCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCatStartOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCatMinLapTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCatLaps)).BeginInit();
            this.tabPageAddEvent.SuspendLayout();
            this.tabPageStartNumbers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFromStartNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStartNumbers)).BeginInit();
            this.tabResults.SuspendLayout();
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
            this.tabs.Controls.Add(this.tabResults);
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
            this.tabPageRunners.Controls.Add(this.tbxRunnerSearch);
            this.tabPageRunners.Controls.Add(this.tbxRunnerStartNumber);
            this.tabPageRunners.Controls.Add(this.label18);
            this.tabPageRunners.Controls.Add(this.btnNewRunner);
            this.tabPageRunners.Controls.Add(this.btnDeleteRunner);
            this.tabPageRunners.Controls.Add(this.btnRunnerSave);
            this.tabPageRunners.Controls.Add(this.tbxRunnerResultTime);
            this.tabPageRunners.Controls.Add(this.label15);
            this.tabPageRunners.Controls.Add(this.label17);
            this.tabPageRunners.Controls.Add(this.cmbRunnerCategory);
            this.tabPageRunners.Controls.Add(this.lstRunners);
            this.tabPageRunners.Controls.Add(this.tbxRunnerName);
            this.tabPageRunners.Controls.Add(this.lbl1);
            this.tabPageRunners.Location = new System.Drawing.Point(4, 22);
            this.tabPageRunners.Name = "tabPageRunners";
            this.tabPageRunners.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRunners.Size = new System.Drawing.Size(1172, 474);
            this.tabPageRunners.TabIndex = 1;
            this.tabPageRunners.Text = "Bezci";
            this.tabPageRunners.UseVisualStyleBackColor = true;
            // 
            // tbxRunnerSearch
            // 
            this.tbxRunnerSearch.Location = new System.Drawing.Point(0, 8);
            this.tbxRunnerSearch.Name = "tbxRunnerSearch";
            this.tbxRunnerSearch.Size = new System.Drawing.Size(257, 20);
            this.tbxRunnerSearch.TabIndex = 41;
            // 
            // tbxRunnerStartNumber
            // 
            this.tbxRunnerStartNumber.Location = new System.Drawing.Point(363, 39);
            this.tbxRunnerStartNumber.Name = "tbxRunnerStartNumber";
            this.tbxRunnerStartNumber.Size = new System.Drawing.Size(102, 20);
            this.tbxRunnerStartNumber.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(285, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 39;
            this.label18.Text = "St.c.";
            // 
            // btnNewRunner
            // 
            this.btnNewRunner.Location = new System.Drawing.Point(480, 154);
            this.btnNewRunner.Name = "btnNewRunner";
            this.btnNewRunner.Size = new System.Drawing.Size(75, 23);
            this.btnNewRunner.TabIndex = 38;
            this.btnNewRunner.Text = "Nový";
            this.btnNewRunner.UseVisualStyleBackColor = true;
            this.btnNewRunner.Click += new System.EventHandler(this.btnNewRunner_Click);
            // 
            // btnDeleteRunner
            // 
            this.btnDeleteRunner.Location = new System.Drawing.Point(388, 154);
            this.btnDeleteRunner.Name = "btnDeleteRunner";
            this.btnDeleteRunner.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRunner.TabIndex = 37;
            this.btnDeleteRunner.Text = "Vymaž";
            this.btnDeleteRunner.UseVisualStyleBackColor = true;
            this.btnDeleteRunner.Click += new System.EventHandler(this.btnDeleteRunner_Click);
            // 
            // btnRunnerSave
            // 
            this.btnRunnerSave.Location = new System.Drawing.Point(572, 154);
            this.btnRunnerSave.Name = "btnRunnerSave";
            this.btnRunnerSave.Size = new System.Drawing.Size(75, 23);
            this.btnRunnerSave.TabIndex = 36;
            this.btnRunnerSave.Text = "Ulož";
            this.btnRunnerSave.UseVisualStyleBackColor = true;
            this.btnRunnerSave.Click += new System.EventHandler(this.btnRunnerSave_Click);
            // 
            // tbxRunnerResultTime
            // 
            this.tbxRunnerResultTime.Location = new System.Drawing.Point(363, 118);
            this.tbxRunnerResultTime.Name = "tbxRunnerResultTime";
            this.tbxRunnerResultTime.Size = new System.Drawing.Size(102, 20);
            this.tbxRunnerResultTime.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(285, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Cas";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(285, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Kategoria";
            // 
            // cmbRunnerCategory
            // 
            this.cmbRunnerCategory.FormattingEnabled = true;
            this.cmbRunnerCategory.Location = new System.Drawing.Point(363, 91);
            this.cmbRunnerCategory.Name = "cmbRunnerCategory";
            this.cmbRunnerCategory.Size = new System.Drawing.Size(284, 21);
            this.cmbRunnerCategory.TabIndex = 32;
            // 
            // lstRunners
            // 
            this.lstRunners.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstRunners.FormattingEnabled = true;
            this.lstRunners.Location = new System.Drawing.Point(0, 39);
            this.lstRunners.Name = "lstRunners";
            this.lstRunners.Size = new System.Drawing.Size(257, 433);
            this.lstRunners.TabIndex = 20;
            this.lstRunners.SelectedIndexChanged += new System.EventHandler(this.lstRunners_SelectedIndexChanged);
            // 
            // tbxRunnerName
            // 
            this.tbxRunnerName.Location = new System.Drawing.Point(363, 65);
            this.tbxRunnerName.Name = "tbxRunnerName";
            this.tbxRunnerName.Size = new System.Drawing.Size(284, 20);
            this.tbxRunnerName.TabIndex = 19;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl1.Location = new System.Drawing.Point(285, 68);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(38, 13);
            this.lbl1.TabIndex = 18;
            this.lbl1.Text = "Meno";
            // 
            // tabPageCategories
            // 
            this.tabPageCategories.Controls.Add(this.label16);
            this.tabPageCategories.Controls.Add(this.label14);
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
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(447, 145);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "sekund";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(447, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "sekund";
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
            // numCatStartOffset
            // 
            this.numCatStartOffset.Location = new System.Drawing.Point(376, 143);
            this.numCatStartOffset.Name = "numCatStartOffset";
            this.numCatStartOffset.Size = new System.Drawing.Size(65, 20);
            this.numCatStartOffset.TabIndex = 9;
            // 
            // numCatMinLapTime
            // 
            this.numCatMinLapTime.Location = new System.Drawing.Point(376, 108);
            this.numCatMinLapTime.Name = "numCatMinLapTime";
            this.numCatMinLapTime.Size = new System.Drawing.Size(65, 20);
            this.numCatMinLapTime.TabIndex = 8;
            this.numCatMinLapTime.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // numCatLaps
            // 
            this.numCatLaps.Location = new System.Drawing.Point(376, 72);
            this.numCatLaps.Name = "numCatLaps";
            this.numCatLaps.Size = new System.Drawing.Size(65, 20);
            this.numCatLaps.TabIndex = 7;
            this.numCatLaps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // tabPageStartNumbers
            // 
            this.tabPageStartNumbers.Controls.Add(this.groupBox1);
            this.tabPageStartNumbers.Controls.Add(this.label9);
            this.tabPageStartNumbers.Controls.Add(this.cmbRFIDMode);
            this.tabPageStartNumbers.Controls.Add(this.btnConnectToRFID);
            this.tabPageStartNumbers.Controls.Add(this.btnAssignTags);
            this.tabPageStartNumbers.Controls.Add(this.nmrFromStartNumber);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblReadMessage);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbxReadTime);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbxReadRunner);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbxReadStartNumber);
            this.groupBox1.Controls.Add(this.tbxReadTag);
            this.groupBox1.Location = new System.Drawing.Point(791, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 183);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblReadMessage
            // 
            this.lblReadMessage.AutoSize = true;
            this.lblReadMessage.Location = new System.Drawing.Point(13, 132);
            this.lblReadMessage.Name = "lblReadMessage";
            this.lblReadMessage.Size = new System.Drawing.Size(0, 13);
            this.lblReadMessage.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(6, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Čas";
            // 
            // tbxReadTime
            // 
            this.tbxReadTime.Location = new System.Drawing.Point(68, 45);
            this.tbxReadTime.Name = "tbxReadTime";
            this.tbxReadTime.Size = new System.Drawing.Size(106, 20);
            this.tbxReadTime.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(6, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Pretekár";
            // 
            // tbxReadRunner
            // 
            this.tbxReadRunner.Location = new System.Drawing.Point(68, 97);
            this.tbxReadRunner.Name = "tbxReadRunner";
            this.tbxReadRunner.Size = new System.Drawing.Size(207, 20);
            this.tbxReadRunner.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(6, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Číslo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Čip";
            // 
            // tbxReadStartNumber
            // 
            this.tbxReadStartNumber.Location = new System.Drawing.Point(68, 71);
            this.tbxReadStartNumber.Name = "tbxReadStartNumber";
            this.tbxReadStartNumber.Size = new System.Drawing.Size(106, 20);
            this.tbxReadStartNumber.TabIndex = 1;
            // 
            // tbxReadTag
            // 
            this.tbxReadTag.Location = new System.Drawing.Point(68, 19);
            this.tbxReadTag.Name = "tbxReadTag";
            this.tbxReadTag.Size = new System.Drawing.Size(207, 20);
            this.tbxReadTag.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(791, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "RFID mod";
            // 
            // cmbRFIDMode
            // 
            this.cmbRFIDMode.FormattingEnabled = true;
            this.cmbRFIDMode.Location = new System.Drawing.Point(865, 48);
            this.cmbRFIDMode.Name = "cmbRFIDMode";
            this.cmbRFIDMode.Size = new System.Drawing.Size(164, 21);
            this.cmbRFIDMode.TabIndex = 31;
            // 
            // btnConnectToRFID
            // 
            this.btnConnectToRFID.Location = new System.Drawing.Point(941, 6);
            this.btnConnectToRFID.Name = "btnConnectToRFID";
            this.btnConnectToRFID.Size = new System.Drawing.Size(88, 23);
            this.btnConnectToRFID.TabIndex = 30;
            this.btnConnectToRFID.Text = "Pripoj k RFID";
            this.btnConnectToRFID.UseVisualStyleBackColor = true;
            this.btnConnectToRFID.Click += new System.EventHandler(this.btnConnectToRFID_Click);
            // 
            // btnAssignTags
            // 
            this.btnAssignTags.Location = new System.Drawing.Point(954, 88);
            this.btnAssignTags.Name = "btnAssignTags";
            this.btnAssignTags.Size = new System.Drawing.Size(75, 23);
            this.btnAssignTags.TabIndex = 29;
            this.btnAssignTags.Text = "Priradzuj";
            this.btnAssignTags.UseVisualStyleBackColor = true;
            // 
            // nmrFromStartNumber
            // 
            this.nmrFromStartNumber.Location = new System.Drawing.Point(865, 88);
            this.nmrFromStartNumber.Name = "nmrFromStartNumber";
            this.nmrFromStartNumber.Size = new System.Drawing.Size(65, 20);
            this.nmrFromStartNumber.TabIndex = 28;
            this.nmrFromStartNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(799, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Od čísla";
            // 
            // dtgStartNumbers
            // 
            this.dtgStartNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgStartNumbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStartNumbers.Location = new System.Drawing.Point(-4, 0);
            this.dtgStartNumbers.Name = "dtgStartNumbers";
            this.dtgStartNumbers.Size = new System.Drawing.Size(396, 474);
            this.dtgStartNumbers.TabIndex = 26;
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
            // tabResults
            // 
            this.tabResults.Controls.Add(this.reportViewer);
            this.tabResults.Location = new System.Drawing.Point(4, 22);
            this.tabResults.Name = "tabResults";
            this.tabResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabResults.Size = new System.Drawing.Size(1172, 474);
            this.tabResults.TabIndex = 6;
            this.tabResults.Text = "Zoznamy";
            this.tabResults.UseVisualStyleBackColor = true;
            // 
            // reportViewer
            // 
            this.reportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer.Location = new System.Drawing.Point(0, 40);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(1172, 434);
            this.reportViewer.TabIndex = 4;
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
            this.tabPageRunners.ResumeLayout(false);
            this.tabPageRunners.PerformLayout();
            this.tabPageCategories.ResumeLayout(false);
            this.tabPageCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCatStartOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCatMinLapTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCatLaps)).EndInit();
            this.tabPageAddEvent.ResumeLayout(false);
            this.tabPageAddEvent.PerformLayout();
            this.tabPageStartNumbers.ResumeLayout(false);
            this.tabPageStartNumbers.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFromStartNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStartNumbers)).EndInit();
            this.tabResults.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnAssignTags;
        private System.Windows.Forms.NumericUpDown nmrFromStartNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbRFIDMode;
        private System.Windows.Forms.Button btnConnectToRFID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxReadRunner;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxReadStartNumber;
        private System.Windows.Forms.TextBox tbxReadTag;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxReadTime;
        private System.Windows.Forms.Label lblReadMessage;
        private System.Windows.Forms.ListBox lstRunners;
        private System.Windows.Forms.TextBox tbxRunnerName;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbRunnerCategory;
        private System.Windows.Forms.TextBox tbxRunnerResultTime;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnNewRunner;
        private System.Windows.Forms.Button btnDeleteRunner;
        private System.Windows.Forms.Button btnRunnerSave;
        private System.Windows.Forms.TextBox tbxRunnerSearch;
        private System.Windows.Forms.TextBox tbxRunnerStartNumber;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tabResults;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}

