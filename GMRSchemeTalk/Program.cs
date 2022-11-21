using GMRSchemeTalk;
using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> arr = PascalsTriangle(5);
        }

        public static List<List<int>> PascalsTriangle(int n)
        {
            List<List<int>> ret = new List<List<int>>();
           
            // n == 5
            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    ret.Add(new List<int> { 1 });
                }

                List<int> temp = new List<int>();
                temp.Add(1);
                for (int y = 1; y < i; y++)
                {
                    temp.Add(ret[i - 1][y] + ret[i - 1][y - 1]);
                }
                temp.Add(1);
                ret.Add(temp);
            }
            return ret;
        }
    }
}