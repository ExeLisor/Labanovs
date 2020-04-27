namespace Laban1
{
    partial class Window
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
            this.Evklid = new System.Windows.Forms.Button();
            this.Zenon = new System.Windows.Forms.Button();
            this.Algorithms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Evklid
            // 
            this.Evklid.Location = new System.Drawing.Point(263, 44);
            this.Evklid.Name = "Evklid";
            this.Evklid.Size = new System.Drawing.Size(212, 89);
            this.Evklid.TabIndex = 0;
            this.Evklid.Text = "Евклид";
            this.Evklid.UseVisualStyleBackColor = true;
            this.Evklid.Click += new System.EventHandler(this.button1_Click);
            // 
            // Zenon
            // 
            this.Zenon.Location = new System.Drawing.Point(263, 167);
            this.Zenon.Name = "Zenon";
            this.Zenon.Size = new System.Drawing.Size(212, 89);
            this.Zenon.TabIndex = 1;
            this.Zenon.Text = "Зенон";
            this.Zenon.UseVisualStyleBackColor = true;
            this.Zenon.Click += new System.EventHandler(this.button2_Click);
            // 
            // Algorithms
            // 
            this.Algorithms.Location = new System.Drawing.Point(263, 285);
            this.Algorithms.Name = "Algorithms";
            this.Algorithms.Size = new System.Drawing.Size(212, 89);
            this.Algorithms.TabIndex = 2;
            this.Algorithms.Text = "Простые алгоритмы";
            this.Algorithms.UseVisualStyleBackColor = true;
            this.Algorithms.Click += new System.EventHandler(this.button3_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Algorithms);
            this.Controls.Add(this.Zenon);
            this.Controls.Add(this.Evklid);
            this.Name = "Window";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Evklid;
        private System.Windows.Forms.Button Zenon;
        private System.Windows.Forms.Button Algorithms;
    }
}

