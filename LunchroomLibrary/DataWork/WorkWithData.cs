using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LunchroomLibrary.LunchroomMenu;
using LunchroomLibrary.LunchroomWork;
using LunchroomLibrary.Operations;

namespace LunchroomLibrary.DataWork
{
    public class WorkWithData
    {
        public List<string> FreeProductiveCapacity(List<Order> orders) 
        {
            List<Operation> operations = new List<Operation>();
            foreach (var v in orders)
                foreach (var v1 in v.Dishes)
                    foreach (var v2 in v1.CookingSequence)
                        operations.Add(v2);
            List<string> freeProdCapacity = new List<string>();
            foreach (var v in operations)
            {
                if ((DateTime.Now - v.StartOperation).TotalSeconds <= v.Lasting)
                    freeProdCapacity.Add(v.Name + "(free productive capacity: " + (v.MaxNumber - v.Number) + ")");
                else
                    freeProdCapacity.Add(v.Name + "(free productive capacity: " + v.MaxNumber + ")");
            }
            return freeProdCapacity;
        }
        public List<string> NumberOfIngrediets(List<Order> orders) 
        {
            List<string> freeIngredients = new List<string>();
            List<Ingredient> ingredients = new List<Ingredient>();
            Dictionary<string, int> rez = new Dictionary<string, int>();
            List<string> mostUnpopular = new List<string>();
            foreach (var v in orders)
            {
                foreach (var x in v.Dishes)
                    foreach (var z in x.Ingredients)
                        ingredients.Add(z);
            }
            var g = (from s in ingredients
                     select new { Name = s.IngredientName, Count = s.Number }).ToList();
            var result = g.GroupBy(x => x.Name);
            foreach (var item in result)
                rez.Add(item.Key, item.Sum(x => x.Count));
            foreach (var v in rez)
                freeIngredients.Add(v.Key + "(in stock: " + (Ingredient.startNumber - v.Value) + ")");
            return freeIngredients;
        }

        public List<Order> LookOrders(DateTime start, DateTime end, List<Order> orders) 
        {
            List<Order> orders1 = new List<Order>();
            foreach (var v in orders) 
            {
                if (v.Date >= start && v.Date <= end)
                    orders1.Add(v);
            }
            return orders1;
        }
        public List<string> TheMostPopularIngredient(List<Order> orders) 
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            Dictionary<string,int> rez = new Dictionary<string, int>();
            List<string> mostPopular = new List<string>();
            foreach (var v in orders)
            {
                foreach (var x in v.Dishes)
                    foreach (var z in x.Ingredients)
                        ingredients.Add(z);
            }
            var g = (from s in ingredients
                    select new { Name = s.IngredientName, Count = s.Number }).ToList();
            var result = g.GroupBy(x => x.Name);
            foreach (var item in result)
                rez.Add(item.Key, item.Sum(x => x.Count));
            double summa = rez.Values.Sum() / rez.Count;
            foreach (var v in rez)
                if (v.Value >= rez.Count)
                    mostPopular.Add(v.Key + "(used:" + v.Value + ")");
            return mostPopular;
        }
        public List<string> TheMostUnpopularIngredient(List<Order> orders) 
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            Dictionary<string,int> rez = new Dictionary<string, int>();
            List<string> mostUnpopular = new List<string>();
            foreach (var v in orders)
            {
                foreach (var x in v.Dishes)
                    foreach (var z in x.Ingredients)
                        ingredients.Add(z);
            }
            var g = (from s in ingredients
                    select new { Name = s.IngredientName, Count = s.Number }).ToList();
            var result = g.GroupBy(x => x.Name);
            foreach (var item in result)
                rez.Add(item.Key, item.Sum(x => x.Count));
            double summa = rez.Values.Sum() / rez.Count;
            foreach (var v in rez)
                if (v.Value < rez.Count)
                    mostUnpopular.Add(v.Key + "(used:" + v.Value + ")");
            return mostUnpopular;
        }
        public List<Ingredient> FindIngredient(StorageConditions storageConditions, List<Order> orders) 
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            foreach (var v in orders)
            {
                foreach (var x in v.Dishes)
                    foreach (var z in x.Ingredients)
                        ingredients.Add(z);
            }
            var ingredientsByStorageConditions = (from s in ingredients
                    where s.StorageConditions == storageConditions
                    select s).ToList();
            return ingredientsByStorageConditions;

        }
        public List<Operation> FindTheLongestAndExpensiveOperation(List<Order> orders) 
        {
            List<Operation> operations = new List<Operation>();
            foreach (var v in orders)
            {
                foreach (var x in v.Dishes)
                    foreach (var z in x.CookingSequence)
                        operations.Add(z);
            }
            double middlePrice = 0.0;
            double middleLasting = 0.0;
            foreach (var x in operations)
            {
                middlePrice += x.Price;
                middleLasting += x.Lasting; 
            }

            var itog = (from d in operations
                    where d.Lasting >= middleLasting / operations.Count() && d.Price >= middlePrice / operations.Count()
                    select d).ToList();
            return itog;
        }
        public List<string> LookTheCostsOfCooking(DateTime start, DateTime end, List<Order> orders) 
        {
            List<string> rez = new List<string>();
            double costs = 0.0;
            List<Dish> dishes = new List<Dish>();
            List<Drink> drinks = new List<Drink>();
            foreach (var v in LookOrders(start,end,orders))
                foreach (var x in v.Dishes)
                        dishes.Add(x);
            foreach (var v in LookOrders(start,end,orders))
                foreach (var x in v.Drinks)
                        drinks.Add(x);
            
            foreach (var v in dishes)
            {
                costs = 0.0;
                foreach (var v1 in v.CookingSequence)
                    costs += v1.Price;
                foreach (var v1 in v.Ingredients)
                    costs += v1.Price;
                rez.Add(v.Name + "(cooking costs: " + costs + ")");
            } 
 
            foreach (var v in drinks)
            {
                costs = 0.0;
                costs += v.Price;
                rez.Add(v.Name + "(cooking costs: " + costs + ")");
            }
            return rez;
        }
    }
}
