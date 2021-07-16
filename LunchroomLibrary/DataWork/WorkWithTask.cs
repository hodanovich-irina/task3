using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LunchroomLibrary.LunchroomWork;
using System.Threading.Tasks;

namespace LunchroomLibrary.DataWork
{
    /// <summary>
    /// Class for work with Task
    /// </summary>
    public class WorkWithTask
    {
        /// <summary>
        /// Method for create collection of order
        /// </summary>
        /// <param name="fileName">file name</param>
        /// <returns>collection of order</returns>
        public List<Order> CreateList(string fileName)
        {
            JSONWorking jSONWorking = new JSONWorking();
            var data = jSONWorking.JsonRead(fileName);

            List<Order> AllOrder = new List<Order>();
            for (int i = 0; i < data.Result.Count; i++)
            {
                Order order = new Order
                {
                    Dishes = data.Result[i].Dishes,
                    Drinks = data.Result[i].Drinks,
                    ClientId = data.Result[i].ClientId,
                    Date = data.Result[i].Date
                };
                AllOrder.Add(order);
            }
            return AllOrder;
        }
    }
}
