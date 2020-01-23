using System;
using System.Collections.Generic;

namespace ITI.Algorithms
{
    public class Exercice2_1
    {
        public static bool ContainsDuplicateChar(string s)
        {
            // quelque soit le nombre d'element dans le hashset le temps d'excution est le même
            HashSet<char> uniqueChars = new HashSet<char>();
            // comparer les performances de for et foreach
            // char en tier de 2 octets
            // utf 16 abordé  
            foreach (Char c in s)
                uniqueChars.Add(c);
        
            return s.Length != uniqueChars.Count;

        }

        public static bool ContainsDuplicateChar_version2(string s)
        {
            for (int i = 0; i < s.Length - 1 ; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if(s[i] == s[j]) return true;
                } 
            }
            return false;
        }
    }
}