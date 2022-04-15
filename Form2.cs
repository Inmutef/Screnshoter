using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screnshoter
{
    public partial class Form2 : Form
    {
        public static Image[] res = new Image[1];

        public Form2()
        {
            InitializeComponent();
            openFileDialog1.Filter = "PNG | *.png";
            openFileDialog1.FileName = null;
            MaximizeBox = false;
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            res[0] = Image.FromFile(openFileDialog1.FileName);
            pictureBox1.Image = res[0];
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i > 1; i++)
            {
                res[i] = null;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
