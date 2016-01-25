using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        string user_figure = "";
        string comp_figure = "";
        int score_win = 0;
        int score_lose = 0;
        int score_draw = 0;
        string mode = "show";

        Random rand = new Random();


        public Form1()
        {
            InitializeComponent();
            show_score();
            set_comp_speed();
        }

        private void start_game()
        {
            if (mode != "game")
            {
                label_messege.Text = "Выбери Свою Фигуру!";
                mode = "game";
            }
            
            
        }

        private void show_comp_figure(string figure)
        {
            comp_picture_stone.Visible = figure == "stone";
            comp_picture_scissors.Visible = figure == "scissors";
            comp_picture_paper.Visible = figure == "paper";
            comp_figure = figure;
        }
        private void show_user_figure(string figure)
        {
            start_game();
            picture_stone.Visible = figure == "stone";
            picture_scissors.Visible = figure == "scissors";
            picture_paper.Visible = figure == "paper";
            user_figure = figure;
        }
        private void user_panel_stone_MouseEnter(object sender, EventArgs e)
        {
            show_user_figure("stone");

        }

        private void user_panel_scissors_MouseEnter(object sender, EventArgs e)
        {
            show_user_figure("scissors");
        }

        private void user_panel_paper_MouseEnter(object sender, EventArgs e)
        {
            show_user_figure("paper");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mode == "game")
                use_comp_random_figure();
        }
        private void use_comp_random_figure()
        {

 
            int f = rand.Next(1, 4);
            if (f == 1) show_comp_figure("stone");
            if (f == 2) show_comp_figure("scissors");
            if (f == 3) show_comp_figure("paper");
        
        }
        void show_score()
        {
            label_score.Text = "Побед " + score_win.ToString() + 
                "   Поражений " + score_lose.ToString()+
                "   Ничья " + score_draw.ToString();


        }

        private void picture_stone_Click(object sender, EventArgs e)
        {
            if (mode == "game")
                check_result();
            else
                start_game();
        }
        private void check_result()
        {
            mode = "show";
            int wins = 0;
            int lose = 0;
            int draw = 0;
            if (user_figure == comp_figure)
                draw = 1;
            else
            {
                if (user_figure == "stone")
                    if (comp_figure == "scissors")
                        wins = 1;
                    else
                        lose = 1;
                if (user_figure == "scissors")
                    if (comp_figure == "paper")
                        wins = 1;
                    else
                        lose = 1;
                if (user_figure == "paper")
                    if (comp_figure == "stone")
                        wins = 1;
                    else
                        lose = 1;
            }
            score_win += wins;
            score_lose += lose;
            score_draw += draw;
            if (wins > 0)
                label_messege.Text = "Победа";
            if (lose > 0)
                label_messege.Text = "Поражение";
            if (draw > 0)
                label_messege.Text = "Ничья";
            show_score();
        }

        private void trackBar_speed_ValueChanged(object sender, EventArgs e)
        {
            set_comp_speed();
        }
        private void set_comp_speed()
        {
            if (trackBar_speed.Value == 1) timer1.Interval = 1000;
            if (trackBar_speed.Value == 2) timer1.Interval = 900;
            if (trackBar_speed.Value == 3) timer1.Interval = 700;
            if (trackBar_speed.Value == 4) timer1.Interval = 600;
            if (trackBar_speed.Value == 5) timer1.Interval = 500;
            if (trackBar_speed.Value == 6) timer1.Interval = 400;
            if (trackBar_speed.Value == 7) timer1.Interval = 300;
            if (trackBar_speed.Value == 8) timer1.Interval = 200;
            if (trackBar_speed.Value == 9) timer1.Interval = 100;
            if (trackBar_speed.Value == 10) timer1.Interval = 1;
        }

    }
}
