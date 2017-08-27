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
        static SampleNull sampleNull = new SampleNull();
        static SampleVar sampleVar = new SampleVar();
  
        /// <summary>
        /// エントリ
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // デバッグ用メッセージサンプル
            //MsgSample(args);

            // LINQ Takeのサンプル
            //linqTake.Test1();

            // 条件演算子、null合体演算子、null条件演算子のサンプル
            //sampleNull.Test1();

            // var のサンプル
            sampleVar.test1();

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

        /// <summary>
        /// WriteLine 新旧サンプル
        /// </summary>
        static void WriteSample()
        {
            string str1 = "8";
            string str2 = "27";

            // 古い書き方
            WriteLine("今日は{0}月の{1}日です。", str1, str2);

            // 新しい書き方
            WriteLine($"今日は{str1}月の{str2}日です。");
        }

        /// <summary>
        /// コメント・トークンの例
        /// </summary>
        static void CommentSample()
        {
            // TODOこれは表示されない
            // TODO:これは表示される

            // 参考：https://www.slideshare.net/ssagawa/ss-14579535　P37

            // TODO: 未実装のため、新たにコードを追加する必要がある個所。

            // HACK: 実装済みだが、コードをさらに改善する必要がある個所。

            // UNDONE: 未完成のため、さらにコードを編集する必要がある個所。

            // UnresolvedMergeConflict コードのマージ（統合）に失敗した場合に追加されるトークン。
        }
    }
}
