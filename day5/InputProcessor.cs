class InputProcessor{
  
  string[] rawCommands;
  public InputProcessor(string filePath)
  {
      rawCommands = File.ReadAllLines(filePath);
  }

  public Line GetLine(string rawCommand){
    Line Output = new Line();
    return Output;
  }

}