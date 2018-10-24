using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSkiBaan.Sporters;

namespace WaterSkiBaan.Wachtrijen
{
    public class WachtrijStarten
    {
        public Queue<Sporter> Wachtrij { get; set; } = new Queue<Sporter>();

        public WachtrijStarten()
        {
            Wachtrij = new Queue<Sporter>();
        }

        public void VoegSporterToeAanRij(Sporter sporter)
        {
            Wachtrij.Enqueue(sporter);
        }

        public void HaalSporterUitRij()
        {
            Wachtrij.Dequeue();
        }
    }
}
