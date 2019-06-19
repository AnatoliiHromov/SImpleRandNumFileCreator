using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static int[] RandomArray(int length)
        {
            int[] a = new int[length];
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(0,9999);
            }
            return a;
        }
        static void Main(string[] args)
        {
            int[] sortArray1 = RandomArray(1000);

            using (StreamWriter sw = new StreamWriter("Arr.txt", false, System.Text.Encoding.Default))
            {
                foreach (var s in sortArray1)
                {
                    sw.Write(s+" ");
                }
            }
           
        }
    }
}
