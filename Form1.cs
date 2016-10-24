using RFIDTimming.Data;
using RFIDTimming.Handlers;
using RFIDTimming.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RFIDTimming
{
    public partial class Form1 : Form
    {
        EventsHandler evHandler = null;

        public Form1()
        {
            InitializeComponent();

            evHandler = new EventsHandler(null);

            dtmEventDate.CustomFormat = "dd.MM.yyyy H:mm";

            // tab selected event
            tabs.Selected += Tabs_Selected;

            // select open event tab
            tabs.SelectTab(tabPageCompetition);
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

            if(e.TabPage == tabPageCompetition)
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
    }
}
