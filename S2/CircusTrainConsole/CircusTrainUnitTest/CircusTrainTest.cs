using CircusTrainLibrary;

namespace CircusTrainUnitTest
{
    [TestClass]
    public class CircusTrainTest
    {
        private CircusTrain circusTrain;
        //private Scenario scenario;

        [TestInitialize]
        public void Setup() 
        { 
            // Arrange
            circusTrain = new CircusTrain();
        }

        [TestMethod]
        public void RandomAmountOfAnimalsCanBeCreated()
        {
            // Arrange
            bool animalsHaveBeenCreated = false;

            // Act
            if (circusTrain.CreateRandomAmountOfAnimals(100) == 100)
            {
                animalsHaveBeenCreated = true;
            }

            // Assert
            Assert.IsTrue(animalsHaveBeenCreated);
        }

        [TestMethod]
        public void RandomAmountOfAnimalsCanBeSortedOverTheWagons()
        {
            // Arrange
            circusTrain.CreateRandomAmountOfAnimals(1000);
            int totalAmountOfAnimalsCreated = 0;

            // Act
            Console.WriteLine(circusTrain.PutEveryAnimalInAWagon());
            Console.WriteLine(circusTrain.ShowWagons());

            foreach (var wagon in circusTrain.Wagons)
            {
                foreach (var animal in wagon.Animals)
                {
                    totalAmountOfAnimalsCreated++;
                }
            }

            // Assert
            Assert.AreEqual(circusTrain.Animals.Count(), totalAmountOfAnimalsCreated);
        }

        [TestMethod]
        public void TestS1()
        {
            // Arrange
            circusTrain.CreateNewAnimal(Size.small, CircusTrainLibrary.Type.Carnivore);
            circusTrain.CreateNewAnimal(Size.large, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.large, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.medium, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.medium, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.medium, CircusTrainLibrary.Type.Herbivore);

            // Act
            Console.WriteLine(circusTrain.AllAnimalsInTrain());
            Console.WriteLine(circusTrain.PutEveryAnimalInAWagon());
            Console.WriteLine(circusTrain.ShowWagons());

            // Assert
            Assert.AreEqual(circusTrain.Wagons.Count(), 2);
        }

        [TestMethod]
        public void TestS2()
        {
            // Arrange
            circusTrain.CreateNewAnimal(Size.small, CircusTrainLibrary.Type.Carnivore);
            circusTrain.CreateNewAnimal(Size.large, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.medium, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.medium, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.small, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.small, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.small, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.small, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.small, CircusTrainLibrary.Type.Herbivore);

            // Act
            Console.WriteLine(circusTrain.AllAnimalsInTrain());
            Console.WriteLine(circusTrain.PutEveryAnimalInAWagon());
            Console.WriteLine(circusTrain.ShowWagons());

            // Assert
            Assert.AreEqual(circusTrain.Wagons.Count(), 2);
        }

        [TestMethod]
        public void TestS3()
        {
            // Arrange
            circusTrain.CreateNewAnimal(Size.large, CircusTrainLibrary.Type.Carnivore);
            circusTrain.CreateNewAnimal(Size.medium, CircusTrainLibrary.Type.Carnivore);
            circusTrain.CreateNewAnimal(Size.small, CircusTrainLibrary.Type.Carnivore);
            circusTrain.CreateNewAnimal(Size.large, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.medium, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.small, CircusTrainLibrary.Type.Herbivore);

            // Act
            Console.WriteLine(circusTrain.AllAnimalsInTrain());
            Console.WriteLine(circusTrain.PutEveryAnimalInAWagon());
            Console.WriteLine(circusTrain.ShowWagons());

            // Assert
            Assert.AreEqual(circusTrain.Wagons.Count(), 4);
        }

        [TestMethod]

        public void TestS4()
        {
            // Arrange
            circusTrain.CreateNewAnimal(Size.large, CircusTrainLibrary.Type.Carnivore);
            circusTrain.CreateNewAnimal(Size.medium, CircusTrainLibrary.Type.Carnivore);
            circusTrain.CreateNewAnimal(Size.small, CircusTrainLibrary.Type.Carnivore);
            circusTrain.CreateNewAnimal(Size.small, CircusTrainLibrary.Type.Carnivore);
            circusTrain.CreateNewAnimal(Size.large, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.medium, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.medium, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.medium, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.medium, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.medium, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.small, CircusTrainLibrary.Type.Herbivore);

            // Act 
            Console.WriteLine(circusTrain.AllAnimalsInTrain());
            Console.WriteLine(circusTrain.PutEveryAnimalInAWagon());
            Console.WriteLine(circusTrain.ShowWagons());

            // Assert
            Assert.AreEqual(circusTrain.Wagons.Count(), 5);
        }

