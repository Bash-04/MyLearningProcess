using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CircusTrainLibrary
{
    public class Scenario
    {
        public string Name { get; private set; }
        public Action Selected { get; private set; }
        public List<Animal> Animals { get; private set; }

        public Scenario() { }

        public Scenario(string name, Action selected)
        {
            Name = name;
            Selected = selected;
            Animals = new List<Animal>();
        }

        public void LoadChosenScenario()
        {
            Console.Clear();
            switch (Name)
            {
                case "Scenario 1":
                    ScenarioOne();
                    break;
                case "Scenario 2":
                    ScenarioTwo();
                    break;
                case "Scenario 3":
                    ScenarioThree();
                    break;
                case "Scenario 4":
                    ScenarioFour();
                    break;
                case "Scenario 5":
                    ScenarioFive();
                    break;
                case "Scenario 6":
                    ScenarioSix();
                    break;
                case "Scenario 7":
                    ScenarioSeven();
                    break;
                case "Choose your own amount of animals":
                    Console.ReadLine();
                    break;
            }
        }

        private void ScenarioOne()
        {
            TryCreateNewAnimal(Size.small, Type.Carnivore);
            TryCreateNewAnimal(Size.large, Type.Herbivore);
            TryCreateNewAnimal(Size.large, Type.Herbivore);
            TryCreateNewAnimal(Size.medium, Type.Herbivore);
            TryCreateNewAnimal(Size.medium, Type.Herbivore);
            TryCreateNewAnimal(Size.medium, Type.Herbivore);
        }

        private void ScenarioTwo()
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

        private void ScenarioThree()
        {
            TryCreateNewAnimal(Size.large, Type.Carnivore);
            TryCreateNewAnimal(Size.medium, Type.Carnivore);
            TryCreateNewAnimal(Size.small, Type.Carnivore);
            TryCreateNewAnimal(Size.large, Type.Herbivore);
            TryCreateNewAnimal(Size.medium, Type.Herbivore);
            TryCreateNewAnimal(Size.small, Type.Herbivore);
        }

        private void ScenarioFour()
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

        private void ScenarioFive()
        {
            TryCreateNewAnimal(Size.small, Type.Carnivore);
            TryCreateNewAnimal(Size.large, Type.Herbivore);
            TryCreateNewAnimal(Size.large, Type.Herbivore);
            TryCreateNewAnimal(Size.medium, Type.Herbivore);
            TryCreateNewAnimal(Size.small, Type.Herbivore);
        }

        private void ScenarioSix()
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

        private void ScenarioSeven()
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

        public int CreateRandomAmountOfAnimals(int AmountOfAnimals)
        {
            Random random = new Random();
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
    }
}
