class RateHandler{
  
  public char[] GammaRate;
  public char[] EpsilonRate ;
  private int lineLength;

  public RateHandler(string[] inputArr)
  {
      lineLength = inputArr[0].Length;
      GammaRate = new char[lineLength];
      EpsilonRate = new char[lineLength];
  }
  public void GammaRateHandler(string[] inputArr){
      // for 5 positions
      for(int i = 0; i < lineLength; i++){
        GammaRate[i] = Utils.MostCommonDigitAtIndex(inputArr, i);
      }
  }

  public void EpisilonRateHandler(string[] inputArr){
    // for 5 positions
    for(int i = 0; i < lineLength; i++){
      
      EpsilonRate[i] = Utils.LeastCommonDigitAtIndex(inputArr, i);
        
    }
  }

  public int EpsilonXGamma() => Utils.binaryToDec(EpsilonRate) * Utils.binaryToDec(GammaRate);

}