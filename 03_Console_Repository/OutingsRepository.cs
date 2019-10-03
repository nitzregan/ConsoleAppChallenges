using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Console_Repository
{
    public class OutingsRepository
    {
        List<Outings> _outingsList = new List<Outings>();

        public void AddOutingToList(Outings outing)
        {
            _outingsList.Add(outing);
        }

        public List<Outings> SeeAllOutings()
        {
            return _outingsList;
        }


        public decimal ViewOutingsByFinalCost()
        {
            decimal finalCost = 0;

            foreach (Outings outing in _outingsList)
            {
                finalCost += outing.TotalCostOfOuting;
            }
            return finalCost;
        }

        public decimal ViewOutingsByTypeFinalCost(OutingType typeOfOuting)
        {
            decimal finalCost = 0;
            foreach (Outings outing in _outingsList)
            {
                switch (typeOfOuting)
                {
                    case OutingType.Golf:
                        finalCost += outing.TotalCostOfOuting;
                        break;
                    case OutingType.Bowling:
                        finalCost += outing.TotalCostOfOuting;
                        break;
                    case OutingType.AmusementPark:
                        finalCost += outing.TotalCostOfOuting;
                        break;
                    case OutingType.Concert:
                        finalCost += outing.TotalCostOfOuting;
                        break;
                }
            }
            return finalCost;
        }

        public void SeedList()
        {
            Outings outing = new Outings(OutingType.Golf, 30, new DateTime(08 / 18 / 2019), 25.00m);
            Outings outingTwo = new Outings(OutingType.Bowling, 25, new DateTime(02 / 20 / 2019), 10.00m);
            Outings outingThree = new Outings(OutingType.AmusementPark, 50, new DateTime(05 / 07 / 2019), 110.00m);
            Outings outingFour = new Outings(OutingType.Concert, 40, new DateTime(07 / 15 / 2019), 40.00m);
            Outings outingFive = new Outings(OutingType.Bowling, 35, new DateTime(04 / 19 / 2019), 10.00m);
            Outings outingSix = new Outings(OutingType.Concert, 20, new DateTime(06 / 01 / 2019), 40.00m);
            Outings outingSeven = new Outings(OutingType.Bowling, 30, new DateTime(09 / 19 / 2019), 10.00m);

            _outingsList.Add(outing);
            _outingsList.Add(outingTwo);
            _outingsList.Add(outingThree);
            _outingsList.Add(outingFour);
            _outingsList.Add(outingFive);
            _outingsList.Add(outingSix);
            _outingsList.Add(outingSeven);
        }
    }
}
