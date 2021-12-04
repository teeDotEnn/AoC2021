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
}