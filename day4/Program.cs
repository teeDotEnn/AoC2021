// See https://aka.ms/new-console-template for more information

List<Board> boards = new List<Board>();
string [] numbers;

// Load in all boards
using (StreamReader stream = new StreamReader("boards.txt")){
  string line;
  int[,] tempboard = new int [5,5];
  int row = 0;

  while((line = stream.ReadLine()) != null){

    if(String.IsNullOrEmpty(line)){
      boards.Add(new Board(tempboard));
      tempboard = new int[5,5];
      row = 0;
    }
    else{
       List<string> sLine = line.Split(' ').ToList();

       if(sLine.Contains("")){
         sLine.RemoveAll(x => x.Equals(""));
       }

       for(int i = 0; i < sLine.Count(); i++){
         if(!String.IsNullOrWhiteSpace(sLine[i])){
         tempboard[row,i] = int.Parse(sLine[i]);
         }
       }

       row++;
    }
  }
}

string[] numbersArr = File.ReadAllLines("numbers.txt");
if(numbersArr.Length > 1){
  Console.WriteLine("Bad Input");
}

numbers = numbersArr[0].Split(',');

Console.WriteLine();
