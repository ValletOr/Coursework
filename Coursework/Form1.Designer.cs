
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
            this.GBar = new System.Windows.Forms.TrackBar();
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
            this.PPTLabel = new System.Windows.Forms.Label();
            this.LTLabel = new System.Windows.Forms.Label();
            this.XLabel1 = new System.Windows.Forms.Label();
            this.YLabel1 = new System.Windows.Forms.Label();
            this.RadLabel1 = new System.Windows.Forms.Label();
            this.XLabel2 = new System.Windows.Forms.Label();
            this.YLabel2 = new System.Windows.Forms.Label();
            this.RadLabel2 = new System.Windows.Forms.Label();
            this.GLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CRadLabel = new System.Windows.Forms.Label();
            this.CRadBar = new System.Windows.Forms.TrackBar();
            this.MinLTLabel = new System.Windows.Forms.Label();
            this.MinLTBar = new System.Windows.Forms.TrackBar();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPTBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LTBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRadBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinLTBar)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(12, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(1024, 720);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseClick);
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
            this.PPTBar.Maximum = 25;
            this.PPTBar.Minimum = 1;
            this.PPTBar.Name = "PPTBar";
            this.PPTBar.Size = new System.Drawing.Size(209, 56);
            this.PPTBar.TabIndex = 4;
            this.PPTBar.Value = 1;
            this.PPTBar.Scroll += new System.EventHandler(this.PPTBar_Scroll);
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
            this.label4.Location = new System.Drawing.Point(1283, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Max Продолжительность жизни:";
            // 
            // LTBar
            // 
            this.LTBar.Location = new System.Drawing.Point(1283, 81);
            this.LTBar.Maximum = 200;
            this.LTBar.Minimum = 20;
            this.LTBar.Name = "LTBar";
            this.LTBar.Size = new System.Drawing.Size(209, 56);
            this.LTBar.TabIndex = 7;
            this.LTBar.Value = 20;
            this.LTBar.Scroll += new System.EventHandler(this.LTBar_Scroll);
            // 
            // GBar
            // 
            this.GBar.Location = new System.Drawing.Point(1042, 140);
            this.GBar.Maximum = 50;
            this.GBar.Minimum = 1;
            this.GBar.Name = "GBar";
            this.GBar.Size = new System.Drawing.Size(209, 56);
            this.GBar.TabIndex = 9;
            this.GBar.Value = 1;
            this.GBar.Scroll += new System.EventHandler(this.GBar_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1042, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Гравитация:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1042, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Управление красящими кругами";
            // 
            // XBar1
            // 
            this.XBar1.Location = new System.Drawing.Point(1042, 351);
            this.XBar1.Name = "XBar1";
            this.XBar1.Size = new System.Drawing.Size(209, 56);
            this.XBar1.TabIndex = 11;
            this.XBar1.Scroll += new System.EventHandler(this.XBar1_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1042, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "X - координата первого круга";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1283, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Y - координата первого круга";
            // 
            // YBar1
            // 
            this.YBar1.Location = new System.Drawing.Point(1283, 351);
            this.YBar1.Name = "YBar1";
            this.YBar1.Size = new System.Drawing.Size(209, 56);
            this.YBar1.TabIndex = 13;
            this.YBar1.Scroll += new System.EventHandler(this.YBar1_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1042, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Радиус первого круга";
            // 
            // RadBar1
            // 
            this.RadBar1.Location = new System.Drawing.Point(1042, 410);
            this.RadBar1.Maximum = 300;
            this.RadBar1.Minimum = 10;
            this.RadBar1.Name = "RadBar1";
            this.RadBar1.Size = new System.Drawing.Size(209, 56);
            this.RadBar1.TabIndex = 15;
            this.RadBar1.Value = 10;
            this.RadBar1.Scroll += new System.EventHandler(this.RadBar1_Scroll);
            // 
            // ColorPick1
            // 
            this.ColorPick1.Location = new System.Drawing.Point(1288, 388);
            this.ColorPick1.Name = "ColorPick1";
            this.ColorPick1.Size = new System.Drawing.Size(197, 78);
            this.ColorPick1.TabIndex = 17;
            this.ColorPick1.Text = "Выбор цвета первого круга";
            this.ColorPick1.UseVisualStyleBackColor = true;
            this.ColorPick1.Click += new System.EventHandler(this.ColorPick1_Click);
            // 
            // ColorPick2
            // 
            this.ColorPick2.Location = new System.Drawing.Point(1288, 538);
            this.ColorPick2.Name = "ColorPick2";
            this.ColorPick2.Size = new System.Drawing.Size(197, 78);
            this.ColorPick2.TabIndex = 24;
            this.ColorPick2.Text = "Выбор цвета второго круга";
            this.ColorPick2.UseVisualStyleBackColor = true;
            this.ColorPick2.Click += new System.EventHandler(this.ColorPick2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1042, 538);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Радиус второго круга";
            // 
            // RadBar2
            // 
            this.RadBar2.Location = new System.Drawing.Point(1042, 560);
            this.RadBar2.Maximum = 300;
            this.RadBar2.Minimum = 10;
            this.RadBar2.Name = "RadBar2";
            this.RadBar2.Size = new System.Drawing.Size(209, 56);
            this.RadBar2.TabIndex = 22;
            this.RadBar2.Value = 10;
            this.RadBar2.Scroll += new System.EventHandler(this.RadBar2_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1283, 479);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 19);
            this.label11.TabIndex = 21;
            this.label11.Text = "Y - координата второго круга";
            // 
            // YBar2
            // 
            this.YBar2.Location = new System.Drawing.Point(1283, 501);
            this.YBar2.Name = "YBar2";
            this.YBar2.Size = new System.Drawing.Size(209, 56);
            this.YBar2.TabIndex = 20;
            this.YBar2.Scroll += new System.EventHandler(this.YBar2_Scroll);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1042, 479);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(202, 19);
            this.label12.TabIndex = 19;
            this.label12.Text = "X - координата второго круга";
            // 
            // XBar2
            // 
            this.XBar2.Location = new System.Drawing.Point(1042, 501);
            this.XBar2.Name = "XBar2";
            this.XBar2.Size = new System.Drawing.Size(209, 56);
            this.XBar2.TabIndex = 18;
            this.XBar2.Scroll += new System.EventHandler(this.XBar2_Scroll);
            // 
            // FirstColorPick
            // 
            this.FirstColorPick.Location = new System.Drawing.Point(1051, 202);
            this.FirstColorPick.Name = "FirstColorPick";
            this.FirstColorPick.Size = new System.Drawing.Size(200, 78);
            this.FirstColorPick.TabIndex = 25;
            this.FirstColorPick.Text = "Выбор первого цвета";
            this.FirstColorPick.UseVisualStyleBackColor = false;
            this.FirstColorPick.Click += new System.EventHandler(this.FirstColorPick_Click);
            // 
            // SecondColorPick
            // 
            this.SecondColorPick.Location = new System.Drawing.Point(1288, 202);
            this.SecondColorPick.Name = "SecondColorPick";
            this.SecondColorPick.Size = new System.Drawing.Size(204, 78);
            this.SecondColorPick.TabIndex = 26;
            this.SecondColorPick.Text = "Выбор второго цвета";
            this.SecondColorPick.UseVisualStyleBackColor = true;
            this.SecondColorPick.Click += new System.EventHandler(this.SecondColorPick_Click);
            // 
            // PPTLabel
            // 
            this.PPTLabel.AutoSize = true;
            this.PPTLabel.Location = new System.Drawing.Point(1218, 59);
            this.PPTLabel.Name = "PPTLabel";
            this.PPTLabel.Size = new System.Drawing.Size(33, 19);
            this.PPTLabel.TabIndex = 27;
            this.PPTLabel.Text = "###";
            // 
            // LTLabel
            // 
            this.LTLabel.AutoSize = true;
            this.LTLabel.Location = new System.Drawing.Point(1499, 59);
            this.LTLabel.Name = "LTLabel";
            this.LTLabel.Size = new System.Drawing.Size(33, 19);
            this.LTLabel.TabIndex = 28;
            this.LTLabel.Text = "###";
            // 
            // XLabel1
            // 
            this.XLabel1.AutoSize = true;
            this.XLabel1.Location = new System.Drawing.Point(1244, 329);
            this.XLabel1.Name = "XLabel1";
            this.XLabel1.Size = new System.Drawing.Size(33, 19);
            this.XLabel1.TabIndex = 29;
            this.XLabel1.Text = "###";
            // 
            // YLabel1
            // 
            this.YLabel1.AutoSize = true;
            this.YLabel1.Location = new System.Drawing.Point(1479, 329);
            this.YLabel1.Name = "YLabel1";
            this.YLabel1.Size = new System.Drawing.Size(33, 19);
            this.YLabel1.TabIndex = 30;
            this.YLabel1.Text = "###";
            // 
            // RadLabel1
            // 
            this.RadLabel1.AutoSize = true;
            this.RadLabel1.Location = new System.Drawing.Point(1198, 388);
            this.RadLabel1.Name = "RadLabel1";
            this.RadLabel1.Size = new System.Drawing.Size(33, 19);
            this.RadLabel1.TabIndex = 31;
            this.RadLabel1.Text = "###";
            // 
            // XLabel2
            // 
            this.XLabel2.AutoSize = true;
            this.XLabel2.Location = new System.Drawing.Point(1244, 479);
            this.XLabel2.Name = "XLabel2";
            this.XLabel2.Size = new System.Drawing.Size(33, 19);
            this.XLabel2.TabIndex = 32;
            this.XLabel2.Text = "###";
            // 
            // YLabel2
            // 
            this.YLabel2.AutoSize = true;
            this.YLabel2.Location = new System.Drawing.Point(1479, 479);
            this.YLabel2.Name = "YLabel2";
            this.YLabel2.Size = new System.Drawing.Size(33, 19);
            this.YLabel2.TabIndex = 33;
            this.YLabel2.Text = "###";
            // 
            // RadLabel2
            // 
            this.RadLabel2.AutoSize = true;
            this.RadLabel2.Location = new System.Drawing.Point(1197, 538);
            this.RadLabel2.Name = "RadLabel2";
            this.RadLabel2.Size = new System.Drawing.Size(33, 19);
            this.RadLabel2.TabIndex = 34;
            this.RadLabel2.Text = "###";
            // 
            // GLabel
            // 
            this.GLabel.AutoSize = true;
            this.GLabel.Location = new System.Drawing.Point(1129, 118);
            this.GLabel.Name = "GLabel";
            this.GLabel.Size = new System.Drawing.Size(33, 19);
            this.GLabel.TabIndex = 35;
            this.GLabel.Text = "###";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1038, 634);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(226, 19);
            this.label13.TabIndex = 36;
            this.label13.Text = "Управление кругами счётчиками:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1038, 653);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(195, 19);
            this.label14.TabIndex = 37;
            this.label14.Text = "Радиус создаваемых кругов:";
            // 
            // CRadLabel
            // 
            this.CRadLabel.AutoSize = true;
            this.CRadLabel.Location = new System.Drawing.Point(1239, 653);
            this.CRadLabel.Name = "CRadLabel";
            this.CRadLabel.Size = new System.Drawing.Size(33, 19);
            this.CRadLabel.TabIndex = 38;
            this.CRadLabel.Text = "###";
            // 
            // CRadBar
            // 
            this.CRadBar.Location = new System.Drawing.Point(1046, 675);
            this.CRadBar.Maximum = 300;
            this.CRadBar.Minimum = 10;
            this.CRadBar.Name = "CRadBar";
            this.CRadBar.Size = new System.Drawing.Size(209, 56);
            this.CRadBar.TabIndex = 39;
            this.CRadBar.Value = 10;
            // 
            // MinLTLabel
            // 
            this.MinLTLabel.AutoSize = true;
            this.MinLTLabel.Location = new System.Drawing.Point(1499, 118);
            this.MinLTLabel.Name = "MinLTLabel";
            this.MinLTLabel.Size = new System.Drawing.Size(33, 19);
            this.MinLTLabel.TabIndex = 42;
            this.MinLTLabel.Text = "###";
            // 
            // MinLTBar
            // 
            this.MinLTBar.Location = new System.Drawing.Point(1283, 140);
            this.MinLTBar.Maximum = 200;
            this.MinLTBar.Minimum = 20;
            this.MinLTBar.Name = "MinLTBar";
            this.MinLTBar.Size = new System.Drawing.Size(209, 56);
            this.MinLTBar.TabIndex = 41;
            this.MinLTBar.Value = 20;
            this.MinLTBar.Scroll += new System.EventHandler(this.MinLTBar_Scroll);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1283, 118);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(219, 19);
            this.label16.TabIndex = 40;
            this.label16.Text = "Min Продолжительность жизни:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 741);
            this.Controls.Add(this.MinLTLabel);
            this.Controls.Add(this.MinLTBar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.CRadBar);
            this.Controls.Add(this.CRadLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.GLabel);
            this.Controls.Add(this.RadLabel2);
            this.Controls.Add(this.YLabel2);
            this.Controls.Add(this.XLabel2);
            this.Controls.Add(this.RadLabel1);
            this.Controls.Add(this.YLabel1);
            this.Controls.Add(this.XLabel1);
            this.Controls.Add(this.LTLabel);
            this.Controls.Add(this.PPTLabel);
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
            this.Controls.Add(this.GBar);
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
            ((System.ComponentModel.ISupportInitialize)(this.GBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRadBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinLTBar)).EndInit();
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
        private System.Windows.Forms.TrackBar GBar;
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
        private System.Windows.Forms.Label PPTLabel;
        private System.Windows.Forms.Label LTLabel;
        private System.Windows.Forms.Label XLabel1;
        private System.Windows.Forms.Label YLabel1;
        private System.Windows.Forms.Label RadLabel1;
        private System.Windows.Forms.Label XLabel2;
        private System.Windows.Forms.Label YLabel2;
        private System.Windows.Forms.Label RadLabel2;
        private System.Windows.Forms.Label GLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label CRadLabel;
        private System.Windows.Forms.TrackBar CRadBar;
        private System.Windows.Forms.Label MinLTLabel;
        private System.Windows.Forms.TrackBar MinLTBar;
        private System.Windows.Forms.Label label16;
    }
}