        [TestMethod]
        public void TestS5()
        {
            // Arrange
            circusTrain.CreateNewAnimal(Size.small, CircusTrainLibrary.Type.Carnivore);
            circusTrain.CreateNewAnimal(Size.large, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.large, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.medium, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.small, CircusTrainLibrary.Type.Herbivore);

            // Act
            Console.WriteLine(circusTrain.AllAnimalsInTrain());
            Console.WriteLine(circusTrain.PutEveryAnimalInAWagon());
            Console.WriteLine(circusTrain.ShowWagons());

            // Assert
            Assert.AreEqual(circusTrain.Wagons.Count(), 2);
        }

        [TestMethod]
        public void TestS6()
        {
            // Arrange
            circusTrain.CreateNewAnimal(Size.small, CircusTrainLibrary.Type.Carnivore);
            circusTrain.CreateNewAnimal(Size.small, CircusTrainLibrary.Type.Carnivore);
            circusTrain.CreateNewAnimal(Size.small, CircusTrainLibrary.Type.Carnivore);
            circusTrain.CreateNewAnimal(Size.large, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.large, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.large, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.medium, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.medium, CircusTrainLibrary.Type.Herbivore);

            // Act
            Console.WriteLine(circusTrain.AllAnimalsInTrain());
            Console.WriteLine(circusTrain.PutEveryAnimalInAWagon());
            Console.WriteLine(circusTrain.ShowWagons());

            // Assert
            Assert.AreEqual(circusTrain.Wagons.Count(), 3);
        }

        [TestMethod]
        public void TestS7()
        {
            // Arrange
            circusTrain.CreateNewAnimal(Size.large, CircusTrainLibrary.Type.Carnivore);
            circusTrain.CreateNewAnimal(Size.large, CircusTrainLibrary.Type.Carnivore);
            circusTrain.CreateNewAnimal(Size.large, CircusTrainLibrary.Type.Carnivore);
            circusTrain.CreateNewAnimal(Size.medium, CircusTrainLibrary.Type.Carnivore);
            circusTrain.CreateNewAnimal(Size.medium, CircusTrainLibrary.Type.Carnivore);
            circusTrain.CreateNewAnimal(Size.medium, CircusTrainLibrary.Type.Carnivore);
            circusTrain.CreateNewAnimal(Size.small, CircusTrainLibrary.Type.Carnivore);
            circusTrain.CreateNewAnimal(Size.small, CircusTrainLibrary.Type.Carnivore);
            circusTrain.CreateNewAnimal(Size.small, CircusTrainLibrary.Type.Carnivore);
            circusTrain.CreateNewAnimal(Size.small, CircusTrainLibrary.Type.Carnivore);
            circusTrain.CreateNewAnimal(Size.small, CircusTrainLibrary.Type.Carnivore);
            circusTrain.CreateNewAnimal(Size.small, CircusTrainLibrary.Type.Carnivore);
            circusTrain.CreateNewAnimal(Size.small, CircusTrainLibrary.Type.Carnivore);
            circusTrain.CreateNewAnimal(Size.large, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.large, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.large, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.large, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.large, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.large, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.medium, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.medium, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.medium, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.medium, CircusTrainLibrary.Type.Herbivore);
            circusTrain.CreateNewAnimal(Size.medium, CircusTrainLibrary.Type.Herbivore);

            // Act
            Console.WriteLine(circusTrain.AllAnimalsInTrain());
            Console.WriteLine(circusTrain.PutEveryAnimalInAWagon());
            Console.WriteLine(circusTrain.ShowWagons());

            // Assert
            Assert.AreEqual(circusTrain.Wagons.Count(), 13);
        }

        [TestMethod]
        public void TestS8()
        {
            // Arrange

            // Act
            Console.WriteLine(circusTrain.AllAnimalsInTrain());
            Console.WriteLine(circusTrain.PutEveryAnimalInAWagon());
            Console.WriteLine(circusTrain.ShowWagons());

            // Assert
            Assert.AreEqual(circusTrain.Wagons.Count(), 0);
        }
    }
}
