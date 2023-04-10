// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

// leap year
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
//----------------------------------------

// Perfect number 1+2+3=6 6 is a perfect num (1,2,3 divisors)

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int sum=0;
        for(int i=1;i<=n/2;i++){
            if(n%i==0){
                sum=sum+(i);
            }
        }
        Console.WriteLine(sum);
        if(sum==n){
            Console.WriteLine("Perfect number");
        }
        else{
            Console.WriteLine("Not");
        }
    }
}

------------------------------------------
    
    
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(GCD(a, b));



    }

    public static int GCD(int a, int b)
    {
        if (b != 0)
        {
            return GCD(b, a % b);
        }
        else
        {
            return a;
        }
    }
}
--------------------------------------------
    
 // Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int digit = input.Length;
        List<string> output = new List<string>();
        int flag = 0;
        Console.WriteLine(digit);
        
        for(int i=0;i<digit; i++)
        { int newVal=i;
            if(digit==3)
            {
                newVal = i + 1;
            }
            else if(digit==2) {
                newVal = i + 2;
            }
            else if (digit == 1)
            {
                newVal = i + 3;
            }

            Console.WriteLine("Switch"+i);
            switch (newVal)
            { 
                case 3:
                    if(flag == 0)
                    {
                      output.Add(numNameZ(int.Parse(input[i].ToString())));
                    }
                   
                    break;
                case 2:
                    Console.WriteLine(input[i]);
                    if (input[i] == '1')
                    {
                        output.Add(numNameT(int.Parse(input[i+1].ToString())));
                        flag = 1;
                        
                    }
                    else
                    {
                        output.Add(numNameTT(int.Parse(input[i].ToString())));
                    }
                    break;
                case 1:
                    output.Add(numNameH(int.Parse(input[i].ToString())));
                    break;
                case 0:
                    output.Add(numNameTH(int.Parse(input[i].ToString())));
                    break;

            }

        }

        foreach(var e in output)
        {
            Console.Write(e + " ");
        }



    }

    public static string numNameZ(int i)
    {
        switch(i)
        {
            case 0:
                return " ";
            case 1:
                return "one";
            case 2:
                return "two";
            case 3:
                return "three";
             case 4:
                return "four";
             case 5:
                return "five";
             case 6:
                return "six";
            case 7:
                return "seven";
            case 8:
                return "eight";
            case 9:
                return "nine";
            default:
                return " ";
             
;        }
    }



   public static string numNameT(int i)
    {
        switch (i)
        {
            case 0:
                return "ten";
            case 1:
                return "eleven";
            case 2:
                return "twelve";
            case 3:
                return "thirteen";
            case 4:
                return "fourteen";
            case 5:
                return "fifteen";
            case 6:
                return "sixteen";
            case 7:
                return "seventeen";
            case 8:
                return "eighteen";
            case 9:
                return "nineteen";
            default:
                return " ";

                
        }
    }

   public static string numNameTT(int i)
    {
        switch (i)
        {
      
            case 2:
                return "twenty";
            case 3:
                return "thirty";
            case 4:
                return "forty";
            case 5:
                return "fifty";
            case 6:
                return "sixty";
            case 7:
                return "seventy";
            case 8:
                return "eighty";
            case 9:
                return "ninenty";
            default:
                return " ";


        }
    }

   public static string numNameH(int i)
    {
        switch (i)
        {
            
            case 1:
                return "one hundred";
            case 2:
                return "two hundred";
            case 3:
                return "three hundred";
            case 4:
                return "four hundred";
            case 5:
                return "five hundred";
            case 6:
                return "six hundred";
            case 7:
                return "seven hundred";
            case 8:
                return "eight hundred";
            case 9:
                return "nine hundred";
            default:
                return " ";
        }
    }


    public static string numNameTH(int i)
    {
        switch (i)
        {

            case 1:
                return "one thousand";
            case 2:
                return "two thousand";
            case 3:
                return "three thousand";
            case 4:
                return "four thousand";
            case 5:
                return "five thousand";
            case 6:
                return "six thousand";
            case 7:
                return "seven thousand";
            case 8:
                return "eight thousand";
            case 9:
                return "nine thousand";
            default:
                return " ";
        }
    }







}
