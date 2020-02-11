using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern_Builder.BuilderDesignPattern.HouseBuilder.Product;

namespace DesignPattern_Builder.BuilderDesignPattern.HouseBuilder.Builder
{
    public class ModernHouseBuilder : IHouseBuilder
    {
        House house;
        public ModernHouseBuilder()
        {
            house = new House
            {
                Type = "Modern",
                ImageUrl = @"/images/modernhouse.jpg",
                Id = Guid.NewGuid()

            };
        }

        public void BuildGarage()
        {
            house.SetGarage("2 Car Garage");
        }

        public void BuildInterior()
        {
            house.SetInterior("Elegant Interior");
        }

        public void BuildRoof()
        {
            house.SetRoof("Rooftop");
        }

        public void BuildRooms()
        {
            house.SetRooms(4);
        }

        public void BuildStructure()
        {
            house.SetStructure("Concrete");
        }
        
        public House GetHouse()
        {
            return house;
        }
 
    }
}
