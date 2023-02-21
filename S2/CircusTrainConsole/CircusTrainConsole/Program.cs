using CircusTrainLibrary;
using System.Diagnostics;

//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello World!");

CircusTrain circusTrain = new CircusTrain();
//Scenario scenario = new Scenario();

Console.WriteLine("Please fill in the amount of animals to be sorted: ");

string input = Console.ReadLine();
int.TryParse(input, out int AmountOfAnimals);

Stopwatch stopwatchAnimalCreation = new Stopwatch();
stopwatchAnimalCreation.Start();
//circusTrain.ScenarioOne();
circusTrain.CreateRandomAmountOfAnimals(AmountOfAnimals);
stopwatchAnimalCreation.Stop();

Console.WriteLine(circusTrain.AllAnimalsInTrain());

Stopwatch stopwatchAnimalSorting = new Stopwatch();
stopwatchAnimalSorting.Start();
Console.WriteLine(circusTrain.PutEveryAnimalInAWagon());
stopwatchAnimalSorting.Stop();

Console.WriteLine(circusTrain.ShowWagons());

Console.WriteLine($"Elapsed time creating animals: {stopwatchAnimalCreation.ElapsedMilliseconds}");
Console.WriteLine($"Elapsed time sorting animals: {stopwatchAnimalSorting.ElapsedMilliseconds}");

Console.Read();
