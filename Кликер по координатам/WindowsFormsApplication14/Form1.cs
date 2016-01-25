using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            text_x.Text = "";
            text_y.Text = "";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            int x, y;
            x = Cursor.Position.X;
            y = Cursor.Position.Y;
            text_x.Text += x.ToString() + Environment.NewLine;
            text_y.Text += y.ToString() + Environment.NewLine;
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public void DoMouseClick(int x, int y)
        {
            //Call the imported function with the cursor's current position
            Cursor.Position = new Point(x, y);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)x, (uint)y, 0, 0);
        }

        private void buttonrepeat_Click(object sender, EventArgs e)
        {
            int x, y;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 0; j < text_x.Lines.Length - 1; j++)
                {
                    x = Convert.ToInt16(text_x.Lines[j]);
                    y = Convert.ToInt16(text_y.Lines[j]);
                    DoMouseClick(x, y);
                }

            }
            }
    }
}
