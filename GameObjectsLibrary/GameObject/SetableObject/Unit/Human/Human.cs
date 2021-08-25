using System;
using System.Collections.Generic;
using System.Text;

namespace GameObjectsLibrary
{
    public class Human:Unit
    {
        public Human():base(25,new ObjectPrice(0,50,0,0),0,10,4)
        {
            this.ageType = EnumAgeType.STONE;
            this.price = new ObjectPrice(0,0,0,0);
            this.name = "Human";
            this.description = "Human that working. Doesn't take part in battles.";

        }
        public Human(double hp,ObjectPrice price,double damage,double range,double speed) : base(25, new ObjectPrice(0, 50, 0, 0), 0, 10, 4)
        {
            this.ageType = EnumAgeType.STONE;
            this.price = new ObjectPrice(0, 0, 0, 0);
            this.name = "Human";
            this.description = "Human that working. Doesn't take part in battles.";

        }

    }
}
