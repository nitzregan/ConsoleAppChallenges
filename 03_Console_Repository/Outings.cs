using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Console_Repository
{
    public enum OutingType { Golf = 1, Bowling, AmusementPark, Concert }

    public class Outings
    {
        public Outings(OutingType typeOfOuting, int numberOfAttendees, DateTime dateOfOuting, decimal totalCostPerAttendee)
        {
            TypeOfOuting = typeOfOuting;
            NumberOfAttendees = numberOfAttendees;
            DateOfOuting = dateOfOuting;
            TotalCostPerAttendee = totalCostPerAttendee;
            TotalCostOfOuting = (numberOfAttendees * totalCostPerAttendee);
        }

        public Outings()
        {

        }

        public OutingType TypeOfOuting { get; set; }
        public int NumberOfAttendees { get; set; }
        public DateTime DateOfOuting { get; set; }
        public decimal TotalCostPerAttendee { get; set; }
        public decimal TotalCostOfOuting { get; set; }
    }
}
