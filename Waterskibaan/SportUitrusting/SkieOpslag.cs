using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSkiBaan.SportOpslag;

namespace WaterSkiBaan.SportUitrusting
{
    public class SkieOpslag : IOpslag
    {
        private Stack<Skies> _opslag { get; set; }

        public void Afgeven(SportArtikel artikel)
        {
            _opslag.Push((Skies) artikel);
        }

        public Skies PakSkies()
        {
            return _opslag.Pop();
        }
    }
}
