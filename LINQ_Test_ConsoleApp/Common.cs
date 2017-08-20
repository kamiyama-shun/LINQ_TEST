using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;

namespace LINQ_Test_ConsoleApp
{
    /// <summary>
    /// 汎用的メソッドの集まり
    /// </summary>
    static public class Common
    {
        /// <summary>
        /// イミディエイトウィンドウとコンソール画面へ文字列を出力（改行あり）
        /// </summary>
        /// <param name="msg">出力文字</param>
        static public void WriteLineMsg(string msg = "")
        {
            Debug.WriteLine(msg);
            WriteLine(msg);
        }

        /// <summary>
        /// イミディエイトウィンドウとコンソール画面へ文字列を出力（改行なし）
        /// </summary>
        /// <param name="msg">出力文字</param>
        static public void WriteMsg(string msg = "")
        {
            Debug.Write(msg);
            Write(msg);
        }

        /// <summary>
        /// コレクション内の整数を表示
        /// </summary>
        /// <param name="numbers">整数</param>
        /// <param name="title">タイトル</param>
        static public void WriteNumbers(IEnumerable<int> numbers, string title)
        {
            WriteMsg($"{title}：");
            foreach (var n in numbers)
                WriteMsg($" {n}");
            WriteLineMsg();
            WriteLineMsg();
        }
    }
}
