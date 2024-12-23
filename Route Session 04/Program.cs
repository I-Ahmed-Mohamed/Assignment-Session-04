using System.Diagnostics;
using System.Text;

namespace Route_Session_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Loop Statement [For - Foreach - while - do-While]

            #region EX for loob

            //// invalid
            //Console.WriteLine("Ahmed Mohamed");
            //Console.WriteLine("Ahmed Mohamed");
            //Console.WriteLine("Ahmed Mohamed");
            //Console.WriteLine("Ahmed Mohamed");
            //Console.WriteLine("Ahmed Mohamed");
            //Console.WriteLine("Ahmed Mohamed");
            //Console.WriteLine("Ahmed Mohamed");
            //Console.WriteLine("Ahmed Mohamed");
            //Console.WriteLine("Ahmed Mohamed");

            //// Valid
            //for (int i = 0; i <=10; i++)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine($"{i} t");

            //}
            #endregion


            #region EX [for & foreach]
            //int[] Numbers  = { 1, 2, 3, 4, 5, 6, 7, 8, 9,10 };

            //// Start one 10 
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    // Start one 10 
            //    Numbers[i] += 10;
            //    Console.WriteLine(Numbers[i]);
            //}

            //// invalid
            //foreach (int i in Numbers)
            //{
            //    Console.WriteLine(Numbers );
            //}

            #endregion

            #region EX do-while
            //int Numbers;
            //bool Flag;

            //do
            //{
            //    Console.Write("Please Enter Number : ");
            //    Flag =  int.TryParse(Console.ReadLine() , out Numbers);


            //} while (Numbers % 2 ==1 || !Flag);

            //Console.WriteLine($"{Numbers} is not Even Number");
            #endregion

            #region EX while
            //int X = 2;
            //bool flag = true;

            //while (X % 2 == 0 || !flag)
            //{
            //    Console.WriteLine("Sory Your Number is Even , Please Enter A odd Number ");
            //    flag = int.TryParse(Console.ReadLine(), out X);

            //}

            //Console.WriteLine($"{X} is a odd Number");
            #endregion

            #endregion

            #region String

            //string Name1 = "Ahmed"; // has to Reference
            //string Name2 = "Ali"; // Unreachable object

            //Console.WriteLine($"Name1 : {Name1}"); // Ahmed
            //Console.WriteLine($"Name1 HC: {Name1.GetHashCode()}"); // 783436761 

            //Console.WriteLine($"Name2 : {Name2}"); // Ali
            //Console.WriteLine($"Name2 HC: {Name2.GetHashCode()}"); // 1923645332

            //Name1 = Name2; // References
            //// Name1 , Name 2 => object

            //Console.WriteLine("After Assign Name1 = Name2");
            //Console.WriteLine($"Name1 : {Name1}"); // Ahmed
            //Console.WriteLine($"Name1 HC: {Name1.GetHashCode()}"); // 1923645332

            //Console.WriteLine($"Name2 : {Name2}"); // Ali 
            //Console.WriteLine($"Name2 HC: {Name2.GetHashCode()}"); // 1923645332


            #endregion

            #region StringBiulder
            // StringBuilder is a reference type
            // is Mutble datatype [Value can be changed]
            // internally is a linklist Of chars

            //StringBuilder Message;
            // declare for Reference From type String
            // CLR Will Allocate 4 Bytes At stack for Reference "Message"
            // Zero Bytes Allocated Heap
            // This Reference "Message" is Reference to default Value of Reference type => Null

            //Message = new StringBuilder("hello");  

            //Console.WriteLine($" Message = {Message} ");
            //Console.WriteLine($" Message HC = {Message.GetHashCode} ");



            //Message.Append( "Route" );
            //Console.WriteLine($" Message = {Message} ");
            //Console.WriteLine($" Message HC = {Message.GetHashCode} ");

            #endregion

            #region StringBiulder Methode

            //StringBuilder Message = new StringBuilder("hello");
            //Message.Append("to"); // Hello To
            //Console.WriteLine("Message");

            //Message.AppendLine("Ahmed"); // Hello To Ahmed
            //Console.WriteLine("Message");

            //Message.Remove(0 , 5 );
            //Console.WriteLine(Message);
            ////  To Ahmed

            //Message.Insert(0, "Hi");
            //Console.WriteLine(Message);
            ///// Hi To Ahmed 


            //string Name = "Ahmed";
            //    int Age = 21;

            //Message.AppendFormat("Hi {0} , your age is {1}", Name, Age);
            //Console.WriteLine(Message);
            ///// Hi To Ahmed 
            ///// Hi Ahmed  your age is 21 
            ///// 

            //Message.AppendJoin('/', "Ahmed", "Mohamed", "Ali", 2);
            //Console.WriteLine(Message);
            //// Hi to Ahmed
            //// Hi Ahmed , your age is 21Ahmed / Mohamed / Ali / 2



            #endregion

            #region Arrays

            #region 1 Dimensions  Arrays
            //int[] Numbers;

            // array [Builtin Class] Reference type
            // Declare For Refrence from type array of int
            // CLR will Allocate 4 bytes at stack For Refrence "Number"
            // This Reference "Numbers" Can refer To An object of type [Array of integer]
            // Zero Bytes Allocated at Heap 

            //Numbers = new int[10];

            // CLR Allocate required bytes At Heap [3 * 4 ] => 12 bytes
            // Initialize Allocated Bytes With Default Value - 0
            // 

            // invalid
            //Console.WriteLine(Numbers[0]); // 0
            //Console.WriteLine(Numbers[0]); // 10

            //Numbers[0] = 10;
            //Numbers[1] = 20;
            //Numbers[2] = 30;

            //int[] Number01 = new int[3] { 1,2,3};
            //int[] Number02 = new int[] { 1, 2, 3 };
            //int[] Number03 =   { 1, 2, 3 };

            //Console.WriteLine($"Size Of array = {Numbers.Length}"); // Size = 3
            //Console.WriteLine($"No of Dimensions = {Numbers.Rank}"); // Dimensions = 1


            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 10 };

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //Numbers[10] = 100;
            //Console.WriteLine(Numbers[10]);





            #endregion

            #region 2 Dimensions  Arrays [Rectangular]
            //int[,] Marks = new int[3, 4] ;

            //// CLR Will Allocated 60 [15 *4 ] Bytes at Heap
            //// Initialize With Default Value = 0



            //Console.WriteLine($"Size Of array = {Marks.Length}"); // Size = 3
            //Console.WriteLine($"No of Dimensions = {Marks.Rank}"); // Dimensions = 1
            //Console.WriteLine($"No of Dimensions = {Marks.GetLength(0)}"); // Rows = 3
            //Console.WriteLine($"No of Dimensions = {Marks.GetLength(1)}"); // Columuns = 5
            //bool flag;
            //for (int i = 0; i < Marks.GetLength(0); i++ )
            //{
            //  Console.WriteLine($"Marks of student Numbers ({i+1})");

            //    for (int k = 0; k < Marks.GetLength(1);k++) 
            //    {
            //        Console.Write($"Mark of Subject Number ({k+1}) : ");
            //        //Console.WriteLine(Marks[i,k]);
            //        //Marks[i,k] = int.Parse(Console.ReadLine());
            //        flag = int.TryParse(Console.ReadLine() , out Marks[i,k]);
            //        // 10 -> TryParse-> True , Marks [i , k]  =10
            //        // -10 = TryParse-> True , Marks [i, k] = -10 xxxx
            //        // Ahmed = TryParse -> false , Marks [i, k] =  0 xxxx
            //      k =  flag && Marks[i, k] >= 0 ? k++ : k;
            //        // 

            //        //if ( flag && Marks[i,k ] >= 0)
            //        //{
            //        //    k++;
            //        //}
            //    }
            //}

            #endregion

            #region 2 Dimensions Arrays  [iterate on 2D Array6 Using one loop]
            //int[,] Marks = new int[2, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };

            //for(int i = 0; i <Marks.Length; i++)
            //{
            //    Console.WriteLine(Marks[i/Marks.GetLength(1), i% Marks.GetLength(1)]);
            //}
            #endregion

            #region 2 Dimensions [Judged Arrays]
            //int[][] Numbers = new int[3][];

            //Numbers[0] = new int[] {1,2,3,4,5 };
            //Numbers[0] = new int[] { 9,10 };
            //Numbers[0] = new int[] { 7,8,20,30 };

            //for(int i = 0; i < Numbers.Length; i++)
            //{
            //    for (int j = 0; j < Numbers[1].Length; i++)
            //    {
            //        Console.WriteLine(Numbers[i][j]);
            //        Console.WriteLine("============"); ;

            //    }
            //}

            #endregion

            #region Arrays Methods
            int[] ints = { 1, 2, 3, 7, 5, 6, 9, 8, 11, 10, };

            #region Static Method [Class Member Method]
            //Array.Sort(ints);    // بترتبهم
            //Array.Reverse(ints); // بتعكس ترتبهم
            //Array.Clear(ints);   // بتصفرهم 


            // بتاخد اول اتنين والتلاته بيرجعوا بزيرو
            //int[] Arra01  = { 1, 2 , 3};
            //int[] Arra02 = new int[5];

            ////Array.Copy(Arra01, Arra02, 2);
            //Array.ConstrainedCopy(Arra02, 1 , Arra01 ,1, 2);

            //foreach(int i in Arra01)
            //{
            //    Console.WriteLine(i);
            //}

            //foreach (int l in Arra02)
            //{
            //    Console.WriteLine(l);
            //}


            //int[] Arra01 = new int[3];

            //String[] Arra03 = (string[])Array.CreateInstance(typeof(String), 10);
            //string[] Arra04 = new string[10];
            //


            //int[,] Arra01 = int([,]) Array.CreateInstance(typeof(int), 20,10);
            //int[,,] Arra02 = int([,,]) Array.CreateInstance(typeof(int), 10, ,10,10);



            #endregion

            #region non-Static Method [object Member Method]
            //ints.GetLength(0);

            //int[] Arra01 = { 1, 2,};
            //int[] Arra02 = new int[2];

            //Arra01.CopyTo(Arra02, 1);


            //foreach(int i in Arra01)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("=========");

            //foreach (int i in Arra02)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(ints[1]);

            //ints.SetValue(100, 1);


            #endregion



            #endregion




            #endregion


        #region Assignmet Session 04

 
            // Call functions to test solutions
            Question1();
            Question2();
            Question3();
            Question4();
            Question5();
            Question6();
            Question7();
            Question8();
            Question9();
            Question10();
            Question11();
            Question12();
            Question13();
            Question14();
            Question15();
            Question16();
            Question17();
            Question18();
            Question19();
        }

        #region Question1_PrintNumbersToN
        static void Question1()
        {
            Console.WriteLine("Enter an integer:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + (i < n ? ", " : "\n"));
            }
        }
        #endregion

        #region Question2_MultiplicationTable
        static void Question2()
        {
            Console.WriteLine("Enter an integer:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.Write(n * i + (i < 12 ? " " : "\n"));
            }
        }
        #endregion

        #region Question3_PrintEvenNumbersToN
        static void Question3()
        {
            Console.WriteLine("Enter an integer:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i += 2)
            {
                Console.Write(i + (i + 2 <= n ? " " : "\n"));
            }
        }
        #endregion

        #region Question4_PowerCalculation
        static void Question4()
        {
            Console.WriteLine("Enter base and exponent (separated by space):");
            string[] input = Console.ReadLine().Split(' ');
            int baseNum = int.Parse(input[0]);
            int exponent = int.Parse(input[1]);
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result *= baseNum;
            }

            Console.WriteLine($"{baseNum}^{exponent} = {result}");
        }
        #endregion

        #region Question5_ReverseString
        static void Question5()
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));
        }
        #endregion

        #region Question6_PrimeNumbersInRange
        static void Question6()
        {
            Console.WriteLine("Input starting number of range:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Input ending number of range:");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("The prime numbers between {0} and {1} are:", start, end);
            for (int num = start; num <= end; num++)
            {
                if (IsPrime(num))
                    Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        #endregion

        #region Question7_DecimalToBinary
        static void Question7()
        {
            Console.WriteLine("Enter a number to convert:");
            int number = int.Parse(Console.ReadLine());
            string binary = "";

            while (number > 0)
            {
                binary = (number % 2) + binary;
                number /= 2;
            }

            Console.WriteLine("The Binary of the number is: " + binary);
        }
        #endregion

        #region Question8_IdentityMatrix
        static void Question8()
        {
            Console.WriteLine("Enter the size of the identity matrix:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(i == j ? "1 " : "0 ");
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region Question9_Substring
        static void Question9()
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            Console.WriteLine("Enter starting index and length of substring (separated by space):");
            string[] parts = Console.ReadLine().Split(' ');
            int start = int.Parse(parts[0]);
            int length = int.Parse(parts[1]);

            Console.WriteLine("Substring: " + input.Substring(start, length));
        }
        #endregion

        #region Question10_ConcatenateStrings
        static void Question10()
        {
            Console.WriteLine("Enter first string:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second string:");
            string str2 = Console.ReadLine();

            Console.WriteLine("Concatenated string: " + str1 + str2);
        }
        #endregion

        #region Question11_IdentityMatrix
        static void Question11()
        {
            Question8();
        }
        #endregion

        #region Question12_ArraySum
        static void Question12()
        {
            Console.WriteLine("Enter the size of the array:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }

            Console.WriteLine("Sum of all elements: " + sum);
        }
        #endregion

        #region Question13_MergeSortedArrays
        static void Question13()
        {
            Console.WriteLine("Enter the size of the arrays:");
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            Console.WriteLine("Enter the elements of the first array in sorted order:");
            for (int i = 0; i < n; i++)
                arr1[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the elements of the second array in sorted order:");
            for (int i = 0; i < n; i++)
                arr2[i] = int.Parse(Console.ReadLine());

            int[] merged = new int[2 * n];
            Array.Copy(arr1, merged, n);
            Array.Copy(arr2, 0, merged, n, n);
            Array.Sort(merged);

            Console.WriteLine("Merged and sorted array: " + string.Join(" ", merged));
        }
        #endregion

        #region Question14_ArrayFrequency
        static void Question14()
        {
            Console.WriteLine("Enter the size of the array:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Frequency of elements:");
            Array.Sort(arr);
            int count = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i == n || arr[i] != arr[i - 1])
                {
                    Console.WriteLine(arr[i - 1] + ": " + count);
                    count = 1;
                }
                else
                {
                    count++;
                }
            }
        }
    #endregion

        #region Question15_MaxMinInArray
    static void Question15()
    {
        Console.WriteLine("Enter the size of the array:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int max = arr[0], min = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
        }

        Console.WriteLine($"Maximum element: {max}");
        Console.WriteLine($"Minimum element: {min}");
    }
    #endregion

        #region Question16_SecondLargestInArray
    static void Question16()
    {
        Console.WriteLine("Enter the size of the array:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);
        int secondLargest = arr[n - 2];

        Console.WriteLine($"Second largest element: {secondLargest}");
    }
    #endregion

        #region Question17_LongestDistanceBetweenEqualCells
    static void Question17()
    {
        Console.WriteLine("Enter the size of the array:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int maxDistance = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = n - 1; j > i; j--)
            {
                if (arr[i] == arr[j])
                {
                    maxDistance = Math.Max(maxDistance, j - i);
                }
            }
        }

        Console.WriteLine($"Longest distance between two equal cells: {maxDistance}");
    }
    #endregion

        #region Question18_CopyMultidimensionalArray
    static void Question18()
    {
        Console.WriteLine("Enter the dimensions of the array (rows and columns):");
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        int[,] firstArray = new int[rows, cols];
        int[,] secondArray = new int[rows, cols];

        Console.WriteLine("Enter the elements of the first array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                firstArray[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                secondArray[i, j] = firstArray[i, j];
            }
        }

        Console.WriteLine("Elements of the second array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(secondArray[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    #endregion
     
        #region Question19_ReverseArray
    static void Question19()
    {
        Console.WriteLine("Enter the size of the array:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Array in reverse order:");
        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
    #endregion
}



#endregion

        }
    }
}

