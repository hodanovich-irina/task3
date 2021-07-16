using LunchroomLibrary.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchroomLibrary.LunchroomMenu
{
    /// <summary>
    /// Class for salad(recipe of dish)
    /// </summary>
    public class Salad : Dish
    {
        /// <summary>
        /// Empty constructor
        /// </summary>
        public Salad()
        {
        }

        /// <summary>
        /// Constructor with params
        /// </summary>
        /// <param name="name">name of dish</param>
        /// <param name="ingredients">array of ingredients</param>
        /// <param name="cookingSequence">array of operation</param>
        public Salad(string name, Ingredient[] ingredients, Operation[] cookingSequence) : base(name, ingredients, cookingSequence)
        {
        }

        /// <summary>
        /// Method overriding Equals()
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>True or false</returns>
        public override bool Equals(object obj)
        {
            return obj is Salad salad &&
                   Name == salad.Name &&
                   EqualityComparer<Ingredient[]>.Default.Equals(Ingredients, salad.Ingredients) &&
                   EqualityComparer<Operation[]>.Default.Equals(CookingSequence, salad.CookingSequence);
        }

        /// <summary>
        /// Method overriding GetHashCode()
        /// </summary>
        /// <returns>Hash-code</returns>
        public override int GetHashCode()
        {
            int hashCode = -41892589;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<Ingredient[]>.Default.GetHashCode(Ingredients);
            hashCode = hashCode * -1521134295 + EqualityComparer<Operation[]>.Default.GetHashCode(CookingSequence);
            return hashCode;
        }

        /// <summary>
        /// Override method ToString()
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
