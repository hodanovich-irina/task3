using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LunchroomLibrary.Operations;

namespace LunchroomLibrary.LunchroomMenu
{
    public class Dish
    {
        public Dish()
        {
        }

        public Dish(string name, Ingredient[] ingredients, Operation[] cookingSequence)
        {
            Name = name;
            Ingredients = ingredients;
            CookingSequence = cookingSequence;
        }

        public string Name { get; set; }   
              
        public Ingredient[] Ingredients { get; set; }
         
        public Operation[] CookingSequence { get; set; }

        public double GetCost() 
        {
            double cost = 0.0;
            foreach(var v in Ingredients) 
            {
                cost += v.Price;
            }
            return cost;
        }
        public override string ToString() => Name;
        //public abstract List<T> Select();

    }
}
