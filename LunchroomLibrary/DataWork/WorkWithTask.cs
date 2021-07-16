using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LunchroomLibrary.LunchroomWork;
using System.Threading.Tasks;

namespace LunchroomLibrary.DataWork
{
    /// <summary>
    /// Класс для работы с Task
    /// </summary>
    public class WorkWithTask
    {
        public List<Order> CreateList()
        {
            JSONWorking jSONWorking = new JSONWorking();
            var data = jSONWorking.JsonReadAsync("orderss.json");

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
