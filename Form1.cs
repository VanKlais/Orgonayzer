using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RlE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
           // string work = textBox1.Text;
            int k = 1;
            for (int i = 0; i < text.Length; i++)
            {
                if ((i < text.Length - 1) && (text[i] == text[i + 1]))
                {
                    k++;
                }
                else
                {
                    if ((k > 2))
                    {
                        textBox2.Text += $"*{k}{text[i]}";
                    }
                    else for (int j = 0; j < k; j++)
                        {
                            textBox2.Text += Convert.ToString(text[i]);
                        }
                    k = 1;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            int k = 1;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]=='*')
                {
                    for (int j = 0; j < Convert.ToInt32(Convert.ToString(text[i+1])); j++)
                    {
                        textBox3.Text += Convert.ToString(text[i+2]);
                    }
                    i += 2;
                }
                else
                {
                    textBox3.Text += Convert.ToString(text[i]);
                }
            }
        }
    }
}
