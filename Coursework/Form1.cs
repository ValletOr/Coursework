using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Form1 : Form
    {
        public Emitter emitter1 = new Emitter();
        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            emitter1.MousePosX = e.X;
            emitter1.MousePosY = e.Y;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            emitter1.UpdateState();

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter1.Render(g);
            }

            picDisplay.Invalidate();
        }

    }
}
