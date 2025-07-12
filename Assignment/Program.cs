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
        }
    }
}
