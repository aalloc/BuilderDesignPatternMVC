using DesignPattern_Builder.BuilderDesignPattern.HouseBuilder.Builder;
using DesignPattern_Builder.BuilderDesignPattern.HouseBuilder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern_Builder.BuilderDesignPattern.HouseBuilder.Director
{
    public class CivilEngineer
    {
        IHouseBuilder _builder;
        public CivilEngineer()
        {

        }
        public CivilEngineer(IHouseBuilder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.BuildGarage();
            _builder.BuildInterior();
            _builder.BuildRoof();
            _builder.BuildRooms();
            _builder.BuildStructure();
        }

        public House GetHouse()
        {
            return _builder.GetHouse();
        }
    }
}
