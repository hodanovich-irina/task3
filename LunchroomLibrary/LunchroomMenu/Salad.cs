using LunchroomLibrary.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchroomLibrary.LunchroomMenu
{
    public class Salad : Dish
    {
        public Salad()
        {
        }

        public Salad(string name, Ingredient[] ingredients, Operation[] cookingSequence) : base(name, ingredients, cookingSequence)
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Salad salad &&
                   Name == salad.Name &&
                   EqualityComparer<Ingredient[]>.Default.Equals(Ingredients, salad.Ingredients) &&
                   EqualityComparer<Operation[]>.Default.Equals(CookingSequence, salad.CookingSequence);
        }

        public override int GetHashCode()
        {
            int hashCode = -41892589;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<Ingredient[]>.Default.GetHashCode(Ingredients);
            hashCode = hashCode * -1521134295 + EqualityComparer<Operation[]>.Default.GetHashCode(CookingSequence);
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
