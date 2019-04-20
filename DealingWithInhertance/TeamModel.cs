using System;
using System.Collections.Generic;
using System.Text;

namespace DealingWithInhertance
{
    public class TeamModel
    {
        public int TeamID { get; set; }
        public string Name { get; set; }
        public Coach TeamCoach { get; set; }
        public object[] Players { get; set; }
    }
}
