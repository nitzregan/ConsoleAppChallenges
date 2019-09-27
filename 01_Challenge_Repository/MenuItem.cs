using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge_Repository
{
    public class MenuItem
    {
        public MenuItem(int menuItemNumber, string menuItemName, string descriptionOfMenuItem, string listOfIngredients, float menuItemPrice)
        {
            MenuItemNumber = menuItemNumber;
            MenuItemName = menuItemName;
            DescriptionOfMenuItem = descriptionOfMenuItem;
            ListOfIngredients = listOfIngredients;
            MenuItemPrice = menuItemPrice;
        }

        public MenuItem()
        {

        }

        public int MenuItemNumber { get; set; }
        public string MenuItemName { get; set; }
        public string DescriptionOfMenuItem { get; set; }
        public string ListOfIngredients { get; set; }
        public float MenuItemPrice { get; set; }
    }
}
