using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LunchroomLibrary.DataWork;
using LunchroomLibrary.LunchroomMenu;
using LunchroomLibrary.LunchroomWork;
using LunchroomLibrary.Operations;
using System.Collections.Generic;

namespace LunchroomLibraryUnitTestProject
{
    /// <summary>
    /// Class for testing LunchroomLibrary
    /// </summary>
    [TestClass]
    public class LunchroomLibraryUnitTest
    {
        /// <summary>
        /// Testing method ToString() in Dish
        /// </summary>
        [TestMethod]
        public void TestMethodToStringDish()
        {
            Dish dish = new Dish("Draniki", new Ingredient[] { new Ingredient(StorageConditions.InKitchenCabinet, "Potato", 1, 2), new Ingredient(StorageConditions.InRefrigerator, "Egg", 1, 2) }, new Operation[] { new Mixing("Mixing", 20, 2, new DateTime(2021, 7, 17, 10, 10, 10), 3, 3) });
            var actual = dish.ToString();
            var except = "Draniki";
            Assert.AreEqual(except, actual);
        }
        /// <summary>
        /// Testing method GetHashCode() in Dish
        /// </summary>
        [TestMethod]
        public void TestMethodGetHashCodeDish()
        {
            Dish dish = new Dish("Draniki", new Ingredient[] { new Ingredient(StorageConditions.InKitchenCabinet, "Potato", 1, 2), new Ingredient(StorageConditions.InRefrigerator, "Egg", 1, 2) }, new Operation[] { new Mixing("Mixing", 20, 2, new DateTime(2021, 7, 17, 10, 10, 10), 3, 3) });
            var actual = dish.GetHashCode();
            Assert.AreEqual(605160021, actual);
        }
        /// <summary>
        /// Testing method Equals() in Dish
        /// </summary>
        [TestMethod]
        public void TestMethodEqualsDish()
        {
            Dish dish = new Dish("Draniki", new Ingredient[] { new Ingredient(StorageConditions.InKitchenCabinet, "Potato", 1, 2), new Ingredient(StorageConditions.InRefrigerator, "Egg", 1, 2) }, new Operation[] { new Mixing("Mixing", 20, 2, new DateTime(2021, 7, 17, 10, 10, 10), 3, 3) });
            Dish dish1 = new Dish() { Name = "Draniki", Ingredients = new Ingredient[] { new Ingredient() { StorageConditions = StorageConditions.InKitchenCabinet, IngredientName = "Potato", Price = 1, Number = 2 }, new Ingredient(StorageConditions.InRefrigerator, "Egg", 1, 2) }, CookingSequence = new Operation[] { new Mixing() { Name = "Mixing", Lasting = 20, Price = 2, StartOperation = new DateTime(2021, 7, 17, 10, 10, 10), Number = 3, MaxNumber = 3 } } };
            var actual = dish.Equals(dish1);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Testing method ToString() in Drink
        /// </summary>
        [TestMethod]
        public void TestMethodToStringDrink()
        {
            Drink drink = new Drink("Juice", 1);
            var actual = drink.ToString();
            var except = "Juice";
            Assert.AreEqual(except, actual);
        }
        /// <summary>
        /// Testing method GetHashCode() Drink
        /// </summary>
        [TestMethod]
        public void TestMethodGetHashCodeDrink()
        {
            Drink drink = new Drink("Juice", 1);
            var actual = drink.GetHashCode();
            Assert.AreEqual(-539223860, actual);
        }

        /// <summary>
        /// Testing method Equals() in Drink
        /// </summary>
        [TestMethod]
        public void TestMethodEqualsDrink()
        {
            Drink drink = new Drink("Juice", 1);
            Drink drink1 = new Drink() {Name = "Juice", Price = 1 };

            var actual = drink.Equals(drink1);
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// Testing method ToString() in Order
        /// </summary>
        [TestMethod]
        public void TestMethodToStringOrder()
        {
            Order order = new Order(new Dish[] { new Dish("Salad", new Ingredient[] { new Ingredient() { StorageConditions = StorageConditions.InRefrigerator, IngredientName = "Tomato", Price = 1, Number = 2 }, new Ingredient() { StorageConditions = StorageConditions.InRefrigerator, IngredientName = "Salt", Price = 0.5, Number = 1 } }, new Operation[] { new Mixing() { Name = "Mixing", Lasting = 89, Price = 98, StartOperation = new DateTime(2021, 7, 15), Number = 1, MaxNumber = 3 } }) }, new Drink[] { new Drink("Juice", 1) }, 1, new DateTime(2011, 11, 11));
            var actual = order.ToString();
            var except = "1";
            Assert.AreEqual(except, actual);
        }
        /// <summary>
        /// Testing method GetHashCode() in Order
        /// </summary>
        [TestMethod]
        public void TestMethodGetHashCodeOrder()
        {
            Order order = new Order(new Dish[] { new Dish("Salad", new Ingredient[] { new Ingredient() { StorageConditions = StorageConditions.InRefrigerator, IngredientName = "Tomato", Price = 1, Number = 2 }, new Ingredient() { StorageConditions = StorageConditions.InRefrigerator, IngredientName = "Salt", Price = 0.5, Number = 1 } }, new Operation[] { new Mixing() { Name = "Mixing", Lasting = 89, Price = 98, StartOperation = new DateTime(2021, 7, 15), Number = 1, MaxNumber = 3 } }) }, new Drink[] { new Drink("Juice", 1) }, 1, new DateTime(2011, 11, 11));
            var actual = order.GetHashCode();
            Assert.AreEqual(-856717928, actual);
        }
        /// <summary>
        /// Testing method Equals() in Order
        /// </summary>
        [TestMethod]
        public void TestMethodEqualsOrder()
        {
            Order order = new Order() { Dishes = new Dish[] { new Dish("Salad", new Ingredient[] { new Ingredient() { StorageConditions = StorageConditions.InRefrigerator, IngredientName = "Tomato", Price = 1, Number = 2 }, new Ingredient() { StorageConditions = StorageConditions.InRefrigerator, IngredientName = "Salt", Price = 0.5, Number = 1 } }, new Operation[] { new Mixing() { Name = "Mixing", Lasting = 89, Price = 98, StartOperation = new DateTime(2021, 7, 15), Number = 1, MaxNumber = 3 } }) }, Drinks = new Drink[] { new Drink("Juice", 1) }, ClientId = 1, Date = new DateTime(2011, 11, 11) };
            Order order1 = new Order(new Dish[] { new Dish("Salad", new Ingredient[] { new Ingredient() { StorageConditions = StorageConditions.InRefrigerator, IngredientName = "Tomato", Price = 1, Number = 2 }, new Ingredient() { StorageConditions = StorageConditions.InRefrigerator, IngredientName = "Salt", Price = 0.5, Number = 1 } }, new Operation[] { new Mixing() { Name = "Mixing", Lasting = 89, Price = 98, StartOperation = new DateTime(2021, 7, 15), Number = 1, MaxNumber = 3 } }) }, new Drink[] { new Drink("Juice", 1) }, 1, new DateTime(2011, 11, 11) );

            var actual = order1.Equals(order);
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Testing method ToString() Operation
        /// </summary>
        [TestMethod]
        public void TestMethodToStringOperation()
        {
            Operation operation = new Operation("Mixing", 89, 98, new DateTime(2021, 7, 15), 1, 3);
            var actual = operation.ToString();
            var except = "Mixing";
            Assert.AreEqual(except, actual);
        }

        /// <summary>
        /// Testing method GetHashCode() Operation
        /// </summary>
        [TestMethod]
        public void TestMethodGetHashCodeOperation()
        {
            Operation operation = new Operation("Mixing", 89, 98, new DateTime(2021, 7, 15), 1, 3);
            var actual = operation.GetHashCode();
            Assert.AreEqual(546932843, actual);
        }
        /// <summary>
        /// Testing method Equals() in Operation
        /// </summary>
        [TestMethod]
        public void TestMethodEqualsOperation()
        {
            Operation operation = new Operation() { Name = "Mixing", Lasting = 89, Price = 98, StartOperation = new DateTime(2021, 7, 15), Number = 1, MaxNumber = 3 };
            Operation operation1 = new Operation("Mixing", 89, 98, new DateTime(2021, 7, 15), 1, 3);

            var actual = operation.Equals(operation1);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// Testing method FreeProductiveCapacity()
        /// </summary>
        [TestMethod]
        public async System.Threading.Tasks.Task TestMethodFreeProductiveCapacityAsync()
        {
            JSONWorking working = new JSONWorking();
            Order[] orders = new Order[] { new Order() { Dishes = new Dish[] { new Dish("Salad", new Ingredient[] { new Ingredient() { StorageConditions = StorageConditions.InRefrigerator, IngredientName = "Tomato", Price = 1, Number = 2 }, new Ingredient() { StorageConditions = StorageConditions.InRefrigerator, IngredientName = "Salt", Price = 0.5, Number = 1 } }, new Operation[] { new Mixing() { Name = "Mixing", Lasting = 89, Price = 98, StartOperation = new DateTime(2021, 7, 15), Number = 1, MaxNumber = 3 } }) }, Drinks = new Drink[] { new Drink("Juice", 1) }, ClientId = 1, Date = new DateTime(2011, 11, 11) } };
            await working.JsonSerialize("orders.json", orders);
            WorkWithTask task = new WorkWithTask();
            List<Order> AllOrder = task.CreateList("orders.json");
            WorkWithData work = new WorkWithData();
            string res = "";
            foreach (var v in work.FreeProductiveCapacity(AllOrder))
                res = v;
            Assert.AreEqual("Mixing(free productive capacity: 3)", res);
           
        }
        /// <summary>
        /// Testing method FindIngredient()
        /// </summary>
        [TestMethod]
        public void TestMethodFindIngredient() 
        {
            JSONWorking jSON = new JSONWorking(); ;
            List<Order> AllOrder = jSON.JsonRead("orders.json").Result;
            WorkWithData work = new WorkWithData();
            string res = "";
            foreach (var v in work.FindIngredient(StorageConditions.InRefrigerator, AllOrder))
                res = v.IngredientName;
            Assert.AreEqual("Salt", res);
        }
        /// <summary>
        /// Testing method LookOrders()
        /// </summary>
        [TestMethod]
        public void TestMethodLookOrders()
        {
            WorkWithTask task = new WorkWithTask();
            List<Order> AllOrder = task.CreateList("orders.json");
            WorkWithData work = new WorkWithData();
            string res = "";
            foreach (var v in work.LookOrders(new DateTime(2011, 1, 1), new DateTime(2012, 1, 1), AllOrder))
                res = v.ToString();
            Assert.AreEqual("1", res);
        }
        /// <summary>
        /// Testing method LookTheCostsOfCooking()
        /// </summary>
        [TestMethod]
        public void TestMethodLookTheCostsOfCooking()
        {
            WorkWithTask task = new WorkWithTask();
            List<Order> AllOrder = task.CreateList("orders.json");
            WorkWithData work = new WorkWithData();
            string res = work.LookTheCostsOfCooking(new DateTime(2011, 1, 1), new DateTime(2012, 1, 1), AllOrder)[0];
            Assert.AreEqual("Salad(cooking costs: 99,5)", res);
        }
        /// <summary>
        /// Testing method NumberOfIngrediets()
        /// </summary>
        [TestMethod]
        public void TestMethodNumberOfIngrediets()
        {
            WorkWithTask task = new WorkWithTask();
            List<Order> AllOrder = task.CreateList("orders.json");
            WorkWithData work = new WorkWithData();
            string res = "";
            foreach (var v in work.NumberOfIngrediets(AllOrder))
                res = v.ToString();
            Assert.AreEqual("Salt(in stock: 99)", res);

        }
        /// <summary>
        /// Testing method TheMostPopularIngredient()
        /// </summary>
        [TestMethod]
        public void TestMethodTheMostPopularIngredient()
        {
            WorkWithTask task = new WorkWithTask();
            List<Order> AllOrder = task.CreateList("orders.json");
            WorkWithData work = new WorkWithData();
            string res = "";
            foreach (var v in work.TheMostPopularIngredient(AllOrder))
                res = v.ToString();
            Assert.AreEqual("Tomato(used:2)", res);
        }
        /// <summary>
        /// Testing method TheMostUnpopularIngredient()
        /// </summary>
        [TestMethod]
        public void TestMethodTheMostUnpopularIngredient()
        {
            WorkWithTask task = new WorkWithTask();
            List<Order> AllOrder = task.CreateList("orders.json");
            WorkWithData work = new WorkWithData();
            string res = "";
            foreach (var v in work.TheMostUnpopularIngredient(AllOrder))
                res = v.ToString();
            Assert.AreEqual("Salt(used:1)", res);
        }
        /// <summary>
        /// Testing method FindTheLongestAndExpensiveOperation()
        /// </summary>
        [TestMethod]
        public void TestMethodFindTheLongestAndExpensiveOperation()
        {
            WorkWithTask task = new WorkWithTask();
            List<Order> AllOrder = task.CreateList("orders.json");
            WorkWithData work = new WorkWithData();
            string res = "";
            foreach (var v in work.FindTheLongestAndExpensiveOperation(AllOrder))
                res = v.ToString();
            Assert.AreEqual("Mixing", res);
        }
    }
}
