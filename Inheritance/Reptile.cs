using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance 
{
    public class Reptile : Animal
    {
        public Reptile()
        {
        }

        public bool isPoisonous {get; set;}
        public bool hasShell {get; set;}
        public string makesNoise {get; set;}
        public bool hasFangs { get; set; }
    }
}
