using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircusTrainLibrary
{
    public class Wagon
    {
        private List<Animal> Animals;
        private int Capacity = 10;

        public Wagon()
        {
            Animals = new List<Animal>();
        }

        public string TryAddAnimalToWagon(Animal animal)
        {
            if (!WagonIsFull())
            {
                if (AnimalMayBeAdded())
                {
                    Animals.Add(animal);
                    return "Animal has succesfully been added to a wagon";
                }
                else
                {
                    return "Animal may not be added to the wagon";
                }
            }
            else
            {
                return "Wagon is full";
            }
        }

        private bool WagonIsFull()
        {
            foreach (var animal in Animals)
            {
                Capacity -= (int)animal.Size;
                if (Capacity < 0)
                {
                    Capacity += (int)animal.Size;
                    return true;
                }
                if (animal.Type == Type.Carnivor && animal.Size == Size.large)
                {
                    return true;
                }
            }
            if (Capacity == 0)
            {
                return true;
            }
            return false;
        }

        private bool AnimalMayBeAdded()
        {
            return true;
        }
    }
}
