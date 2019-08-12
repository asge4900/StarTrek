using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace startrek
{
    class Program
    {
        static void Main(string[] args)
        {       


            //https://social.msdn.microsoft.com/Forums/vstudio/en-US/eec3eadf-4712-48e5-bb40-42ab7c83c44a/print-out-list-of-lists-all-combinations?forum=csharpgeneral

            var A = new string[] { "S", "Sp", "Sk", "St", "T" };
            var B = new string[] { "a", "e", "i", "o", "u", "y" };
            var C = new string[] { "r", "t", "p", "d", "f", "j", "k", "l", "v", "b", "n", "m" };
            var D = new string[] { "q", "p", "k", "ck" };
            //Func<string, int> all = z => 0;
            //Func<string, string, string> concat = (a, b) => a + b;
            //var vulcanMaleLongNames = A.Join(B, all, all, concat).Join(C, all, all, concat).Join(B, all, all, concat).Join(D, all, all, concat);
            //foreach (var i in vulcanMaleLongNames)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("");

            //var vulcanMaleShortNames = A.Join(B, all, all, concat).Join(D, all, all, concat);
            //foreach (var i in vulcanMaleShortNames)
            //{
            //    Console.WriteLine(i);
            //}

            foreach (string s1 in A)
            {
                foreach(string s2 in B)
                {
                    foreach(string s3 in C)
                    {
                        foreach(string s4 in D)
                        {
                            Console.WriteLine(s1+s2+s3+s2+s4);
                        }
                    }
                }
            }

            Console.WriteLine("");


            foreach (string s1 in A)
            {
                foreach (string s2 in B)
                {
                    foreach (string s3 in C)
                    {
                        Console.WriteLine(s1+s2+s3);
                    }
                }
            }

            Console.WriteLine($"\nfemale");


            var E = new string[] { "T’", "P", "K", "Q" };
            var F = new string[] { "a", "e", "i", "o", "u", "y" };
            var G = new string[] { "r", "j", "’p", "k", "l" };

            foreach (string s1 in E)
            {
                foreach (string s2 in F)
                {
                    foreach (string s3 in G)
                    {
                        Console.WriteLine(s1 + s2 + s3);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
