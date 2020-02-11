using DesignPattern_Builder.BuilderDesignPattern.HouseBuilder.Product;

namespace DesignPattern_Builder.BuilderDesignPattern.HouseBuilder.Builder
{
    public interface IHouseBuilder
    { 
        void BuildGarage();
        void BuildRoof();
        void BuildStructure();
        void BuildRooms();
        void BuildInterior();
        House GetHouse();
    }
}
