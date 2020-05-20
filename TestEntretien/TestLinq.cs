using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestEntretien
{
    public class TestLinq
    {
        public static void Sum2List()
        {
            Dictionary<string, int> a = new Dictionary<string, int>()
            {
                {"a",1 },{"b",10},{"c",45}
            };

            Dictionary<string, int> b = new Dictionary<string, int>()
            {
                {"a",10 },{"c",22},{"b",7896}
            };
            
            var res = a.Concat(b).GroupBy(e => e.Key).Select(e => new 
            { 
                Key = e.Key,
                Sum = e.Sum(a => a.Value) 
            })
            .ToDictionary(e => e.Key, y => y.Sum);
            
            foreach(var entry in res)
            {
                Console.WriteLine(string.Join(',', entry.Value));
            }
        }

        /// <summary>
        /// retourner la liste des sommes de chaque index des 3 listes
        /// </summary>
        public static void IndexAddition()
        {
            List<List<int>> datas = new List<List<int>>()
            {
                new List<int>() { 1, 10, 20, 30, 45, 75 },
                new List<int>() { 45, 2, 1, 4, 2, 2 },
                // new List<int>() { 45, 2, 1, 4, 2, 2, 100 }, how to handle different size ...
                new List<int>() { 45, 2, 1, 4, 2, 2 }
            };
            
            var res = datas.SelectMany(x => x)  
                   .Select((v, i) => new { Value = v, Index = i % 6 })
                   .GroupBy(x => x.Index).Select(y => y.Sum(z => z.Value));

        }

        /// <summary>
        /// Fusionner toutes les intervalles qui se chevauchent, en utilisant LINQ
        /// </summary>
        public static void MergeInterval()
        {
            List<int[]> intervals = new List<int[]>()
            {
                new int[]{ 1, 3 },
                new int[]{ 2, 6},
                new int[]{ 8, 10 },
                new int[]{ 15, 18 },
                new int[]{ 16, 19 },
                new int[]{ 17, 25 },
            };
            List<int[]> result = new List<int[]>();
            int index = 0;
        }

        private static int getValue(int[] intArray, int index)
        {
            int end = 0;
            if(intArray != null && intArray[index + 1] != null)
            {
                end = getValue(intArray, index);
            }
            return end;
        }
    }
}
