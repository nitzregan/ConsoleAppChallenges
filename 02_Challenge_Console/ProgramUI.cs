using _02_Challenge_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge_Console
{
    internal class ProgramUI
    {
        ClaimRepository _repo = new ClaimRepository();

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
                Console.WriteLine("Enter the number of the function you would like to use...\n" +
                    "1. See All Claims\n" +
                    "2. Take Care of Next Claim\n" +
                    "3. New Claim\n" +
                    "4. Exit Program\n");

                string UserInput = Console.ReadLine();

                switch (UserInput)
                {
                    case "1":
                        Console.Clear();
                        SeeAllClaims();
                        break;
                    case "2":
                        Console.Clear();
                        TakeCareOfClaim();
                        break;
                    case "3":
                        Console.Clear();
                        AddNewClaim();
                        break;
                    case "4":
                        usingMenu = false;
                        break;
                }
            }
        }

        public void SeeAllClaims()
        {
            //view on screen is mad weird, why it do that?

            Queue<ClaimItems> claimItems = _repo.SeeAllClaims();
            Console.WriteLine("Claim ID \t" +
                              "Claim Type \t" +
                              "Description \t" +
                              "Claim Amount \t" +
                              "Date of Incident \t" +
                              "Date of Claim \t" +
                              "IsValid \n");
            foreach (ClaimItems claim in claimItems)
            {
                Console.WriteLine($"{claim.ClaimID}\t" +
                    $"{claim.TypeOfClaim}\t" +
                    $"{claim.Description}\t" +
                    $"{claim.ClaimAmount}\t" +
                    $"{claim.DateOfIncident}\t" +
                    $"{claim.DateOfClaim}\t" +
                    $"{claim.IsValid}\n");
            }
            Console.ReadKey();
        }

        public void TakeCareOfClaim()
        {
            Queue<ClaimItems> claimItems = _repo.SeeAllClaims();
            Console.WriteLine("Claim ID \t" +
                  "Claim Type \t" +
                  "Description \t" +
                  "Claim Amount \t" +
                  "Date of Incident \t" +
                  "Date of Claim \t" +
                  "IsValid \n");

            ClaimItems claim = claimItems.Peek();
            Console.WriteLine($"{claim.ClaimID}\t" +
                $"{claim.TypeOfClaim}\t" +
                $"{claim.Description}\t" +
                $"{claim.ClaimAmount}\t" +
                $"{claim.DateOfIncident}\t" +
                $"{claim.DateOfClaim}\t" +
                $"{claim.IsValid}\n");

            Console.WriteLine("Would you like to take care of this claim now?\n" +
                "y or n?");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "y":
                    RemoveClaimFromQueue();
                    break;
                case "n":
                    break;
            }
            Console.Clear();
        }

        public void RemoveClaimFromQueue()
        {
            Queue<ClaimItems> claimItems = _repo.SeeAllClaims();
            ClaimItems claim = claimItems.Dequeue();
            Console.WriteLine("Claim removed from queue, hit any key to continue...\n");
            Console.ReadKey();
        }

        public void AddNewClaim()
        {
            Console.WriteLine("Enter the claim ID: ");
            string claimIDAsString = Console.ReadLine();
            int claimID = int.Parse(claimIDAsString);

            Console.WriteLine("What type of claim is this?\n" +
                "1. Car\n" +
                "2. Home\n" +
                "3. Theft\n");
            string typeOfClaimAsString = Console.ReadLine();
            int typeOfClaimAsInt = int.Parse(typeOfClaimAsString);
            ClaimType typeOfClaim = (ClaimType)typeOfClaimAsInt;

            Console.WriteLine("Enter a description of the claim: ");
            string description = Console.ReadLine();

            Console.WriteLine("Amount of damage: ");
            string claimAmountAsString = Console.ReadLine();
            float claimAmount = float.Parse(claimAmountAsString);

            Console.WriteLine("Enter date of incident as DD/MM/YYYY: ");
            string dateOfIncidentAsString = Console.ReadLine();
            DateTime dateOfIncident = DateTime.Parse(dateOfIncidentAsString);

            Console.WriteLine("Enter date of claim as DD/MM/YYYY: ");
            string dateOfClaimAsString = Console.ReadLine();
            DateTime dateOfClaim = DateTime.Parse(dateOfClaimAsString);



            ClaimItems newClaim = new ClaimItems(claimID, typeOfClaim, description, claimAmount, dateOfIncident, dateOfClaim);

            _repo.AddNewClaim(newClaim);
        }
    }




    //Enter the claim id: 4
    //Enter the claim type: Car
    //Enter a claim description: Wreck on I-70.
    //Amount of Damage: $2000.00
    //Date Of Accident: 4/27/18
    //Date of Claim: 4/28/18
    //This claim is valid.


}
