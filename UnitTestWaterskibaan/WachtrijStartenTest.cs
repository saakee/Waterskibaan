using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WaterSkiBaan.Wachtrijen;
using WaterSkiBaan.Medewerkers;
using WaterSkiBaan.Sporters;

namespace UnitTestWaterskibaan
{
    [TestClass]
    public class WachtrijStartenTest
    {
        [TestInitialize]
        public void Test_InitializingWachtrijStarten_ShouldNotBeEqualToNull()
        {
            WachtrijStarten wachtrijStarten = new WachtrijStarten();
            Assert.IsNotNull(wachtrijStarten);
        }
        [TestMethod]
        public void Test_AddingSporterToQueue_ShouldSucced()
        {
            WachtrijStarten wachtrijStarten = new WachtrijStarten();
            Wakeboarder wakeboarder = new Wakeboarder();
            
            wachtrijStarten.voegSporterToeAanRij(wakeboarder);
        }


        [TestMethod]
        public void Test_AddingMedewerkerToQueue_ShouldReturnException()
        {
            WachtrijStarten wachtrijStarten = new WachtrijStarten();
            Instructeur medewerker = new Instructeur();

            try
            {
                wachtrijStarten.voegSporterToeAanRij(medewerker);
                Assert.Fail("Exception throw FAIL!");
            }
            catch (ArgumentException)
            {
                // pass
            }
        }

    }
}
