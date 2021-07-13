using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using LunchroomLibrary.LunchroomWork;
using LunchroomLibrary.LunchroomMenu;
using LunchroomLibrary.Operations;

namespace ConsoleApp1
{
    class Program
    {
        /*Dish[] dishes, Drink[] drinks, int clientId, double price*/


        static async Task Main(string[] args)
        {
            // сохранение данных
            using (FileStream fs = new FileStream("orders.json", FileMode.OpenOrCreate))
            {
                Order tom = new Order() { Dishes = new Dish[] { new Dish("Salad", new Ingredient[] { new Ingredient(StorageConditions.InRefrigerator, "Tomato", 1), new Ingredient(StorageConditions.InRefrigerator, "Salt", 0.5) }, new string[] { "" }) },  Drinks = new Drink[] { new Drink("Juice", 1) } ,ClientId = 1 };
                await JsonSerializer.SerializeAsync<Order>(fs, tom);
                Console.WriteLine("Data has been saved to file");
            }

            // чтение данных
            using (FileStream fs = new FileStream("orders.json", FileMode.OpenOrCreate))
            {
                Order restoredPerson = await JsonSerializer.DeserializeAsync<Order>(fs);
                Console.WriteLine($"Dishes: {restoredPerson.Dishes}  Drinks: {restoredPerson.Drinks} ClientId : {restoredPerson.ClientId}");
            }        
            Console.ReadKey();

        }
    }
}
