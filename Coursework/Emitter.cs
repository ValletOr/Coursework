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

        //Координаты и другие хар-ки эмиттера
        public int X = 0;
        public int Y = 0;

        public int Direction = 0;
        public int Spreading = 360;
        public int SpeedMin = 1;
        public int SpeedMax = 10;
        public int RadiusMin = 2;
        public int RadiusMax = 10;
        public int LifeMin = 20;
        public int LifeMax = 100;

        public Color ColorFrom = Color.Aqua;
        public Color ColorTo = Color.FromArgb(0, Color.Magenta);

        public float GravityX = 0;
        public float GravityY = 1;

        public int ParticlesPerTick = 1;

        //Обновляем состояние частиц
        public void UpdateState()
        {
            int particlesToCreate = ParticlesPerTick;

            foreach (var particle in particles)
            {
                if (particle.Life <= 0)
                {
                    if (particlesToCreate > 0)
                    {
                        particlesToCreate -= 1;
                        ResetParticle(particle);
                    }
                }
                else
                {
                    particle.SpeedX += GravityX;
                    particle.SpeedY += GravityY;

                    particle.Life -= 1;
                    //Воздействие импактов на частицу
                    foreach (var point in impactPoints)
                    {
                        point.ImpactParticle(particle);
                    }

                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;
                }
            }
            while (particlesToCreate >= 1)
            {
                particlesToCreate -= 1;
                var particle = CreateParticle();
                ResetParticle(particle);
                particles.Add(particle);
            }
        }

        //Отрисовываем частицы и impactpoint'ы
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

        //Создание отдельной частицы
        public virtual Particle CreateParticle()
        {
            var particle = new Particle();
            particle.Color1 = ColorFrom;
            particle.Color0 = ColorTo;

            return particle;
        }

        //Переустановка характеристик частицы
        public virtual void ResetParticle(Particle particle)
        {
            particle.Life = Particle.rand.Next(LifeMin, LifeMax);

            particle.Color1 = ColorFrom;
            particle.Color0 = ColorTo;

            particle.X = X;
            particle.Y = Y;

            float direction = Direction
                + (float)Particle.rand.Next(Spreading)
                - Spreading / 2;
            int speed = Particle.rand.Next(SpeedMin, SpeedMax);

            particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

            particle.Radius = Particle.rand.Next(RadiusMin, RadiusMax);
        }
    }

    public class WideEmitter : Emitter
    {
        public int Width = 1;

        public override void ResetParticle(Particle particle)
        {
            base.ResetParticle(particle);

            particle.X = Particle.rand.Next(Width);
            particle.Y = 0;

            particle.SpeedY = 1;
            particle.SpeedX = Particle.rand.Next(-2, 2);
        }
    }
}
