using DesignPattern_Builder.BuilderDesignPattern.RobotBuilder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern_Builder.BuilderDesignPattern.RobotBuilder.Builder
{
    public interface IRobotBuilder
    {
        void BuildHead();
        void BuildTorso();
        void BuildLegs();
        void BuildArms();
        void EquipWeapon();
        Robot GetRobot();
    }
}
