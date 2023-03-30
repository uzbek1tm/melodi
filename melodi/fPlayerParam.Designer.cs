namespace melodi
{
    partial class fPlayerParam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPlayerParam));
            this.txplayer1 = new System.Windows.Forms.TextBox();
            this.txplayer2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnplayerOK = new System.Windows.Forms.Button();
            this.btnplayerCANCLE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txplayer1
            // 
            this.txplayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txplayer1.Location = new System.Drawing.Point(43, 59);
            this.txplayer1.Name = "txplayer1";
            this.txplayer1.Size = new System.Drawing.Size(129, 31);
            this.txplayer1.TabIndex = 1;
            // 
            // txplayer2
            // 
            this.txplayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txplayer2.Location = new System.Drawing.Point(234, 59);
            this.txplayer2.Name = "txplayer2";
            this.txplayer2.Size = new System.Drawing.Size(137, 31);
            this.txplayer2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(50, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя 1 игрока";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(248, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя 2 игрока";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(57, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Клавиша A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(256, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Клавиша Р";
            // 
            // btnplayerOK
            // 
            this.btnplayerOK.Location = new System.Drawing.Point(31, 193);
            this.btnplayerOK.Name = "btnplayerOK";
            this.btnplayerOK.Size = new System.Drawing.Size(151, 48);
            this.btnplayerOK.TabIndex = 7;
            this.btnplayerOK.Text = "Ок";
            this.btnplayerOK.UseVisualStyleBackColor = true;
            this.btnplayerOK.Click += new System.EventHandler(this.btnplayerOK_Click);
            // 
            // btnplayerCANCLE
            // 
            this.btnplayerCANCLE.Location = new System.Drawing.Point(234, 193);
            this.btnplayerCANCLE.Name = "btnplayerCANCLE";
            this.btnplayerCANCLE.Size = new System.Drawing.Size(151, 48);
            this.btnplayerCANCLE.TabIndex = 8;
            this.btnplayerCANCLE.Text = "Отмена";
            this.btnplayerCANCLE.UseVisualStyleBackColor = true;
            this.btnplayerCANCLE.Click += new System.EventHandler(this.btnplayerCANCLE_Click);
            // 
            // fPlayerParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 251);
            this.Controls.Add(this.btnplayerCANCLE);
            this.Controls.Add(this.btnplayerOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txplayer2);
            this.Controls.Add(this.txplayer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fPlayerParam";
            this.Load += new System.EventHandler(this.fPlayerParam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txplayer1;
        public System.Windows.Forms.TextBox txplayer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnplayerOK;
        private System.Windows.Forms.Button btnplayerCANCLE;
    }
}