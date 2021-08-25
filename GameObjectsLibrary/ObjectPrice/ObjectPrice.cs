using System;
using System.Collections.Generic;
using System.Text;

namespace GameObjectsLibrary
{
    public class ObjectPrice
    {
        public int price;
        public int food;
        public int wood;
        public int stone;

        public ObjectPrice(int price,int food,int wood,int stone)
        {
            this.price = price;
            this.food = food;
            this.wood = wood;
            this.stone = stone;
        }
        public ObjectPrice(ObjectPrice other)
        {
            this.price = other.price;
            this.food = other.food;
            this.wood = other.wood;
            this.stone = other.stone;
        }

    }
}
