using System;
using System.Collections.Generic;
using System.Text;

namespace GameObjectsLibrary
{
    public class Lion:Animal
    {
        public Lion(): base(20, new ObjectPrice(0, 10, 0, 0), 3, 5, 10)
        {
            this.ageType = EnumAgeType.NONE;
            this.price = new ObjectPrice(0, 10, 0, 0);
            this.name = "Lion";
            this.description = "Lion is dengerous animal, also can be a food source.";
        }
    }
}
