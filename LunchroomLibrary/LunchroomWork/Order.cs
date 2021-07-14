using LunchroomLibrary.LunchroomMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchroomLibrary.LunchroomWork
{
    public class Order
    {
        public Order()
        {
        }

        public Order(Dish[] dishes, Drink[] drinks, int clientId /*,double price*/)
        {
            Dishes = dishes;
            Drinks = drinks;
            ClientId = clientId;
            //Price = price;
        }

        public Dish[] Dishes{ get; set; }
        public Drink[] Drinks { get; set; }
        public int ClientId { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
        //public double Price { get; set; }




    }
}
