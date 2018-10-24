using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSkiBaan.SportUitrusting;

namespace WaterSkiBaan.SportOpslag
{
    public class SkieOpslag : IOpslag
    {
        private Stack<Skies> _opslag { get; set; } = new Stack<Skies>();

        public void Afgeven(SportArtikel sportartikel)
        {
            var skies = (Skies)sportartikel;
            _opslag.Push(skies);
        }

        public Skies PakSkies()
        {
            return _opslag.Pop();
        }

        public override string ToString()
        {
            var opslagArray = _opslag.ToArray();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < opslagArray.Length; i++)
            {
                sb.Append("* ");
            }
            return $"({opslagArray.Length.ToString()}) {sb.ToString()}";
        }
    }
}
