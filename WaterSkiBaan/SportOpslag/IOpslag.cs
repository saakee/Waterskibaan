using System;
using WaterSkiBaan.SportUitrusting;

namespace WaterSkiBaan.SportOpslag
{
    public interface IOpslag
    {
        void Afgeven(SportArtikel artikel);
    }
}