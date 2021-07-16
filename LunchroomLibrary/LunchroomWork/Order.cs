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

        public Order(Dish[] dishes, Drink[] drinks, int clientId, DateTime date)
        {
            Dishes = dishes;
            Drinks = drinks;
            ClientId = clientId;
            Date = date;
        }
        /*public double DishCosts() 
        {
            double costs = 0.0;
            foreach (var v in Dishes) 
            {
                foreach (var v1 in v.Ingredients)
                    costs += v1.Price;
                foreach (var v1 in v.CookingSequence)
                    costs += v1.Price;
            }
            return costs;
        }*/
        
        

        public Dish[] Dishes{ get; set; }
        public Drink[] Drinks { get; set; }
        public int ClientId { get; set; }
        public DateTime Date { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   EqualityComparer<Dish[]>.Default.Equals(Dishes, order.Dishes) &&
                   EqualityComparer<Drink[]>.Default.Equals(Drinks, order.Drinks) &&
                   ClientId == order.ClientId &&
                   Date == order.Date;
        }

        public override int GetHashCode()
        {
            int hashCode = 1842003699;
            hashCode = hashCode * -1521134295 + EqualityComparer<Dish[]>.Default.GetHashCode(Dishes);
            hashCode = hashCode * -1521134295 + EqualityComparer<Drink[]>.Default.GetHashCode(Drinks);
            hashCode = hashCode * -1521134295 + ClientId.GetHashCode();
            hashCode = hashCode * -1521134295 + Date.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return ClientId.ToString();
        }
        //public double Price { get; set; }




    }
}
