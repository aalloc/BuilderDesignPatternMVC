using DesignPattern_Builder.BuilderDesignPattern.MealPlanner.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern_Builder.BuilderDesignPattern.MealPlanner.Builder
{
    public class KiddieMeal : IMealBuilder
    {
        Meal _meal;
        public KiddieMeal()
        {
            _meal = new Meal
            {
                Name = "Kiddie Meal",
                ImageUrl = @"/images/kiddiemealicon.png"
            };
        }
        public void AddAppetizer()
        {
            _meal.Appetizer = "French Fries";
        }

        public void AddDessert()
        {
            _meal.Dessert = "Chocolate Sundae";
        }

        public void AddDrinks()
        {
            _meal.Drinks = "Orange Juice";
        }

        public void AddMainCourse()
        {
            _meal.MainCourse = "Chicken Spaghetti";
        }

        public void AddVeggie()
        {
            _meal.Veggie = "None";
        }
        public Meal ServeMeal()
        {
            return _meal;
        }
    }
}
