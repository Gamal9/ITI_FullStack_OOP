using System;
using System.Collections.Generic;
using System.Text;

namespace DealingWithInhertance
{
    public class GoalKeeper : Player
    {
        public GoalKeeper(int id,string Name,int T_Shirt,int GKPower,int height):base(id,Name,T_Shirt)
        {
            Power = GKPower;
            Height = height;
        }
        public int Power { get; set; }
        public int Height { get; set; }

        public new string DisplayPlayer()
        {
            return base.DisplayPlayer() + $"Goal Keeper Power Is : {Power} And Height = {Height} cm";
        }
    }
}
