public class LifeSupportAnalysis{
  int oxygenRating;
  int scrubberRating;
  int numberLength;
  string[] inputArr;

  public int LifeSupportRating => oxygenRating * scrubberRating;
  public LifeSupportAnalysis(string[] inputArr)
  {
      numberLength = inputArr[0].Length;
      this.inputArr = inputArr;
      oxygenRating = CalculateOxygenRating();
      scrubberRating = CalculateScrubberRating();
  }

  private int CalculateOxygenRating(){
    // loop through indicies of numbers
    List<string> workingList = inputArr.ToList();
    List<string> dupeList = inputArr.ToList();
    for (int i = 0; i < numberLength; i++)
    {
        char mcd = Utils.MostCommonDigitAtIndex(workingList.ToArray(), i);
        for(int j = 0; j<workingList.Count(); j++){
          if(!workingList[j][i].Equals(mcd)){
            dupeList.Remove(workingList[j]);
          }
        }
        workingList = dupeList.ToList();
        if(workingList.Count() == 1){
          break;
        }

    }

    if(workingList.Count() > 1){
      return -1;
    }

    return Utils.binaryToDec(workingList[0].ToCharArray());

  }

    private int CalculateScrubberRating(){
    // loop through indicies of numbers
    List<string> workingList = inputArr.ToList();
    List<string> dupeList = inputArr.ToList();
    for (int i = 0; i < numberLength; i++)
    {
        char lcd = Utils.LeastCommonDigitAtIndex(workingList.ToArray(), i);
        for(int j = 0; j<workingList.Count(); j++){
          if(!workingList[j][i].Equals(lcd)){
            dupeList.Remove(workingList[j]);
          }
        }
        workingList = dupeList.ToList();
        if(workingList.Count() == 1){
          break;
        }
    }

    if(workingList.Count() > 1){
      return -1;
    }

    return Utils.binaryToDec(workingList[0].ToCharArray());

  }
}