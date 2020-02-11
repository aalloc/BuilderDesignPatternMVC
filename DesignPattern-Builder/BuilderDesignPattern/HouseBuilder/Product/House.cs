using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern_Builder.BuilderDesignPattern.HouseBuilder.Product
{
    public class House : IHousePlanner
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Garage { get; set; }
        public string Interior { get; set; }
        public string Roof { get; set; }
        public int Rooms { get; set; }
        public string Structure { get; set; }
        public string ImageUrl { get; set; }


        public void SetStructure(string structure)
        {
            Structure = structure;
        }

        public void SetRooms(int rooms)
        {
            Rooms = rooms;
        }

        public void SetGarage(string garage)
        {
            Garage = garage;
        }

        public void SetRoof(string roof)
        {
            Roof = roof;
        }

        public void SetInterior(string interior)
        {
            Interior = interior;
        }
    }
}
