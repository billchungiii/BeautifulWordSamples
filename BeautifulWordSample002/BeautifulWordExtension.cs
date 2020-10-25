using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BeautifulWordSample002
{
    /// <summary>
    /// 如果沒有非得要限制成一行做完
    /// </summary>
    public static class BeautifulWordExtension
    {
        public static bool IsBeautiful(this string source)
        {
            int current = 0;

            return source.ToLower()
                         .OrderByDescending(x => x)
                         .GroupBy(x => x)
                         .Select(x =>
                         {
                             var count = x.Count();
                             var result = count - current;
                             current = count;
                             return result;
                         })
                         .All(x => x > 0);
        }
    }
}
