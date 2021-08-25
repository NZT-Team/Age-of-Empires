using System;
using System.Collections.Generic;
using System.Text;

namespace GameObjectsLibrary
{
   public class GameObject
   {
        protected EnumAgeType ageType {  set;  get; }
        protected ObjectPrice price { set; get; }
        protected string name { set; get; }
        protected string description { set; get; }
        public GameObject() 
        {
            ageType = EnumAgeType.NONE;
            price = new ObjectPrice(0,0,0,0);
            this.name = "Game Object";
            this.description = "Default Object";
        }
        public GameObject(EnumAgeType type, ObjectPrice price)
        {
            this.price = new ObjectPrice(price);
            this.ageType = type;
        }


    }
}
