using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSkiBaan.Sporters;

namespace WaterSkiBaan.Wachtrijen
{
    class WachtrijStarten
    {
        Queue<Sporter> Wachtrij;

        public WachtrijStarten()
        {
            Wachtrij = new Queue<Sporter>();
        }

        public void voegSporterToeAanRij(Sporter sporter)
        {
            Wachtrij.Enqueue(sporter);
        }
    }
}
