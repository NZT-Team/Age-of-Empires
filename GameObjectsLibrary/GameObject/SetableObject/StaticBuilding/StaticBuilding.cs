using System;
using System.Collections.Generic;
using System.Text;

namespace GameObjectsLibrary
{
    public class StaticBuilding:SettableObject
    {
        protected 
        public StaticBuilding():base(0,new ObjectPrice(0,0,0,0))
        {
            this.ageType = EnumAgeType.NONE;
            this.name = "Static Building";
            this.description = "Building without specials";
        }
        public StaticBuilding(double hp,ObjectPrice price) : base(0, new ObjectPrice(0, 0, 0, 0))
        {
            this.ageType = EnumAgeType.NONE;
            this.name = "Static Building";
            this.description = "Building without specials";
        }
    }
}
