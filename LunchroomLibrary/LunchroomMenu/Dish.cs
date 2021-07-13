using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchroomLibrary.LunchroomMenu
{
    public class Dish
    {
        public Dish()
        {
        }

        public Dish(string name, Ingredient[] ingredients, string[] cookingSequence)
        {
            Name = name;
            Ingredients = ingredients;
            CookingSequence = cookingSequence;
        }

        public string Name { get; set; }   
              
        public Ingredient[] Ingredients { get; set; }
         
        public string[] CookingSequence { get; set; }

        public double GetCost() 
        {
            double cost = 0.0;
            foreach(var v in Ingredients) 
            {
                cost += v.Price;
            }
            return cost;
        }
        //public abstract List<T> Select();

    }
}
