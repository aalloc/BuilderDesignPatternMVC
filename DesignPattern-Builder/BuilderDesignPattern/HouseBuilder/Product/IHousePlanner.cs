using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern_Builder.BuilderDesignPattern.HouseBuilder.Product
{
    public interface IHousePlanner
    {
        void SetStructure(string structure);
        void SetRooms(int rooms);
        void SetGarage(string garage);
        void SetRoof(string roof);
        void SetInterior(string interior);

    }
}
