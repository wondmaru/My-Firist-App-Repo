using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Advanced
{
    public class LinqExamples
    {
        public void SomeLinq()
        {
            string[] names = { "Tom", "David", "Sarah", "mindy" };
            IEnumerable<string> query = names
                .Where(n => n.Contains("m"))
                .OrderBy(n => n.Length)
                .Select(n => n.ToUpper());
            foreach (string name in query)
            {
                Console.WriteLine(name);
            }
        }
    }
}
