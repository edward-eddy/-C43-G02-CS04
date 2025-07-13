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
        static void MinMaxArray(ref int[] Numbers, out int Min, out int Max)
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

        #region Q08 Functions
        static void ChangeChar(ref string Sentence)
        {
            char[] Temp = Sentence.ToCharArray();
            Temp[0] = Temp[0] == 'A' ? 'B' : 'A';
            Sentence = new string(Temp);
        }
        #endregion

        #region Q09 Functions
        static void IdentitTtable(int Index)
        {
            for (int i = 0; i < Index; i++)
            {
                for (int j = 0; j < Index; j++)
                {
                    Console.Write($"{i}{j}  ");
                }
                Console.WriteLine("\n");
            }
        }
        #endregion

        #region Q10 Functions
        static int ArraySumm(int[] Number)
        {
            int Result = 0;
            foreach (int i in Number)
                Result += i;
            return Result;
        }
        #endregion

        #region Q11 Functions
        static int[] MergeArrays(int[] Arr1, int[] Arr2)
        {
            int[] Result = new int[Arr1.Length + Arr2.Length];
            Arr1.CopyTo(Result, 0);
            Arr2.CopyTo(Result, Arr1.Length);
            Array.Sort(Result);
            return Result;
        }
        #endregion

        #region Q13 Functions
        static int SecondLargest(int[] Input)
        {
            int[] Temp = new int[Input.Length];
            Input.CopyTo(Temp, 0);
            Array.Sort(Temp);

            return Temp[Temp.Length - 2];
        }
        #endregion

        #region Q14 Functions
        static void ElementLargestDistance(int[] Input, out int Element, out int Distance)
        {
            Element = 0;
            Distance = 0;
            int TempDistance;

            for (int i = 0; i < Input.Length; i++)
            {
                TempDistance = Array.LastIndexOf(Input, Input[i]) - Array.IndexOf(Input, Input[i]) - 1;
                if (TempDistance > Distance)
                {
                    Element = Input[i];
                    Distance = TempDistance;
                }
            }
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
            //MinMaxArray(ref Numbers, out Min, out Max);
            //Console.WriteLine($"The Minimum value is: {Min}");
            //Console.WriteLine($"The Maximum value is: {Max}");
            #endregion

            #region Q07
            //Create function to calculate the factorial of the number specified as parameter

            //int Input = 5;
            //Console.WriteLine($"The Factorial Of {Input} Is : {Factorial(Input)}");
            #endregion

            #region Q08
            //Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string,
            //replacing it with a different letter


            //string Input = "Create a function named \"ChangeChar\"";
            //ChangeChar(ref Input);
            //Console.WriteLine(Input);
            #endregion

            #region Q09
            /*
                Write a program that prints an identity matrix using for loop, in other words takes a value n 
                from the user and shows the identity table of size n * n.
             */


            //Console.Write("Enter indexes Number : ");
            //int index = int.Parse(Console.ReadLine());
            //IdentitTtable(index);

            #endregion

            #region Q10
            // Write a program in C# Sharp to find the sum of all elements of the array.

            //int[] InputArr = { 1, 2, 3, 8, 6, 34, 6, 7, 4 };
            //int Output = ArraySumm(InputArr);
            //Console.WriteLine($"The Sum Of The Array Elements Is : {Output}");
            #endregion

            #region Q11
            // Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //int[] Arr1 = { 10, 12, 43, 76, 22, 90, 8 };
            //int[] Arr2 = { 9, 23, 54, 15, 32, 34, 5 };
            //int[] Output = MergeArrays(Arr1, Arr2);
            //foreach (int i in Output)
            //    Console.Write($"{i} ");
            #endregion

            #region Q12
            // Write a program in C# Sharp to find maximum and minimum element in an array

            /*              Same As No.6            */

            //int[] Numbers = { 131, 232, 333, 234, 30, 606, 437, 378, 569, 100 };
            //int Min, Max;
            //MinMaxArray(ref Numbers, out Min, out Max);
            //Console.WriteLine($"The Minimum value is: {Min}");
            //Console.WriteLine($"The Maximum value is: {Max}");
            #endregion

            #region Q13
            // Write a program in C# Sharp to find the second largest element in an array

            //int[] Input = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            //int Output = SecondLargest(Input);
            //Console.WriteLine($"The Second Largest Element in the Array is : {Output}");
            #endregion

            #region Q14
            /*
             Consider an Array of Integer values with size N, having values as in this Example
            {7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3}

            write a program to find the longest distance between Two equal cells. In this example,
            The measured by the number Of cells.

            for example, the distance between the first and the fourth cell is 2 (cell 2 and cell 3).
             */



            //int[] Input = { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };
            //ElementLargestDistance(Input, out int Element, out int Distance);
            //Console.WriteLine($"The longest distance is between the first {Element} and the last {Element}\n is {Distance}");
            #endregion
        }
    }
}
