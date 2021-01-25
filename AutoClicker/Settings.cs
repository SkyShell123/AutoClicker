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
        private Keys CurrentKey;

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
                int x = Cursor.Position.X;
                int y = Cursor.Position.Y;

                asd.numbersX.Add(x);
                asd.numbersY.Add(y);

                PointWindow.Text = PointWindow.Text + x + " " + y + "\n";
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {

        }
    }
}
