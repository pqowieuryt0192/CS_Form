using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        TestLabel _testLabel;
        TestTextBox _textBox;
        public Form1()
        {
            InitializeComponent();

            string[] strs =
           {
                "あか",
                "あお", 
                "きいろ",
                "くろ",
                "むらさき",
               "しろ",
               "みどり",
               "ピンク",
               "ちゃいろ",
               "グレー",


            };

            //while (true) 何回ループするか、わからないときにつかう 

            for (int i = 0; i < 10; i++)
            {
                TestButton testButton = new TestButton(this,strs[i] , (i % 3) *  100,(i/3) * 100, 100, 100);
                Controls.Add(testButton);

            }         
            
            _testLabel =
                new TestLabel("ラベルです",100,300,100,500);
            Controls.Add(_testLabel);

            _textBox = new TestTextBox("テキストボックスです",200,350,200,200);
            Controls.Add(_textBox);

            /// Label label = new Label();
            /// label.Location = new Point(30,400);
            /// label.Text = "ラベルです";
            ///  Controls.Add(label);


        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public void LabelTextUpdate(string str)
        { 
            _testLabel.TextUpdate (str);
        }
    }
}
