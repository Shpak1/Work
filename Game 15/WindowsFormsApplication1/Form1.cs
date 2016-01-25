using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Game game;
        int counter = 0;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            game = new Game(4);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int position = Convert.ToInt16(((Button)sender).Tag);
            game.shift(position);
            refresh();
            if (game.Chesk_number())
            {
                timer.Enabled = false;
                MessageBox.Show("Вы победили", "Победа!");
                start_game();
            }
            
        }
        private Button button(int position)
        {
            switch (position)
            {
                case 0: return button1;
                case 1: return button2;
                case 2: return button3;
                case 3: return button4;
                case 4: return button5;
                case 5: return button6;
                case 6: return button7;
                case 7: return button8;
                case 8: return button9;
                case 9: return button10;
                case 10: return button11;
                case 11: return button12;
                case 12: return button13;
                case 13: return button14;
                case 14: return button15;
                case 15: return button16;
                default: return null;

            }
     }

        private void menu_start_Click(object sender, EventArgs e)
        {
            start_game();
            timer.Enabled = true;
        }
        public void start_game()
        {
            i = 0;
            counter = 0;
            label1.Text = "Количество очков = " + counter.ToString();
            label2.Text = "Время " + i.ToString();
            game.start();
            for (int j = 0; j < 100; j++)
                game.shift_random();
            refresh();
        }
        private void refresh()
        {
            for (int position = 0; position < 16; position++)
            {
                int nr = game.get_number(position);
                button(position).Text = nr.ToString();
                button(position).Visible = (nr > 0);
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

            counter++;
            label1.Text = "Количество очков = " + counter.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            i++;
            label2.Text = "Время " + i.ToString();
        }
    }
}
