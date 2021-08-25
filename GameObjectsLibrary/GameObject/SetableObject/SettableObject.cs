using System;
using System.Collections.Generic;
using System.Text;

namespace GameObjectsLibrary
{


    public class SettableObject : GameObject
    {
        private double hp { set; get; }
        private ObjectPrice unitPrice {set;get;}

        public SettableObject():base()
        {
            this.hp = 0;
            this.unitPrice = new ObjectPrice(0,0,0,0);
            base.name = "Setteble Game Object";
            base.description = "Object that can be set on field.";
        }
        public SettableObject(double hp,ObjectPrice price) : base()
        {
            this.hp = hp;
            this.unitPrice = new ObjectPrice(price);
            base.name = "Setteble Game Object";
            base.description = "Object that can be set on field.";
        }


    }
}
