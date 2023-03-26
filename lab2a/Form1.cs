using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Bitmap b1 = new Bitmap(@"C:\Users\anied\OneDrive\Pulpit\obraz.png");
            Bitmap b2 = new Bitmap(2*b1.Width-1,b1.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics g = CreateGraphics();
            g.DrawImage(b1, 0, 0);

            for (int x = 0; x < b1.Width; x++)
            {
                for (int y = 0; y < b1.Height; y++)
                {
                    b2.SetPixel(x + b1.Width - (y+1), y, b1.GetPixel(x, y));
                   
                }

                
            }
            g.DrawImage(b2, 0, 0);





        }
    }
}
