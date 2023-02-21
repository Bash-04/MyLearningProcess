using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CircusTrainLibrary
{
    public class CircusTrain
    {
        public List<Wagon> Wagons { get; private set; }
        public List<Animal> Animals { get; private set; }
        Random random = new Random();
        
        public CircusTrain()
        {
            Wagons = new List<Wagon>();
            Animals = new List<Animal>();
        }

        public string PutEveryAnimalInAWagon()
        {
            PutAllCarnivorsInWagon();

            PutAllHerbivoresInWagon();

            return "All animals have been added to a wagon";
        }

        private void PutAllCarnivorsInWagon()
        {
            foreach (var animal in OrderAnimalsOnTypeAndSize())
            {
                // eerst alle carnivoren aan wagons toevoegen. voor iedere carnivoor maak een nieuwe wagon aan.
                if (animal.Type == Type.Carnivore)
                {
                    Wagon w = new Wagon();
                    Wagons.Add(w);
                    w.TryAddAnimalToWagon(animal);
                }
            }
        }

        private void PutAllHerbivoresInWagon()
        {
            foreach (var animal in OrderAnimalsOnTypeAndSize()) 
            { 
                // voor iedere herbivoor check iedere wagon of de herbivoor toegevoegd mag worden. zo niet maak een nieuwe wagon. 
                if (animal.Type == Type.Herbivore)
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
            CreateNewAnimal(Size.small, Type.Carnivore);
            CreateNewAnimal(Size.large, Type.Herbivore);
            CreateNewAnimal(Size.large, Type.Herbivore);
            CreateNewAnimal(Size.medium, Type.Herbivore);
            CreateNewAnimal(Size.medium, Type.Herbivore);
            CreateNewAnimal(Size.medium, Type.Herbivore);
        }

        public void ScenarioTwo()
        {
            CreateNewAnimal(Size.small, Type.Carnivore);
            CreateNewAnimal(Size.large, Type.Herbivore);
            CreateNewAnimal(Size.medium, Type.Herbivore);
            CreateNewAnimal(Size.medium, Type.Herbivore);
            CreateNewAnimal(Size.small, Type.Herbivore);
            CreateNewAnimal(Size.small, Type.Herbivore);
            CreateNewAnimal(Size.small, Type.Herbivore);
            CreateNewAnimal(Size.small, Type.Herbivore);
            CreateNewAnimal(Size.small, Type.Herbivore);
        }

        public void ScenarioThree()
        {
            CreateNewAnimal(Size.large, Type.Carnivore);
            CreateNewAnimal(Size.medium, Type.Carnivore);
            CreateNewAnimal(Size.small, Type.Carnivore);
            CreateNewAnimal(Size.large, Type.Herbivore);
            CreateNewAnimal(Size.medium, Type.Herbivore);
            CreateNewAnimal(Size.small, Type.Herbivore);
        }

        public void ScenarioFour()
        {
            CreateNewAnimal(Size.large, Type.Carnivore);
            CreateNewAnimal(Size.medium, Type.Carnivore);
            CreateNewAnimal(Size.small, Type.Carnivore);
            CreateNewAnimal(Size.small, Type.Carnivore);
            CreateNewAnimal(Size.large, Type.Herbivore);
            CreateNewAnimal(Size.medium, Type.Herbivore);
            CreateNewAnimal(Size.medium, Type.Herbivore);
            CreateNewAnimal(Size.medium, Type.Herbivore);
            CreateNewAnimal(Size.medium, Type.Herbivore);
            CreateNewAnimal(Size.medium, Type.Herbivore);
            CreateNewAnimal(Size.small, Type.Herbivore);
        }

        public void ScenarioFive()
        {
            CreateNewAnimal(Size.small, Type.Carnivore);
            CreateNewAnimal(Size.large, Type.Herbivore);
            CreateNewAnimal(Size.large, Type.Herbivore);
            CreateNewAnimal(Size.medium, Type.Herbivore);
            CreateNewAnimal(Size.small, Type.Herbivore);
        }

        public void ScenarioSix()
        {
            CreateNewAnimal(Size.small, Type.Carnivore);
            CreateNewAnimal(Size.small, Type.Carnivore);
            CreateNewAnimal(Size.small, Type.Carnivore);
            CreateNewAnimal(Size.large, Type.Herbivore);
            CreateNewAnimal(Size.large, Type.Herbivore);
            CreateNewAnimal(Size.large, Type.Herbivore);
            CreateNewAnimal(Size.medium, Type.Herbivore);
            CreateNewAnimal(Size.medium, Type.Herbivore);
        }

        public void ScenarioSeven()
        {
            CreateNewAnimal(Size.large, Type.Carnivore);
            CreateNewAnimal(Size.large, Type.Carnivore);
            CreateNewAnimal(Size.large, Type.Carnivore);
            CreateNewAnimal(Size.medium, Type.Carnivore);
            CreateNewAnimal(Size.medium, Type.Carnivore);
            CreateNewAnimal(Size.medium, Type.Carnivore);
            CreateNewAnimal(Size.small, Type.Carnivore);
            CreateNewAnimal(Size.small, Type.Carnivore);
            CreateNewAnimal(Size.small, Type.Carnivore);
            CreateNewAnimal(Size.small, Type.Carnivore);
            CreateNewAnimal(Size.small, Type.Carnivore);
            CreateNewAnimal(Size.small, Type.Carnivore);
            CreateNewAnimal(Size.small, Type.Carnivore);
            CreateNewAnimal(Size.large, Type.Herbivore);
            CreateNewAnimal(Size.large, Type.Herbivore);
            CreateNewAnimal(Size.large, Type.Herbivore);
            CreateNewAnimal(Size.large, Type.Herbivore);
            CreateNewAnimal(Size.large, Type.Herbivore);
            CreateNewAnimal(Size.large, Type.Herbivore);
            CreateNewAnimal(Size.medium, Type.Herbivore);
            CreateNewAnimal(Size.medium, Type.Herbivore);
            CreateNewAnimal(Size.medium, Type.Herbivore);
            CreateNewAnimal(Size.medium, Type.Herbivore);
            CreateNewAnimal(Size.medium, Type.Herbivore);
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
                CreateNewAnimal(sizeVar, typeVar);
            }
            return AmountOfAnimals;
        }

        private bool CreateNewAnimal(Size size, Type type)
        {
            Animal animal;
            animal = new Animal(size, type);
            Animals.Add(animal);

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
