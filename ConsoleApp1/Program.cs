using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LunchroomLibrary.DataWork;
using LunchroomLibrary.LunchroomMenu;
using LunchroomLibrary.LunchroomWork;
using LunchroomLibrary.Operations;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
//            Order order = new Order() { Dishes = new Dish[] { new Dish("Salad", new Ingredient[] { new Ingredient() { StorageConditions = StorageConditions.InRefrigerator, IngredientName = "Tomato", Price = 1, Number = 2 }, new Ingredient() { StorageConditions = StorageConditions.InRefrigerator, IngredientName = "Salt", Price = 0.5, Number = 1 } }, new Operation[] { new Mixing() { Name = "Mixing", Lasting = 89, Price = 98, StartOperation = new DateTime(2021, 7, 15), Number = 1, MaxNumber = 3 } }) }, Drinks = new Drink[] { new Drink("Juice", 1) }, ClientId = 1, Date = new DateTime(2011, 11, 11) };
//            Order order1 = new Order() { Dishes = new Dish[] { new Dish("Salad", new Ingredient[] { new Ingredient() { StorageConditions = StorageConditions.InRefrigerator, IngredientName = "Tomato", Price = 1, Number = 2 }, new Ingredient() { StorageConditions = StorageConditions.InRefrigerator, IngredientName = "Salt", Price = 0.5, Number = 1 } }, new Operation[] { new Mixing() { Name = "Mixing", Lasting = 89, Price = 98, StartOperation = new DateTime(2021, 7, 15), Number = 1, MaxNumber = 3 } }) }, Drinks = new Drink[] { new Drink("Juice", 1) }, ClientId = 1, Date = new DateTime(2011, 11, 11) };
//            Order[] orders = new Order[] { order, order1 };
          JSONWorking jSON = new JSONWorking();
//            jSON.JsonSerialize("orders1.json",  orders);
            WorkWithTask task = new WorkWithTask();
            List<Order> AllOrder = jSON.JsonRead("orders.json").Result;
            Console.WriteLine(AllOrder.Count);
            Console.ReadKey();

        }
    }
}
