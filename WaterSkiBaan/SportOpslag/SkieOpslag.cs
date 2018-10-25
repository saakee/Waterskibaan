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
        private Stack<Skies> _opslag { get; } = new Stack<Skies>();

        public void Afgeven(SportArtikel sportartikel)
        {
            // zou het niet netjes zijn om hier een exception handling in te bouwen als het casten niet lukt (voor alle 3?)?
            try
            {
                _opslag.Push((Skies)sportartikel);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("Gelieve enkel Skies inleveren");
            }

            
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
