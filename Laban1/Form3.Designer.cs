namespace Laban1
{
    partial class Zenon
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.speedZenon = new System.Windows.Forms.TextBox();
            this.speedTort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Real = new System.Windows.Forms.Button();
            this.Abstarkt = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 317);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint_1);
            // 
            // speedZenon
            // 
            this.speedZenon.Location = new System.Drawing.Point(0, 381);
            this.speedZenon.Name = "speedZenon";
            this.speedZenon.Size = new System.Drawing.Size(119, 22);
            this.speedZenon.TabIndex = 1;
            this.speedZenon.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // speedTort
            // 
            this.speedTort.Location = new System.Drawing.Point(161, 381);
            this.speedTort.Name = "speedTort";
            this.speedTort.Size = new System.Drawing.Size(132, 22);
            this.speedTort.TabIndex = 2;
            this.speedTort.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Скорость Зенона";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Скорость черепахи";
            // 
            // Real
            // 
            this.Real.Location = new System.Drawing.Point(308, 347);
            this.Real.Name = "Real";
            this.Real.Size = new System.Drawing.Size(166, 91);
            this.Real.TabIndex = 5;
            this.Real.Text = "Реальность";
            this.Real.UseVisualStyleBackColor = true;
            this.Real.Click += new System.EventHandler(this.button1_Click);
            // 
            // Abstarkt
            // 
            this.Abstarkt.Location = new System.Drawing.Point(480, 347);
            this.Abstarkt.Name = "Abstarkt";
            this.Abstarkt.Size = new System.Drawing.Size(155, 91);
            this.Abstarkt.TabIndex = 6;
            this.Abstarkt.Text = "Аппорий";
            this.Abstarkt.UseVisualStyleBackColor = true;
            this.Abstarkt.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(641, 347);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(155, 91);
            this.Stop.TabIndex = 7;
            this.Stop.Text = "Стоп";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Zenon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Abstarkt);
            this.Controls.Add(this.Real);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speedTort);
            this.Controls.Add(this.speedZenon);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Zenon";
            this.Text = "Zenon";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox speedZenon;
        private System.Windows.Forms.TextBox speedTort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Real;
        private System.Windows.Forms.Button Abstarkt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button Stop;
    }
}