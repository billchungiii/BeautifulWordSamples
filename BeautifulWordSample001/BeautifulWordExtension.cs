using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWordSample001
{
    public static class BeautifulWordExtension
    {
        public static bool IsBeautiful(this string source) =>
            Enumerable.Repeat(source.ToLower().OrderBy(x => x).GroupBy(x => x).Select(x => x.Count()), 2)
                      .Aggregate((x, y) => x.Zip(y.Skip(1), (a, b) => a - b))
                      .All(x => x > 0);
    }
}
