using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using LunchroomLibrary.LunchroomWork;
using LunchroomLibrary.LunchroomMenu;
using LunchroomLibrary.Operations;
using System.Collections.Generic;

namespace LunchroomLibrary.DataWork
{
    /// <summary>
    /// Class for work with json-file
    /// </summary>
    public  class JSONWorking
    {
        /// <summary>
        /// Method for serialize 
        /// </summary>
        /// <param name="fileName">file name for save</param>
        /// <param name="order">Array of orders</param>
        /// <returns>Task</returns>
        public async Task JsonSerialize(string fileName, Order[] order ) 
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<Order[]>(fs, order);
            }

        }
        /// <summary>
        /// Method for read json-file
        /// </summary>
        /// <param name="fileName">json-file</param>
        /// <returns>Collection of order</returns>
        public async Task<List<Order>> JsonRead(string fileName) 
        {
            Order[] orders = null;
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                orders = await JsonSerializer.DeserializeAsync<Order[]>(fs);            
            }
            var data = orders;

            List<Order> AllOrder = new List<Order>();
            for (int i = 0; i < data.Length; i++)
            {
                Order order = data[i];
                foreach (var v in data[i].Dishes)
                {
                    order.Dishes[i] = v;
                }
                foreach (var v in data[i].Drinks)
                {
                    order.Drinks[i] = v;
                }
                order.ClientId = data[i].ClientId;
                order.Date = data[i].Date;
                AllOrder.Add(order);

            }
            return AllOrder;
        }
    }
}
