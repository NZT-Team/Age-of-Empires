using System;
using System.Collections.Generic;
using System.Text;

namespace GameObjectsLibrary
{
    public class Animal:Unit
    {
        public Animal() : base(0,new ObjectPrice(0,0,0,0),0,0,0) {
            this.ageType = EnumAgeType.NONE;
            this.price = new ObjectPrice(0,0,0,0);
            this.name = "Animal";
            this.description = "Default Animal";
        }
        public Animal(double hp, ObjectPrice price, double damage, double range, double speed) : base(hp, new ObjectPrice(price), damage, range, speed)
        {
        }
    }
}
