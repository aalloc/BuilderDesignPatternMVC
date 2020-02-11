using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern_Builder.BuilderDesignPattern.HouseBuilder.Builder;
using DesignPattern_Builder.BuilderDesignPattern.HouseBuilder.Director;
using DesignPattern_Builder.BuilderDesignPattern.HouseBuilder.Product;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DesignPattern_Builder.Controllers
{
    [Route("api/[controller]")]
    public class HouseBuilderController : Controller
    {
        IHouseBuilder houseBuilder;
        CivilEngineer engineer;
        // GET: /<controller>/
        public HouseBuilderController()
        {
            engineer  = new CivilEngineer();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("[action]")]
        public House GetHouse(string id)
        {
            switch (id)
            {
                case "modern":
                    GetModernHouse();
                    break;
                case "igloo":
                    GetIglooHouse();
                    break;

            }
            return engineer.GetHouse();
            
        }

        private void GetModernHouse()
        {
            houseBuilder = new ModernHouseBuilder();
            engineer = new CivilEngineer(houseBuilder);
            engineer.Construct();
        }

        private void GetIglooHouse()
        {
            houseBuilder = new IglooHouseBuilder();
            engineer = new CivilEngineer(houseBuilder);
            engineer.Construct();
        }
        [HttpGet("[action]")]
        public IEnumerable<House> DefaultHouses()
        {
            var defaultHouses = new List<House>();
            defaultHouses.Add(GetHouse("modern"));
            defaultHouses.Add(GetHouse("igloo"));
            return defaultHouses.AsEnumerable();
        }

    }
}
