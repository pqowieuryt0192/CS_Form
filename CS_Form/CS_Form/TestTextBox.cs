using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
     class TestTextBox : TextBox
    {
        public TestTextBox(string str, int x, int y, int width, int height)
        {
            //ラベル内に文字を表示させる
            Text = str;


            Location = new Point(x, y);//ボタンの位置変更
            Size = new Size(width, height);//ボタンの大きさの設定
        }
        /// <summary>
        /// ラベルの文字更新関数
        /// </summary>
        /// <param name="str"></param>
    }
}
