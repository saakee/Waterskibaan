using System;
using System.Collections.Generic;
using System.Text;
using WaterSkiBaan.SportOpslag;
using WaterSkiBaan.SportUitrusting;

namespace WaterSkiBaan.SportOpslag
{
    public class WakeboardOpslag : IOpslag
    {
        private Stack<Wakeboard> _opslag { get; set; } = new Stack<Wakeboard>();

        public void Afgeven(SportArtikel sportartikel)
        {
            try
            {
                _opslag.Push((Wakeboard)sportartikel);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("Gelieve enkel Wakeboard inleveren");
            }
        }

        public Wakeboard PakWakeboard()
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