
namespace Coursework
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.CounterLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PPTBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LTBar = new System.Windows.Forms.TrackBar();
            this.SBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.XBar1 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.YBar1 = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.RadBar1 = new System.Windows.Forms.TrackBar();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.ColorPick1 = new System.Windows.Forms.Button();
            this.ColorPick2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.RadBar2 = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.YBar2 = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.XBar2 = new System.Windows.Forms.TrackBar();
            this.FirstColorPick = new System.Windows.Forms.Button();
            this.SecondColorPick = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPTBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LTBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(12, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(1024, 720);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 40;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // CounterLabel
            // 
            this.CounterLabel.AutoSize = true;
            this.CounterLabel.Location = new System.Drawing.Point(1186, 31);
            this.CounterLabel.Name = "CounterLabel";
            this.CounterLabel.Size = new System.Drawing.Size(33, 19);
            this.CounterLabel.TabIndex = 1;
            this.CounterLabel.Text = "###";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1042, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Управление эмиттером";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1042, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество частиц:";
            // 
            // PPTBar
            // 
            this.PPTBar.Location = new System.Drawing.Point(1042, 81);
            this.PPTBar.Name = "PPTBar";
            this.PPTBar.Size = new System.Drawing.Size(209, 56);
            this.PPTBar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1042, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество частиц в тик:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1257, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Продолжительность жизни:";
            // 
            // LTBar
            // 
            this.LTBar.Location = new System.Drawing.Point(1257, 81);
            this.LTBar.Name = "LTBar";
            this.LTBar.Size = new System.Drawing.Size(209, 56);
            this.LTBar.TabIndex = 7;
            // 
            // SBar
            // 
            this.SBar.Location = new System.Drawing.Point(1042, 140);
            this.SBar.Name = "SBar";
            this.SBar.Size = new System.Drawing.Size(209, 56);
            this.SBar.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1042, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Скорость:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1042, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Управление красящими кругами";
            // 
            // XBar1
            // 
            this.XBar1.Location = new System.Drawing.Point(1042, 245);
            this.XBar1.Name = "XBar1";
            this.XBar1.Size = new System.Drawing.Size(209, 56);
            this.XBar1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1042, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "X - координата первого круга";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1257, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Y - координата первого круга";
            // 
            // YBar1
            // 
            this.YBar1.Location = new System.Drawing.Point(1257, 245);
            this.YBar1.Name = "YBar1";
            this.YBar1.Size = new System.Drawing.Size(209, 56);
            this.YBar1.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1042, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Радиус первого круга";
            // 
            // RadBar1
            // 
            this.RadBar1.Location = new System.Drawing.Point(1042, 304);
            this.RadBar1.Name = "RadBar1";
            this.RadBar1.Size = new System.Drawing.Size(209, 56);
            this.RadBar1.TabIndex = 15;
            // 
            // ColorPick1
            // 
            this.ColorPick1.Location = new System.Drawing.Point(1262, 282);
            this.ColorPick1.Name = "ColorPick1";
            this.ColorPick1.Size = new System.Drawing.Size(197, 78);
            this.ColorPick1.TabIndex = 17;
            this.ColorPick1.Text = "Выбор цвета первого круга";
            this.ColorPick1.UseVisualStyleBackColor = true;
            // 
            // ColorPick2
            // 
            this.ColorPick2.Location = new System.Drawing.Point(1262, 432);
            this.ColorPick2.Name = "ColorPick2";
            this.ColorPick2.Size = new System.Drawing.Size(197, 78);
            this.ColorPick2.TabIndex = 24;
            this.ColorPick2.Text = "Выбор цвета второго круга";
            this.ColorPick2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1042, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Радиус второго круга";
            // 
            // RadBar2
            // 
            this.RadBar2.Location = new System.Drawing.Point(1042, 454);
            this.RadBar2.Name = "RadBar2";
            this.RadBar2.Size = new System.Drawing.Size(209, 56);
            this.RadBar2.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1257, 373);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 19);
            this.label11.TabIndex = 21;
            this.label11.Text = "Y - координата второго круга";
            // 
            // YBar2
            // 
            this.YBar2.Location = new System.Drawing.Point(1257, 395);
            this.YBar2.Name = "YBar2";
            this.YBar2.Size = new System.Drawing.Size(209, 56);
            this.YBar2.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1042, 373);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(202, 19);
            this.label12.TabIndex = 19;
            this.label12.Text = "X - координата второго круга";
            // 
            // XBar2
            // 
            this.XBar2.Location = new System.Drawing.Point(1042, 395);
            this.XBar2.Name = "XBar2";
            this.XBar2.Size = new System.Drawing.Size(209, 56);
            this.XBar2.TabIndex = 18;
            // 
            // FirstColorPick
            // 
            this.FirstColorPick.Location = new System.Drawing.Point(1262, 118);
            this.FirstColorPick.Name = "FirstColorPick";
            this.FirstColorPick.Size = new System.Drawing.Size(90, 78);
            this.FirstColorPick.TabIndex = 25;
            this.FirstColorPick.Text = "Выбор первого цвета";
            this.FirstColorPick.UseVisualStyleBackColor = true;
            // 
            // SecondColorPick
            // 
            this.SecondColorPick.Location = new System.Drawing.Point(1368, 118);
            this.SecondColorPick.Name = "SecondColorPick";
            this.SecondColorPick.Size = new System.Drawing.Size(90, 78);
            this.SecondColorPick.TabIndex = 26;
            this.SecondColorPick.Text = "Выбор второго цвета";
            this.SecondColorPick.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 741);
            this.Controls.Add(this.SecondColorPick);
            this.Controls.Add(this.FirstColorPick);
            this.Controls.Add(this.ColorPick2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.RadBar2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.YBar2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.XBar2);
            this.Controls.Add(this.ColorPick1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RadBar1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.YBar1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.XBar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LTBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PPTBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CounterLabel);
            this.Controls.Add(this.picDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Система частиц";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPTBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LTBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label CounterLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar PPTBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar LTBar;
        private System.Windows.Forms.TrackBar SBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar XBar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar YBar1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar RadBar1;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button ColorPick1;
        private System.Windows.Forms.Button ColorPick2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar RadBar2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar YBar2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar XBar2;
        private System.Windows.Forms.Button FirstColorPick;
        private System.Windows.Forms.Button SecondColorPick;
    }
}

