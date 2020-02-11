using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern_Builder.BuilderDesignPattern.HouseBuilder.Product;

namespace DesignPattern_Builder.BuilderDesignPattern.HouseBuilder.Builder
{
    public class IglooHouseBuilder : IHouseBuilder
    {
        House house;
        public IglooHouseBuilder()
        {
            house = new House
            {
                Type = "Igloo",
                ImageUrl = @"/images/iglooo.png",
                Id = Guid.NewGuid()

            };

        }
        
        public void BuildGarage()
        {
            house.SetGarage("Ski Garage");
        }

        public void BuildInterior()
        {
            house.SetInterior("Ice cravings");
        }

        public void BuildRoof()
        {
            house.SetRoof("Glacier roofs");
        }

        public void BuildRooms()
        {
            house.SetRooms(1);
        }

        public void BuildStructure()
        {
            house.SetStructure("Ice Structure");
        }

        public House GetHouse()
        {
            return house;
        }
 
    }
}
