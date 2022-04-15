using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Drawing.Imaging;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screnshoter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;

        }

        public static void MakeScrenshot()
        {
            Rectangle bound = Screen.GetBounds(Point.Empty);
            using (var bitmap = new Bitmap(bound.Width, bound.Height))
            {
                using (var g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(Point.Empty, Point.Empty, bound.Size);
                }

                {
                    Random rnd = new Random();
                    bitmap.Save("Screnshot_"+ rnd.Next() + ".png", ImageFormat.Png);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakeScrenshot();
            MessageBox.Show("Скриншот готов", "ГОТОВО!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists("Screnshot_01.png"))
            {
                File.Delete("Screnshot_01.png");
            }
            else
            {
                MessageBox.Show("Скриншот не найден", "");
            }
        }
    }
}
