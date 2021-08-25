using System;
using System.Collections.Generic;
using System.Text;

namespace GameObjectsLibrary
{
    public class Ship:Unit
    {
        public Ship():base(0,new ObjectPrice(0,0,0,0),0,0,0)
        {
            this.price = new ObjectPrice(0,0,0,0);
            this.ageType = EnumAgeType.NONE;
            this.name = "Ship";
            this.description = "Ship can only move in water.";
        }
    }
}
