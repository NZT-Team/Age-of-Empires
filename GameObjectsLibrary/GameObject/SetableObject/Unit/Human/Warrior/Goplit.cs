using System;
using System.Collections.Generic;
using System.Text;

namespace GameObjectsLibrary
{
    public class Goplit:Warrior
    {
        public Goplit() : base(120, new ObjectPrice(40, 60, 0, 0), 17, 15, 2)
        {
            this.price = new ObjectPrice(15, 35, 0, 0);
            this.ageType = EnumAgeType.BRONZE;
            this.name = "Goplit";
            this.description = "Slow and heavy warrior with a lot of damage.";
        }
    }
}
