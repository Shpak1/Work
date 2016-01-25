using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        int total_clicks = 10;
        int click_nr = -1;
        int reactime_ms = 0;
        int waiting = 0;
        int min_waiting = 1;
        int max_waiting = 3;
        int my_card_nr = 0;

        Stopwatch watch = new Stopwatch();
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            progressBar1.Maximum = total_clicks;
        }
        private void show_card(int nr)
        {
            picture1.Visible = nr == 1;
            picture2.Visible = nr == 2;
            picture3.Visible = nr == 3;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (click_nr < 0) return;
            if (waiting > 0)
            {
                waiting--;
                if (waiting == 0)
                {
                    my_card_nr = rand.Next(1, 4);
                    show_card(my_card_nr);
                    watch.Restart();
                }
            }

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            click_nr = 0;
            reactime_ms = 0;
            button_start.Visible = false;
            next_click();
        }
        private void next_click()
        {
            show_card(0);
            click_nr++;
            progressBar1.Value = click_nr;
            waiting = rand.Next(min_waiting * 1000 / timer1.Interval , 
                                max_waiting * 1000 / timer1.Interval);
        }

        private void picture2_Click(object sender, EventArgs e)
        {
            watch.Stop();
            reactime_ms = (int)watch.ElapsedMilliseconds;
            if (click_nr >= total_clicks)
                Showresults();
            else
                next_click();
        }
        private void Showresults()
        {
            double sec = reactime_ms / 100.0 / total_clicks;
            MessageBox.Show("Среднее время реакции" + sec.ToString(" 0.000") + " сек.", "Результат");
            button_start.Visible = true;
            click_nr = -1;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            set_comp_speed();
        }
        private void set_comp_speed()
        {
            if (trackBar1.Value == 1) timer1.Interval = 200;
            if (trackBar1.Value == 2) timer1.Interval = 100;
            if (trackBar1.Value == 3) timer1.Interval = 75;
            if (trackBar1.Value == 4) timer1.Interval = 50;
            if (trackBar1.Value == 5) timer1.Interval = 25;

        }
    }
}
