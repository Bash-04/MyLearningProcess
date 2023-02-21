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

        public bool TryEatOtherAnimal(Size praySize)
        {
            bool result = false;
            switch (Type)
            {
                case Type.Carnivore:
                    switch (Size)
                    {
                        case Size.large:
                            {
                                result = true;
                                break;
                            }

                        case Size.medium:
                            {
                                if (praySize == Size.medium || praySize == Size.small)
                                {
                                    result = true;
                                }
                                break;
                            }

                        case Size.small:
                            {
                                if (praySize == Size.small)
                                {
                                    result = true;
                                }
                                break;
                            }
                    }
                    break;

                case Type.Herbivore:
                    result = false;
                    break;
            }
            return result;
        }
    }
}
