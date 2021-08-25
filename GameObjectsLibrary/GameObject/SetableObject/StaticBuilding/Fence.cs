using System;
using System.Collections.Generic;
using System.Text;

namespace GameObjectsLibrary
{
    public class Fence:StaticBuilding
    {
        public Fence() : base(0, new ObjectPrice(0, 50, 0, 0))
        {
            
            this.ageType = EnumAgeType.NONE;
            this.name = "Static Building";
            this.description = "Building without specials";
        }


    }
}
