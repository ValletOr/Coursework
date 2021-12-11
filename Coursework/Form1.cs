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
        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            /*
            emitter1 = new WideEmitter
            {
                Width = picDisplay.Width,
                GravityY = 0.2f,
            };*/
            emitter = new Emitter();

            emitter.impactPoints.Add(new GravityPoint
            {
                X = picDisplay.Width /1.5f,
                Y = picDisplay.Height / 2,
                Power = 150,
            });

            emitter.impactPoints.Add(new GravityPoint
            {
                X = picDisplay.Width / 4,
                Y = picDisplay.Height / 2,
                Power = 150,
            });

            emitter.impactPoints.Add(new AntiGravityPoint
            {
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
                Power = 200,
            });

            emitters.Add(emitter);
        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            emitter.X = e.X;
            emitter.Y = e.Y;
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
            label1.Text = emitter.particles.Count.ToString();
        }

    }
}
