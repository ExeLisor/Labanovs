namespace Laban1
{
    partial class Algs
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
            this.Random = new System.Windows.Forms.TextBox();
            this.ToMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Launch = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.TextBox();
            this.Max = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ToMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Random
            // 
            this.Random.Location = new System.Drawing.Point(217, 29);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(361, 22);
            this.Random.TabIndex = 0;
            // 
            // ToMax
            // 
            this.ToMax.Location = new System.Drawing.Point(217, 295);
            this.ToMax.Name = "ToMax";
            this.ToMax.Size = new System.Drawing.Size(361, 22);
            this.ToMax.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Случайные числа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "В порядке возрастания";
            // 
            // Launch
            // 
            this.Launch.Location = new System.Drawing.Point(339, 103);
            this.Launch.Name = "Launch";
            this.Launch.Size = new System.Drawing.Size(116, 61);
            this.Launch.TabIndex = 4;
            this.Launch.Text = "do it";
            this.Launch.UseVisualStyleBackColor = true;
            this.Launch.Click += new System.EventHandler(this.button1_Click);
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(12, 210);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(361, 22);
            this.Min.TabIndex = 5;
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(427, 210);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(361, 22);
            this.Max.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Минимальное";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Максимальное";
            // 
            // ToMin
            // 
            this.ToMin.Location = new System.Drawing.Point(217, 416);
            this.ToMin.Name = "ToMin";
            this.ToMin.Size = new System.Drawing.Size(361, 22);
            this.ToMin.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "В порядке убывания";
            // 
            // Algs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ToMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Launch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToMax);
            this.Controls.Add(this.Random);
            this.Name = "Algs";
            this.Text = "Algs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Random;
        private System.Windows.Forms.TextBox ToMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Launch;
        private System.Windows.Forms.TextBox Min;
        private System.Windows.Forms.TextBox Max;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ToMin;
        private System.Windows.Forms.Label label5;
    }
}