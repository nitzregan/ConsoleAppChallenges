using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_Console_Repository;

namespace _03_Challenge_Console
{
    internal class ProgramUI
    {
        OutingsRepository _repo = new OutingsRepository();

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
                Console.WriteLine("What would you like to do?\n" +
                    "1. Add New Outings\n" +
                    "2. See All Outings\n" +
                    "3. View Outings by Cost\n" +
                    "4. Exit Program\n");

                string UserInput = Console.ReadLine();

                switch (UserInput)
                {
                    case "1":
                        Console.Clear();
                        AddOutingToList();
                        break;
                    case "2":
                        Console.Clear();
                        SeeAllOutings();
                        break;
                    case "3":
                        Console.Clear();
                        ViewOutingsByCost();
                        break;
                    case "4":
                        usingMenu = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid response...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public void AddOutingToList()
        {
            Console.WriteLine("What type of outing is this?\n" +
                "1. Golf\n" +
                "2. Bowling\n" +
                "3. Amusement Park\n" +
                "4. Concert\n");
            string typeOfOutingAsString = Console.ReadLine();
            int typeOfOutingAsInt = int.Parse(typeOfOutingAsString);
            OutingType typeOfOuting = (OutingType)typeOfOutingAsInt;

            Console.WriteLine("How many people are attending this outing?");
            string numberOfAttendeesAsString = Console.ReadLine();
            int numberOfAttendees = int.Parse(numberOfAttendeesAsString);

            Console.WriteLine("Enter the date of the outing as DD/MM/YYYY: ");
            string dateOfOutingAsString = Console.ReadLine();
            DateTime dateOfOuting = DateTime.Parse(dateOfOutingAsString);

            Console.WriteLine("What is the cost per attendee?");
            string totalCostPerAttendeeAsString = Console.ReadLine();
            decimal totalCostPerAttendee = decimal.Parse(totalCostPerAttendeeAsString);

            Outings newOuting = new Outings(typeOfOuting, numberOfAttendees, dateOfOuting, totalCostPerAttendee);

            _repo.AddOutingToList(newOuting);
        }

        public void SeeAllOutings()
        {
            List<Outings> outings = _repo.SeeAllOutings();

            foreach (Outings outing in outings)
            {
                Console.WriteLine($"Type of Outing: {outing.TypeOfOuting} \n" +
                    $"Number of Attendees: {outing.NumberOfAttendees} \n" +
                    $"Date of Outing: {outing.DateOfOuting} \n" +
                    $"Total Cost per Attendee: {outing.TotalCostPerAttendee} \n" +
                    $"Total Cost of Outing: {outing.TotalCostOfOuting} \n");
            }
            Console.ReadKey();
        }

        public void ViewOutingsByCost()
        {
            Console.WriteLine("What would you like to see?\n" +
                "1. View Total Cost of All Outings\n" +
                "2. View Total Cost of Each Type of Outing");

            string UserInput = Console.ReadLine();

            switch (UserInput)
            {
                case "1":
                    Console.Clear();
                    ViewOutingsByFinalCost();
                    break;
                case "2":
                    Console.Clear();
                    ViewOutingsByTypeFinalCost();
                    break;


                default:
                    Console.WriteLine("Please enter a valid response...");
                    Console.ReadKey();
                    break;
            }
        }

        public void ViewOutingsByFinalCost()
        {
            decimal finalCost = _repo.ViewOutingsByFinalCost();

            Console.WriteLine($"Total Cost of All Outings: {finalCost}\n");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void ViewOutingsByTypeFinalCost()
        {
            decimal finalGolfCost = _repo.ViewOutingsByTypeFinalCost(OutingType.Golf);
            decimal finalBowlingCost = _repo.ViewOutingsByTypeFinalCost(OutingType.Bowling);
            decimal finalAmusementParkCost = _repo.ViewOutingsByTypeFinalCost(OutingType.AmusementPark);
            decimal finalConcertCost = _repo.ViewOutingsByTypeFinalCost(OutingType.Concert);

            Console.WriteLine($"Golf Outings: {finalGolfCost}\n" +
                $"Bowling Outings: {finalBowlingCost}\n" +
                $"Amusement Park Outings: {finalAmusementParkCost}\n" +
                $"Concert: {finalConcertCost}\n");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
