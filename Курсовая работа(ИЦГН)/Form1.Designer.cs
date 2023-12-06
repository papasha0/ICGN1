namespace Курсовая_работа_ИЦГН_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.печатьФормаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.корректностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.begin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.W = new System.Windows.Forms.RadioButton();
            this.M = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.печатьФормаToolStripMenuItem,
            this.корректностьToolStripMenuItem,
            this.посмотретьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1180, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // печатьФормаToolStripMenuItem
            // 
            this.печатьФормаToolStripMenuItem.Name = "печатьФормаToolStripMenuItem";
            this.печатьФормаToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // корректностьToolStripMenuItem
            // 
            this.корректностьToolStripMenuItem.Enabled = false;
            this.корректностьToolStripMenuItem.Name = "корректностьToolStripMenuItem";
            this.корректностьToolStripMenuItem.Size = new System.Drawing.Size(267, 24);
            this.корректностьToolStripMenuItem.Text = "Проверка данных на корректность";
            this.корректностьToolStripMenuItem.Click += new System.EventHandler(this.корректностьToolStripMenuItem_Click);
            // 
            // посмотретьToolStripMenuItem
            // 
            this.посмотретьToolStripMenuItem.Name = "посмотретьToolStripMenuItem";
            this.посмотретьToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.посмотретьToolStripMenuItem.Text = "Предыдущие результаты";
            this.посмотретьToolStripMenuItem.Click += new System.EventHandler(this.посмотретьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // begin
            // 
            this.begin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.begin.Location = new System.Drawing.Point(735, 532);
            this.begin.Margin = new System.Windows.Forms.Padding(4);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(426, 103);
            this.begin.TabIndex = 1;
            this.begin.Text = "Старт";
            this.begin.UseVisualStyleBackColor = true;
            this.begin.Click += new System.EventHandler(this.begin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(730, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Данные о участнике тестирования";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(848, 136);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(132, 22);
            this.name.TabIndex = 3;
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(733, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(732, 269);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Возраст";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(848, 273);
            this.age.Margin = new System.Windows.Forms.Padding(4);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(132, 22);
            this.age.TabIndex = 6;
            this.age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.age_KeyPress_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(733, 421);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пол";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.W);
            this.groupBox1.Controls.Add(this.M);
            this.groupBox1.Location = new System.Drawing.Point(848, 404);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(133, 89);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // W
            // 
            this.W.AutoSize = true;
            this.W.Location = new System.Drawing.Point(16, 52);
            this.W.Margin = new System.Windows.Forms.Padding(4);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(42, 21);
            this.W.TabIndex = 1;
            this.W.TabStop = true;
            this.W.Text = "Ж";
            this.W.UseVisualStyleBackColor = true;
            // 
            // M
            // 
            this.M.AutoSize = true;
            this.M.Location = new System.Drawing.Point(16, 23);
            this.M.Margin = new System.Windows.Forms.Padding(4);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(40, 21);
            this.M.TabIndex = 0;
            this.M.TabStop = true;
            this.M.Text = "М";
            this.M.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(669, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(32, 344);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(679, 291);
            this.label5.TabIndex = 10;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 661);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.begin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem посмотретьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button begin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton W;
        private System.Windows.Forms.RadioButton M;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ToolStripMenuItem печатьФормаToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem корректностьToolStripMenuItem;
    }
}

