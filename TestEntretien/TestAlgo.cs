using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace TestEntretien
{
    public class TestAlgo
    {

        /// <summary>
        /// grouper les anagrammes 
        /// 10 min
        /// </summary>
        public static void GroupAnagram()
        {
            Console.WriteLine("GroupAnagram start");
            string[] input = { "reza","eat", "tea", "tan", "ate", "nat", "bat", "bta", "azer" };

            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
            foreach(string s in input)
            {
                var word = s.ToCharArray();                        
                Array.Sort(word);
                
                string sortedWord = new string (word);
                            
                if(!result.ContainsKey(sortedWord))
                {
                    result.Add(sortedWord, new List<string>());
                }
                
                result[sortedWord].Add(s);
            }

            foreach(var entry in result)
            {
                Console.WriteLine(string.Join(',', entry.Value.ToArray()));
            }
        }

        public static void SortInt()
        {
            int[] numbers = Enumerable.Range(0, 10).OrderBy(xp => Guid.NewGuid()).ToArray();

            numbers = numbers.OrderBy(e => e).ToArray();
            Console.WriteLine(string.Join(",", numbers));
           
        }


        /// <summary>
        /// Reconstruire une liste en fusionnant les infos, de manière performante ( < 200ms pour 100_000 itérations)
        /// 10 min
        /// </summary>
        public static void PerfSeach()
        {
            int count = 100_000;
            IEnumerable<(string Id, string Name)> persons = Enumerable.Range(0, count)
                .Select(i =>  (i.ToString(), $"username_{i}"));

            IEnumerable<(string Id, string Email)> persons2 = Enumerable.Range(0, count)
                .Select(i => (i.ToString(),  $"mail_{i}@citeo.com" ));

            List<(string Id, string Email, string Name)> result = new List<(string Id, string Email, string Name)>();

            Stopwatch watch = Stopwatch.StartNew();

            // 
            Console.WriteLine(watch.Elapsed.TotalSeconds);


        }
    }
}
