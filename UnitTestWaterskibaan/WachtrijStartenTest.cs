using System;
using System.Collections.Generic;
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
        public void WachtrijStarten_AddingSporterToQueue_ShouldIncrementQueueByOne()
        {
            WachtrijStarten wachtrij = new WachtrijStarten();
            Skier skier = new Skier();
            int currentQueueSize = wachtrij.Wachtrij.Count;

            wachtrij.VoegSporterToeAanRij(skier);
            Assert.AreEqual(currentQueueSize + 1, wachtrij.Wachtrij.Count);
        }

        [TestMethod]
        public void WachtrijStarten_RemovingSporterFromQueue_ShouldDecreaseQueueByOne()
        {
            WachtrijStarten wachtrij = new WachtrijStarten();
            List<Sporter> list = new List<Sporter>
            {
                new Skier(),
                new Skier(),
                new Wakeboarder(),
                new Wakeboarder()
            };
            list.ForEach(x => wachtrij.VoegSporterToeAanRij(x));
            int currentQueueLength = wachtrij.Wachtrij.Count;
            wachtrij.HaalSporterUitRij();
            Assert.AreEqual(currentQueueLength -1, wachtrij.Wachtrij.Count);
        }

        [TestMethod]
        public void WachtrijStarten_RemovingSporterFromQeueue_ShouldBeTheFirstSporterInQueue()
        {
            WachtrijStarten wachtrij = new WachtrijStarten();
            List<Sporter> list = new List<Sporter>
            {
                new Skier(),
                new Skier(),
                new Wakeboarder(),
                new Wakeboarder()
            };
            list.ForEach(x => wachtrij.VoegSporterToeAanRij(x));
            wachtrij.HaalSporterUitRij();
            Assert.IsFalse(wachtrij.Wachtrij.Contains(list[0]));
        }
     
    }
}
