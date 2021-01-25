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
        Form1 asd = new Form1();
        bool isPress = false;
        private Keys CurrentKey = Keys.L;

        public Settings()
        {
            InitializeComponent();

            this.KeyUp += new KeyEventHandler(OKP);
        }

        private void KeySelect_Click(object sender, EventArgs e)
        {

            //CurrentKey = e.KeyUp;

        }

        private void RecButt_Click(object sender, EventArgs e)
        {
            if (!isPress)
            {
                isPress = true;
                KeyPreview = true;
            }
            else
            {
                isPress = false;
                KeyPreview = false;
            }
        }

        private void OKP(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == CurrentKey)
            {
                int x1 = Cursor.Position.X;
                int y1 = Cursor.Position.Y;

                asd.numbersX.Add(x1);
                asd.numbersY.Add(y1);

                asd.label1.Text = asd.label1.Text + x1 + " " + y1 + "\n";

                PointWindow.Text = PointWindow.Text + x1 + " " + y1 + "\n";
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            asd.Message();
        }
    }
}
