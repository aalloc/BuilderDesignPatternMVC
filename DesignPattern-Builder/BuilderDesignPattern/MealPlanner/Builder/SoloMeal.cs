using DesignPattern_Builder.BuilderDesignPattern.MealPlanner.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern_Builder.BuilderDesignPattern.MealPlanner.Builder
{
    public class SoloMeal : IMealBuilder
    {
        Meal _meal;
        public SoloMeal()
        {
            _meal = new Meal
            {
                Name = "Solo Meal",
                ImageUrl = @"/images/solomealicon.png"
            };
        }
        public void AddAppetizer()
        {
            _meal.Appetizer = "Mushroom Soup";
        }

        public void AddDessert()
        {
            _meal.Dessert = "Cheese Cake";
        }

        public void AddDrinks()
        {
            _meal.Drinks = "Root Beer";
        }

        public void AddMainCourse()
        {
            _meal.MainCourse = "Beef Tenerloin Steak";
        }

        public void AddVeggie()
        {
            _meal.Veggie = "Asparagus";
        }

        public Meal ServeMeal()
        {
            return _meal;
        }
    }
}
