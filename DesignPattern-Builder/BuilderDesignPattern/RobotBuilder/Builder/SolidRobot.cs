using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern_Builder.BuilderDesignPattern.RobotBuilder.Product;

namespace DesignPattern_Builder.BuilderDesignPattern.RobotBuilder.Builder
{
    public class SolidRobot : IRobotBuilder
    {
        Robot _robot;
        public SolidRobot()
        {
            _robot = new Robot
            {
                Id = Guid.NewGuid(),
                Type = "Solid"
            };
        }
        public void BuildArms()
        {
            _robot.Arms = "Metal Arms" ;
        }

        public void BuildHead()
        {
            _robot.Head = "Metal Head";
        }

        public void BuildLegs()
        {
            _robot.Legs = "Metal Legs";
        }

        public void BuildTorso()
        {
            _robot.Torso = "Metal Torso";
        }

        public void EquipWeapon()
        {
            _robot.Weapon = "Spear";
        }

        public Robot GetRobot()
        {
            return _robot;
        }
    }
}
