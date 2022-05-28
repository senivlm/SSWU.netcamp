using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class Vector
    {
        int[] arr;


        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < arr.Length)
                {
                    return arr[index];
                }
                else
                {
                    throw new Exception("Index out of range array");
                }
            }
            set
            {
                arr[index] = value;
            }
        }

        public Vector(int[] arr)
        {
            this.arr = arr;
        }

        public Vector(int n)
        {
            arr = new int[n];
        }

        public Vector() { }

        public void RandomInitialization(int a, int b)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(a, b);
            }
        }

        public void InitShuffle()
        {
            Random random = new Random();
            int y;
            int z;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;

            }
            for (int i = 0; i < arr.Length; i++)
            {
                y = random.Next(0, arr.Length - 1);
                z = arr[i];
                arr[i] = arr[y];
                arr[y] = z;
            }
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    while (arr[i] == 0)
            //    {
            //        x = random.Next(1, arr.Length + 1);
            //        bool isExist = false;
            //        for (int j = 0; j < i; j++)
            //        {
            //            if (x == arr[j])
            //            {
            //                isExist = true;
            //                break;
            //            }
            //        }
            //        if (!isExist)
            //        {
            //            arr[i] = x;
            //            break;
            //        }
            //    }
            //}
        }

        public void SortBubble()
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j + 1] > arr[j])
                    {
                        int X = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = X;
                    }
                }

            }
        }

        public void Counting()
        {
            int Max = arr[0];
            int Min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > Max)
                {
                    Max = arr[i];
                }
                if (arr[i] < Min)
                {
                    Min = arr[i];
                }

            }

            int[] temp = new int[Max - Min + 1];
            int k = 0;
            for (int i = 1; i <= arr.Length; i++)
            {
                temp[arr[i] - Min]++;
            }
            for (int i = 1; i <= temp.Length; i++)
            {
                for (int j = 0; j <= temp[i]; j++)
                {
                    arr[k] = i + Min;
                    k++;
                }
            }
        }




        public Pair[] CalculateFreq()
        {

            Pair[] pairs = new Pair[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                pairs[i] = new Pair(0, 0);

            }
            int countDifference = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool isElement = false;
                for (int j = 0; j < countDifference; j++)
                {
                    if (arr[i] == pairs[j].Number)
                    {
                        pairs[j].Freq++;
                        isElement = true;
                        break;
                    }
                }
                if (!isElement)
                {
                    pairs[countDifference].Freq++;
                    pairs[countDifference].Number = arr[i];
                    countDifference++;
                }
            }

            Pair[] result = new Pair[countDifference];
            for (int i = 0; i < countDifference; i++)
            {
                result[i] = pairs[i];
            }

            return result;
        }

        public bool IsPalindrom()
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (!(arr[i] == arr[arr.Length - 1 - i]))
                {
                    return false;
                }
            }
            return true;
        }

        public void Reverse()
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int j = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = arr[i];
                arr[i] = j;
            }
        }

        public Pair LongestSequence()
        {
            int MaxCount = 0, MaxNum = 0;
            int count = 1;
            int X = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (count >= MaxCount)
                {
                    MaxCount = count;
                    MaxNum = X;
                }
                if (arr[i] == X)
                {
                    count++;
                    continue;
                }
                X = arr[i];
                count = 1;
            }
            return new Pair(MaxCount, MaxNum);
        }


        public void SortQuick()
        {
           QuickSort( ref arr, 0, arr.Length-1);
        }
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < arr.Length; i++)
            {
                str += arr[i] + " ";
            }
            return str;
        }

        public static void QuickSort(ref int[] arr, int minindex, int maxindex) // для замінии опорного елементу просто замінимо індекс на minindex або (minindex+maxindex)/2 в стрічці 251
        {

            int pivot = arr[maxindex];
            int i = minindex;
            int j = maxindex;
            while (i <= j)
            {
                while (arr[i] < pivot)
                {
                    i++;
                }

                while (arr[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    Swap(ref arr[i], ref arr[j]);
                    i++;
                    j--;
                }
            }
            if (minindex < j)
                QuickSort(ref arr, minindex , j);
            if (i < maxindex)
                QuickSort(ref arr, i, maxindex);
            
            
        }
        
        static void Swap(ref int x, ref int y)
        {
            int z = y;
            y = x;
            x = z;
        }
    }
}
