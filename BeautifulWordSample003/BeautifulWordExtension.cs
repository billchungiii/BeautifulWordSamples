using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWordSample003
{
    public static class BeautifulWordExtension
    {
        /// <summary>
        /// 002 的 減法改為關係運算子
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsBeautiful(this string source)
        {
            int last = 0;

            return source.ToLower()
                         .OrderByDescending(x => x)
                         .GroupBy(x => x)
                         .Select(x =>
                         {
                             var count = x.Count();
                             var result = count > last;
                             last = count;
                             return result;
                         })
                         .All(x => x);
        }
    }
}
