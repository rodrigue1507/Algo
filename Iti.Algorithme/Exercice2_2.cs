using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.Algorithms
{
    // permutation s'il est contient le même nombre de 
    public class Exercice2_2
    {
        public static bool PernutedStrings(string s1,string s2)
        {
            if (s1.Length != s2.Length)
                return false;
            else
            {

                for (int i = 0; i < s1.Length; i++)
                {
                    int s1CaracterNumber = LetterNumber(s1, s1[i]);
                    for (int j = 0; j < s2.Length; j++)
                    {
                        int s2CaracterNumber = LetterNumber(s2, s2[j]);
                        if (s1CaracterNumber != s2CaracterNumber)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public static int LetterNumber(string s,char c)
        {
            int total = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    total = total + 1;
                }
            }
            return total;
        } 
    }
}
