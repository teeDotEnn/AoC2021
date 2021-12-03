using System.Collections.Generic;

class DepthMeasurement{
    private int[] measurments;
    private List<int> windows = new List<int>();
    
    
    public DepthMeasurement(int[] measurments)
    {
        this.measurments = measurments;
    }

    public int GetIncreased()
    {
        int increasedCount = 0;
        int prev = measurments[0];
        
        foreach(var measurment in measurments){
            if(measurment > prev){
                increasedCount++;
            }
            prev = measurment;
        }
        return increasedCount;
    }

    public int GetIncreased(int windowSize){
        makeWindows(windowSize);
        int increasedCount = 0;
        int prev = windows[0];
        foreach(var window in windows){
            if(window> prev){
                increasedCount ++;
            }
            prev = window;
        }
        return increasedCount;
    }

    private void makeWindows(int windowSize){
        for(int i = 0; i <= measurments.Length - windowSize; i++){
            int windowSum = 0;
            int tempWindowSize = windowSize -1;
            while(tempWindowSize > -1){
                windowSum += measurments[i+tempWindowSize];
                tempWindowSize--;
            }
            windows.Add(windowSum);
        }
    }

}