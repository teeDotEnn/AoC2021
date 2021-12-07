public class Lanternfish{
  private int daysToSpawn;

  public Lanternfish(int daysToSpawn)
  {
      this.daysToSpawn = daysToSpawn;
  }

  public Lanternfish? Tick(){
    if(daysToSpawn == 0){
      daysToSpawn = 6;
      return new Lanternfish(8);
    }else{
      daysToSpawn--;
      return null;
    }

  }
}