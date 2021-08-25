using System;
using System.Collections.Generic;
using System.Text;

namespace GameObjectsLibrary
{
    public class Slinger:Warrior
    {
        public Slinger() : base(25, new ObjectPrice(0, 40, 0, 10), 2, 25, 6)
        {
            this.price = new ObjectPrice(0, 40, 0, 10);
            this.ageType = EnumAgeType.TOOL;
            this.name = "Slinger";
            this.description = "Warrior that can throw stones in enemies.";
        }
    }
}
