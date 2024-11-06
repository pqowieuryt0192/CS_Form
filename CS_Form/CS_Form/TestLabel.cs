using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace CS_Form
{
    internal class TestLabel : Label
    {
        public TestLabel(string str, int x, int y, int width, int height)
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
        public void TextUpdate(string str)
        { 
            Text = str;
        }

        
    }
}
