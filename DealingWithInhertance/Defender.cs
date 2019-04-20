using System;
using System.Collections.Generic;
using System.Text;

namespace DealingWithInhertance
{
    public class Defender : Player
    {
        public Defender(int id, string Name, int T_Shirt, int DPower, int DRate) : base(id, Name, T_Shirt)
        {
            Power = DPower;
            DefenceRate = DRate;
        }
        public int Power { get; set; }
        public int DefenceRate { get; set; }

        public new string DisplayPlayer()
        {
            return base.DisplayPlayer() + $"Defender Power Is : {Power} And Defence Rate = {DefenceRate}";
        }
    }
}
