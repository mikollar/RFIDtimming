﻿using Microsoft.Reporting.WinForms;
using RFIDTimming.Data;
using RFIDTimming.Handlers;
using RFIDTimming.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace RFIDTimming
{
    public partial class Form1 : Form
    {
        EventsHandler evHandler = null;
        RFIDHandler rfidHandler = null;

        public Form1()
        {
            InitializeComponent();

            evHandler = new EventsHandler(null);
            rfidHandler = new RFIDHandler(null, evHandler.Context);
            // reload start numbers
            dtgStartNumbers.DataSource = rfidHandler.GetStartNumbers();

            cmbRFIDMode.DataSource = Enum.GetValues(typeof(RFIDTimming.Enums.Enums.RFIDMode));
            cmbRFIDMode.SelectedValueChanged += CmbRFIDMode_SelectedValueChanged;

            dtmEventDate.CustomFormat = "dd.MM.yyyy H:mm";

            // tab selected event
            tabs.Selected += Tabs_Selected;

            // select open event tab
            tabs.SelectTab(tabPageCompetition);

            // hide delte category button
            btnCatDelete.Hide();
        }



        /// <summary>
        /// Tab select event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tabs_Selected(object sender, TabControlEventArgs e)
        {
            // get active event
            var activeEvent = evHandler.GetActiveEvent();

            if (e.TabPage == tabPageCompetition)
            {
                // get all events and set to events dropdown list
                cmbEvents.DataSource = evHandler.GetEvents();
            }
            if (e.TabPage == tabPageAddEvent)
            {
                if (activeEvent != null)
                {
                    tbxEventName.Text = activeEvent.EventName;
                    dtmEventDate.Value = activeEvent.EventDateTime;
                }
                else
                {
                    tbxEventName.Text = "Novy pretek " + DateTime.Now.ToShortDateString();
                    dtmEventDate.Value = DateTime.Now;
                }
            }
            if (e.TabPage == tabPageRunners)
            {
                if (activeEvent != null)
                {
                    this.ReloadRunners();

                    cmbRunnerCategory.DisplayMember = "CategoryName";
                    cmbRunnerCategory.ValueMember = "CateogryID";
                    cmbRunnerCategory.DataSource = new CategoriesHandler(this.evHandler.GetActiveEvent(), this.evHandler.Context).GetCategories();
                }
                else
                {
                }
            }
            if (e.TabPage == tabPageCategories)
            {
                if (activeEvent != null)
                {
                    this.ReloadCategories();
                }
                else
                {
                }
            }
            if (e.TabPage == tabResults)
            {
                if (activeEvent != null)
                {
                    this.ShowReports();
                }
                else
                {
                }
            }
        }

        /// <summary>
        /// Form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //var dd = cnt.R_TagRead.ToList();
            // config UI
            this.ConfigUI();
            
        }

        /// <summary>
        /// Create or update event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveEvent_Click(object sender, EventArgs e)
        {
            // create or update event
            evHandler.CreateUpdateEvent(tbxEventName.Text, dtmEventDate.Value);
            // config UI
            this.ConfigUI();
        }

        /// <summary>
        /// Config UI
        /// </summary>
        private void ConfigUI()
        {
            tabs.TabPages.Remove(tabPageRunners);
            tabs.TabPages.Remove(tabPageCategories);
            tabs.TabPages.Remove(tabPageClubs);
            tabs.TabPages.Remove(tabPageCompetition);

            // event is opened
            if (evHandler.ActiveEventID != null)
            {
                tabs.TabPages.Insert(0, tabPageRunners);
                tabs.TabPages.Insert(1, tabPageCategories);
                tabs.TabPages.Insert(2, tabPageClubs);

                btnCloseEvent.Show();

                tabPageAddEvent.Text = "Pretek";
            }
            else
            {
                tabs.TabPages.Insert(0, tabPageCompetition);
                btnCloseEvent.Hide();

                tabPageAddEvent.Text = "Nový pretek";
            }

            if (rfidHandler.IsRfidConnected())
            {
                btnConnectToRFID.Enabled = false;
            }
            else
            {
                btnConnectToRFID.Enabled = true;
            }
        }

        /// <summary>
        /// Open event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenEvent_Click(object sender, EventArgs e)
        {
            // open event
            evHandler.SetActiveEvent((int)cmbEvents.SelectedValue);

            this.ConfigUI();
        }

        /// <summary>
        /// Close event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseEvent_Click(object sender, EventArgs e)
        {
            // clear active event
            evHandler.SetActiveEvent(null);

            // config UI
            this.ConfigUI();

            // select open event tab
            tabs.SelectTab(tabPageCompetition);
        }


        #region Categories
        /// <summary>
        /// Reload categories
        /// </summary>
        private void ReloadCategories()
        {
            lstCategories.DisplayMember = "CategoryName";
            lstCategories.DataSource = new CategoriesHandler(evHandler.GetActiveEvent(), evHandler.Context).GetCategories();
        }

        /// <summary>
        /// Save category button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCatSave_Click(object sender, EventArgs e)
        {
            new CategoriesHandler(evHandler.GetActiveEvent(), evHandler.Context).CreateUpdateCategory(tbxCatCode.Text, tbxCatCatName.Text, (int)numCatLaps.Value, (int)numCatMinLapTime.Value, (int)numCatStartOffset.Value);
            this.ReloadCategories();
        }

        /// <summary>
        /// New category button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCatNew_Click(object sender, EventArgs e)
        {
            tbxCatCatName.Text = string.Empty;
            tbxCatCode.Text = string.Empty;
            lstCategories.ClearSelected();
        }

        /// <summary>
        /// Delete category button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCatDelete_Click(object sender, EventArgs e)
        {
            if (lstCategories.SelectedItem != null)
            {
                var category = (E_Category)lstCategories.SelectedItem;

                new CategoriesHandler(evHandler.GetActiveEvent(), evHandler.Context).DeleteCategory(category.CategoryID);

                this.ReloadCategories();
            }
        }


        #endregion

        /// <summary>
        /// Categories list selection changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCategories.SelectedItem != null)
            {
                var category = (E_Category)lstCategories.SelectedItem;

                tbxCatCatName.Text = category.CategoryName;
                tbxCatCode.Text = category.CategoryID;
                numCatLaps.Value = category.Laps;
                numCatMinLapTime.Value = category.MinLapTime;
                numCatStartOffset.Value = category.OffsetStartTime;

                btnCatDelete.Show();
            }
            else
            {
                btnCatDelete.Hide();
            }
        }

        /// <summary>
        /// Get selected RFID mode
        /// </summary>
        /// <returns></returns>
        private RFIDTimming.Enums.Enums.RFIDMode GetSelectedRFIDMode()
        {
            RFIDTimming.Enums.Enums.RFIDMode mode;
            Enum.TryParse<RFIDTimming.Enums.Enums.RFIDMode>(cmbRFIDMode.SelectedValue.ToString(), out mode);

            return mode;
        }

        /// <summary>
        /// Connect to RFID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnectToRFID_Click(object sender, EventArgs e)
        {
            // init RFID
            lblReadMessage.Text = rfidHandler.InitRFID(RFIDCallback);
            // set RFID mode
            rfidHandler.SetRfidMode(this.GetSelectedRFIDMode(), evHandler.GetActiveEvent(), (int)nmrFromStartNumber.Value);

            this.ConfigUI();
        }

        /// <summary>
        /// On change selected RFID mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbRFIDMode_SelectedValueChanged(object sender, EventArgs e)
        {
            // set RFID mode
            rfidHandler.SetRfidMode(this.GetSelectedRFIDMode(), evHandler.GetActiveEvent(), (int)nmrFromStartNumber.Value);
        }

        /// <summary>
        /// RFID call back
        /// </summary>
        /// <param name="rfidRead"></param>
        /// <returns></returns>
        private int RFIDCallback(RFIDRead rfidRead)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                tbxReadTag.Text = "";
                tbxReadTime.Text = "";
                tbxReadRunner.Text = "";
                tbxReadTime.Text = "";
                tbxReadStartNumber.Text = "";
                lblReadMessage.Text = "";
                lblStartNumber.Text = "";

                if (rfidRead != null)
                {
                    lblReadMessage.Text = rfidRead.Error;

                    tbxReadStartNumber.Text = rfidRead.StartNumber;
                    lblStartNumber.Text = rfidRead.StartNumber;
                    if (rfidRead.Tag != null)
                    {
                        tbxReadTag.Text = rfidRead.Tag.TagID;
                        tbxReadTime.Text = rfidRead.Tag.ReadTime.ToString("h\\:mm\\:ss");
                    }

                    if (rfidRead.Runner != null)
                    {
                        System.Media.SystemSounds.Question.Play();
                        tbxReadRunner.Text = rfidRead.Runner.Surname + " " + rfidRead.Runner.Firstname;
                        tbxReadTime.Text = rfidRead.Tag.ReadTime.ToString("h\\:mm\\:ss");
                    }
                }

                // reload start numbers
                if (rfidHandler.GetRfidMode() == Enums.Enums.RFIDMode.ASSIGN)
                {
                    dtgStartNumbers.DataSource = rfidHandler.GetStartNumbers();
                }

            }));
            return 0;
        }


        #region Runners

        /// <summary>
        /// Get selected runner
        /// </summary>
        /// <returns></returns>
        private E_Runners GetSelectedRunner()
        {
            E_Runners runner = null;
            if (lstRunners.SelectedItem != null)
            {
                 runner = (E_Runners)lstRunners.SelectedItem;
            }

            return runner;
        }
    
        /// <summary>
        /// Reload runners
        /// </summary>
        private void ReloadRunners()
        {
            lstRunners.DisplayMember = "Surname";
            lstRunners.DataSource = new RunnersHandler(evHandler.GetActiveEvent(), evHandler.Context).GetRunners();
        }

        // On change selected runner
        private void lstRunners_SelectedIndexChanged(object sender, EventArgs e)
        {
           var runner = this.GetSelectedRunner();
            if(runner != null)
            {
                runner = new RunnersHandler(evHandler.GetActiveEvent(), evHandler.Context).GetRunner(runner.RunnerID, true);

                if (runner != null)
                {
                    tbxRunnerName.Text = runner.Surname;
                    tbxRunnerStartNumber.Text = runner.StartNumber;
                    cmbRunnerCategory.SelectedValue = runner.CategoryID;
                    tbxRunnerResultTime.Text = runner.ResultTime.HasValue ? runner.ResultTime.Value.ToString("h\\:mm\\:ss") : "";
                }
            }
            else
            {
                this.ClearRunnerForm();
            }
        }

        /// <summary>
        /// Clear runner form
        /// </summary>
        private void ClearRunnerForm()
        {
            tbxRunnerName.Text = string.Empty;
            tbxRunnerStartNumber.Text = string.Empty;
            tbxRunnerResultTime.Text = string.Empty;

            // clear selected runner
            lstRunners.ClearSelected();
        }

        #endregion

        /// <summary>
        /// Create/Update runner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRunnerSave_Click(object sender, EventArgs e)
        {
            int runnerID = 0;
            var selectedRunner = this.GetSelectedRunner();
            if(selectedRunner != null)
            {
                runnerID = selectedRunner.RunnerID;
            }

            var runnerCategory = (E_Category)cmbRunnerCategory.SelectedItem;

            if (runnerCategory == null)
            {
                MessageBox.Show("Vyberte kategoriu",
                                "Chyba",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);

                return;
            }

            // save to DB
            var msg = new RunnersHandler(evHandler.GetActiveEvent(), evHandler.Context).CreateUpdateRunner(runnerID, tbxRunnerName.Text, runnerCategory.CategoryID, "", tbxRunnerStartNumber.Text);
            this.ReloadRunners();

            if(!string.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg,
                                "Chyba",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
            }
        }

        // Clear form to add new runner
        private void btnNewRunner_Click(object sender, EventArgs e)
        {
            this.ClearRunnerForm();
        }

        /// <summary>
        /// Delete runner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteRunner_Click(object sender, EventArgs e)
        {
            var runner = this.GetSelectedRunner();
            if (runner != null)
            {
                new RunnersHandler(evHandler.GetActiveEvent(), evHandler.Context).DeleteRunner(runner.RunnerID);

                this.ReloadRunners();
            }
        }

        private void ShowReports()
        {

            List<ResultLap> myPeople = new List<ResultLap>();
            myPeople.Add(new ResultLap() { Name = "John", Category = "Doe" });
            myPeople.Add(new ResultLap() { Name = "Jane", Category = "Doe" });
            myPeople.Add(new ResultLap() { Name = "Jerry", Category = "Smithers" });

            this.reportViewer.LocalReport.ReportPath = "Reports\\Report1.rdlc";

            this.reportViewer.LocalReport.ReportEmbeddedResource = "ReportViewer.Report1.rdlc";

            ReportDataSource rds = new ReportDataSource("DataSet1", myPeople);
           
           reportViewer.LocalReport.DataSources.Clear();
           reportViewer.LocalReport.DataSources.Add(rds);

            string eventName = string.Empty;
            var ev = evHandler.GetActiveEvent();
            if(ev != null)
            {
                eventName = ev.EventName;
            }
           ReportParameter rp = new ReportParameter("EventName", eventName);
           reportViewer.LocalReport.SetParameters(new ReportParameter[] { rp });

            this.reportViewer.RefreshReport();
        }
    }
}
