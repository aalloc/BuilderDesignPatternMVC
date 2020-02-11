using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern_Builder.BuilderDesignPattern.MealPlanner.Product
{
    public class Meal
    {
        public Meal()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Veggie { get; set; }
        public string MainCourse { get; set; }
        public string Drinks { get; set; }
        public string Appetizer { get; set; }
        public string Dessert { get; set; }
        public string ImageUrl { get; set; }

    }
}
