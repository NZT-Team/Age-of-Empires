using System;
using System.Collections.Generic;
using System.Text;

namespace GameObjectsLibrary
{
    public class Axe:Warrior
    {
        public Axe():base(50,new ObjectPrice(0,50,0,0),5,15,4)
        {
            this.price = new ObjectPrice(0, 100, 0, 0);
            this.ageType = EnumAgeType.TOOL;
            this.name = "Warrior with Axe";
            this.description = "Better variation of warrior with dubina. Warrior with Axe has more health, damage and atack range.";
        }
    }
}
