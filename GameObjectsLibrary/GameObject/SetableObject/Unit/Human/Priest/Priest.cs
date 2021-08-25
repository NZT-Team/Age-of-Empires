using System;
using System.Collections.Generic;
using System.Text;

namespace GameObjectsLibrary
{
    public class Priest:Human
    {
        public Priest():base(25,new ObjectPrice(125,0,0,0),0,10,4) {
            this.ageType = EnumAgeType.STONE;
            this.price = new ObjectPrice(125, 0, 0, 0);
            this.name = "Priest";
            this.description = "Healing friendly units and turns enemies to alies side.";
        }

    }
}
