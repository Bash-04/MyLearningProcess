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
            //scenario = new Scenario();
        }

        [TestMethod]
        public void AnimalsCanBeCreated()
        {
            // Arrange


            // Act
            circusTrain.CreateRandomAmountOfAnimals(100);

            // Assert

        }

        [TestMethod]
        public void AnimalsCanBeSortedOverTheWagons()
        {
            // Arrange
            circusTrain.CreateRandomAmountOfAnimals(100);

            // Act
            Console.WriteLine(circusTrain.PutEveryAnimalInAWagon());
            Console.WriteLine(circusTrain.ShowWagons());

            // Assert

        }
    }
}
