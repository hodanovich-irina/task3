using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchroomLibrary.LunchroomMenu
{
    public enum StorageConditions
    {
        InRefrigerator = 1,
        InFreezer,
        InKitchenCabinet
    }
    /// <summary>
    /// Ingredient description
    /// </summary>
    public class Ingredient
    {
        /// <summary>
        /// Storage conditions
        /// </summary>
        public StorageConditions StorageConditions { get; set; }
        /// <summary>
        /// Ingredient name
        /// </summary>
        public string IngredientName { get; set; }

        /// <summary>
        /// Ingredient cost
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Constructor with parametrs
        /// </summary>
        /// <param name="IngredientName">Ingredient name</param>
        /// <param name="Price">Ingredient cost</param>
        public Ingredient(StorageConditions storageConditions, string ingredientName, double price)
        {
            StorageConditions = storageConditions;
            IngredientName = ingredientName;
            Price = price;
        }
        /// <summary>
        /// Empty constructor
        /// </summary>
        public Ingredient()
        {
        }
        
        /// <summary>
        /// Override method ToString()
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return IngredientName;
        }

        /// <summary>
        /// Method overriding GetHashCode()
        /// </summary>
        /// <returns>Hash-code</returns>
        public override int GetHashCode()
        {
            int hashCode = 671967871;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(IngredientName);
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            return hashCode;
        }

        /// <summary>
        /// Method overriding Equals()
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>True or false</returns>
        public override bool Equals(object obj)
        {
            return obj is Ingredient ingredient &&
                   StorageConditions == ingredient.StorageConditions &&
                   IngredientName == ingredient.IngredientName &&
                   Price == ingredient.Price;
        }
    }
}
