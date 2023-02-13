using CircusTrainLibrary;
using System.Diagnostics;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello World!");

CircusTrain circusTrain = new CircusTrain();

string input = Console.ReadLine();
int.TryParse(input, out int AmountOfAnimals);
Stopwatch stopwatchAnimalCreation = new Stopwatch();
stopwatchAnimalCreation.Start();
circusTrain.CreateRandomAmountOfAnimals(AmountOfAnimals);
stopwatchAnimalCreation.Stop();

Stopwatch stopwatchAnimalSorting = new Stopwatch();
stopwatchAnimalSorting.Start();
Console.WriteLine(circusTrain.PutEveryAnimalInAWagon());
stopwatchAnimalSorting.Stop();

int i = 1;
foreach (var wagon in circusTrain.Wagons)
{
    Console.WriteLine($"Wagon {i}");
    foreach (var animal in wagon.Animals)
    {
        Console.WriteLine($"{animal.Size} {animal.Type}");
    }
    i++;
    Console.WriteLine();
}

Console.WriteLine($"Elapsed time creating animals: {stopwatchAnimalCreation.ElapsedMilliseconds}");
Console.WriteLine($"Elapsed time sorting animals: {stopwatchAnimalSorting.ElapsedMilliseconds}");

Console.Read();
