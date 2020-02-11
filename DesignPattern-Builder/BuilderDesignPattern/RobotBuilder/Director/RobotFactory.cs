using DesignPattern_Builder.BuilderDesignPattern.RobotBuilder.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern_Builder.BuilderDesignPattern.RobotBuilder.Director
{
    public class RobotFactory
    {
        IRobotBuilder _robotBuilder;
        public RobotFactory(IRobotBuilder robotBuilder)
        {
            _robotBuilder = robotBuilder;
        }
        public void ConstructRobot()
        {
            _robotBuilder.BuildArms();
            _robotBuilder.BuildHead();
            _robotBuilder.BuildTorso();
            _robotBuilder.BuildLegs();
            _robotBuilder.EquipWeapon();
        }
    }
}
