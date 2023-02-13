using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircusTrainLibrary
{
    public class Wagon
    {
        public List<Animal> Animals;
        public int Capacity { get; private set; }

        public Wagon()
        {
            Animals = new List<Animal>();
            Capacity = 10;
        }

        public bool TryAddAnimalToWagon(Animal animal)
        {
            if (!WagonIsFull() && !AnimalIsToLarge(animal))
            {
                if (AnimalMayBeAdded(animal))
                {
                    Animals.Add(animal);
                    return true; // "Animal has succesfully been added to a wagon";
                }
                else
                {
                    return false; // "Animal may not be added to the wagon";
                }
            }
            else
            {
                return false; //"Wagon is full";
            }
        }

        private bool WagonIsFull()
        {
            Capacity = 10;
            foreach (var _animal in Animals)
            {
                Capacity -= (int)_animal.Size;
                if (Capacity < 0)
                {
                    Capacity += (int)_animal.Size;
                    return true;
                }
            }
            if (Capacity == 0)
            {
                return true;
            }
            return false;
        }

        private bool AnimalIsToLarge(Animal animal)
        {
            Capacity -= (int)animal.Size;
            if (Capacity < 0)
            {
                Capacity += (int)animal.Size;
                return true;
            }
            return false;
        }

        private bool AnimalMayBeAdded(Animal animal)
        {
            if (animal.Type == Type.Carnivor && animal.Size == Size.large && Animals.Count() != 0)
            {
                return false;
            }
            else if (animal.Type == Type.Carnivor && animal.Size == Size.medium)
            {
                foreach (var _animal in Animals)
                {
                    if (_animal.Type == Type.Carnivor)
                    {
                        return false;
                    }
                    else if (_animal.Type == Type.Herbivor && _animal.Size == Size.medium || _animal.Size == Size.small)
                    {
                        return false;
                    }
                }
                return true;
            }
            else if (animal.Type == Type.Carnivor && animal.Size == Size.small)
            {
                foreach (var _animal in Animals)
                {
                    if (_animal.Type == Type.Carnivor)
                    {
                        return false;
                    }
                    else if (_animal.Type == Type.Herbivor && _animal.Size == Size.small)
                    {
                        return false;
                    }
                }
                return true;
            }
            else if (animal.Type == Type.Herbivor && animal.Size == Size.large)
            {
                foreach (var _animal in Animals)
                {
                    if (_animal.Type == Type.Carnivor && _animal.Size == Size.large)
                    {
                        return false;
                    }
                }
                return true;
            }
            else if (animal.Type == Type.Herbivor && animal.Size == Size.medium)
            {
                foreach (var _animal in Animals)
                {
                    if (_animal.Type == Type.Carnivor && _animal.Size == Size.large || _animal.Type == Type.Carnivor && _animal.Size == Size.medium)
                    {
                        return false;
                    }
                }
                return true;
            }
            else if (animal.Type == Type.Herbivor && animal.Size == Size.small)
            {
                foreach (var _animal in Animals)
                {
                    if (_animal.Type == Type.Carnivor)
                    {
                        return false;
                    }
                }
                return true;
            }
            return true;
        }
    }
}
