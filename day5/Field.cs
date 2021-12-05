public class Field{
  Vent[,] Vents;

  public Field(int maxX, int maxY)
  {
      Vents = new Vent[maxY,maxX];
  }

  public void AddLine(Line line){
    
    if(line.xStart == line.xEnd){
      for(int y = line.yStart; y <= line.yEnd; y++){
        Vents[y,line.xStart].Count++;
      }
    }

    if(line.yStart == line.yEnd){
      for(int x = line.xStart; x <= line.xEnd; x++){
        Vents[line.yStart,x].Count++;
      }
    }
  }
}

public class Vent{
  public int Count = 0;
}