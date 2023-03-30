namespace melodi
{
    partial class fPlay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPlay));
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnNext = new System.Windows.Forms.Button();
            this.Player1 = new System.Windows.Forms.Label();
            this.oT1 = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.oT2 = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnCont = new System.Windows.Forms.Button();
            this.Mcount = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timer = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(1, -5);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(28, 30);
            this.WMP.TabIndex = 0;
            this.WMP.Visible = false;
            this.WMP.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.WMP_OpenStateChange);
            this.WMP.Enter += new System.EventHandler(this.WMP_Enter);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Gold;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnNext.Location = new System.Drawing.Point(12, 229);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(248, 67);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Следующая";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Player1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player1.Location = new System.Drawing.Point(53, 34);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(107, 37);
            this.Player1.TabIndex = 3;
            this.Player1.Text = "Игрок 1";
            // 
            // oT1
            // 
            this.oT1.AutoSize = true;
            this.oT1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.oT1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oT1.Location = new System.Drawing.Point(92, 100);
            this.oT1.Name = "oT1";
            this.oT1.Size = new System.Drawing.Size(32, 37);
            this.oT1.TabIndex = 4;
            this.oT1.Text = "0";
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Player2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player2.Location = new System.Drawing.Point(322, 34);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(107, 37);
            this.Player2.TabIndex = 5;
            this.Player2.Text = "Игрок 2";
            // 
            // oT2
            // 
            this.oT2.AutoSize = true;
            this.oT2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.oT2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oT2.Location = new System.Drawing.Point(362, 100);
            this.oT2.Name = "oT2";
            this.oT2.Size = new System.Drawing.Size(32, 37);
            this.oT2.TabIndex = 6;
            this.oT2.Text = "0";
            this.oT2.Click += new System.EventHandler(this.oT2_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPause.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPause.Location = new System.Drawing.Point(177, 302);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(83, 38);
            this.btnPause.TabIndex = 7;
            this.btnPause.Text = "Пауза";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCont
            // 
            this.btnCont.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCont.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCont.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCont.Location = new System.Drawing.Point(12, 302);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(157, 38);
            this.btnCont.TabIndex = 8;
            this.btnCont.Text = "Продолжить";
            this.btnCont.UseVisualStyleBackColor = false;
            this.btnCont.Click += new System.EventHandler(this.btnCont_Click);
            // 
            // Mcount
            // 
            this.Mcount.AutoSize = true;
            this.Mcount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Mcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mcount.Location = new System.Drawing.Point(222, 106);
            this.Mcount.Name = "Mcount";
            this.Mcount.Size = new System.Drawing.Size(29, 31);
            this.Mcount.TabIndex = 9;
            this.Mcount.Text = "0";
            this.Mcount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Mcount.Click += new System.EventHandler(this.label1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Chocolate;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar1.Location = new System.Drawing.Point(1, 165);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(505, 48);
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Timer.ForeColor = System.Drawing.Color.Red;
            this.Timer.Location = new System.Drawing.Point(221, 26);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(39, 42);
            this.Timer.TabIndex = 11;
            this.Timer.Text = "0";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.close.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close.Location = new System.Drawing.Point(329, 302);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(119, 38);
            this.close.TabIndex = 12;
            this.close.Text = "Выход";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // fPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::melodi.Properties.Resources.depositphotos_29790383_stock_illustration_colorful_music_notes;
            this.ClientSize = new System.Drawing.Size(507, 387);
            this.Controls.Add(this.close);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Mcount);
            this.Controls.Add(this.btnCont);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.oT2);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.oT1);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.WMP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "fPlay";
            this.Text = "Игра";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fPlay_FormClosed);
            this.Load += new System.EventHandler(this.fPlay_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fPlay_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnCont;
        private System.Windows.Forms.Label Mcount;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Timer;
        public System.Windows.Forms.Label Player1;
        public System.Windows.Forms.Label Player2;
        private System.Windows.Forms.Button close;
        public System.Windows.Forms.Label oT1;
        public System.Windows.Forms.Label oT2;
    }
}