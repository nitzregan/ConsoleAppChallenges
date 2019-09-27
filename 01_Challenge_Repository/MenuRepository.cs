using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge_Repository
{
    public class MenuRepository
    {
        List<MenuItem> _menuItemList = new List<MenuItem>();

        public List<MenuItem> GetMenuItems()
        {
            return _menuItemList;
        }

        public void AddToMenu(MenuItem meal)
        {
            _menuItemList.Add(meal);
        }

        public void RemoveMenuItemFromList(int menuItemNumber)
        {
            foreach (MenuItem meal in _menuItemList)
            {
                if (meal.MenuItemNumber == menuItemNumber)
                {
                    _menuItemList.Remove(meal);
                    break;
                }
            }
        }

        //public void UpdateMenuItemByMenuItemNumber(int menuItemNumber, MenuItem updates)
        //{
        //    stuff goes here, will figure out l8r sk8r
        //}










        public void SeedList()
        {
            MenuItem meal = new MenuItem(1, "Grilled Cheese", "American cheese melted between two slices of Texas Toast. Simple, served with fries.", "American cheese, Texas Toast, butter", 5.99f);
            MenuItem mealTwo = new MenuItem(2, "Burger", "Backyard BBQ staple, patty on a bun, add cheese and a full garden if that's your cup of tea! Served with fries", "Burger bun, hamburger patty. Cheese, Lettuce, Tomato, and Onion optional", 9.99f);
            MenuItem mealThree = new MenuItem(3, "BLT", "Exactly what you think it is", "Bacon, Lettuce, Tomato, Toast", 6.99f);
            MenuItem mealFour = new MenuItem(4, "Just the Fries", "Picky eater? Not as hungry as your friends? This is the choice for you!", "Potatoes", 2.99f);
            MenuItem mealFive = new MenuItem(5, "Soup n Salad", "Your choice of soup and salad. Ask server for details!", "Ingredients may vary", 7.99f);

            _menuItemList.Add(meal);
            _menuItemList.Add(mealTwo);
            _menuItemList.Add(mealThree);
            _menuItemList.Add(mealFour);
            _menuItemList.Add(mealFive);
        }
    }
}
