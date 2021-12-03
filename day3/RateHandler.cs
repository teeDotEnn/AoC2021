class RateHandler{
  
  char[] GammaRate = new char[5];
  char[] EpsilonRate = new char[5];
  public void GammaRateHandler(string[] inputArr){
      // for 5 positions
      for(int i = 0; i < 5; i++){
        int zeroCount = 0;
        int oneCount = 1;
        
        foreach(var item in inputArr){
          if(item[i].Equals('0')){
            zeroCount++;
          }
          oneCount++;
          
          if(zeroCount>oneCount){
            GammaRate[i] = '0';
          }
          else{
            GammaRate[i] = '1';
          }
        }
      }
  }

  public void EpisilonRateHandler(string[] inputArr){
    // for 5 positions
      for(int i = 0; i < 5; i++){
        int zeroCount = 0;
        int oneCount = 1;
        
        foreach(var item in inputArr){
          if(item[i].Equals('0')){
            zeroCount++;
          }
          oneCount++;
          
          if(zeroCount<oneCount){
            GammaRate[i] = '0';
          }
          else{
            GammaRate[i] = '1';
          }
        }
      }
  }
}