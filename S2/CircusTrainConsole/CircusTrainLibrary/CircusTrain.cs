﻿using System.Collections.Generic;
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
        }

        public string PutEveryAnimalInAWagon()
        {
            #region commented for loop (same as foreach)
            //for (int i = 0; i < OrderAnimalsOnTypeAndSize().Count(); i++)
            //{
            //    Animal animal = OrderAnimalsOnTypeAndSize().ElementAt(i);
            //    // eerst alle carnivoren aan wagons toevoegen. voor iedere carnivoor maak een nieuwe wagon aan.
            //    int FirstNotFullWagon = 0;
            //    if (animal.Type == Type.Carnivore)
            //    {
            //        Wagon w = new Wagon();
            //        Wagons.Add(w);
            //        w.TryAddAnimalToWagon(animal);
            //        if (animal.Size == Size.large)
            //        {
            //            FirstNotFullWagon++;
            //        }
            //    }
            //    // voor iedere herbivoor check iedere wagon of de herbivoor toegevoegd mag worden. zo niet maak een nieuwe wagon. 
            //    if (animal.Type == Type.Herbivore)
            //    {
            //        bool animalHasBeenAdded = false;
            //        for (int j = FirstNotFullWagon; j < Wagons.Count; j++)
            //        {
            //            animalHasBeenAdded = false;
            //            if (Wagons[j].TryAddAnimalToWagon(animal))
            //            {
            //                animalHasBeenAdded = true;
            //            }
            //        }
            //        //foreach (var wagon in Wagons)
            //        //{
            //        //    if(wagon.Capacity != 0)
            //        //    {
            //        //        animalHasBeenAdded = false;
            //        //        if (wagon.TryAddAnimalToWagon(animal))
            //        //        {
            //        //            animalHasBeenAdded = true;
            //        //        }
            //        //    }
            //        //}
            //        if (!animalHasBeenAdded)
            //        {
            //            Wagon w = new Wagon();
            //            Wagons.Add(w);
            //            w.TryAddAnimalToWagon(animal);
            //        }
            //    }
            //}
            #endregion

            foreach (var animal in OrderAnimalsOnTypeAndSize())
            {
                // eerst alle carnivoren aan wagons toevoegen. voor iedere carnivoor maak een nieuwe wagon aan.
                if (animal.Type == Type.Carnivore)
                {
                    Wagon w = new Wagon();
                    Wagons.Add(w);
                    w.TryAddAnimalToWagon(animal);
                }
                // voor iedere herbivoor check iedere wagon of de herbivoor toegevoegd mag worden. zo niet maak een nieuwe wagon. 
                if (animal.Type == Type.Herbivore)
                {
                    bool animalHasBeenAdded = false;
                    foreach (var wagon in Wagons)
                    {
                        if (wagon.capacityLeft != 0)
                        {
                            animalHasBeenAdded = false;
                            if (wagon.TryAddAnimalToWagon(animal))
                            {
                                animalHasBeenAdded = true;
                            }
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

            RemoveEmptyWagons();

            return "All animals have been added to a wagon";
        }

        public StringBuilder AllAnimalsInTrain()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var animal in OrderAnimalsOnTypeAndSize())
            {
                stringBuilder.AppendLine($"{animal.Size} {animal.Type}");
            }

            return stringBuilder;
        }

        public string RemoveEmptyWagons()
        {
            int count = 0;
            string AmountOfWagonsRemoved = $"{ count } wagons have been removed";

            for (int i = 0; i < Wagons.Count; i++)
            {
                if (Wagons[i].capacityLeft == 10)
                {
                    Wagons.RemoveAt(i);
                    count++;
                }
            }

            return AmountOfWagonsRemoved = $"{count} wagons have been removed";
        }

        public StringBuilder ShowWagons()
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < Wagons.Count(); i++)
            {
                stringBuilder.AppendLine($"Wagon {i + 1}");
                for (int j = 0; j < Wagons[i].Animals.Count(); j++)
                {
                    stringBuilder.AppendLine($"{Wagons[i].Animals[j].Size} {Wagons[i].Animals[j].Type}");
                }
                stringBuilder.AppendLine("");
            }

            return stringBuilder;
        }

        public void ScenarioOne()
        {
            TryCreateNewAnimal(Size.small, Type.Carnivore);
            TryCreateNewAnimal(Size.large, Type.Herbivore);
            TryCreateNewAnimal(Size.large, Type.Herbivore);
            TryCreateNewAnimal(Size.medium, Type.Herbivore);
            TryCreateNewAnimal(Size.medium, Type.Herbivore);
            TryCreateNewAnimal(Size.medium, Type.Herbivore);
        }

        public void ScenarioTwo()
        {
            TryCreateNewAnimal(Size.small, Type.Carnivore);
            TryCreateNewAnimal(Size.large, Type.Herbivore);
            TryCreateNewAnimal(Size.medium, Type.Herbivore);
            TryCreateNewAnimal(Size.medium, Type.Herbivore);
            TryCreateNewAnimal(Size.small, Type.Herbivore);
            TryCreateNewAnimal(Size.small, Type.Herbivore);
            TryCreateNewAnimal(Size.small, Type.Herbivore);
            TryCreateNewAnimal(Size.small, Type.Herbivore);
            TryCreateNewAnimal(Size.small, Type.Herbivore);
        }

        public void ScenarioThree()
        {
            TryCreateNewAnimal(Size.large, Type.Carnivore);
            TryCreateNewAnimal(Size.medium, Type.Carnivore);
            TryCreateNewAnimal(Size.small, Type.Carnivore);
            TryCreateNewAnimal(Size.large, Type.Herbivore);
            TryCreateNewAnimal(Size.medium, Type.Herbivore);
            TryCreateNewAnimal(Size.small, Type.Herbivore);
        }

        public void ScenarioFour()
        {
            TryCreateNewAnimal(Size.large, Type.Carnivore);
            TryCreateNewAnimal(Size.medium, Type.Carnivore);
            TryCreateNewAnimal(Size.small, Type.Carnivore);
            TryCreateNewAnimal(Size.small, Type.Carnivore);
            TryCreateNewAnimal(Size.large, Type.Herbivore);
            TryCreateNewAnimal(Size.medium, Type.Herbivore);
            TryCreateNewAnimal(Size.medium, Type.Herbivore);
            TryCreateNewAnimal(Size.medium, Type.Herbivore);
            TryCreateNewAnimal(Size.medium, Type.Herbivore);
            TryCreateNewAnimal(Size.medium, Type.Herbivore);
            TryCreateNewAnimal(Size.small, Type.Herbivore);
        }

        public void ScenarioFive()
        {
            TryCreateNewAnimal(Size.small, Type.Carnivore);
            TryCreateNewAnimal(Size.large, Type.Herbivore);
            TryCreateNewAnimal(Size.large, Type.Herbivore);
            TryCreateNewAnimal(Size.medium, Type.Herbivore);
            TryCreateNewAnimal(Size.small, Type.Herbivore);
        }

        public void ScenarioSix()
        {
            TryCreateNewAnimal(Size.small, Type.Carnivore);
            TryCreateNewAnimal(Size.small, Type.Carnivore);
            TryCreateNewAnimal(Size.small, Type.Carnivore);
            TryCreateNewAnimal(Size.large, Type.Herbivore);
            TryCreateNewAnimal(Size.large, Type.Herbivore);
            TryCreateNewAnimal(Size.large, Type.Herbivore);
            TryCreateNewAnimal(Size.medium, Type.Herbivore);
            TryCreateNewAnimal(Size.medium, Type.Herbivore);
        }

        public void ScenarioSeven()
        {
            TryCreateNewAnimal(Size.large, Type.Carnivore);
            TryCreateNewAnimal(Size.large, Type.Carnivore);
            TryCreateNewAnimal(Size.large, Type.Carnivore);
            TryCreateNewAnimal(Size.medium, Type.Carnivore);
            TryCreateNewAnimal(Size.medium, Type.Carnivore);
            TryCreateNewAnimal(Size.medium, Type.Carnivore);
            TryCreateNewAnimal(Size.small, Type.Carnivore);
            TryCreateNewAnimal(Size.small, Type.Carnivore);
            TryCreateNewAnimal(Size.small, Type.Carnivore);
            TryCreateNewAnimal(Size.small, Type.Carnivore);
            TryCreateNewAnimal(Size.small, Type.Carnivore);
            TryCreateNewAnimal(Size.small, Type.Carnivore);
            TryCreateNewAnimal(Size.small, Type.Carnivore);
            TryCreateNewAnimal(Size.large, Type.Herbivore);
            TryCreateNewAnimal(Size.large, Type.Herbivore);
            TryCreateNewAnimal(Size.large, Type.Herbivore);
            TryCreateNewAnimal(Size.large, Type.Herbivore);
            TryCreateNewAnimal(Size.large, Type.Herbivore);
            TryCreateNewAnimal(Size.large, Type.Herbivore);
            TryCreateNewAnimal(Size.medium, Type.Herbivore);
            TryCreateNewAnimal(Size.medium, Type.Herbivore);
            TryCreateNewAnimal(Size.medium, Type.Herbivore);
            TryCreateNewAnimal(Size.medium, Type.Herbivore);
            TryCreateNewAnimal(Size.medium, Type.Herbivore);
        }

        public void ScenarioEight()
        {
        }

        public int CreateRandomAmountOfAnimals(int AmountOfAnimals)
        {
            for (int i = 0; i < AmountOfAnimals; i++)
            {
                var sizeVar = Size.small;
                int size = random.Next(1, 4);

                var typeVar = Type.Carnivore;
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
                    typeVar = Type.Carnivore;
                }
                else if (type == 2)
                {
                    typeVar = Type.Herbivore;
                }
                TryCreateNewAnimal(sizeVar, typeVar);
            }
            return AmountOfAnimals;
        }

        private string TryCreateNewAnimal(Size size, Type type)
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
            if (size != Size.small && size != Size.medium && size != Size.large || type != Type.Herbivore && type != Type.Carnivore)
            {
                return false;
            }
            return true;
        }

        private IEnumerable<Animal> OrderAnimalsOnTypeAndSize()
        {
            var orderedAnimalsOnSize = Animals.OrderByDescending(x => x.Size);
            var orderedAnimalsOnSizeAndOnType = orderedAnimalsOnSize.OrderBy(x => x.Type);

            return orderedAnimalsOnSizeAndOnType;
        }
    }
}
