using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        int count;
        int min = 1;
        int max = 20;
        int count_max = 3;
        Random rnd = new Random();
        string answer;
        string mode = "";

        public Form1()
        {
            InitializeComponent();
            text_max.Text = max.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            start_game("plus");
        }
        private void start_game(string my_mode)
        {
            mode = my_mode;
            button_plus.Enabled = false;
            button_minus.Enabled = false;
            button_multip.Enabled = false;
            button_div.Enabled = false;
            text_max.Enabled = false;
            label_work.Enabled = true;
            text_decision.Enabled = true;
            label_counter.Text = "";
            label_work.Text = "";
            text_decision.Text = "";
            count = 0;
            progress.Minimum = 0;
            progress.Maximum = count_max;
            progress.Value = 0;
            try
            {
                max = Convert.ToInt16(text_max.Text);
            }
            catch
            {
                max = 10;
                text_max.Text = max.ToString();
            }
            think();
        }
        private void think()
        {
            if (count == count_max)
            {
                counter();
                gamewin();
                return;
            }
            int a, b;
            a = rnd.Next(min, max + 1);
            b = rnd.Next(min, max + 1);

            if (mode == "plus")
            {
                label_work.Text = a.ToString() + " + " + b.ToString() + " = ";
                answer = (a + b).ToString();
            }
            if (mode == "minus")
            {
                if (a < b)
                {
                    int x = a;
                    a = b;
                    b = x;
                }
                label_work.Text = a.ToString() + " – " + b.ToString() + " = ";
                answer = (a - b).ToString();
            }
            if (mode == "multip")
            {
                label_work.Text = a.ToString() + " * " + b.ToString() + " = ";
                answer = (a * b).ToString();
            }
            if (mode == "division")
            {
                label_work.Text = (a * b).ToString() + " : " + b.ToString() + " = ";
                answer = (a).ToString();
            }
            counter();
            count++;

        }

        private void text_decision_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(text_decision.Text == answer)
                {
                    text_decision.Text = "";
                    progress.Value = count;
                    think();
                }else
                    gameover();
            }  
        }
        private void gameover()
        {
            text_decision.Text = answer;
            button_plus.Enabled = true;
            label_work.Enabled = false;
            text_decision.Enabled = false;
            button_plus.Enabled = true;
            button_minus.Enabled = true;
            button_multip.Enabled = true;
            button_div.Enabled = true;
            text_max.Enabled = true;
            button_plus.Focus();
        }
        private void gamewin()
        {
            MessageBox.Show("Молодец, просто гений", "Победа!");
            button_plus.Enabled = true;
            button_minus.Enabled = true;
            button_multip.Enabled = true;
            button_div.Enabled = true;
            text_max.Enabled = true;
            label_work.Text = "";
            text_decision.Text = "";
            label_counter.Text = "";
            button_plus.Focus();
         }

        private void button_minus_Click(object sender, EventArgs e)
        {
            start_game("minus");
        }

        private void button_multip_Click(object sender, EventArgs e)
        {
            start_game("multip");
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            start_game("division");
        }
        private void counter()
        {
            int counter = (count_max - count);
            label_counter.Text = ("Осталось попыток ").ToString() + counter.ToString();
        }
    }
}
