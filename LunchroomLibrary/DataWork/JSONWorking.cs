using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using LunchroomLibrary.LunchroomWork;
using LunchroomLibrary.LunchroomMenu;
using LunchroomLibrary.Operations;
namespace LunchroomLibrary.DataWork
{
    public  class JSONWorking<T>
    {
        public async Task JsonSerialize(string fileName, Order order ) 
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<Order>(fs, order);
            }
        }
         public async Task<string> JsonReadAsync(string fileName) 
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                Order restoredPerson = await JsonSerializer.DeserializeAsync<Order>(fs);
                return ($"Dishes: {restoredPerson.Dishes}  Drinks: {restoredPerson.Drinks} ClientId : {restoredPerson.ClientId}");
            }
        }
    }
}
