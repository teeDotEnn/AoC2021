class Position{
  
  private int depth;
  private int horizontalPos;

  private int aim;

  public int FinalPos => depth*horizontalPos;

  public void ChangePosition(Vector vector){
    if(vector.Direction.Equals("forward")){
      horizontalPos += vector.Magnitude;
      depth += aim * vector.Magnitude;
    }
    if(vector.Direction.Equals("down")){
      aim += vector.Magnitude;
    }
    if(vector.Direction.Equals("up")){
      aim -= vector.Magnitude;
    }
  }

}




