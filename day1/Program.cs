
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string[] input = File.ReadAllLines("input.txt");
int[] testCase = {199,
200,
208,
210,
200,
207,
240,
269,
260,
263};

DepthMeasurement depth = new DepthMeasurement(input.Select(x => int.Parse(x)).ToArray());

//DepthMeasurement depth = new DepthMeasurement(testCase);

Console.WriteLine($"Measures that are increasing: {depth.GetIncreased()}");

Console.WriteLine($"Measures that are increasing with shifting window: {depth.GetIncreased(3)}");
