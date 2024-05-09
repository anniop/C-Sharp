using System;


class Calculator
{
    static void Main(string[] Google)
    {
        int num1;
        int num2;
        int Result;
        string Answer; 

        Console.WriteLine("Welcome !!!");
        Console.WriteLine("This is a simple Calculator");

        Console.WriteLine("Enter Number 1 : ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Number 2 :");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What Operation Do you want on it");
        Console.WriteLine("Please enter a for addition, b for Substraction , c for multiplication, d for division");
        
        Answer = Console.ReadLine();

        if(Answer == "a")
        {
            Result = num1 + num2;
        }
        else if(Answer == "b")
        {
            Result = num1 - num2;
        }
        else if(Answer == "c")
        {
            Result = num1 * num2;
        }
        else if(Answer == "d")
        {
            Result = num1/num2;
        }
        //else
        //{
        //    Console.WriteLine("Invalid Choice");
        //}
        
        
        Console.WriteLine("The Answer is : "+Result);



    }
}