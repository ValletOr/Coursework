using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Coursework
{
    public class Particle
    {
        public float X;
        public float Y;

        public int Radius;
        public int Life;

        public float SpeedX;
        public float SpeedY;

        public static Random rand = new Random();
        public Particle()
        {
            float speed = 1 + rand.Next(10);
            float direction = rand.Next(360);

            SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

            Radius = 1 + rand.Next(10);
            Life = 20 + rand.Next(100);
        }

        public virtual void Draw(Graphics g)
        {
            float k = Math.Min(1f, Life / 100f);
            int alpha = (int)(k * 255);

            Color color = Color.FromArgb(alpha, Color.Black);

            SolidBrush b = new SolidBrush(color);

            g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2);

            b.Dispose();
        }
    }

    public class ParticleColorful : Particle
    {
        public Color Color0;
        public Color Color1;

        public static Color MixColor(Color color1, Color color0, float k)
        {
            return Color.FromArgb(
                (int)(color0.A * k + color1.A * (1 - k)),
                (int)(color0.R * k + color1.R * (1 - k)),
                (int)(color0.G * k + color1.G * (1 - k)),
                (int)(color0.B * k + color1.B * (1 - k))
                );
        }

        public override void Draw(Graphics g)
        {
            float k = Math.Min(1f, Life / 100f);

            var color = MixColor(Color0, Color1, k);
            var b = new SolidBrush(color);

            g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2);

            b.Dispose();
        }
    }
}
