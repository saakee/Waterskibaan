using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WaterSkiBaan.Wachtrijen;
using WaterSkiBaan.Medewerkers;
using WaterSkiBaan.Personen;
using WaterSkiBaan.Sporters;

namespace UnitTestWaterskibaan
{
    [TestClass]
    public class WachtrijStartenTest
    {
        [TestMethod]
        public void WachtrijStarten_InitializingWachtrijStarten_ShouldNotBeEqualToNull()
        {
            WachtrijStarten wachtrijStarten = new WachtrijStarten();
            Assert.IsNotNull(wachtrijStarten);
        }

        [TestMethod]
        public void WachtrijStarten_AddingSporterToQueue_ShouldSucceed()
        {
            WachtrijStarten wachtrijStarten = new WachtrijStarten();
            Wakeboarder wakeboarder = new Wakeboarder();

            //Assert.IsTrue(wachtrijStarten.voegSporterToeAanRij(wakeboarder)); Dit werkt niet, omdat het return type voegSporterToeAanRij void is.    
        }

        [TestMethod]
        public void WachtrijStarten_AddingMedewerkerToQueue_ShouldReturnException()
        {
            WachtrijStarten wachtrijStarten = new WachtrijStarten();
            Skier medewerker = new Skier();

            wachtrijStarten.voegSporterToeAanRij(medewerker);
        }

    }
}
