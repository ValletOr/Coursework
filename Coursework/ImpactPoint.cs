using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Coursework
{
    //Оновной класс - точка взаимодействия
    public abstract class ImpactPoint
    {
        public float X;
        public float Y;

        public abstract void ImpactParticle(Particle particle);

        public virtual void Render(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Red), X - 5, Y - 5, 10, 10);
        }
    }

    //============================================================================
    //Гравитон и антиГравитон, я их не использую, но оставил, на всякий случай
    public class GravityPoint : ImpactPoint
    {
        public float Power = 100;

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r2 = (float)Math.Max(100, gX * gX + gY * gY);

            particle.SpeedX += gX * Power / r2;
            particle.SpeedY += gY * Power / r2;
        }
    }

    public class AntiGravityPoint : ImpactPoint
    {
        public float Power = 100;

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r2 = (float)Math.Max(100, gX * gX + gY * gY);

            particle.SpeedX -= gX * Power / r2;
            particle.SpeedY -= gY * Power / r2;
        }

        public override void Render(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Blue), X - 5, Y - 5, 10, 10);
        }
    }
    //==============================================================================

    //Раскрашивающий частицы круг
    public class PainterPoint : ImpactPoint
    {
        public Color PointColor = Color.White;
        public float Rad = 15;

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY);
            if (r - particle.Radius < Rad)
            {
                particle.Color1 = PointColor;
                particle.Color0 = Color.FromArgb(0, PointColor);
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(new Pen(new SolidBrush(PointColor), 2), X - Rad, Y - Rad, Rad * 2, Rad * 2);
        }
    }

    //Круг счётчик
    public class CounterPoint : ImpactPoint
    {
        public int Count = 0;
        public float Rad = 15;

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY);
            if (r - particle.Radius < Rad)
            {
                particle.Life = 0;
                Count++;
            }
        }

        public override void Render(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.FromArgb(100, Color.Red)), X - Rad, Y - Rad, Rad * 2, Rad * 2);
            g.DrawEllipse(new Pen(new SolidBrush(Color.White), 2), X - Rad, Y - Rad, Rad * 2, Rad * 2);

            var stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            g.DrawString(
            $"{Count}",
            new Font("Verdana", 10),
            new SolidBrush(Color.White),
            X,
            Y,
            stringFormat
        );
        }
    }
}
