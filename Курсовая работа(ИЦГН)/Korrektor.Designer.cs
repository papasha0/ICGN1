namespace Курсовая_работа_ИЦГН_
{
    partial class Korrektor
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
            this.vopros = new System.Windows.Forms.Label();
            this.var1 = new System.Windows.Forms.Label();
            this.var2 = new System.Windows.Forms.Label();
            this.var3 = new System.Windows.Forms.Label();
            this.var4 = new System.Windows.Forms.Label();
            this.next2 = new System.Windows.Forms.Button();
            this.Vash = new System.Windows.Forms.Label();
            this.Prav = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vopros
            // 
            this.vopros.AutoSize = true;
            this.vopros.Location = new System.Drawing.Point(31, 37);
            this.vopros.Name = "vopros";
            this.vopros.Size = new System.Drawing.Size(44, 13);
            this.vopros.TabIndex = 0;
            this.vopros.Text = "Вопрос";
            // 
            // var1
            // 
            this.var1.AutoSize = true;
            this.var1.Location = new System.Drawing.Point(31, 79);
            this.var1.Name = "var1";
            this.var1.Size = new System.Drawing.Size(55, 13);
            this.var1.TabIndex = 1;
            this.var1.Text = "Вариант1";
            // 
            // var2
            // 
            this.var2.AutoSize = true;
            this.var2.Location = new System.Drawing.Point(31, 113);
            this.var2.Name = "var2";
            this.var2.Size = new System.Drawing.Size(55, 13);
            this.var2.TabIndex = 2;
            this.var2.Text = "Вариант2";
            // 
            // var3
            // 
            this.var3.AutoSize = true;
            this.var3.Location = new System.Drawing.Point(31, 145);
            this.var3.Name = "var3";
            this.var3.Size = new System.Drawing.Size(55, 13);
            this.var3.TabIndex = 3;
            this.var3.Text = "Вариант3";
            // 
            // var4
            // 
            this.var4.AutoSize = true;
            this.var4.Location = new System.Drawing.Point(31, 180);
            this.var4.Name = "var4";
            this.var4.Size = new System.Drawing.Size(55, 13);
            this.var4.TabIndex = 4;
            this.var4.Text = "Вариант4";
            // 
            // next2
            // 
            this.next2.Location = new System.Drawing.Point(772, 261);
            this.next2.Name = "next2";
            this.next2.Size = new System.Drawing.Size(153, 23);
            this.next2.TabIndex = 5;
            this.next2.Text = "Следующий ответ";
            this.next2.UseVisualStyleBackColor = true;
            this.next2.Click += new System.EventHandler(this.next2_Click);
            // 
            // Vash
            // 
            this.Vash.AutoSize = true;
            this.Vash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vash.Location = new System.Drawing.Point(31, 210);
            this.Vash.Name = "Vash";
            this.Vash.Size = new System.Drawing.Size(62, 13);
            this.Vash.TabIndex = 6;
            this.Vash.Text = "Ваш ответ:";
            // 
            // Prav
            // 
            this.Prav.AutoSize = true;
            this.Prav.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prav.Location = new System.Drawing.Point(31, 239);
            this.Prav.Name = "Prav";
            this.Prav.Size = new System.Drawing.Size(105, 13);
            this.Prav.TabIndex = 7;
            this.Prav.Text = "Правильный ответ:";
            // 
            // Korrektor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 296);
            this.Controls.Add(this.Prav);
            this.Controls.Add(this.Vash);
            this.Controls.Add(this.next2);
            this.Controls.Add(this.var4);
            this.Controls.Add(this.var3);
            this.Controls.Add(this.var2);
            this.Controls.Add(this.var1);
            this.Controls.Add(this.vopros);
            this.Name = "Korrektor";
            this.Text = "Korrektor";
            this.Load += new System.EventHandler(this.Korrektor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vopros;
        private System.Windows.Forms.Label var1;
        private System.Windows.Forms.Label var2;
        private System.Windows.Forms.Label var3;
        private System.Windows.Forms.Label var4;
        private System.Windows.Forms.Button next2;
        private System.Windows.Forms.Label Vash;
        private System.Windows.Forms.Label Prav;
    }
}