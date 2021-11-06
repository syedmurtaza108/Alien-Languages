using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alien_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nm = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nm[0]);

                int m = Convert.ToInt32(nm[1]);

                int result = alienLanguages(n, m);

                Console.WriteLine(result);
            }


        }

        static int alienLanguages(int n, int m)
        {
            int temp = (int)Math.Pow(n, m);
            int ans = 0;
            for(int i = 1; i<= n; i++)
            {
                if (2 * i > n)
                    ans += m;
                else
                {

                }
            }
            return ans;
        }
        
        //static string[] MakeWords(int n, int m)
        //{
        //    string[] s = new string[(int)Math.Pow(n, m)];
        //    char[] charInd = new char[n];
        //    int[] comb = new int[m];
        //    for (int i = 0; i < n; i++)
        //    {
        //        charInd[i] = (char)(65 + i);
        //    }
            
        //    for (int i = 0; i<s.Length; i++)
        //    {
                
        //        for (int j = 0; j< m; j++)
        //        {
        //            int temp;
        //            if()
        //            s[i] += charInd[temp++];
        //        }
        //    }

        //    return s;
        //}
    }
}
