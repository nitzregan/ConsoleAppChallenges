using System;
using _02_Challenge_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Challenge_Tests
{
    [TestClass]
    public class ClaimRepositoryTests
    {
        [TestMethod]
        public void AddNewClaim()
        {
            ClaimItems claim = new ClaimItems();
            ClaimRepository repo = new ClaimRepository();
            repo.SeedList();

        }

        [TestMethod]
        public void RemoveClaimFromList()
        {
            ClaimRepository repo = new ClaimRepository();
            repo.SeedList();
        }
    }
}
