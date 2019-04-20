using System;
using System.Collections.Generic;
using System.Text;

namespace DealingWithInhertance
{
    public class Player
    {
        public Player():this(100,"Player",0)
        {}

        public Player(int _ID , string _name , int Num)
        {
            Id = _ID;
            Name = _name;
            TshirtNumber = Num;
        }

        public Player(int _ID, string _name)
        {
            Id = _ID;
            Name = _name;
            TshirtNumber = 0;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int TshirtNumber { get; set; }

        public string DisplayPlayer()
        {
            return $"ID = {Id}  Name = {Name}  Tshirt Number = {TshirtNumber}";
        }
    }
}
