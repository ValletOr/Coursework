using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Coursework
{
    class Particle
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

        public void Draw(Graphics g)
        {
            SolidBrush b = new SolidBrush(Color.Black);

            g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2);

            b.Dispose();
        }
    }
}
