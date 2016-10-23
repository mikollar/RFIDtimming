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
            this.tabPageRunners = new System.Windows.Forms.TabPage();
            this.tabPageCategories = new System.Windows.Forms.TabPage();
            this.tabPageClubs = new System.Windows.Forms.TabPage();
            this.tabPageAddEvent = new System.Windows.Forms.TabPage();
            this.btnSaveEvent = new System.Windows.Forms.Button();
            this.dtmEventDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxEventName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenEvent = new System.Windows.Forms.Button();
            this.cmbEvents = new System.Windows.Forms.ComboBox();
            this.tabs.SuspendLayout();
            this.tabPageCompetition.SuspendLayout();
            this.tabPageAddEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPageCompetition);
            this.tabs.Controls.Add(this.tabPageRunners);
            this.tabs.Controls.Add(this.tabPageCategories);
            this.tabs.Controls.Add(this.tabPageClubs);
            this.tabs.Controls.Add(this.tabPageAddEvent);
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
            this.tabPageAddEvent.ResumeLayout(false);
            this.tabPageAddEvent.PerformLayout();
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
    }
}

