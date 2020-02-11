using DesignPattern_Builder.BuilderDesignPattern.MealPlanner.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
