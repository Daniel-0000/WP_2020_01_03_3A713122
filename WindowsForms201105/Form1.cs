using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms201105.Properties;

namespace WindowsForms201105
{
    public partial class Form1 : Form
    {
        List<Image> list = new List<Image>();
        List<string> text1 = new List<string>();
        




        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int randomNum = new Random().Next(12);
            pictureBox3.Image = list[randomNum];
            richTextBox1.Text = text1[randomNum];
        }

        

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            list.Add(Resources.優質_201105_0);
            list.Add(Resources.優質_201105_1);
            list.Add(Resources.優質_201105_2);
            list.Add(Resources.優質_201105_3);
            list.Add(Resources.優質_201105_4);
            list.Add(Resources.優質_201105_5);
            list.Add(Resources.優質_201105_6);
            list.Add(Resources.優質_201105_7);
            list.Add(Resources.優質_201105_8);
            list.Add(Resources.優質_201105_9);
            list.Add(Resources.優質_201105_10);
            list.Add(Resources.優質_201105_11);


            text1.Add("我先去洗澡了");
            text1.Add("你是好人");
            text1.Add("我們還是可以當朋友");
            text1.Add("你是我最好的朋友");
            text1.Add("你人其實還不錯");
            text1.Add("你跟我星座不合");
            text1.Add("我媽說不喜歡你");
            text1.Add("我家的狗討厭你");
            text1.Add("媽祖昨天託夢跟我說的");
            text1.Add("你人很好");
            text1.Add("我們比較適合當朋友");
            text1.Add("謝謝你的好意");
        }
    }
}
