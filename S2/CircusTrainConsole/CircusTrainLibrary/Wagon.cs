using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircusTrainLibrary
{
    public class Wagon
    {
        public List<Animal> Animals;
        private int Capacity { get; set; }
        public int capacityLeft { get; set; }

        public Wagon()
        {
            Animals = new List<Animal>();
            Capacity = 10;
        }

        public bool TryAddAnimalToWagon(Animal animal)
        {
            if (AnimalIsNotToLarge(animal))
            {
                if (AnimalMayBeAdded(animal))
                {
                    Animals.Add(animal);
                    return true; // "Animal has succesfully been added to a wagon";
                }
            }
            return false;
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

        private bool AnimalIsNotToLarge(Animal animal)
        {
            capacityLeft = Capacity;
            foreach (var _animal in Animals)
            {
                capacityLeft -= (int)_animal.Size;
            }
            return capacityLeft >= (int)animal.Size;
        }

        private bool AnimalMayBeAdded(Animal animal)
        {
            switch (animal.Type)
            {
                case Type.Carnivore:
                    switch (animal.Size)
                    {
                        case Size.large:
                            {
                                if (Animals.Count() != 0)
                                {
                                    return false;
                                }
                                return true;
                            }

                        case Size.medium:
                            {
                                foreach (var _animal in Animals)
                                {
                                    if (_animal.Type == Type.Carnivore)
                                    {
                                        return false;
                                    }
                                    else if (_animal.Type == Type.Herbivore && _animal.Size == Size.medium || _animal.Size == Size.small)
                                    {
                                        return false;
                                    }
                                }
                                return true;
                            }

                        case Size.small:
                        {
                            foreach (var _animal in Animals)
                            {
                                if (_animal.Type == Type.Carnivore)
                                {
                                    return false;
                                }
                                else if (_animal.Type == Type.Herbivore && _animal.Size == Size.small)
                                {
                                    return false;
                                }
                            }
                            return true;
                        }
                    }
                    break;

                case Type.Herbivore:
                    switch (animal.Size)
                    {
                        case Size.large:
                            {
                                foreach (var _animal in Animals)
                                {
                                    if (_animal.Type == Type.Carnivore && _animal.Size == Size.large)
                                    {
                                        return false;
                                    }
                                }
                                return true;
                            }
                        case Size.medium:
                            {
                                foreach (var _animal in Animals)
                                {
                                    if (_animal.Type == Type.Carnivore && _animal.Size == Size.large || _animal.Type == Type.Carnivore && _animal.Size == Size.medium)
                                    {
                                        return false;
                                    }
                                }
                                return true;
                            }
                            
                        case Size.small:
                            {
                                foreach (var _animal in Animals)
                                {
                                    if (_animal.Type == Type.Carnivore)
                                    {
                                        return false;
                                    }
                                }
                                return true;
                            }
                    }
                    break;
            }
            return true;
        }
    }
}
