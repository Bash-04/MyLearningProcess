using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircusTrainLibrary
{
    public class Animal
    {
        public Size Size { get; private set; }
        public Type Type { get; private set; }

        public Animal(Size size, Type type) 
        {
            Size = size;
            Type = type;
        }

        public bool TryEatOtherAnimal()
        {
            return false;
        }
    }
}
