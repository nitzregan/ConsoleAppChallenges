using System;
using _03_Console_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Challenge_Tests
{
    [TestClass]
    public class Outing_Tests
    {
        [TestMethod]
        public void AddOutingToList()
        {
            Outings outings = new Outings();
            OutingsRepository repo = new OutingsRepository();
            repo.SeedList();
        }

        [TestMethod]
        public void ViewOutingsByFinalCost()
        {
            Outings outings = new Outings();
            OutingsRepository repo = new OutingsRepository();
            repo.SeedList();
        }

        [TestMethod]
        public void ViewOutingsByFinalTypeCost()
        {
            Outings outings = new Outings();
            OutingsRepository repo = new OutingsRepository();
            repo.SeedList();
        }
    }
}
