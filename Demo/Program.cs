namespace Demo
{

    // 1. Class     -> Function
    // 2. Struct    -> Function
    // 3. Interface -> Function
    // 4. Enum

    internal class Program
    {
        #region Function Prototype Ex
        //static void PrintShape()
        //{
        //    // Body
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine("^_^");
        //    }
        //}

        //static void PrintShape(int Count)
        //{
        //    // Body
        //    for (int i = 1; i <= Count; i++)
        //    {
        //        Console.WriteLine("^_^");
        //    }
        //}

        //static void PrintShape(string Shape = "0o0", int Count = 10)
        //{
        //    // Body
        //    for (int i = 1; i <= Count; i++)
        //    {
        //        Console.WriteLine(Shape);
        //    }
        //} 

        //static int SumNumber(int Number01, int Number02) { 
        //    return Number01 + Number02;
        //}
        #endregion

        #region SWAP(int X, int Y)
        //static void SWAP(int X, int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //static void SWAP(ref int X, ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //} 
        #endregion

        #region SumArray(-ref- int[] Arr)
        //static int SumArray(int[] Arr)
        //{
        //    int Sum = 0;

        //    Arr[0] = 100;

        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }

        //    return Sum;
        //}

        //static int SumArray(ref int[] Arr)
        //{
        //    int Sum = 0;

        //    Arr[0] = 100;

        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }

        //    return Sum;
        //}

        //static int SumArray(int[] Arr)
        //{
        //    int Sum = 0;

        //    Arr = new int[] { 10, 20, 30 };

        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }

        //    return Sum;
        //}

        //static int SumArray(ref int[] Arr)
        //{
        //    int Sum = 0;

        //    Arr = new int[] { 10, 20, 30 };

        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }

        //    return Sum;
        //}


        //static int SumArray(params int[] Arr)
        //{
        //    int Sum = 0;
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }
        //    return Sum;
        //}
        #endregion

        #region SumMul
        //static void SumMul(int X, int Y, out int Sum, out int Mul)
        //{
        //    Sum = Y + X;
        //    Mul = Y * X;
        //} 
        #endregion


        // Entry Point
        static void Main(string[] args)
        {
            #region One D Array
            //int[] Numbers;
            // Declare For Reference (Pointer) From Type 'Array of Integers'
            // Numbers : Can Refer To Object From Type 'Array of Integers'
            // Numbers : Refer To Null

            // 8 Bytes Will Be Allocated At Stack For The Reference 'Numbers'
            // 0 Bytes Will Be Allocated At Heap

            // new
            // 1. Allocate The Number of Required Bytes For The Object At HEAP (4 Bytes * 5)
            // 2. Initialized The Allocated Bytes With The Default Value Of The Datatypes
            // 3. Call User-Defined Constrcutor if Exists
            // 4. Assign The Object To The Reference 'Numbers'


            //Numbers = new int[Size];
            //Numbers = new int[5];

            //Numbers[0] = 12;
            //Numbers[1] = 6;
            //Numbers[2] = 7;
            //Numbers[3] = 11;
            //Numbers[4] = 19;
            // Numbers[5] = 20; Out of Range

            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Numbers[1]);
            //Console.WriteLine(Numbers[2]);
            //Console.WriteLine(Numbers[3]);
            //Console.WriteLine(Numbers[4]);


            //int[] Numbers01 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int[] Numbers02 = new int[4] { 1, 2, 3, 4 };
            //int[] Numbers03 = new int[6] { 1, 2, 3, 4, 0, 0 };
            //int[] Numbers04 = new int[6];

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.Write($"Enter Numbers[{i}]: ");
            //    Numbers[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("=================");

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.Write($"{Numbers[i]} ");
            //}

            // One D Array

            //Console.WriteLine(Numbers.Length); // Size
            //Console.WriteLine(Numbers.Rank); // Dimention 
            #endregion

            #region Two D Array
            // Two D Array

            //int[,] Marks = new int[3, 3];

            //Marks[0, 0] = 99;
            //Marks[0, 1] = 99;
            //Marks[0, 2] = 99;

            //Marks[1, 0] = 80;
            //Marks[1, 1] = 98;
            //Marks[1, 2] = 97;

            //Marks[2, 0] = 88;
            //Marks[2, 1] = 78;
            //Marks[2, 2] = 47;

            //Console.WriteLine(Marks[0, 0]);
            //Console.WriteLine(Marks[0, 1]);
            //Console.WriteLine(Marks[0, 2]);

            //Console.WriteLine(Marks[1, 0]);
            //Console.WriteLine(Marks[1, 1]);
            //Console.WriteLine(Marks[1, 2]);

            //Console.WriteLine(Marks[2, 0]);
            //Console.WriteLine(Marks[2, 1]);
            //Console.WriteLine(Marks[2, 2]);

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Enter Marks[{i}, {j}] : ");
            //        Marks[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine();

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{Marks[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Two D Array - Juddge

            //int[][] Marks = new int[3][];

            //Marks[0] = new int[2];
            //Marks[1] = new int[5];
            //Marks[2] = new int[1];

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < Marks[i].Length; j++)
            //    {
            //        Console.Write($"Marks[{i}][{j}] : ");
            //        Marks[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < Marks[i].Length; j++)
            //    {
            //        Console.WriteLine($"{Marks[i][j]}");
            //    }
            //}

            #endregion

            #region Function Prototype
            // Functions : Block Of Code That Have Name if U Need To Execute This Code
            // U Need To Call The Function By The Name
            // DRY

            // Function Prototype
            // 1. Signature
            //   1.1.Name
            //   1.2.Retrun Type
            //   1.3. Parameters (Inputs)

            // 2. Body (Code)


            // Calling for The Function

            //PrintShape();
            //PrintShape(3);
            //PrintShape(5);
            //PrintShape(5, "-_-"); // Passing By Order
            //PrintShape(Shape: "-_-", Count: 5); // Passing By Name
            //PrintShape(Shape: "-_-");
            //PrintShape();

            // Methods
            // 1. Class Member Method (Static Method)
            // 1. Object Member Method (Non Static Method) 

            //SumNumber(10, 20);
            #endregion

            #region Passing Parameter Value Type
            // Passing Parameter Value Type
            // 1. Passing By Value

            //int A = 4, B = 5;

            //Console.WriteLine(value: $"A : {A}"); // 4
            //Console.WriteLine(value: $"B : {B}"); // 5

            //Console.WriteLine(value: " ---- After Swap ---- ");

            //SWAP(A, B); // Passing By Value

            //Console.WriteLine(value: $"A : {A}"); // 4
            //Console.WriteLine(value: $"B : {B}"); // 5


            // 2. Passing By Reference

            //int A = 4, B = 5;

            //Console.WriteLine(value: $"A : {A}"); // 4
            //Console.WriteLine(value: $"B : {B}"); // 5

            //Console.WriteLine(value: " ---- After Swap ---- ");

            //SWAP(ref A, ref B); // Passing By Reference

            //Console.WriteLine(value: $"A : {A}"); // 5
            //Console.WriteLine(value: $"B : {B}"); // 4 
            #endregion

            #region Passing Parameter Reference Type
            //Passing Parameter Reference Type

            // 1. Passing By Value

            //int[] Numbers = { 1, 2, 3 };

            //int Result = SumArray(Numbers); // Passing By Value

            //Console.WriteLine(Result);
            //Console.WriteLine(Numbers[0]);


            // 2. Passing By Reference

            //int[] Numbers = { 1, 2, 3 };

            //int Result = SumArray(ref Numbers); // Passing By Ref
            // The Address Of "Numbers"

            //Console.WriteLine(Result);
            //Console.WriteLine(Numbers[0]); 
            #endregion

            #region Passing By Out
            // Output Paramters

            // Passing By Out

            //int A = 4, B = 5;

            //SumMul(A, B, out int Sum, out int Mul);

            //Console.WriteLine(Sum);
            //Console.WriteLine(Mul); 
            #endregion

            #region Params
            // Params 

            //int[] Numbers = [1, 2, 3, 4, 5, 6, 7];

            //Console.WriteLine(SumArray(1, 2, 3, 4, 5, 6, 7, 8, 9, 12)); 
            #endregion

        }
    }
}
