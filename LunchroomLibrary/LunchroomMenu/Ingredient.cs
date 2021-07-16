using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchroomLibrary.LunchroomMenu
{
    /// <summary>
    /// Enum of storage conditions
    /// </summary>
    public enum StorageConditions
    {
        /// <summary>
        /// in refrigerator
        /// </summary>
        InRefrigerator = 1,
        /// <summary>
        /// in freezer
        /// </summary>
        InFreezer,
        /// <summary>
        /// in kitchen cabinet
        /// </summary>
        InKitchenCabinet
    }

    /// <summary>
    /// Class for ingredient description
    /// </summary>
    public class Ingredient
    {
        /// <summary>
        /// Start number of ingredients
        /// </summary>
        public const int startNumber = 100;

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
        /// Number of ingredients
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Constructor with parametrs
        /// </summary>
        /// <param name="storageConditions">storage conditions</param>
        /// <param name="ingredientName">Ingredient name</param>
        /// <param name="price">Ingredient cost</param>
        /// <param name="number">number</param>
        public Ingredient(StorageConditions storageConditions, string ingredientName, double price, int number)
        {
            StorageConditions = storageConditions;
            IngredientName = ingredientName;
            Price = price;
            Number = number;
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
            int hashCode = 679536327;
            hashCode = hashCode * -1521134295 + StorageConditions.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(IngredientName);
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            hashCode = hashCode * -1521134295 + Number.GetHashCode();
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
                   Price == ingredient.Price &&
                   Number == ingredient.Number;
        }

        
    }
}
