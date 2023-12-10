public class Solution {
    public int DistanceTraveled(int mainTank, int additionalTank) {
        var total = 0;
        while(mainTank != 0){
           if(mainTank >= 5){ 
               total += 5;
               mainTank -=5;
               if(additionalTank > 0) {
                   mainTank += 1;
                   additionalTank -= 1;
               }
           }
           else {
               total += mainTank;
               mainTank -= mainTank;
           }
        }
        return total * 10;
    }
}
