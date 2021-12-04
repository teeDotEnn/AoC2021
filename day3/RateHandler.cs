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
        int zeroCount = 0;
        int oneCount = 0;
        
        foreach(var item in inputArr){
          if(item[i].Equals('0')){
            zeroCount++;
          }else{
            oneCount++;
          }
        }

        if(zeroCount>oneCount){
          GammaRate[i] = '0';
        }
        else{
          GammaRate[i] = '1';
        }
      }
  }

  public void EpisilonRateHandler(string[] inputArr){
    // for 5 positions
    for(int i = 0; i < lineLength; i++){
      int zeroCount = 0;
      int oneCount = 0;
      
      foreach(var item in inputArr){
        if(item[i].Equals('0')){
            zeroCount++;
          }else{
            oneCount++;
          }
      }

      if(zeroCount<oneCount){
          EpsilonRate[i] = '0';
        }
        else{
          EpsilonRate[i] = '1';
        }
    }
  }

  public int EpsilonXGamma() => binaryToDec(EpsilonRate) * binaryToDec(GammaRate);

  public int binaryToDec(char[] input){
    int output = 0;
    char[] reversedInput = input.Reverse().ToArray();
    for(int place = 0; place < input.Length; place++){
        int multiplier = placeMultiplier(place);
        output += (int)(char.GetNumericValue(reversedInput[place])* multiplier);
    }
    return output;
  }

  private int placeMultiplier(int place){
    switch (place)
      {
          case 0:
            return 1;
          case 1:
            return 2;
          case 2:
            return 4;
          case 3:
            return 8;
          case 4:
            return 16;
          case 5:
            return 32;
          case 6:
            return 64;
          case 7:
            return 128;
          case 8:
            return 256;
          case 9:
            return 512;
          case 10:
            return 1024;
          case 11:
            return 2048;
          case 12:
            return 4096;
          default:
            return -1;
      }
  }

}