using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern_Builder.BuilderDesignPattern.RobotBuilder.Builder;
using DesignPattern_Builder.BuilderDesignPattern.RobotBuilder.Director;
using DesignPattern_Builder.BuilderDesignPattern.RobotBuilder.Product;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern_Builder.Controllers
{
    [Route("api/[controller]")]
    public class RobotBuilderController : Controller
    {
        IRobotBuilder _robotBuilder;

        [HttpGet("[action]")]
        public Robot ConstructRobot(string type)
        {
            switch (type)
            {
                case "noob":
                    return MakeNoobRobot();
                case "solid":
                    return MakeSolidRobot();
                default:
                    return MakeNoobRobot();
            }
        }

        public Robot MakeNoobRobot()
        {
            _robotBuilder = new NoobRobot();
            RobotFactory factory = new RobotFactory(_robotBuilder);
            factory.ConstructRobot();
            var noobRobot = _robotBuilder.GetRobot();
            return noobRobot;
        }

        public Robot MakeSolidRobot()
        {
            _robotBuilder = new SolidRobot();
            RobotFactory factory = new RobotFactory(_robotBuilder);
            factory.ConstructRobot();
            var noobRobot = _robotBuilder.GetRobot();
            return noobRobot;
        }
    }
}