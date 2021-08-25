using System;
using System.Collections.Generic;
using System.Text;

namespace GameObjectsLibrary
{
    public class Warrior:Human
    {
        public Warrior():base(40,new ObjectPrice(0,50,0,0),3,10,4) {
            this.name = "Warrior";
            this.description = "Warrior is takes part in figthing with weapons";
        }
        public Warrior(double hp,ObjectPrice price,double damage,double range,double speed) : base(40, new ObjectPrice(0, 50, 0, 0), 3, 10, 4)
        {
            this.name = "Warrior";
            this.description = "Warrior is takes part in figthing with weapons";
        }
    }
}
