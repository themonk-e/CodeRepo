import java.util.*;
import java.io.*;
import java.lang.*;

public class FindfirstKoccur {
    public static void main (String[] args) throws IOException  {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        int t = Integer.parseInt(br.readLine().trim());
        while(t-->0){
            String inputLine[] = br.readLine().trim().split(" ");
            int n = Integer.parseInt(inputLine[0]);
            int m = Integer.parseInt(inputLine[1]);
            int[] arr = new int[n];
            inputLine = br.readLine().trim().split(" ");
            for(int i=0; i<n; i++)arr[i] = Integer.parseInt(inputLine[i]);

            Solution1 obj = new Solution1();
            System.out.println(obj.firstElementKTime(arr, n, m));
        }
    }
}


class Solution1
{
    public int firstElementKTime(int[] a, int n, int k) {
        int count;
        int num=-1;

        HashMap <Integer,Integer> occur= new HashMap<>();
        for(int i:a){
            if(occur.containsKey(i)){
                occur.put(i,occur.get(i)+1);
                if(k>1){
                    count=occur.get(i);
                    if(count==k){
                        num=i;
                        break;
                    }
                }
            }
            else{

                occur.put(i,1);
                if(k==1){
                    num=i;
                    break;
                }
            }
        }

        return num;
    }
}
