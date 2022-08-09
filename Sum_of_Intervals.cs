

using System;
using System.Collections.Generic;



class Sum_of_Intervals
{
    public static void Main()
    {
        (int,int)[] jija = { (6, 6), (4, 4), (8, 8) };
        List<(int,int)> JIJA = new List<(int,int)>();
        foreach((int,int) pair in jija)
        {
            JIJA.Add(pair);
        }
        JIJA.Sort((x,y) => x.Item1.CompareTo(y.Item1));
        foreach((int,int) pair in JIJA)
        {
            Console.WriteLine(pair.Item1);
        }
    }

    public static int SumIntervals((int, int)[] intervals)
    {
    //   List<int> inters = new List<int>();
    //   int length = 0;
    //   intervals.Sort((x, y) => y.Item1.CompareTo(x.Item1));
    //   foreach((int,int) n_int in intervals)
    //   {
    //     for(int i = n_int.Item1 ; i < n_int.Item2-1 ; i++)
    //     {
    //         if(!inters.Contains(i))
    //         {

    //         }
    //     }
    //   }
      return -1;
    }




}


