using DesignPattern_Builder.BuilderDesignPattern.MealPlanner.Product;

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
            _meal.Dessert = "Blueberry Cheesecake";
        }

        public void AddDrinks()
        {
            _meal.Drinks = "Red Wine";
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
