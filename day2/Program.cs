// See https://aka.ms/new-console-template for more information
const string INPUT_SOURCE = "testCase.txt";

Position pos = new Position();


string[] input = File.ReadAllLines(INPUT_SOURCE);

var vectors = Utils.ParseTextInput(input);
foreach (var vector in vectors){
    pos.ChangePosition(vector);
}

Console.WriteLine($"Final position product: {pos.FinalPos}");