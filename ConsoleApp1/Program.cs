using System;

namespace ConsoleApp1
{
    class Program
    {

        public static int[] Sort(int[] NewArr)
        {
            int param;
            for (int j = 0; j < NewArr.Length; j++)
            {
                for (int i = NewArr.Length - 1; i >= 0; i--)
                {
                    if (i - 1 == -1) break;
                    if (NewArr[i] < NewArr[i - 1])
                    {
                        param = NewArr[i];
                        NewArr[i] = NewArr[i - 1];
                        NewArr[i - 1] = param;
                    }
                }
            }
            return NewArr;
        }

        public static void AllRepeatedNumbers(int[] SortedArr)
        {
            int count = 1;
            for (int i = SortedArr.Length - 1; i >= 0; i--)
            {
                if (i - 1 == -1)
                {
                    Console.WriteLine($"{SortedArr[i]} Is Repeated {count} Times");
                    break;
                }

                if (SortedArr[i] != SortedArr[i - 1])
                {
                    Console.WriteLine($"{SortedArr[i]} Is Repeated {count} Times");
                    count = 1;
                }
                else count++;
            }
        }

        public static void IndexBetweenFirstAndLast(int[] UnSorted, int[] Sorted)
        {
            int count = 1, param = 0; ;
            for (int i = Sorted.Length-1; i >=0 ; i--)
            {
                if (i - 1 == -1)
                {
                    for (int j = 0; j < UnSorted.Length; j++)
                    {
                        if (UnSorted[j] == Sorted[i])
                        {
                            param++;
                            if (param == 1)
                            {
                                Console.WriteLine($"The First Indx for Number {Sorted[i]} = {j}");
                            }
                        }
                        if (param == count)
                        {
                            param = 0;
                            count = 1;
                            Console.WriteLine($"The Last Indx for Number {Sorted[i]} = {j}");
                            break;
                        }
                    }
                }
                
                else if(Sorted[i]!=Sorted[i-1])
                {
                    for (int j = 0; j < UnSorted.Length; j++)
                    {
                        if(UnSorted[j]==Sorted[i])
                        {
                            param++;
                            if(param==1)
                            {
                                Console.WriteLine($"The First Indx for Number {Sorted[i]} = {j}");
                            }
                        }
                        if(param==count)
                        {
                            param = 0;
                            count = 1;
                            Console.WriteLine($"The Last Indx for Number {Sorted[i]} = {j}");
                            break;
                        }
                    }
                }
                else count++;
            }
        }

        public static void MaxDistance(int[] UnSorted, int[] Sorted)
        {
            int count = 0,count1=1 , MaxValue=0;
            for (int i = 0; i < Sorted.Length; i++)
            {
                count = 0;
                for (int j = i; j < Sorted.Length; j++)
                {
                    if (Sorted[i] == Sorted[j])
                    {
                        count++;
                    }
                    else break;
                }
                if(count1<count)
                {
                    count1 = count;
                    MaxValue = Sorted[i];
                }
            }
            Console.WriteLine($"Max Value Is : {MaxValue} and repeated {count1} times");
            int sub = 0;
            for (int i = 0; i < UnSorted.Length; i++)
            {
                if(UnSorted[i]==MaxValue)
                {
                    sub++;
                    if(sub==1)
                    {
                        Console.Write($"The First Index for Max Number {MaxValue} Repeated is :- {i} And ");
                    }
                }
                if(sub==count1)
                {
                    Console.WriteLine($"The Last Index for Max Number {MaxValue} Repeated is {i} \n");
                    break;
                }
            }

        }

        public static void Task1()
        {
            Console.WriteLine("Enter Number Of Students :");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number Of Subject :");
            int col = int.Parse(Console.ReadLine());
            int[] RowTotalCount = new int[row];
            float[] ColomnTotalAvg = new float[col];
            int sumParam = 0 ;

            int[,] arr = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                Console.WriteLine($"Student Number {i} :- ");
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine($"\t Enter The Result For Subject Number {j+1} : ");
                    arr[i,j] = int.Parse(Console.ReadLine());
                    sumParam += arr[i, j];
                    ColomnTotalAvg[j] += float.Parse(arr[i, j].ToString())/ float.Parse(row.ToString());
                }
                RowTotalCount[i] = sumParam;
                sumParam = 0;
                Console.WriteLine("-----------------------------------------------------------------");
            }


            for (int i = 0; i < row; i++)
            {
                Console.Write(RowTotalCount[i] + " - ");
            }
            Console.WriteLine("---------------------------------------------------------------------------");
            for (int i = 0; i < col; i++)
            {
                Console.Write(ColomnTotalAvg[i] + " - ");
            }


        }

        public static void Task2()
        {
            Console.WriteLine("Enter The Array Length :- ");
            int ArrLength = int.Parse(Console.ReadLine());
            int[] arr = new int[ArrLength];
            int[] SortedArr = new int[ArrLength];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter The Value For Index {i+1} : ");
                int x = int.Parse(Console.ReadLine());
                arr[i] = x;
                SortedArr[i] = x;
            }
            Sort(SortedArr);
            int choise = 0;
            do
            {
                Console.WriteLine("Choose Your Operation : \n \t 1-Repeating For All Numbers \n \t 2-Length From First And Last Number \n \t 3- Max Distance \n \t 4-Exit");
                choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        AllRepeatedNumbers(SortedArr);
                        break;
                    case 2:
                        IndexBetweenFirstAndLast(arr, SortedArr);
                        break;
                    case 3:
                        MaxDistance(arr, SortedArr);
                        break;
                    default:
                        Console.Clear();
                        break;
                }

            } while (choise != 4);
            
            
        }

        public static void Task3()
        {
            int sum = 0, multiply = 1;
            Console.WriteLine("Enter First Array Length Size :- ");
            int Arr1Length = int.Parse(Console.ReadLine());
            int[] Arr1 = new int[Arr1Length];
            for (int i = 0; i < Arr1Length; i++)
            {
                Console.WriteLine($"Enter {i} Element :- ");
                Arr1[i] = int.Parse(Console.ReadLine());
                sum += Arr1[i];
                multiply *= Arr1[i];
            }
            Console.WriteLine("Enter First Array Length Size :- ");
            int Arr2Length = int.Parse(Console.ReadLine());
            int[] Arr2 = new int[Arr2Length];
            for (int i = 0; i < Arr2Length; i++)
            {
                Console.WriteLine($"Enter {i} Element :- ");
                Arr2[i] = int.Parse(Console.ReadLine());
                sum += Arr2[i];
                multiply *= Arr2[i];
            }

            int[] TotalArray = new int[Arr1.Length + Arr2.Length];
            for (int i = 0; i < TotalArray.Length; i++)
            {
                if(i>Arr1.Length-1)
                {
                    TotalArray[i] = Arr2[i - Arr1.Length];
                }
                else TotalArray[i] = Arr1[i];
            }

            Console.WriteLine($"The Sum Of Arrays Is => {sum}");
            Console.WriteLine($"The Multiply Of Arrays Is => {multiply}");

            for (int i = 0; i < TotalArray.Length; i++)
            {
                Console.Write(TotalArray[i]+ " ");
            }


        }

        static void Main(string[] args)
        {
            Task1();
            //Task2();
            //Task3();
            Console.ReadKey();
        }
    }
}
