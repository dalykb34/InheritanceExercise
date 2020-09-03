using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
        }

        public bool canFly { get; set;}
        public bool doesSwim { get; set;}
        public bool isCarnivore { get; set;}
        public string migrationDirection { get; set;}
    }
}
