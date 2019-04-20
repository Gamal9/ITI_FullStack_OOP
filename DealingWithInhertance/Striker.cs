using System;
using System.Collections.Generic;
using System.Text;

namespace DealingWithInhertance
{
    public class Striker : Player
    {
        public Striker(int id, string Name, int T_Shirt, int Shoot, int _headerRate) : base(id, Name, T_Shirt)
        {
            ShootPower = Shoot;
            HeaderRate = _headerRate;
        }
        public int ShootPower { get; set; }
        public int HeaderRate { get; set; }

        public new string DisplayPlayer()
        {
            return base.DisplayPlayer() + $"Striker Head Rate Is : {HeaderRate} And Shooting Power = {ShootPower}";
        }
    }
}
