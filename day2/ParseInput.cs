static class ParseInput{
  static public List<Tuple<string, int>> ParseTextInput(string[] lines){
    List<Tuple<string,int>> output = new List<Tuple<string,int>>();
    foreach(var line in lines){
      string[] temp = line.Split(' ');
      output.Add(new Tuple<string, int>(temp[0], int.Parse(temp[1])));
    }
    return output;
  }
}