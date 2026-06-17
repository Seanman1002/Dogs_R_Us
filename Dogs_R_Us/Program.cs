using Dogs;

Random random = new();
string[] randomNames = ["Pippin", "Jelly", "Molly", "Nemo", "Teddy", "Sunny"];
string[] randomBreeds = ["Chihuahua", "Pug", "Labrador", "Boxer"];
int[] randomAge = [1, 18];
double[] randomWeight = [5, 110];




random.Next(randomNames.Length);
random.Next(randomBreeds.Length);
random.Next(randomWeight.Length);
random.Next(randomAge.Length);

double minWeight = randomWeight[0];
double maxWeight = randomWeight[1];
double dynamicWeight = minWeight + (random.NextDouble() * (maxWeight - minWeight));

Dogs.Dog randomPatient = new Dogs.Dog()
{
    Breed = randomBreeds[random.Next(randomBreeds.Length)],
    Name = randomNames[random.Next(randomNames.Length)],
    Weight = Math.Round(dynamicWeight, 1), // Rounds the decimal to 1 place (e.g., 42.5)
    Age = random.Next(randomAge[0], randomAge[1] + 1) // +1 makes 18 inclusive
};

// --- PRINT RANDOM PATIENT ---
Console.WriteLine($"Admitted: {randomPatient.Name}");
Console.WriteLine($"Weight is: {randomPatient.Weight} Pounds");
Console.WriteLine($"Age of Patient is: {randomPatient.Age}");
Console.WriteLine($"The Breed of the Patient is a: {randomPatient.Breed}");
randomPatient.Bark();









