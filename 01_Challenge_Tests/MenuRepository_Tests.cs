using System;
using _01_Challenge_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Challenge_Tests
{
    [TestClass]
    public class MenuRepository_Tests
    {
        [TestMethod]
        public void AddToMenu()
        {
            MenuItem meal = new MenuItem();
            meal.MenuItemName = "Pizza";

            string expected = "Pizza";
            Assert.AreEqual(expected, meal.MenuItemName);

            MenuItem mealTwo = new MenuItem(7, "Coffee", "Cup of Joe", "Cup(to go or otherwise), Coffee", 1.99f);
            float expectedTwo = 1.99f;
            Assert.AreEqual(expectedTwo, mealTwo.MenuItemPrice);
        }

        [TestMethod]
        public void RemoveMenuItemFromList()
        {
            MenuRepository repo = new MenuRepository();
            repo.SeedList();
        }
    }
}
