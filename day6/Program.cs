// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
const string TEST = "test.txt";
const int ITERATIONS = 80;
List<Lanternfish> fishes = new List<Lanternfish>();
string[] lines = File.ReadAllLines(TEST);
string[] sFishInit = lines[0].Split(',');
int[] nFishInit = new int[sFishInit.Length];

for (int i = 0; i < sFishInit.Length; i++)
{
  nFishInit[i] = int.Parse(sFishInit[i]);
} 

foreach(int value in nFishInit){
  fishes.Add(new Lanternfish(value));
}

for(int i = 0; i <ITERATIONS; i++){
  int currentLength = fishes.Count();
  for(int j = 0; j < currentLength; j++){
    var newFish = fishes[currentLength].Tick();
    if(newFish != null){
      fishes.Add(newFish);
    }
  }
}

Console.WriteLine($"Final fish count: {fishes.Count()}");