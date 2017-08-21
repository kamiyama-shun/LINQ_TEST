using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Test_ConsoleApp
{
    class SampleNull
    {
        // TODO どちらかをコメントにしてデバッグしてね。
        private Point point = null;
        //private Point point = new Point();

        /// <summary>
        /// 条件演算子、null合体演算子、null条件演算子
        /// ロジックの書き方について学習
        /// </summary>
        public void Test1()
        {
            var list = new List<int> { 10, 20, 30, 40 };

            #region 条件演算子
            // 条件演算子（例1）
            var num = list.Contains(10) ? 1 : 0;

            // 条件演算子（例2）
            if (list.Contains(10))
                num = 1;
            else
                num = 0;
            #endregion

            #region null合体演算子
            // null合体演算子（例1） ※引数は適当
            var msg = GetMsg("E0001");
            if (msg == null)
                msg = DefaultMsg();

            // null合体演算子（例2） ※引数は適当
            var msg2 = GetMsg("E0001") ?? DefaultMsg();
            #endregion

            #region null条件演算子
            // TODO 各メソッドの処理内を比較してね。
            string x = GetPointX();
            string y = GetPointY();
            #endregion

        }

        /// <summary>
        /// 例で使用するスタブ１
        /// </summary>
        /// <param name="code">メッセージコード（仮）</param>
        /// <returns></returns>
        public object GetMsg(string code)
        {
            return null;
        }

        /// <summary>
        /// 例で使用するスタブ２
        /// </summary>
        /// <returns></returns>
        public object DefaultMsg()
        {
            return new object();
        }

        /// <summary>
        /// 例で使用するスタブ３
        /// </summary>
        /// <returns></returns>
        private string GetPointX()
        {
            if (point == null)
                return null;
            else
                return point.x;
        }

        /// <summary>
        /// 例で使用するスタブ４
        /// </summary>
        /// <returns></returns>
        private string GetPointY()
        {
            return point?.y;
        }

        /// <summary>
        /// 例で使用するインナークラス
        /// </summary>
        class Point
        {
            public string x { get; set; }
            public string y { get; set; }
        }
    }
}
