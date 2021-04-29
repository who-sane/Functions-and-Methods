using System;

namespace Functions_and_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1 Write a program in C# Sharp to create a user define function:
           // Console.WriteLine("Welcome Friends");
           // Console.WriteLine("Have a nice day!");

            // Task 2: Create a user define function with parameters.
           // Console.WriteLine("______________________________________________________");

            //Console.WriteLine("Please input your name: ");
           // string yourName = Console.ReadLine();

           // Console.WriteLine("Welcome friend " + yourName);
          //  Console.WriteLine("Have a nice day!");
            
            // Task 3: Create a function for the sum of two numbers.
        //    Console.WriteLine("______________________________________________________");

        //    Console.WriteLine("Enter a number of your choice: ");
        //    int num1 = int.Parse(Console.ReadLine());
            // Asks user for a second input
        //    Console.WriteLine("Enter another number of your choice: ");
        //    int num2 = int.Parse(Console.ReadLine());

         //   int sum = num1 + num2;

         //   Console.WriteLine("The sum of the two numbers is: " + sum);

             // Task 4:  Create a function to input a string and count number of spaces are in the string.

            
          //  string str = "This is a test string";
          //  char ch = 's';
 
          //  int freq = 0;
          //  foreach (char c in str)
       // {
         //   if (c == ch) {
        //        freq++;
        //    }
       // }
 
        //  Console.WriteLine(freq);

// //Exercise 5
            // int[] numbers = new int[5] {5, 7, 3, 2, 9};

            // int suma = 0;

            // Array.ForEach(numbers, i => suma += i);
            // Console.WriteLine(suma);

            //Exercise 6
            // int numb1, numb2;
            // numb1 = 5;
            // numb2 = 6;

            // Console.WriteLine("Values before swapping");
            // Console.WriteLine(numb1.ToString());
            // Console.WriteLine(numb2.ToString());

            // numb1 = numb1 + numb2;
            // numb2 = numb1 - numb2;
            // numb1 = numb1 - numb2;

            // Console.WriteLine("Values after swapping");
            // Console.WriteLine(numb1.ToString());
            // Console.WriteLine(numb2.ToString());

            //Exercise 7
            // {
            // int num1;
            // int exponent1;

            // Console.Write("Function: To calculate the result of raising an integer number to another!");
            // Console.WriteLine("---------------")
            // Console.Write("Input Base number:");
            // num1= Convert.ToInt32(Console.ReadLine());
            // Console.Write("Input the Exponent:");
            // exponent1= Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("So, the number {0} ^ (to the power) {1} = {2} ",num1, exponent1, PowerRaising(num1, exponent1));
            // }

            // static int PowerRaising(int num, int exp)
            // {
            //     int rvalue = 1; 
            //     int i;
            //     for (i=1; i <= exp; i++)
            //     rvalue = rvalue*num;
            //     return rvalue;
            // }

        // Task 8: Create a function to display the n number Fibonacci sequence. 
        
      //  Console.Write("Please enter the Length of the Fibonacci Series : ");
      //  int number = int.Parse(Console.ReadLine());
     //       FibonacciSeries(0, 1, 1, number);
     //       Console.ReadKey();
     //   }
     //   public static void FibonacciSeries(int firstNumber, int secondNumber, int counter, int number)
    //    {
    //        Console.Write(firstNumber + " ");
     //       if (counter < number)
     //       {
      //          FibonacciSeries(secondNumber, firstNumber + secondNumber, counter + 1, number);
           


        

        // Task 9: Create a function to check whether a number is prime or not. 
      //  Console.WriteLine("Pick a number: ");
      //  int n = int.Parse(Console.ReadLine()), a = 0; 
        
      //   for (int i = 1; i <= n; i++) {
       //     if (n % i == 0) {
       //        a++;
      //      }
      //   }
      //   if (a == 2) {
     //       Console.WriteLine("{0} is a Prime Number", n);
     //    } else {
     //       Console.WriteLine("Not a Prime Number");
     //    }
     //    Console.ReadLine();

        // Task 10: Create a function to calculate the sum of the individual digits of a given number.
    //    int SumCal( int n ){

    //    string n1 = Convert.ToString(n);
     //   int sum = 0;  
     //   for (int i = 0; i < n1.Length; i++)
    //    sum += Convert.ToInt32(n1.Substring(i,1));
    //    return sum;
     //   }
      //  int num;
	    

     //   Console.Write("Enter a number: ");
     //   num = Convert.ToInt32( Console.ReadLine() );
     //   Console.WriteLine("The sum of the digits of the number {0} is : {1} \n",num,SumCal(num));   
        

        }

        }
    }
}
