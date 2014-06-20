using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections.Generic;

namespace TheExpense.Models
{
    public class Participant
    {
        public string FullName
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int ID
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public virtual ICollection<ParticipantGroupMapping> Groups { get; set; }
    }
}
