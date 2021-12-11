﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Coursework
{
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
}
