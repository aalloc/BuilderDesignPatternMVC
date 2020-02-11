using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern_Builder.BuilderDesignPattern.RobotBuilder.Product
{
    public class Robot
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Head { get; set; }
        public string Torso { get; set; }
        public string Arms { get; set; }
        public string Legs { get; set; }
        public string Weapon { get; set; }

    }
}
