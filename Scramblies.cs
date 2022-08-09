

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


class Scramblies
{
    public static void Main()
    {
        Console.WriteLine(IsAnagrama("rkqodlw","world"));
    }

     public static bool Scramble(string str1, string str2) 
    {
        return true;
    } 
    public static bool IsAnagrama(string Word1, string Word2)
    {
        Dictionary<char, int> word1 = new Dictionary<char, int>();
        Dictionary<char, int> word2 = new Dictionary<char, int>();
        for (int i = 0;  i < Word1.Length; i++)
        {
          if(!word1.ContainsKey(Word1[i])) word1.Add(Word1[i] , 1);
          else word1[Word1[i]] = word1[Word1[i]] + 1;
        }
        foreach(KeyValuePair<char , int> pair in word1)
        {
            Console.WriteLine("" + pair.Key + " | " + pair.Value);
        }
        for (int i = 0;  i < Word2.Length; i++)
        {
            if(!word2.ContainsKey(Word2[i])) word2.Add(Word2[i] , 1);
            else word2[Word2[i]] = word2[Word2[i]] + 1;
        }
        for(int i = 0; i < Word1.Length;i++)
        {
            if(!word2.ContainsKey(Word1[i])) return false;
            if(! (word1[Word1[i]] > word2[Word1[i]])) return false;
        }
        return true;
    }
}
