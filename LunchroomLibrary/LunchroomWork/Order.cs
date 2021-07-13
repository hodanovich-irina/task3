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
        //public double Price { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   EqualityComparer<Dish[]>.Default.Equals(Dishes, order.Dishes) &&
                   EqualityComparer<Drink[]>.Default.Equals(Drinks, order.Drinks) &&
                   ClientId == order.ClientId;// &&
                   //Price == order.Price;
        }

        public override int GetHashCode()
        {
            int hashCode = -265333526;
            hashCode = hashCode * -1521134295 + EqualityComparer<Dish[]>.Default.GetHashCode(Dishes);
            hashCode = hashCode * -1521134295 + EqualityComparer<Drink[]>.Default.GetHashCode(Drinks);
            hashCode = hashCode * -1521134295 + ClientId.GetHashCode();
            return hashCode;
        }
    }
}
