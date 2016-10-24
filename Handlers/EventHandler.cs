using Impinj.OctaneSdk;
using RFIDTimming.Data;
using RFIDTimming.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace RFIDTimming.Handlers
{

    class EventsHandler : BaseHandler
    {
        E_Events ActiveEvent = null;

        public EventsHandler(E_Events ev) : base(ev != null ? (int?)ev.EventID : null)
        {
        }

        public EventsHandler(int? eventID, Context context) : base(eventID, context)
        {
        }

        /// <summary>
        /// Get event by ID
        /// </summary>
        /// <param name="eventID"></param>
        /// <returns></returns>
        public E_Events GetEvent()
        {
            return this.Context.E_Events.FirstOrDefault(x => x.EventID == this.ActiveEventID);
        }

        /// <summary>
        /// Return active event
        /// </summary>
        /// <returns></returns>
        public E_Events GetActiveEvent()
        {
            return this.ActiveEvent;

        }

        /// <summary>
        /// Create or update event
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="eventDate"></param>
        /// <returns></returns>
        public E_Events CreateUpdateEvent(string eventName, DateTime eventDate)
        {
            if(this.ActiveEventID.HasValue)
            {
                // get event
               var ev = this.GetEvent();
                if(ev == null)
                {
                    MessageBox.Show("Chyba",
                                    "Pretek nebol najdeny",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button1);

                    return null;
                }

                ev.EventDateTime = eventDate;
                ev.EventName = eventName;

                this.Context.SaveChanges();

                return ev;
            }
            else
            {
                var newEvent = new E_Events
                {
                    EventDateTime = eventDate,
                    EventName = eventName,
                };
                this.Context.E_Events.Add(newEvent);

                this.Context.SaveChanges();

                // set new event as active event
                this.ActiveEventID = newEvent.EventID;

                return newEvent;
            }
        }

        /// <summary>
        /// Get all events
        /// </summary>
        /// <returns></returns>
        public List<E_Events> GetEvents()
        {
           return this.Context.E_Events.OrderByDescending(o => o.EventDateTime).ToList();
        }

        /// <summary>
        /// Set active event id
        /// </summary>
        /// <param name="eventID"></param>
        public void SetActiveEvent(int? eventID)
        {
            this.ActiveEventID = eventID;
            // get event from DB
           this.ActiveEvent = this.GetEvent();
        }

    }
}
