using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern_Builder.BuilderDesignPattern.RobotBuilder.Product;

namespace DesignPattern_Builder.BuilderDesignPattern.RobotBuilder.Builder
{
    public class NoobRobot : IRobotBuilder
    {
        Robot _robot;
        public NoobRobot()
        {
            _robot = new Robot
            {
                Id = Guid.NewGuid(),
                Type = "Noob"
            };
        }
        public void BuildArms()
        {
            _robot.Arms = "Tin Arms";
        }

        public void BuildHead()
        {
            _robot.Head = "Tin Head";
        }

        public void BuildLegs()
        {
            _robot.Legs = "Tin Legs";
        }

        public void BuildTorso()
        {
            _robot.Torso = "Tin Torso";
        }

        public void EquipWeapon()
        {
            _robot.Weapon = "Sword";
        }

        public Robot GetRobot()
        {
            return _robot;
        }
    }
}
