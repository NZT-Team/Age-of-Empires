using System;
using System.Collections.Generic;
using System.Text;

namespace GameObjectsLibrary
{
    public class Fish:Animal
    {
        public Fish():base(1,new ObjectPrice(0,10,0,0),0,0,0)
        {
            this.ageType = EnumAgeType.NONE;
            this.price = new ObjectPrice(0, 10, 0, 0);
            this.name = "Fish";
            this.description = "Fish is peacful animal. The source of food.";
       }
}
}
