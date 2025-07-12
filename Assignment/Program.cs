namespace Assignment
{
    internal class Program
    {
        #region Q01 Functions
        static void Increment(int number)
        {
            number += 5;
            Console.WriteLine("Inside Function: " + number);
        }

        static void IncrementRef(ref int number)
        {
            number += 5;
            Console.WriteLine("Inside Function: " + number);
        }
        #endregion

        #region Q02 Functions
        static void PowerByTwo(int[] numbers)
        {
            numbers[0] = 240;
            numbers = new int[] { 4, 4, 4, 4, 4 };
        }
        static void PowerByTwoRef(ref int[] numbers)
        {
            numbers[0] = 240;
            numbers = new int[] { 4, 4, 4, 4, 4 };
        }
        #endregion

        #region Q03 Functions
        static void SumAndSub(int Num1, int Num2, out int Sum, out int Sub)
        {
            Sum = Num1 + Num2;
            Sub = Num1 - Num2;
        }
        #endregion

        #region Q04 Functions
        static int SumOfDigits(int Number)
        {
            int Sum = 0;
            while (Number > 0)
            {
                Sum += Number % 10;
                Number /= 10;
            }
            return Sum;
        }
        #endregion

        #region Q05 Functions
        static bool IsPrime(int num)
        {
            if (num == 2)
                return true;
            else if (num % 2 == 0 || num < 2)
                return false;
            else
            {
                for (int i = 3; i < num / 2; i++)
                {
                    if (num % i == 0)
                        return false;
                }
                return true;
            }
        }
        #endregion

        #region Q06 Functions
        static void MinMaxArray(int[] Numbers, out int Min, out int Max)
        {
            Min = Numbers.Min();
            Max = Numbers.Max();
        }
        #endregion

        #region Q07 Functions
        static int Factorial(int Number)
        {
            int Result = 1;
            while (Number > 0)
            {
                Result *= Number--;
            }
            return Result;
        }
        #endregion
        static void Main(string[] args)
        {
            #region Q01
            /* 
            Q01. Explain the difference between passing(Value type parameters) by value and by reference 
            then write a suitable c# example.
            */

            /*  
                Passing by value will pass a copy of the variable to the function so that any modification
            wouldn't affect the main variable.
            Meanwhile, passing by reference will pass the address of the variable to the function 
            so that any modification will affect the main variable.
             */



            //Example for passing by value
            //int value = 10;
            //Console.WriteLine("Before passing: " + value);
            //Increment(value);
            //Console.WriteLine("After passing: " + value);

            //Example for passing by reference
            //int value = 10;
            //Console.WriteLine("Before passing: " + value);
            //IncrementRef(ref value);
            //Console.WriteLine("After passing: " + value);
            #endregion

            #region Q02
            /*
            Q02. Explain the difference between passing (Reference type parameters) by value 
            and by reference then write a suitable c# example.
             */

            /*
             Passing by value will pass a copy of the reference(address) to the Function,
            so any modification to the object will affect the original object, but if we reassign the
            reference to a new object, it won't affect the original object.

            Meanwhile, passing by reference will pass the reference(address) to the function,
            so any modification to the object or reassigning the reference to a new object will affect
            the original object.
             */



            //Example
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Before passing by value: ");
            //foreach (var number in numbers)
            //    Console.Write(number + " ");

            //PowerByTwo(numbers);

            //Console.WriteLine("\nAfter passing by value: ");
            //foreach (var number in numbers)
            //    Console.Write(number + " ");
            //Console.WriteLine("The first element changed but the reference still the same");


            ////Passing by reference
            //Console.WriteLine("Before passing by reference:");
            //foreach (var number in numbers)
            //    Console.Write(number + " ");

            //PowerByTwoRef(ref numbers);

            //Console.WriteLine("\nAfter passing by reference:");
            //foreach (var number in numbers)
            //    Console.Write(number + " ");
            //Console.WriteLine("The first element changed and also the reference");
            #endregion

            #region Q03
            /*
             Q03. Write a c# Function that accept 4 parameters from user and return result of summation 
             and subtracting of two numbers
             */

            //int Num1, Num2, Sum, Sub;
            //Console.Write("Enter first number: ");
            //Num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //Num2 = int.Parse(Console.ReadLine());

            //SumAndSub(Num1, Num2, out Sum, out Sub);
            //Console.WriteLine($"\nSumation: {Sum}, Subtraction: {Sub}");
            #endregion

            #region Q04
            /*
                Q04. Write a program in C# Sharp to create a function to calculate the sum of 
            the individual digits of a given number.
            */
            //int num;
            //do
            //{
            //    Console.Write("Enter a number : ");
            //} while (!int.TryParse(Console.ReadLine(), out num));
            //int Result = SumOfDigits(num);
            //Console.WriteLine($"The sum of the digits of the number 25 is: {Result}");
            #endregion

            #region Q05
            /*
             Create a function named "IsPrime", which receives an integer number
             and retuns true if it is prime, or false if it is not
             */

            //Console.Write("Enter the Number : ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(IsPrime(num));
            #endregion

            #region Q06
            /*
                Create a function named MinMaxArray, to return the minimum and
                maximum values stored in an array, using reference parameters
             */

            //int[] Numbers = { 131, 232, 333, 234, 30, 606, 437, 378, 569, 100 };
            //int Min, Max;
            //MinMaxArray(Numbers, out Min, out Max);
            //Console.WriteLine($"The Minimum value is: {Min}");
            //Console.WriteLine($"The Maximum value is: {Max}");
            #endregion

            #region Q07
            //Create function to calculate the factorial of the number specified as parameter

            //int Input = 5;
            //Console.WriteLine($"The Factorial Of {Input} Is : {Factorial(Input)}");
            #endregion
        }
    }
}
