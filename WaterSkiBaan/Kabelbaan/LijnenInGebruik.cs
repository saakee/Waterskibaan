using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSkiBaan.Kabelbaan
{
    class LijnenInGebruik
    {
        private LinkedList<Lijn> Lijnen = new LinkedList<Lijn>();
        private Queue<Lijn> LijnenUitgerangeerd = new Queue<Lijn>();


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
