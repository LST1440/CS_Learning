using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2
{
    public partial class Form1 : Form
    {
        private TextBox[] inputBoxes;
        void arrMin(int[] a, out int min)
        {
            min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                    min = a[i];
            }
        }
        public Form1()
        {
            InitializeComponent();
            inputBoxes = new TextBox[]
            {input1,input2,input3,input4,input5,input6};
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int min=0;
            int[] numbers = new int[6];

            for (int i = 0; i < inputBoxes.Length; i++)
            {
               if(!int.TryParse(inputBoxes[i].Text,out numbers[i]))
                {
                    MessageBox.Show($"第{i+1}個值輸入無效", "輸入錯誤",MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            }
        
            arrMin(numbers, out min);
            output.Text = "最小值:" + min.ToString();
            
        }
    }
}


/*private void button1_Click(object sender, EventArgs e)
{
    int min = 0;
    int[] numbers = new int[6];

    for (int i = 0; i < inputBoxes.Length; i++)
    {
        numbers[i] = Convert.ToInt32(inputBoxes[i].Text);
    }
    arrMin(numbers, out min);
    output.Text = "最小值:" + min.ToString();
}*/
//不能只有強制轉換，要設錯誤檢查