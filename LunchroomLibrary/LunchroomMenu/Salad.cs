using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchroomLibrary.LunchroomMenu
{
    public class Salad : Dish
    {
        public Salad(string name, Ingredient[] ingredients, string[] cookingSequence) : base(name, ingredients, cookingSequence)
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Salad salad &&
                   EqualityComparer<Ingredient[]>.Default.Equals(Ingredients, salad.Ingredients) &&
                   EqualityComparer<string[]>.Default.Equals(CookingSequence, salad.CookingSequence);
        }

        public override int GetHashCode()
        {
            int hashCode = 55189165;
            hashCode = hashCode * -1521134295 + EqualityComparer<Ingredient[]>.Default.GetHashCode(Ingredients);
            hashCode = hashCode * -1521134295 + EqualityComparer<string[]>.Default.GetHashCode(CookingSequence);
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
