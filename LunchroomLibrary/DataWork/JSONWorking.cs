using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using LunchroomLibrary.LunchroomWork;
using LunchroomLibrary.LunchroomMenu;
using LunchroomLibrary.Operations;
using System.Collections.Generic;

/*using (FileStream fs = new FileStream("orderss.json", FileMode.OpenOrCreate))
            {
                Order[] tom = new Order[] { new Order() { Dishes = new Dish[] { new Dish("Salad", new Ingredient[] { new Ingredient() { StorageConditions = StorageConditions.InRefrigerator, IngredientName = "Tomato", Price = 1, Number = 2 }, new Ingredient() { StorageConditions = StorageConditions.InRefrigerator, IngredientName = "Salt", Price = 0.5, Number = 1 } }, new Operation[] { new Mixing() {Name = "Mixing",Lasting = 89, Price = 98, StartOperation = new DateTime(2021, 7, 15), Number = 1, MaxNumber = 3} }) }, Drinks = new Drink[] { new Drink("Juice", 1) }, ClientId = 1, Date = new DateTime(2011, 11, 11) } };
                await JsonSerializer.SerializeAsync<Order[]>(fs, tom);
                Console.WriteLine("Data has been saved to file");
            }
            Order[] restoredPerson = null;
            // чтение данных
            using (FileStream fs = new FileStream("orderss.json", FileMode.OpenOrCreate))
            {
                restoredPerson = await JsonSerializer.DeserializeAsync<Order[]>(fs);
            }

            var data = restoredPerson;

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
            foreach (var v in AllOrder)
                Console.WriteLine(v.ClientId + " " + v.Date + " ");
            for (int i = 0; i < AllOrder.Count; i++)
            {
                foreach (var v in AllOrder[i].Drinks)
                    Console.WriteLine(v.Name);
            }
            for (int i = 0; i < AllOrder.Count; i++)
            {
                foreach (var v in AllOrder[i].Dishes)
                    Console.WriteLine(v.Name);
            }
            WorkWithData work = new WorkWithData();
            foreach (var v in work.FreeProductiveCapacity(AllOrder))
                Console.WriteLine(v);
            foreach (var v in work.FindIngredient(StorageConditions.InRefrigerator,AllOrder))
                Console.WriteLine(v);
            foreach (var v in work.LookOrders(new DateTime(2011,1,1), new DateTime(2012, 1, 1), AllOrder))
                Console.WriteLine(v);
            foreach (var v in work.LookTheCostsOfCooking(new DateTime(2011, 1, 1), new DateTime(2012, 1, 1),AllOrder))
                Console.WriteLine(v);
            foreach (var v in work.NumberOfIngrediets(AllOrder))
                Console.WriteLine(v);
            foreach (var v in work.TheMostPopularIngredient(AllOrder))
                Console.WriteLine(v);
            foreach (var v in work.TheMostUnpopularIngredient(AllOrder))
                Console.WriteLine(v);
            foreach (var v in work.FindTheLongestAndExpensiveOperation(AllOrder))
                Console.WriteLine(v.Name);
            Console.ReadKey();*/

namespace LunchroomLibrary.DataWork
{
    public  class JSONWorking
    {
        public async Task JsonSerialize(string fileName, Order[] order ) 
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<Order[]>(fs, order);
            }

        }
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
