using System;
using System.Collections.Generic;
using System.Text;

namespace GameObjectsLibrary
{
    public class Dubina:Warrior
    {
        public Dubina():base()
        {
            this.ageType = EnumAgeType.STONE;
            this.price = new ObjectPrice(0, 50, 0, 0);
            this.name = "Warrior with Dubina";
            this.description = "Just a warrior with acute dubina.";
        }
    }
}
