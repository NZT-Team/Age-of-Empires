using System;
using System.Collections.Generic;
using System.Text;

namespace GameObjectsLibrary
{
    public class Bird:Animal
    {
        public Bird():base(1,new ObjectPrice(0,0,0,0),0,0,10)
        {
            this.ageType = EnumAgeType.NONE;
            this.price = new ObjectPrice(0, 0, 0, 0);
            this.name = "Bird";
            this.description = "Bird just flying.";
        }
    }
}
