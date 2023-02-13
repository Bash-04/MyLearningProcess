using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CircusTrainLibrary
{
    public class CircusTrain
    {
        public List<Wagon> Wagons;
        public List<Animal> Animals;
        Random random = new Random();
        
        public CircusTrain()
        {
            Wagons = new List<Wagon>();
            Animals = new List<Animal>();
            CreateTestAnimals();
        }

        public StringBuilder PutEveryAnimalInAWagon()
        {
            foreach (var animal in OrderAnimalsOnTypeAndSize())
            {
            // eerst alle carnivoren aan wagons toevoegen. voor iedere carnivoor maak een nieuwe wagon aan.
                if (animal.Type == Type.Carnivor)
                {
                    Wagon w = new Wagon();
                    Wagons.Add(w);
                    w.TryAddAnimalToWagon(animal);
                }
                // voor iedere herbivoor check iedere wagon of de herbivoor toegevoegd mag worden. zo niet maak een nieuwe wagon. 
                if (animal.Type == Type.Herbivor)
                {
                    bool animalHasBeenAdded = false;
                    foreach (var wagon in Wagons)
                    {
                        animalHasBeenAdded = false;
                        if (wagon.TryAddAnimalToWagon(animal))
                        {
                            animalHasBeenAdded = true;
                        }
                    }
                    if (!animalHasBeenAdded)
                    {
                        Wagon w = new Wagon();
                        Wagons.Add(w);
                        w.TryAddAnimalToWagon(animal);
                    }
                }
            }

            //Wagon w = new Wagon();
            //Wagons.Add(w);

            //foreach (var animal in OrderAnimalsOnTypeAndSize())
            //{
            //    if (!w.TryAddAnimalToWagon(animal))
            //    {
            //        w = new Wagon();
            //        Wagons.Add(w);
            //        w.TryAddAnimalToWagon(animal);
            //    }
            //}

            for (int i = 0; i < Wagons.Count; i++)
            {
                if (Wagons[i].Capacity == 10)
                {
                    Wagons.RemoveAt(i);
                }
            }

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var animal in OrderAnimalsOnTypeAndSize())
            {
                stringBuilder.AppendLine($"{animal.Size} {animal.Type}");
            }

            return stringBuilder;
        }

        private void CreateTestAnimals()
        {
            /// Eigen Scenario
            //TryCreateNewAnimal(Size.small, Type.Carnivor);
            //TryCreateNewAnimal(Size.medium, Type.Herbivor);
            //TryCreateNewAnimal(Size.small, Type.Herbivor);
            //TryCreateNewAnimal(Size.small, Type.Herbivor);
            //TryCreateNewAnimal(Size.large, Type.Carnivor);
            //TryCreateNewAnimal(Size.small, Type.Herbivor);
            //TryCreateNewAnimal(Size.medium, Type.Herbivor);
            //TryCreateNewAnimal(Size.medium, Type.Carnivor);
            //TryCreateNewAnimal(Size.small, Type.Carnivor);
            //TryCreateNewAnimal(Size.large, Type.Herbivor);

            /// Scenario 1
            //TryCreateNewAnimal(Size.small, Type.Carnivor);
            //TryCreateNewAnimal(Size.large, Type.Herbivor);
            //TryCreateNewAnimal(Size.large, Type.Herbivor);
            //TryCreateNewAnimal(Size.medium, Type.Herbivor);
            //TryCreateNewAnimal(Size.medium, Type.Herbivor);
            //TryCreateNewAnimal(Size.medium, Type.Herbivor);

            /// Scenario 2
            //TryCreateNewAnimal(Size.small, Type.Carnivor);
            //TryCreateNewAnimal(Size.large, Type.Herbivor);
            //TryCreateNewAnimal(Size.medium, Type.Herbivor);
            //TryCreateNewAnimal(Size.medium, Type.Herbivor);
            //TryCreateNewAnimal(Size.small, Type.Herbivor);
            //TryCreateNewAnimal(Size.small, Type.Herbivor);
            //TryCreateNewAnimal(Size.small, Type.Herbivor);
            //TryCreateNewAnimal(Size.small, Type.Herbivor);
            //TryCreateNewAnimal(Size.small, Type.Herbivor);

            /// Scenario 3
            //TryCreateNewAnimal(Size.large, Type.Carnivor);
            //TryCreateNewAnimal(Size.medium, Type.Carnivor);
            //TryCreateNewAnimal(Size.small, Type.Carnivor);
            //TryCreateNewAnimal(Size.large, Type.Herbivor);
            //TryCreateNewAnimal(Size.medium, Type.Herbivor);
            //TryCreateNewAnimal(Size.small, Type.Herbivor);

            /// Scenario 4
            //TryCreateNewAnimal(Size.large, Type.Carnivor);
            //TryCreateNewAnimal(Size.medium, Type.Carnivor);
            //TryCreateNewAnimal(Size.small, Type.Carnivor);
            //TryCreateNewAnimal(Size.small, Type.Carnivor);
            //TryCreateNewAnimal(Size.large, Type.Herbivor);
            //TryCreateNewAnimal(Size.medium, Type.Herbivor);
            //TryCreateNewAnimal(Size.medium, Type.Herbivor);
            //TryCreateNewAnimal(Size.medium, Type.Herbivor);
            //TryCreateNewAnimal(Size.medium, Type.Herbivor);
            //TryCreateNewAnimal(Size.medium, Type.Herbivor);
            //TryCreateNewAnimal(Size.small, Type.Herbivor);

            /// Scenario 5
            //TryCreateNewAnimal(Size.small, Type.Carnivor);
            //TryCreateNewAnimal(Size.large, Type.Herbivor);
            //TryCreateNewAnimal(Size.large, Type.Herbivor);
            //TryCreateNewAnimal(Size.medium, Type.Herbivor);
            //TryCreateNewAnimal(Size.small, Type.Herbivor);

            /// Scenario 6
            //TryCreateNewAnimal(Size.small, Type.Carnivor);
            //TryCreateNewAnimal(Size.small, Type.Carnivor);
            //TryCreateNewAnimal(Size.small, Type.Carnivor);
            //TryCreateNewAnimal(Size.large, Type.Herbivor);
            //TryCreateNewAnimal(Size.large, Type.Herbivor);
            //TryCreateNewAnimal(Size.large, Type.Herbivor);
            //TryCreateNewAnimal(Size.medium, Type.Herbivor);
            //TryCreateNewAnimal(Size.medium, Type.Herbivor);

            /// Scenario 7
            //TryCreateNewAnimal(Size.large, Type.Carnivor);
            //TryCreateNewAnimal(Size.large, Type.Carnivor);
            //TryCreateNewAnimal(Size.large, Type.Carnivor);
            //TryCreateNewAnimal(Size.medium, Type.Carnivor);
            //TryCreateNewAnimal(Size.medium, Type.Carnivor);
            //TryCreateNewAnimal(Size.medium, Type.Carnivor);
            //TryCreateNewAnimal(Size.small, Type.Carnivor);
            //TryCreateNewAnimal(Size.small, Type.Carnivor);
            //TryCreateNewAnimal(Size.small, Type.Carnivor);
            //TryCreateNewAnimal(Size.small, Type.Carnivor);
            //TryCreateNewAnimal(Size.small, Type.Carnivor);
            //TryCreateNewAnimal(Size.small, Type.Carnivor);
            //TryCreateNewAnimal(Size.small, Type.Carnivor);
            //TryCreateNewAnimal(Size.large, Type.Herbivor);
            //TryCreateNewAnimal(Size.large, Type.Herbivor);
            //TryCreateNewAnimal(Size.large, Type.Herbivor);
            //TryCreateNewAnimal(Size.large, Type.Herbivor);
            //TryCreateNewAnimal(Size.large, Type.Herbivor);
            //TryCreateNewAnimal(Size.large, Type.Herbivor);
            //TryCreateNewAnimal(Size.medium, Type.Herbivor);
            //TryCreateNewAnimal(Size.medium, Type.Herbivor);
            //TryCreateNewAnimal(Size.medium, Type.Herbivor);
            //TryCreateNewAnimal(Size.medium, Type.Herbivor);
            //TryCreateNewAnimal(Size.medium, Type.Herbivor);
        }

        public int CreateRandomAmountOfAnimals(int AmountOfAnimals)
        {
            for (int i = 0; i < AmountOfAnimals; i++)
            {
                var sizeVar = Size.small;
                int size = random.Next(1, 4);

                var typeVar = Type.Carnivor;
                int type = random.Next(1, 3);

                if (size == 1)
                {
                    sizeVar = Size.small;
                }
                else if (size == 2)
                {
                    sizeVar = Size.medium;
                }
                else if (size == 3)
                {
                    sizeVar = Size.large;
                }
                if (type == 1)
                {
                    typeVar = Type.Carnivor;
                }
                else if (type == 2)
                {
                    typeVar = Type.Herbivor;
                }
                TryCreateNewAnimal(sizeVar, typeVar);
            }
            return AmountOfAnimals;
        }

        public string TryCreateNewAnimal(Size size, Type type)
        {
            Animal animal;
            if (AnimalMayBeCreated(size, type))
            {
                animal = new Animal(size, type);
                Animals.Add(animal);
            }
            else
            {
                return "Don't forget filling in a size AND a type for the animal";
            }
            return "Animal has succesfully been created";
        }

        private bool AnimalMayBeCreated(Size size, Type type)
        {
            if (size != Size.small && size != Size.medium && size != Size.large || type != Type.Herbivor && type != Type.Carnivor)
            {
                return false;
            }
            return true;
        }

        public IEnumerable<Animal> OrderAnimalsOnTypeAndSize()
        {
            var orderedAnimalsOnSize = Animals.OrderByDescending(x => x.Size);
            var orderedAnimalsOnSizeAndOnType = orderedAnimalsOnSize.OrderBy(x => x.Type);

            return orderedAnimalsOnSizeAndOnType;
        }
    }
}
