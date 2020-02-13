using DesignPattern_Builder.BuilderDesignPattern.MealPlanner.Product;

namespace DesignPattern_Builder.BuilderDesignPattern.MealPlanner.Builder
{
    public interface IMealBuilder
    {
        void AddVeggie();
        void AddDrinks();
        void AddMainCourse();
        void AddAppetizer();
        void AddDessert();
        Meal ServeMeal();
    }
}
