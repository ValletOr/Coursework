using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Coursework
{
    public class Emitter
    {
        List<Particle> particles = new List<Particle>();
        public int MousePosX = 0;
        public int MousePosY = 0;

        //Обновляем состояние частиц
        public void UpdateState()
        {
            foreach (var particle in particles)
            {
                particle.Life--;
                if (particle.Life < 0)
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
            for (int i = 0; i < 10; ++i)
            {
                if (particles.Count < 500)
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

        //Отрисовываем частицы
        public void Render(Graphics g)
        {
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }
        }
    }
}
