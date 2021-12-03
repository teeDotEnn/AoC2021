static class Utils{
  static public List<Vector> ParseTextInput(string[] lines){
    List<Vector> output = new List<Vector>();
    
    foreach(var line in lines){
      string[] temp = line.Split(' ');
      output.Add(new Vector(temp[0], int.Parse(temp[1])));
    }

    return output;
  }

}