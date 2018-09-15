using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSkiBaan.Kabelbaan
{
    class LijnenInGebruik
    {
        private LinkedList<Lijn> Lijnen;
        private Queue<Lijn> LijnenUitgerangeerd;
    

        public void NeemLijnInGebruik(Lijn lijn)
        {
            Lijnen.AddLast(lijn);
            lijn.Positie = 0;
        }
        
        public void StelLijnBuitenGebruik(Lijn lijn)
        {
            Lijnen.Remove(lijn);
            LijnenUitgerangeerd.Enqueue(lijn);
        }
    }
}
