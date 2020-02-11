using DesignPattern_Builder.BuilderDesignPattern.MealPlanner.Builder;

namespace DesignPattern_Builder.BuilderDesignPattern.MealPlanner.Director
{
    public class Chef
    {
        IMealBuilder _mealBuilder;
 
        public Chef()
        {
            
        }

        public void Cook(IMealBuilder _mealBuilder)
        {
            _mealBuilder.AddAppetizer();
            _mealBuilder.AddDessert();
            _mealBuilder.AddMainCourse();
            _mealBuilder.AddVeggie();
            _mealBuilder.AddDrinks();
        }
    }
}
