public class Board{
  private Node[,] boardState;

  public Board(int[,] input)
  {
    boardState = new Node[5,5];

    for(int i = 0; i< 5; i++){
      for(int j = 0; j<5; j++){
        boardState[i,j] = new Node{ Value=input[i,j]};
      }
    }
  }

  // Check to see if Node on the board matches
  public void CheckNode(int number){
    for (int row = 0; row < 5; row++)
    {
        for (int cols = 0; cols < 5; cols++)
        {
            if(boardState[row, cols].Value == number){
              boardState[row, cols].Marked = true;
            }
        }
    }
  }

  //check to see if there is a win
  public bool CheckWin(){
    
    for(int row = 0; row< 5; row++){
      int markedCounter = 0;
      for(int cols = 0; cols< 5; cols++){
        if(boardState[row, col].Marked){
          markedCounter++;
        }
        if(markedCounter == 5){
          return true;
        }
      }
    }

    for(int col = 0; col< 5; col++){
      int markedCounter = 0;
      for(int row = 0; row< 5; row++){
        if(boardState[row, col].Marked){
          markedCounter++;
        }
        if(markedCounter == 5){
          return true;
        }
      }
    }
  }

  public int CalculateWin(int number){
    int output = 0;
    for(int row = 0; row< 5; row++){
      for(int cols = 0; cols< 5; cols++){
        if(!boardState[row, col].Marked){
          output += boardState[row, col].Value;
        }
      }
    }

    return output * number;
  }
}