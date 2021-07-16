using LunchroomLibrary.LunchroomMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchroomLibrary.LunchroomWork
{
    /// <summary>
    /// Class for order
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Empty constructor
        /// </summary>
        public Order()
        {
        }

        /// <summary>
        /// Constructor with params
        /// </summary>
        /// <param name="dishes">Array of dishes</param>
        /// <param name="drinks">Array of drinks</param>
        /// <param name="clientId">Id of client</param>
        /// <param name="date">Date of order</param>
        public Order(Dish[] dishes, Drink[] drinks, int clientId, DateTime date)
        {
            Dishes = dishes;
            Drinks = drinks;
            ClientId = clientId;
            Date = date;
        }

        /// <summary>
        /// Array of dishes
        /// </summary>
        public Dish[] Dishes{ get; set; }

        /// <summary>
        /// Array of drinks
        /// </summary>
        public Drink[] Drinks { get; set; }

        /// <summary>
        /// Id of client
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        /// Date of order
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Method overriding Equals()
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>True or false</returns>
        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   EqualityComparer<Dish[]>.Default.Equals(Dishes, order.Dishes) &&
                   EqualityComparer<Drink[]>.Default.Equals(Drinks, order.Drinks) &&
                   ClientId == order.ClientId &&
                   Date == order.Date;
        }

        /// <summary>
        /// Method overriding GetHashCode()
        /// </summary>
        /// <returns>Hash-code</returns>
        public override int GetHashCode()
        {
            int hashCode = 1842003699;
            hashCode = hashCode * -1521134295 + EqualityComparer<Dish[]>.Default.GetHashCode(Dishes);
            hashCode = hashCode * -1521134295 + EqualityComparer<Drink[]>.Default.GetHashCode(Drinks);
            hashCode = hashCode * -1521134295 + ClientId.GetHashCode();
            hashCode = hashCode * -1521134295 + Date.GetHashCode();
            return hashCode;
        }

        /// <summary>
        /// Override method ToString()
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return ClientId.ToString();
        }
    }
}
