using DesignPattern_Builder.BuilderDesignPattern.MealPlanner.Product;

namespace DesignPattern_Builder.BuilderDesignPattern.MealPlanner.Builder
{
    public class BeerSet : IMealBuilder
    {
        Meal _meal;
        public BeerSet()
        {
            _meal = new Meal
            {
                Name = "Beer Set",
                ImageUrl = @"/images/beericon.png"
            };
        }
        public void AddAppetizer()
        {
            _meal.Appetizer = "Kropek";
        }

        public void AddDessert()
        {
            _meal.Dessert = "None";
        }

        public void AddDrinks()
        {
            _meal.Drinks = "1 Bucket of Red Horse Beer";
        }

        public void AddMainCourse()
        {
            _meal.MainCourse = "Crispy Pata";
        }

        public void AddVeggie()
        {
            _meal.Veggie = "Vegetable Salad";
        }
        public Meal ServeMeal()
        {
            return _meal;
        }
    }
}
