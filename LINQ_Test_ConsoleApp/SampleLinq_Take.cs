using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Test_ConsoleApp
{
    class SampleLinq_Take
    {
        /// <summary>
        /// 条件を満たす要素をn個取得する
        /// </summary>
        public void Test1()
        {
            var numbers = new List<int> { 9, 7, -5, -4, 2, 5, 4, 0, -4, 8, -1, 0, 4 };

            var result = numbers.Where(n => n > 0).Take(5);
            Common.WriteNumbers(result, "条件（n > 0）を満たす要素（先頭5個まで）");

            result = numbers.Where(n => n > 0);
            Common.WriteNumbers(result, "条件（n > 0）を満たす要素（全て）");
        }
    }
}
