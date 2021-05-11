using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class Settings : Form
    {
        bool isPress = false;
        private Keys CurrentKey;

        public List<int> numbersX = new List<int>();
        public List<int> numbersY = new List<int>();
        public string qwe;
        public int Time_delay;
        public int Cycles;



        public Settings()
        {
            InitializeComponent();

            
            CurrentKey = Keys.L;
            KeySelect.Text = CurrentKey.ToString();
        }

        private void KeySelect_Click(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            KeySelect.Text = "???";
            this.KeyDown += new KeyEventHandler(KeySelect_KeyDown);
        }

        private void KeySelect_KeyDown(object sender, KeyEventArgs e)
        {
            CurrentKey = e.KeyCode;
            KeySelect.Text = CurrentKey.ToString();
            this.KeyPreview = false;
        }

        private void RecButt_Click(object sender, EventArgs e)
        {
            if (!isPress)
            {
                isPress = true;
                RecButt.Text = "Стоп";
                this.KeyPreview = true;
                this.KeyDown += new KeyEventHandler(RecButt_KeyDown);
            }
            else
            {
                isPress = false;
                this.KeyPreview = false;
                RecButt.Text = "Запись";
            }
        }

        private void RecButt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == CurrentKey)
            {
                
                int x = Cursor.Position.X;
                int y = Cursor.Position.Y;

                numbersX.Add(x);
                numbersY.Add(y);

                qwe = qwe + x + " " + y + "\n";

                PointWindow.Text = PointWindow.Text + x + " " + y + "\n";
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Time_delay = Convert.ToInt32(textBox1.Text);
            Cycles= Convert.ToInt32(textBox2.Text);
        }
    }
}
