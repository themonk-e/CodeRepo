// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int year=Convert.ToInt32(Console.ReadLine());
        
        if(year%400==0){
             Console.WriteLine("a leap year");
        }
        
        else if(year%4==0){
            if(year%100!=0){
                    Console.WriteLine("a leap year");
            }
             else{
            Console.WriteLine("Not a leap year");
        }
        
        }
        else{
            Console.WriteLine("Not a leap year");
        }
    }
}
