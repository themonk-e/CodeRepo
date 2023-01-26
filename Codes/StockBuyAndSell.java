import java.util.*;
public class StockBuyAndSell {
  public static  void main(String []args ){
      Scanner  sn=new Scanner(System.in);
      int n=sn.nextInt();
      int [] arr=new int[n];
      for(int i=0;i<n;i++){
          arr[i]=sn.nextInt();
      }
      Solution sln=new Solution();
      sln.stockBuySell(arr,n);
  }

}


// User function Template for Java

class Solution {
    public void stockBuySell(int[] price, int n) {
        int profit;
        int prevProfit=Integer.MIN_VALUE;
        int start=0;
        int end;

        for(int i=1;i<n;i++){
            profit=price[i]-price[start];
            if(profit<prevProfit || profit<0){
                end=i-1;
                if(start!=end){
                    System.out.print("("+start+" "+end+") ");
                }
                start=i;
                profit=0;
                prevProfit=Integer.MIN_VALUE;
            }
            else {
                if(i==n-1 && profit>prevProfit){
                    System.out.println("("+start+" "+i+")");
                }

            }
            prevProfit=profit;

        }
        System.out.println();

    }
}