using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge_Repository
{
    public class ClaimRepository
    {
        Queue<ClaimItems> _claimItemsQueue = new Queue<ClaimItems>();

        public Queue<ClaimItems> SeeAllClaims()
        {
            return _claimItemsQueue;
        }

        public void AddNewClaim(ClaimItems claim)
        {
            _claimItemsQueue.Enqueue(claim);
        }

        public void SeedList()
        {
            ClaimItems claim = new ClaimItems(1, ClaimType.Car, "Fender bender at Meridian and Ohio", 500.00f, new DateTime(08/18/2019), new DateTime(09/02/2019));
            ClaimItems claimTwo = new ClaimItems(2, ClaimType.Home, "Small fire in garage", 1000.00f, new DateTime(09/19/2019), new DateTime(09/23/2019));
            ClaimItems claimThree = new ClaimItems(3, ClaimType.Theft, "Medication stolen from vehicle, door handle broken", 275.00f, new DateTime(07/12/2019), new DateTime(09/07/2019));

            AddNewClaim(claim);
            AddNewClaim(claimTwo);
            AddNewClaim(claimThree);
        }
    }
}
