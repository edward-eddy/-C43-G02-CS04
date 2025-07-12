namespace Assignment
{
    internal class Program
    {
        #region Increment(int number)
        static void Increment(int number)
        {
            number += 5;
            Console.WriteLine("Inside Function: " + number);
        }
        #endregion


        static void Main(string[] args)
        {
            #region Q01
            /*
                Explain the difference between passing(Value type parameters) by value and by reference 
                then write a suitable c# example.
            */

            /*
             Passing by value will pass a copy of the variable to the function so that any modification
            wouldn't affect the main variable.
            Meanwhile, passing by reference will pass the address of the variable to the function 
            so that any modification will affect the main variable.
             */

            //Example
            //int value = 10;
            //Console.WriteLine("Before passing: " + value);
            //Increment(value);
            //Console.WriteLine("After passing: " + value);
            #endregion
        }
    }
}
