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
        public int CapacityLeft { get; set; }

        public Wagon()
        {
            Animals = new List<Animal>();
            Capacity = 10;
        }

        public bool TryAddAnimalToWagon(Animal animal)
        {
            if (AnimalIsNotToLarge(animal))
            {
                foreach (var animalInWagon in Animals)
                {
                    if (animal.TryEatOtherAnimal(animalInWagon.Size))
                    {
                        return false;
                    }
                    else if (animalInWagon.TryEatOtherAnimal(animal.Size))
                    {
                        return false;
                    }
                }
                Animals.Add(animal);
                return true; // "Animal has succesfully been added to a wagon";
            }
            return false;
        }

        private bool AnimalIsNotToLarge(Animal animal)
        {
            CapacityLeft = Capacity;
            foreach (var animalInWagon in Animals)
            {
                CapacityLeft -= (int)animalInWagon.Size;
            }
            return CapacityLeft >= (int)animal.Size;
        }
    }
}
