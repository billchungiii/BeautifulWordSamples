using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWordSample003
{

    /// <summary>
    /// 稍微改一下 Sample002 的作法，不用減法，直接用關係比較
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
                             var result = count > current;
                             current = count;
                             return result;
                         })
                         .All(x => x);
        }
    }
}
