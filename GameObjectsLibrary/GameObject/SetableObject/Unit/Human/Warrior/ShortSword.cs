using System;
using System.Collections.Generic;
using System.Text;

namespace GameObjectsLibrary
{
    public class ShortSword:Warrior
    {
        public ShortSword(): base(60, new ObjectPrice(15, 35, 0, 0), 7, 10, 4)
        {
            this.price = new ObjectPrice(15, 35, 0, 0);
            this.ageType = EnumAgeType.BRONZE;
            this.name = "Warrior with Short Sword";
            this.description = "Light Swordman with a lot of health and damage.";
        }
    }
}
