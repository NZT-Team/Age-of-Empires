using System;
using System.Collections.Generic;
using System.Text;

namespace GameObjectsLibrary
{
    public class Unit:SettableObject
    {
        protected double damage { set; get; }
        protected double range { set; get; }
        protected double speed { set; get; }

        public Unit():base()
        {
            this.damage = 0;
            this.range = 0;
            this.speed = 0;
            this.name = "Unit";
            this.description = "Default unit.";
        }
        public Unit(double hp,ObjectPrice price,double damage,double range,double speed) : base(hp,price)
        {
            this.damage = damage;
            this.range = range;
            this.name = "Unit";
            this.description = "Default unit.";
            this.speed = speed;
        }
    }
}
