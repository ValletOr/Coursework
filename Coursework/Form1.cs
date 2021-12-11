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
        //public Emitter emitter2 = new Emitter();
        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            //emitter2.PosX = picDisplay.Width / 2;
            //emitter2.PosY = picDisplay.Height / 2;
            emitter1.impactPoints.Add(new GravityPoint
            {
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
                Power = 500,
            });
        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            emitter1.PosX = e.X;
            emitter1.PosY = e.Y;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            emitter1.UpdateState();
            //emitter2.UpdateState();

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter1.Render(g);
                //emitter2.Render(g);
            }

            picDisplay.Invalidate();
        }

    }
}
