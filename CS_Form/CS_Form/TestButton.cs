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
        Form1 _form1;

        ///<summary>
        ///コンストラクタ
        ///クラスを生成したときに呼び出される
        ///</summary>
        public TestButton(Form1 form1, string  str, int x, int y, int width, int height)
        {
            _form1 = form1;

            //ClickイベントにOnClick関数を登録
            //ボタンをクリックスタ時に登録した関数を実行します。
           Click += OnClick;

            //ボタン内に文字を表示させる　顔文字も出せる
            Text = str.ToString();
           
           

            Location = new Point(x,y);//位置変更
            Size = new Size(width, height);
        }

        ///<summary>
        ///ボタンwクリックした際の処理を記述する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void OnClick(object sender, EventArgs e)
        {

         
            _form1.LabelTextUpdate(Text);
        }
    }
}
