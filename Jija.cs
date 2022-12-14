#pragma warning disable format

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;



class P
{
    public static void Main()
    {
       Console.WriteLine(Mat.Kolvo('a',2));
    }
}

class Mat
{
    public static int Kolvo(char letter, int length)
    {
        int let = (int)letter - (int)'a' + 1;
        List<int> l = new List<int>();
        int[,] Matrix = fillMat(l , let);
        printMatrix(Matrix);
        // return 0;
        // Console.WriteLine("I was there, BUT NOT FURTHER | " + let);
        return getKolvo(Matrix , l, length , let);
    }

    public static int getKolvo(int[,] Matrix , List<int> old_letters,int length, int new_letter)
    {
        int sum = 0;
        int ch = new_letter;
        if(length <= 0) return 0;
        if(length >= 10) return 0;
        List<int> letters = new List<int>(old_letters);
        letters.Add(new_letter);
        foreach(int l in old_letters)
        {
            Console.WriteLine("All letters in old_letters = " + l);
        }
        // letters.Add(new_letter);
        Console.WriteLine("length - let.count = " + (length - letters.Count));
        if(length - letters.Count == 0) return 1;
        if(length - letters.Count < 0) return 0;

        
        
        for(int i =0;i<9;i++)
        {
            if(Matrix[ch - 1,i] != 0 )
            {

                sum += getKolvo(fillMat(letters,i+1) , letters,length , i+1);
                Console.WriteLine("Inside the getKolvo , letter.Length = " +  letters.Count + " | " + length + " | letter = "+ (i+1) +  " | sum  = " + sum);
            }
        }
        return sum;
    }
    public static int[,] fillMat(List<int> old_letters, int new_letter)
    {
        // if( letters.Length != 0)
        // Console.WriteLine("!!!");
        int n = new_letter;
        // Console.WriteLine(n);
        List<int> letters = new List<int>(old_letters);
        letters.Add(new_letter);
        int m = 9;
        int[] markers = new int[9];
        for(int i = 0;i< 9;i++)
        {
            markers[i] = Convert.ToInt32(!letters.Contains(i+1));;
        }
        //  markers[1] = Convert.ToInt32(!letters.Contains<int>(2));
        //  markers[3] = Convert.ToInt32(!letters.Contains<int>(4));
        //  markers[4] = Convert.ToInt32(!letters.Contains<int>(5));
        //  markers[5] = Convert.ToInt32(!letters.Contains<int>(6));
        //  markers[7] = Convert.ToInt32(!letters.Contains<int>(8));

        int[,] Matrix = new int[m,m];
        // for(int i = 0;i < m;i++)
        // {
        //     for(int j = 0; j < m;j++)
        //     {
        //         Matrix[i,j] = 1*markers[j];
        //         // if(i != n) Matrix[i,j] = markers[i];
        //         if(i == j) Matrix[i,j] = 0;
        //     }
        // }

        //If password contains letter B

        for(int i = 0;i < m;i++)
        {
            for(int j = 0; j < m;j++)
            {
                Matrix[i,j] = 1;
                if(i == j) Matrix[i,i] = 0;
            }
        }
        for(int i = 0;i<m;i++)
        {
            foreach(int l in letters)
            {
                Matrix[i,l-1] = 0;
                if(l != n) Matrix[l-1,i] = 0;
            }
        }
        Matrix = fillMatrixMarkes(Matrix,letters);
        // printMatrix(Matrix);
        return Matrix;
    }

    public static void printMatrix(int[,] Matrix)
    {
        int n = 9;
        //???????????? ???????????????????????????? ????????????
        Console.Write("-|-");
        for(int i = 0;i<n;i++)
        {
            Console.Write("--{0}-" , i+1);
        }
        Console.WriteLine("|-");
        //???????????? ???????????????????????? ???????????? ?? ???????? ??????????????
        for(int i = 0; i < n; i++)
        {

            Console.Write("-{0}-| " , i+1);
            for(int j = 0; j < n; j++)
            {
                Console.Write("" + Matrix[i,j] + " | ");
            }
            Console.WriteLine("");
        }
    }
    
    public static int[,] fillMatrixMarkes(int[,] Matrix, List<int> letters)
    {
        int m = 9;
        if(!letters.Contains(2))
        {
            Matrix[0,2] = 0;
            Matrix[2,0] = 0;
        }
        if(!letters.Contains(4))
        {
            Matrix[0,6] = 0;
            Matrix[6,0] = 0;
        }
          if(!letters.Contains(5))
        {
            for(int i = 0;i<m;i++)
            {
                Matrix[i,m-1-i] = 0;
            }
        }
          if(!letters.Contains(6))
        {
            Matrix[2,8] = 0;
            Matrix[8,2] = 0;
        }
          if(!letters.Contains(8))
        {
            Matrix[6,8] = 0;
            Matrix[8,6] = 0;
        }
        return Matrix;
    }


}