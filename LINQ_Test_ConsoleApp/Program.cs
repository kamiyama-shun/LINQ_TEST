using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LINQ_Test_ConsoleApp
{
    class Program
    {
        static SampleLinq_Take linqTake = new SampleLinq_Take();

        /// <summary>
        /// エントリ
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // デバッグ用メッセージサンプル
            //MsgSample(args);

            // LINQ Takeのサンプル
            linqTake.Test1();


            // 後処理
            End();
        }

        /// <summary>
        /// デバッグ用メッセージサンプル
        /// </summary>
        /// <param name="args"></param>
        static void MsgSample(string[] args)
        {
            Common.WriteLineMsg("開始");

            Common.WriteLineMsg($"引数の数は{args.Length}個です。");

            Common.WriteLineMsg("終了");
        }

        /// <summary>
        /// 後処理
        /// </summary>
        static void End()
        {
            // コンソール画面がすぐに閉じないようにする為の対応
            // DebugとReleaseでコードが変化
            #if DEBUG
            Common.WriteLineMsg("プログラムを終了します。何かキーを押してください。");
            ReadKey();
            #endif
        }
    }
}
