class Position{
  
  private int depth;
  private int horizontalPos;

  public int FinalPos => depth*horizontalPos;

  public void ChangePosition((string direction, int magnitude) vector){
    if(vector.direction.Equals("forward")){
      horizontalPos += vector.magnitude;
    }
    if(vector.direction.Equals("down")){
      depth += vector.magnitude;
    }
    if(vector.direction.Equals("up")){
      depth -= vector.magnitude;
    }
  }

}



