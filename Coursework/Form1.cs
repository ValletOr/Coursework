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
        public List<Emitter> emitters = new List<Emitter>();
        public Emitter emitter;
        public PainterPoint paint1;
        public PainterPoint paint2;

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            emitter = new WideEmitter
            {
                Width = picDisplay.Width,
                GravityY = 0.2f,
                ParticlesCount = 1000,
            };
            emitters.Add(emitter);

            paint1 = new PainterPoint
            {
                PointColor = Color.IndianRed,
                X = (picDisplay.Width / 2) - 200,
                Y = (picDisplay.Height / 2) - 100,
                Rad = 50,
            };

            paint2 = new PainterPoint
            {
                PointColor = Color.IndianRed,
                X = (picDisplay.Width / 2) + 200,
                Y = (picDisplay.Height / 2) - 100,
                Rad = 50,
            };

            emitter.impactPoints.Add(paint1);
            emitter.impactPoints.Add(paint2);

            XBar1.Maximum = picDisplay.Width;
            YBar1.Maximum = picDisplay.Height;
            XBar2.Maximum = picDisplay.Width;
            YBar2.Maximum = picDisplay.Height;
            XBar1.Value = (int)paint1.X;
            YBar1.Value = (int)paint1.Y;
            XBar2.Value = (int)paint2.X;
            YBar2.Value = (int)paint2.Y;
            RadBar1.Value = (int)paint1.Rad;
            RadBar2.Value = (int)paint2.Rad;
        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            //emitter.impactPoints[0].X = e.X;
            //emitter.impactPoints[0].Y = e.Y;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            foreach(var emitter in emitters)
            {
                emitter.UpdateState();

                using (var g = Graphics.FromImage(picDisplay.Image))
                {
                    g.Clear(Color.Black);
                    emitter.Render(g);
                }
            }

            picDisplay.Invalidate();
            CounterLabel.Text = emitter.particles.Count.ToString();
        }

        private void XBar1_Scroll(object sender, EventArgs e)
        {
            paint1.X = XBar1.Value;
        }

        private void YBar1_Scroll(object sender, EventArgs e)
        {
            paint1.Y = YBar1.Value;
        }

        private void RadBar1_Scroll(object sender, EventArgs e)
        {
            paint1.Rad = RadBar1.Value;
        }

        private void XBar2_Scroll(object sender, EventArgs e)
        {
            paint2.X = XBar2.Value;
        }

        private void YBar2_Scroll(object sender, EventArgs e)
        {
            paint2.Y = YBar2.Value;
        }

        private void RadBar2_Scroll(object sender, EventArgs e)
        {
            paint2.Rad = RadBar2.Value;
        }

        private void ColorPick1_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            paint1.PointColor = colorDialog.Color;
        }

        private void ColorPick2_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            paint2.PointColor = colorDialog.Color;
        }
    }
}
