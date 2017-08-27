using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Test_ConsoleApp
{
    class SampleVar
    {

        public void test1()
        {

            // ① var は変数の型を推論してくれる
            var a = 1; // a は int になる。

            // ② 暗黙的配列
            var b1 = new int[] { 1, 2, 3 };
            var b2 = new[] { 1, 2, 3 };

            // ③ 匿名型 <Anonymous Type> という型になる
            var c = new { x = 1, y = 3 };

            // NG例
            // var d; // ※初期値が必要なのでこのようには記載できない

            #region サンプル1
            // var を使って短くコードを書いた - 例1
            var abc1 = new Dictionary<string, string>();

            // 通常はこのように書く - 例2
            Dictionary<string, string> abc2 = new Dictionary<string, string>();
            #endregion


            #region サンプル2 （極端な例）
            var var3 = new テストAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA();
            テストAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA aaa = new テストAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA();

            // 右辺でどの型を使ってるか分かるので、インテリセンスでプロパティが表示できる。
            var3.val1 = "a";
            aaa.val1 = "a";
            #endregion
        }


        private class テストAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
        {
            // 自動実装プロパティ
            public string val1 { get; set; }
            public string val2 { get; set; }
        }

    }
}
