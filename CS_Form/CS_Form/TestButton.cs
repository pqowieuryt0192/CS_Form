using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace CS_Form
{
    class TestButton : Button
    {
        ///<summary>
        ///コンストラクタ
        ///クラスを生成したときに呼び出される
        ///</summary>
        public TestButton(int x, int y)
        {
            

            //ClickイベントにOnClick関数を登録
            //ボタンをクリックスタ時に登録した関数を実行します。
            Click += OnClick;
            //ボタン内に文字を表示させる　顔文字も出せる
            Text = "押すの!?Σ(･ω･ﾉ)ﾉ！";

            Location = new Point(x,y);
        }

        ///<summary>
        ///ボタンwクリックした際の処理を記述する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void OnClick(object sender, EventArgs e)
        {
            MessageBox.Show("☜(´・ω・｀)");
        }
    }
}
