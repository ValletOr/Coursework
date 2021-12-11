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
        List<Particle> particles = new List<Particle>();

        private int MousePosX = 0;
        private int MousePosY = 0;

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            MousePosX = e.X;
            MousePosY = e.Y;
        }

        public void UpdateState()
        {
            foreach(var particle in particles)
            {
                particle.Life--;
                if(particle.Life < 0)
                {
                    particle.Life = 20 + Particle.rand.Next(100);

                    particle.X = MousePosX;
                    particle.Y = MousePosY;

                    float direction = (float)Particle.rand.Next(360);
                    float speed = 1 + (float)Particle.rand.Next(10);

                    particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
                    particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

                    particle.Radius = 1 + Particle.rand.Next(10);
                }
                else
                {
                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;
                }
            }
            for(int i = 0; i < 10; ++i)
            {
                if(particles.Count < 500)
                {
                    var particle = new ParticleColorful();
                    particle.Color1 = Color.DarkOrange;
                    particle.Color0 = Color.FromArgb(0, Color.DeepSkyBlue);
                    particle.X = MousePosX;
                    particle.Y = MousePosY;
                    particles.Add(particle);
                }
                else
                {
                    break;
                }
            }
        }

        public void Render(Graphics g)
        {
            foreach(var particle in particles)
            {
                particle.Draw(g);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            UpdateState();

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                Render(g);
            }

            picDisplay.Invalidate();
        }

    }
}
