using System;
using System.Collections.Generic;
using System.Text;

namespace DealingWithInhertance
{
    public class Coach : Player
    {
        public Coach(int _id , string _name,int _crewCount) :base(_id,_name)
        {
            CrewNumber = _crewCount;
        }

        public int CrewNumber { get; set; }

        public new string DisplayPlayer()
        {
            return $"Coach ID = {base.Id} , Coach Name = {base.Name} , Coach Crew Count = {CrewNumber}";
        }
    }
}
