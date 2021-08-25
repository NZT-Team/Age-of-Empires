using System;
using System.Collections.Generic;
using System.Text;

namespace GameObjectsLibrary
{
    public class Dear:Animal
    {
       public Dear():base(10,new ObjectPrice(0,10,0,0),0,0,6)
        {
            this.ageType = EnumAgeType.NONE;
            this.price = new ObjectPrice(0, 10, 0, 0);
            this.name = "Dear";
            this.description = "Dear is peacful animal. The source of food.";
       }
}
}
