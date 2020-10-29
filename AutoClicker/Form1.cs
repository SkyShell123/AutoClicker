using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WindowsInput;

namespace AutoClicker
{
    public partial class Form1 : Form
    {
        int qwe = 0;
        int CountClick = 700;
        private readonly Timer tmrShow;
        private readonly Timer ClickShow;
        private readonly Timer TimeShow;
        bool isPress = false;
        bool isPressqwe = false;
        List<int> numbersX = new List<int>();
        List<int> numbersY = new List<int>();

        public Form1()
        {
            InitializeComponent();

            tmrShow = new Timer();
            tmrShow.Interval = 3000;
            tmrShow.Tick += tmrShow_Tick;

            ClickShow = new Timer();
            ClickShow.Interval = 40000;
            ClickShow.Tick += ClickShow_Tick;

            TimeShow = new Timer();
            TimeShow.Interval = 1;
            TimeShow.Tick += Time_Tick;
        }

        private void tmrShow_Tick(object sender, EventArgs e)
        {
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;

            numbersX.Add(x);
            numbersY.Add(y);

            label1.Text = label1.Text + x + " " + y + "\n";
            
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            if (isPress)
            {
                TimeShow.Interval = 1000;
                if (qwe < tmrShow.Interval / 1000 + 1)
                {
                    label2.Text = (tmrShow.Interval / 1000 - qwe).ToString();
                    qwe++;
                }
                else
                {
                    qwe = 1;
                    TimeShow.Interval = 1;
                }
            }
            else if(isPressqwe)
            {
                TimeShow.Interval = 1000;
                if (qwe < ClickShow.Interval / 1000 + 2)
                {
                    label2.Text = (ClickShow.Interval / 1000 - qwe + 1).ToString();
                    qwe++;
                }
                else
                {
                    qwe = 2;
                    TimeShow.Interval = 1;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isPress)
            {
                tmrShow.Enabled = true;
                TimeShow.Enabled = true;
                isPress = true;
                button1.Text = "Стоп";
            }
            else
            {
                tmrShow.Enabled = false;
                isPress = false;
                button1.Text = "Запись";
                TimeShow.Enabled = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (isPressqwe)
            {
                ClickShow.Enabled = false;
                TimeShow.Enabled = false;
                button2.Text = "Пуск";
                isPressqwe = false;
            }
            else
            {
                TimeShow.Enabled = true;
                button2.Text = "Стоп";
                isPressqwe = true;

                if (numbersX.Count > 0)
                {
                    if (isPress)
                    {
                        tmrShow.Enabled = false;
                        isPress = false;
                        button1.Text = "Запись";
                        TimeShow.Enabled = false;
                    }

                    ClickOwer();
                    ClickShow.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Сначала выполните запись!");
                }
            }
        }

        private void ClickShow_Tick(object sender, EventArgs e)
        {
            if (CountClick > 0)
            {
                ClickOwer();
            }
            else
            {
                ClickShow.Enabled = false;
            }
        }

        void ClickOwer()
        {
            for (int i = 0; i < numbersX.Count; i++)
            {
                int x = numbersX.ElementAt(i);
                int y = numbersY.ElementAt(i);

                Cursor.Position = new Point(x, y);

                var sim = new InputSimulator();
                sim.Mouse.LeftButtonClick();
                
            }
            CountClick--;
            label3.Text = CountClick.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isPress)
            {
                tmrShow.Enabled = false;
                isPress = false;
                button1.Text = "Запись";
                TimeShow.Enabled = false;
            }

            numbersX.Clear();
            numbersY.Clear();
            label1.Text = "";
        }
    }
}
