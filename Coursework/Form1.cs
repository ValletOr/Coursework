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
        public PainterPoint paint1;
        public PainterPoint paint2;

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            emitter = new WideEmitter
            {
                Width = picDisplay.Width,
                GravityY = 0.2f,
                ParticlesPerTick = 2,
            };
            emitters.Add(emitter);

            paint1 = new PainterPoint
            {
                PointColor = Color.White,
                X = (picDisplay.Width / 2) - 200,
                Y = (picDisplay.Height / 2) - 100,
                Rad = 50,
            };

            paint2 = new PainterPoint
            {
                PointColor = Color.Red,
                X = (picDisplay.Width / 2) + 200,
                Y = (picDisplay.Height / 2) - 100,
                Rad = 50,
            };

            emitter.impactPoints.Add(paint1);
            emitter.impactPoints.Add(paint2);

            ElementsStartPos();
        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            //emitter.impactPoints[0].X = e.X;
            //emitter.impactPoints[0].Y = e.Y;
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
            ElementsUpdate();
        }

        //Задание начальных значений формы
        public void ElementsStartPos()
        {
            XBar1.Maximum = picDisplay.Width;
            YBar1.Maximum = picDisplay.Height;
            XBar2.Maximum = picDisplay.Width;
            YBar2.Maximum = picDisplay.Height;
            XBar1.Value = (int)paint1.X;
            YBar1.Value = (int)paint1.Y;
            XBar2.Value = (int)paint2.X;
            YBar2.Value = (int)paint2.Y;
            RadBar1.Value = (int)paint1.Rad;
            RadBar2.Value = (int)paint2.Rad;
            PPTBar.Value = emitter.ParticlesPerTick;
            LTBar.Value = emitter.LifeMax;
            MinLTBar.Value = emitter.LifeMin;
            GBar.Value = (int)(emitter.GravityY * 10);
            CRadBar.Value = 50;
            FirstColorPick.BackColor = emitter.ColorFrom;
            SecondColorPick.BackColor = Color.FromArgb(255, emitter.ColorTo);
            ColorPick1.BackColor = paint1.PointColor;
            ColorPick2.BackColor = paint2.PointColor;
        }

        //Обновление значений элементов(Лейблы и т.п.)
        public void ElementsUpdate()
        {
            CounterLabel.Text = emitter.particles.Count(particle => particle.Life > 0).ToString();
            PPTLabel.Text = PPTBar.Value.ToString();
            LTLabel.Text = LTBar.Value.ToString();
            MinLTLabel.Text = MinLTBar.Value.ToString();
            GLabel.Text = (GBar.Value / 10f).ToString();
            XLabel1.Text = XBar1.Value.ToString();
            YLabel1.Text = YBar1.Value.ToString();
            RadLabel1.Text = RadBar1.Value.ToString();
            XLabel2.Text = XBar2.Value.ToString();
            YLabel2.Text = YBar2.Value.ToString();
            RadLabel2.Text = RadBar2.Value.ToString();
            CRadLabel.Text = CRadBar.Value.ToString();
        }

        //=============================================================
        //Много методов-событий от элементов формы.
        private void XBar1_Scroll(object sender, EventArgs e)
        {
            paint1.X = XBar1.Value;
        }

        private void YBar1_Scroll(object sender, EventArgs e)
        {
            paint1.Y = YBar1.Value;
        }

        private void RadBar1_Scroll(object sender, EventArgs e)
        {
            paint1.Rad = RadBar1.Value;
        }

        private void XBar2_Scroll(object sender, EventArgs e)
        {
            paint2.X = XBar2.Value;
        }

        private void YBar2_Scroll(object sender, EventArgs e)
        {
            paint2.Y = YBar2.Value;
        }

        private void RadBar2_Scroll(object sender, EventArgs e)
        {
            paint2.Rad = RadBar2.Value;
        }

        private void ColorPick1_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            paint1.PointColor = colorDialog.Color;
            ColorPick1.BackColor = paint1.PointColor;
        }

        private void ColorPick2_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            paint2.PointColor = colorDialog.Color;
            ColorPick2.BackColor = paint2.PointColor;
        }

        private void PPTBar_Scroll(object sender, EventArgs e)
        {
            emitter.ParticlesPerTick = PPTBar.Value;
        }

        private void GBar_Scroll(object sender, EventArgs e)
        {
            emitter.GravityY = (GBar.Value / 10f);
        }

        private void FirstColorPick_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            emitter.ColorFrom = colorDialog.Color;
            FirstColorPick.BackColor = emitter.ColorFrom;
        }

        private void SecondColorPick_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            emitter.ColorTo = Color.FromArgb(0, colorDialog.Color);
            SecondColorPick.BackColor = Color.FromArgb(255, emitter.ColorTo);
        }

        //Два метода - события для ползунков, определяющих время жизни частиц.
        //Они взаимозависимы, поэтому изменяют максимальное и минимальное значения друг-друга при каждом вызове
        private void LTBar_Scroll(object sender, EventArgs e)
        {
            emitter.LifeMax = LTBar.Value;
            MinLTBar.Maximum = LTBar.Value;
            LTBar.Minimum = MinLTBar.Value;
        }

        private void MinLTBar_Scroll(object sender, EventArgs e)
        {
            emitter.LifeMin = MinLTBar.Value;
            MinLTBar.Maximum = LTBar.Value;
            LTBar.Minimum = MinLTBar.Value;
        }

        //Создание и удаление кругов-счётчиков
        private void picDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                emitter.impactPoints.Add(new CounterPoint
                {
                    X = e.X,
                    Y = e.Y,
                    Rad = CRadBar.Value,
                });
            }
            else if (e.Button == MouseButtons.Right)
            {
                foreach(var point in emitter.impactPoints.ToArray())
                {
                    //Если impactpoint - счётчик
                    if(point is CounterPoint)
                    {
                        //то проверяем на пересечение с местом клика мышью
                        CounterPoint cpoint = point as CounterPoint;
                        float gX = cpoint.X - e.X;
                        float gY = cpoint.Y - e.Y;
                        double r = Math.Sqrt((gX * gX) + (gY * gY));
                        if(r <= cpoint.Rad)
                        {
                            //и при пересечении удаляем счётчик.
                            emitter.impactPoints.Remove(point);
                        }
                    }
                }
            }
        }
        //=================================================================
    }
}
