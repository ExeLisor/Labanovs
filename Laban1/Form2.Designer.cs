namespace Laban1
{
    partial class NOD
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Solve = new System.Windows.Forms.Button();
            this.firstnum = new System.Windows.Forms.TextBox();
            this.secondnum = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Первое число";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Второе число";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Результат";
            // 
            // Solve
            // 
            this.Solve.Location = new System.Drawing.Point(34, 151);
            this.Solve.Name = "Solve";
            this.Solve.Size = new System.Drawing.Size(170, 54);
            this.Solve.TabIndex = 3;
            this.Solve.Text = "Вычислить";
            this.Solve.UseVisualStyleBackColor = true;
            this.Solve.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstnum
            // 
            this.firstnum.Location = new System.Drawing.Point(34, 76);
            this.firstnum.Name = "firstnum";
            this.firstnum.Size = new System.Drawing.Size(100, 22);
            this.firstnum.TabIndex = 4;
            // 
            // secondnum
            // 
            this.secondnum.Location = new System.Drawing.Point(271, 76);
            this.secondnum.Name = "secondnum";
            this.secondnum.Size = new System.Drawing.Size(100, 22);
            this.secondnum.TabIndex = 5;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(271, 183);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(100, 22);
            this.Result.TabIndex = 6;
            // 
            // NOD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.secondnum);
            this.Controls.Add(this.firstnum);
            this.Controls.Add(this.Solve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NOD";
            this.Text = "NOD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Solve;
        private System.Windows.Forms.TextBox firstnum;
        private System.Windows.Forms.TextBox secondnum;
        private System.Windows.Forms.TextBox Result;
    }
}