using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using LunchroomLibrary.LunchroomWork;
using LunchroomLibrary.LunchroomMenu;
using LunchroomLibrary.Operations;

namespace ConsoleApp1
{
    class Program<T>
    {
        /*Dish[] dishes, Drink[] drinks, int clientId, double price*/


        static async Task Main(string[] args)
        {
            // сохранение данных
            using (FileStream fs = new FileStream("orders.json", FileMode.OpenOrCreate))
            {
                Order<T> tom = new Order<T>() { Dishes = new Dish<T>[] { new Dish<T>("Salad", new Ingredient[] { new Ingredient(StorageConditions.InRefrigerator, "Tomato", 1), new Ingredient(StorageConditions.InRefrigerator, "Salt", 0.5) },   new ProductiveCapacity<T>[] { new ProductiveCapacity<T>(1) }) },  Drinks = new Drink[] { new Drink("Juice", 1) } ,ClientId = 1 };
                await JsonSerializer.SerializeAsync<Order<T>>(fs, tom);
                Console.WriteLine("Data has been saved to file");
            }

            // чтение данных
            using (FileStream fs = new FileStream("orders.json", FileMode.OpenOrCreate))
            {
                Order<T> restoredPerson = await JsonSerializer.DeserializeAsync<Order<T>>(fs);
                Console.WriteLine($"Dishes: {restoredPerson.Dishes}  Drinks: {restoredPerson.Drinks} ClientId : {restoredPerson.ClientId}");
            }        
            Console.ReadKey();

        }
    }
}
