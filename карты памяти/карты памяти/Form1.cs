using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace карты_памяти
{
    public partial class Form1 : Form
    {
        static Random rnd = new Random();
        int[] cards = new int [16];
        bool[] opens = new bool[16];
        int done;
        int status = 0;
        int card_a;
        int card_b;
         
        public Form1()
        {
            InitializeComponent();
            init_game();
        }

        private void Menu_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Menu_Rules_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"Право первого хода переходит по часовой стрелке от игрока к игроку. Каждый игрок обязан открыть 2 любых закрытых карты на столе. 
Если достоинства и масти открытых карт совпадают, то игроку засчитывается пара открытых карт, 
они остаются открытыми и право следующего хода остается за игроком, открывшим пару. В противном случае, 
карты переворачиваются рубашкой вверх (закрываются) и ход переходит к следующему игроку. 
После того, как все карты на столе будут открыты игра завершается и побеждает тот, 
кто больше всех открыл одинаковых пар карт.","Правила игры");
             
        }

        private void Menu_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"Учебный проект Шпака Сергея", "Что это такое.");
        }

        private void init_game()
        {
            for (int j = 0; j < cards.Length; j++)
                cards[j] = j % (cards.Length / 2) + 1;
            for (int j = 0; j < 100; j++)
                shuffle_cards();
            for (int j = 0; j < cards.Length; j++)
                load_picture(j, 1);
            for (int j = 0; j < cards.Length; j++)
                hide(j);
            for (int j = 0; j < cards.Length; j++)
                opens[j] = false;
            done = 0;
            status = 0;
        }
        private void shuffle_cards()
        {
            int a = rnd.Next(0, cards.Length);
            int b = rnd.Next(0, cards.Length);
            if (a == b) return;
            int x;
            x = cards[a];
            cards[a] = cards[b];
            cards[b] = x;
        }
        private void load_picture(int picture, int image)
        {
            get_picture_box(picture).Image = get_image(image);
        }
        private PictureBox get_picture_box(int picture)
        {
            switch (picture)
            {
                case 0: return pictureBox0;
                case 1: return pictureBox1;
                case 2: return pictureBox2;
                case 3: return pictureBox3;
                case 4: return pictureBox4;
                case 5: return pictureBox5;
                case 6: return pictureBox6;
                case 7: return pictureBox7;
                case 8: return pictureBox8;
                case 9: return pictureBox9;
                case 10: return pictureBox10;
                case 11: return pictureBox11;
                case 12: return pictureBox12;
                case 13: return pictureBox13;
                case 14: return pictureBox14;
                case 15: return pictureBox15;
                default: return null;

            }

        }
        private Image get_image(int index)
        {
            switch (index)
            {
                case 0: return Properties.Resources.zero;
                case 1: return Properties.Resources.one;
                case 2: return Properties.Resources.two;
                case 3: return Properties.Resources.three;
                case 4: return Properties.Resources.four;
                case 5: return Properties.Resources.five;
                case 6: return Properties.Resources.six;
                case 7: return Properties.Resources.srven;
                case 8: return Properties.Resources.height;
                default: return null;
            }

        }

        private void Menu_NewGame_Click(object sender, EventArgs e)
        {
            init_game();
        }
        private void show(int picture)
        {
            load_picture(picture, cards[picture]);
            get_picture_box(picture).Cursor = Cursors.Arrow;
        }
        private void hide (int picture)
        {
            load_picture(picture, 0);
            get_picture_box(picture).Cursor = Cursors.Hand;
        }
        private void open(int picture)
        {
            opens[picture] = true;
            show(picture);
        }
        private void status_0(int nr)
        {
            card_a = nr;
            show(card_a);
            status = 1;
        }
        private void status_1(int nr)
        {
            card_b = nr;
            if (card_a == card_b) return;
            show(card_b);
            status = 2;
            if (cards[card_a] == cards[card_b])
            {
                open(card_a);
                open(card_b);
                done += 2;
                if (done == 16)
                    winner();
                else
                    status = 0;
            }
            else status = 3;
        }
        private void status_2(int nr)
        {

        }
        private void status_3(int nr)
        {
            hide(card_a);
            hide(card_b);
            status_0(nr);
        }
        public void winner()
        {
            MessageBox.Show("Ты победил", "Поздравляю");
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            {
                int nr = int.Parse(((PictureBox)sender).Tag.ToString());

                if (opens[nr]) return;
                switch (status)
                {
                    case 0: status_0(nr); break;
                    case 1: status_1(nr); break;
                    case 2: status_2(nr); break;
                    case 3: status_3(nr); break;
                }
            }
        }
    }
}
