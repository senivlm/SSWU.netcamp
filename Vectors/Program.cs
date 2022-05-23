using Vectors;
using System;

Pair pair1 = new Pair(2, 5);
Pair pair2 = new Pair(2, 5);
Console.WriteLine(pair1.Equals(pair2));




Vector Vec = new Vector(10);
Vec.InitShuffle();
Console.WriteLine(Vec);
Console.WriteLine(Vec.LongestSequence());









//Vector arr = new Vector(20);
//arr.RandomInitialization(1, 5);

//try
//{
//    arr[0] = 999;
//    Console.WriteLine(arr[21]);
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}


/*            Pair[] pairs = arr.CalculateFreq();

            for (int i = 0; i < pairs.Length; i++)
            {
                Console.Write(pairs[i] + "\n"); 
            }
            Console.WriteLine();*/

//Console.WriteLine(pairs);
//arr.RandomInitialization();
//Console.WriteLine(arr);