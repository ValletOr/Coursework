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

        public float Power = 100;

        public abstract void ImpactParticle(Particle particle);

        public void Render(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Red), X - 5, Y - 5, 10, 10);
        }
    }

    public class GravityPoint : ImpactPoint
    {
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
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r2 = (float)Math.Max(100, gX * gX + gY * gY);

            particle.SpeedX -= gX * Power / r2;
            particle.SpeedY -= gY * Power / r2;
        }
    }
}
