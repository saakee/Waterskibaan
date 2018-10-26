using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSkiBaan.Kabelbaan
{
    public class LijnenInGebruik
    {
        public LinkedList<Lijn> Lijnen { get; } = new LinkedList<Lijn>();
        public LijnenVoorraad LijnenVoorraad { get; set; }
        private Queue<Lijn> LijnenUitgerangeerd = new Queue<Lijn>();

        public void NeemLijnInGebruik(Lijn lijn)
        {
            Lijnen.AddFirst(lijn);
            lijn.Positie = 0;
        }
        
        public void StelLijnBuitenGebruik(Lijn lijn)
        {
            Lijnen.Remove(lijn);
            LijnenUitgerangeerd.Enqueue(lijn);
        }
    }
}
