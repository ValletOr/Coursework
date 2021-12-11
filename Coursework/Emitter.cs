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
        public List<Particle> particles = new List<Particle>();
        public List<ImpactPoint> impactPoints = new List<ImpactPoint>();
        public int PosX = 0;
        public int PosY = 0;

        public float GravityX = 0;
        public float GravityY = 1;

        public int ParticlesCount = 500;

        //Обновляем состояние частиц
        public void UpdateState()
        {
            foreach (var particle in particles)
            {
                particle.Life--;
                if (particle.Life < 0)
                {
                    particle.Life = 20 + Particle.rand.Next(100);

                    particle.X = PosX;
                    particle.Y = PosY;

                    float direction = (float)Particle.rand.Next(360);
                    float speed = 1 + (float)Particle.rand.Next(10);

                    particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
                    particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

                    particle.Radius = 1 + Particle.rand.Next(10);
                }
                else
                {
                    //Взаимодействие гравитонов на частицу
                    foreach(var point in impactPoints)
                    {
                        point.ImpactParticle(particle);
                    }
                    particle.SpeedX += GravityX;
                    particle.SpeedY += GravityY;

                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;
                }
            }
            for (int i = 0; i < 10; ++i)
            {
                if (particles.Count < ParticlesCount)
                {
                    var particle = new ParticleColorful();
                    particle.Color1 = Color.DarkOrange;
                    particle.Color0 = Color.FromArgb(0, Color.DeepSkyBlue);
                    particle.X = PosX;
                    particle.Y = PosY;
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
            foreach (var point in impactPoints)
            {
                point.Render(g);
            }
        }
    }
}
