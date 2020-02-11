using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern_Builder.BuilderDesignPattern.MealPlanner.Builder;
using DesignPattern_Builder.BuilderDesignPattern.MealPlanner.Director;
using DesignPattern_Builder.BuilderDesignPattern.MealPlanner.Product;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern_Builder.Controllers
{
    [Route("api/[controller]")]
    public class MealBuilderController : Controller
    {
        IMealBuilder _mealBuilder;
        Chef _chef;
        public MealBuilderController()
        {
            _chef = new Chef();
        }

        [HttpGet("[action]")]
        public Meal MakeMeal(string type)
        {
            switch(type)
            {
                case "kiddie":
                    return MakeKiddieMeal();
                case "solo":
                    return MakeSoloMeal();
                default:
                    return MakeBeerSet();
            }
        }

        private Meal MakeKiddieMeal()
        {
            _mealBuilder = new KiddieMeal();
            _chef.Cook(_mealBuilder);
            var kiddieMeal = _mealBuilder.ServeMeal();
            return kiddieMeal;
        }

        private Meal MakeSoloMeal()
        {
            _mealBuilder = new SoloMeal();
            _chef.Cook(_mealBuilder);
            var meal = _mealBuilder.ServeMeal();
            return meal;
        }

        private Meal MakeBeerSet()
        {
            _mealBuilder = new BeerSet();
            _chef.Cook(_mealBuilder);
            var meal = _mealBuilder.ServeMeal();
            return meal;
        }


    }
}