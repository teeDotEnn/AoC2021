// See https://aka.ms/new-console-template for more information
const string INPUT_FILE = "input.txt";
string[] input = File.ReadAllLines(INPUT_FILE);
//RateHandler handler = new RateHandler(input);
//handler.EpisilonRateHandler(input);
//handler.GammaRateHandler(input);

//Console.WriteLine(handler.EpsilonXGamma());

LifeSupportAnalysis analysis = new LifeSupportAnalysis(input);

Console.WriteLine(analysis.LifeSupportRating);