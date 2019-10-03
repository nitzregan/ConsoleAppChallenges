using _01_Challenge_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge_Console
{
    internal class ProgramUI
    {
        MenuRepository _repo = new MenuRepository();

        public void Run()
        {
            _repo.SeedList();
            RunMenu();
        }

        private void RunMenu()
        {
            bool usingMenu = true;
            while (usingMenu)
            {
                Console.Clear();
                Console.WriteLine("Enter number for what you would like to do\n" +
                    "1. See All Menu Items\n" +
                    "2. Add New Menu Item\n" +
                    "3. Remove Item from Menu\n" +
                    "4. Update Menu Item\n" +
                    "5. Exit Program\n");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        GetMenuItems();
                        break;
                    case "2":
                        Console.Clear();
                        AddToMenu();
                        break;
                    case "3":
                        Console.Clear();
                        RemoveMenuItemFromList();
                        break;
                    case "4":
                        Console.Clear();
                        UpdateMenuItemByMenuItemNumber();
                        break;
                    case "5":
                        usingMenu = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid response...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public void GetMenuItems()
        {
            List<MenuItem> menuItems = _repo.GetMenuItems();

            foreach (MenuItem meal in menuItems)
            {
                Console.WriteLine($"{meal.MenuItemNumber} {meal.MenuItemName}\n" +
                    $"Description: {meal.DescriptionOfMenuItem}\n" +
                    $"Ingredients: {meal.ListOfIngredients}\n" +
                    $"Price: ${meal.MenuItemPrice}\n");
            }
            Console.WriteLine("Press any key to continue...\n");
            Console.ReadKey();
        }

        public void AddToMenu()
        {
            Console.WriteLine("What number would you like to assign to this menu item?");
            string menuItemNumberAsString = Console.ReadLine();
            int menuItemNumber = int.Parse(menuItemNumberAsString);

            Console.WriteLine("What is this item called?");
            string menuItemName = Console.ReadLine();

            Console.WriteLine("Describe this item.");
            string descriptionOfMenuItem = Console.ReadLine();

            Console.WriteLine("What ingredients are in this?");
            string listOfIngredients = Console.ReadLine();

            Console.WriteLine("How much does this cost?");
            string itemPriceAsString = Console.ReadLine();
            float menuItemPrice = float.Parse(itemPriceAsString);

            MenuItem newMenuItem = new MenuItem(menuItemNumber, menuItemName, descriptionOfMenuItem, listOfIngredients, menuItemPrice);

            _repo.AddToMenu(newMenuItem);

            Console.WriteLine("Item added to menu.\n" +
                "Press any key to continue...\n");
            Console.ReadKey();
        }

        public void RemoveMenuItemFromList()
        {
            GetMenuItems();

            Console.WriteLine("What item would you like to delete? Enter item number");
            string menuItemNumberAsString = Console.ReadLine();
            int menuItemNumber = int.Parse(menuItemNumberAsString);

            _repo.RemoveMenuItemFromList(menuItemNumber);

            Console.Clear();

            GetMenuItems();
        }

        public void UpdateMenuItemByMenuItemNumber()
        {
            GetMenuItems();

            Console.WriteLine("Which menu item would you like to update? Enter item number");
            string menuItemNumberAsString = Console.ReadLine();
            int menuItemNumber = int.Parse(menuItemNumberAsString);

            MenuItem oldMenuItem = _repo.GetMenuItem(menuItemNumber);
            Console.WriteLine(oldMenuItem);

            Console.WriteLine("What number would you like to assign to this menu item?");
            string updatedMenuItemNumberAsString = Console.ReadLine();
            int updatedMenuItemNumber = int.Parse(updatedMenuItemNumberAsString);

            Console.WriteLine("What is this item called?");
            string updatedMenuItemName = Console.ReadLine();

            Console.WriteLine("Describe this item.");
            string updatedDescriptionOfMenuItem = Console.ReadLine();

            Console.WriteLine("What ingredients are in this?");
            string updatedListOfIngredients = Console.ReadLine();

            Console.WriteLine("How much does this cost?");
            string updatedItemPriceAsString = Console.ReadLine();
            float updatedMenuItemPrice = float.Parse(updatedItemPriceAsString);

            MenuItem updatedMenuItem = new MenuItem(updatedMenuItemNumber, updatedMenuItemName, updatedDescriptionOfMenuItem, updatedListOfIngredients, updatedMenuItemPrice);

            _repo.UpdateMenuItemByMenuItemNumber(menuItemNumber, updatedMenuItem);

            Console.WriteLine(oldMenuItem);
            Console.ReadKey();
        }
    }
}
