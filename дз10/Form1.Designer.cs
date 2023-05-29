namespace дз10
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
            this.tb_root = new System.Windows.Forms.TextBox();
            this.bt_create = new System.Windows.Forms.Button();
            this.tb_write_text = new System.Windows.Forms.TextBox();
            this.bt_write_text = new System.Windows.Forms.Button();
            this.bt_get_text = new System.Windows.Forms.Button();
            this.tb_get_text = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb2_in = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb3_in = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb4_old = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb4_new = new System.Windows.Forms.TextBox();
            this.bt_replace = new System.Windows.Forms.Button();
            this.bt_up = new System.Windows.Forms.Button();
            this.bt_down = new System.Windows.Forms.Button();
            this.bt_all_up = new System.Windows.Forms.Button();
            this.bt_all_down = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_root
            // 
            this.tb_root.Location = new System.Drawing.Point(90, 102);
            this.tb_root.Name = "tb_root";
            this.tb_root.Size = new System.Drawing.Size(982, 38);
            this.tb_root.TabIndex = 1;
            // 
            // bt_create
            // 
            this.bt_create.Location = new System.Drawing.Point(1565, 90);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(284, 50);
            this.bt_create.TabIndex = 2;
            this.bt_create.Text = "создать";
            this.bt_create.UseVisualStyleBackColor = true;
            this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // tb_write_text
            // 
            this.tb_write_text.Location = new System.Drawing.Point(90, 160);
            this.tb_write_text.Multiline = true;
            this.tb_write_text.Name = "tb_write_text";
            this.tb_write_text.Size = new System.Drawing.Size(792, 273);
            this.tb_write_text.TabIndex = 3;
            // 
            // bt_write_text
            // 
            this.bt_write_text.Location = new System.Drawing.Point(90, 459);
            this.bt_write_text.Name = "bt_write_text";
            this.bt_write_text.Size = new System.Drawing.Size(284, 50);
            this.bt_write_text.TabIndex = 4;
            this.bt_write_text.Text = "записать";
            this.bt_write_text.UseVisualStyleBackColor = true;
            this.bt_write_text.Click += new System.EventHandler(this.bt_write_text_Click);
            // 
            // bt_get_text
            // 
            this.bt_get_text.Location = new System.Drawing.Point(971, 459);
            this.bt_get_text.Name = "bt_get_text";
            this.bt_get_text.Size = new System.Drawing.Size(284, 50);
            this.bt_get_text.TabIndex = 6;
            this.bt_get_text.Text = "считать";
            this.bt_get_text.UseVisualStyleBackColor = true;
            this.bt_get_text.Click += new System.EventHandler(this.bt_get_text_Click);
            // 
            // tb_get_text
            // 
            this.tb_get_text.Location = new System.Drawing.Point(971, 160);
            this.tb_get_text.Multiline = true;
            this.tb_get_text.Name = "tb_get_text";
            this.tb_get_text.Size = new System.Drawing.Size(792, 273);
            this.tb_get_text.TabIndex = 7;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(1107, 102);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(408, 38);
            this.tb_name.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(84, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "путь к папке";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(1101, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "имя файла";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb1
            // 
            this.tb1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb1.Location = new System.Drawing.Point(90, 580);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(470, 38);
            this.tb1.TabIndex = 12;
            this.tb1.Text = "нажмите...";
            this.tb1.Click += new System.EventHandler(this.tb1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(84, 545);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "кол-во строк";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(84, 636);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "кол-во строк";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb2
            // 
            this.tb2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb2.Location = new System.Drawing.Point(90, 671);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(470, 38);
            this.tb2.TabIndex = 14;
            this.tb2.Text = "нажмите...";
            this.tb2.Click += new System.EventHandler(this.tb2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(741, 677);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "если содержит ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb2_in
            // 
            this.tb2_in.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb2_in.Location = new System.Drawing.Point(984, 671);
            this.tb2_in.Name = "tb2_in";
            this.tb2_in.Size = new System.Drawing.Size(250, 38);
            this.tb2_in.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(741, 771);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 32);
            this.label6.TabIndex = 21;
            this.label6.Text = "если содержит ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb3_in
            // 
            this.tb3_in.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb3_in.Location = new System.Drawing.Point(984, 765);
            this.tb3_in.Name = "tb3_in";
            this.tb3_in.Size = new System.Drawing.Size(250, 38);
            this.tb3_in.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(84, 730);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(265, 32);
            this.label7.TabIndex = 19;
            this.label7.Text = "частота появления";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb3
            // 
            this.tb3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb3.Location = new System.Drawing.Point(90, 765);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(470, 38);
            this.tb3.TabIndex = 18;
            this.tb3.Text = "нажмите...";
            this.tb3.Click += new System.EventHandler(this.tb3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(364, 909);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 32);
            this.label8.TabIndex = 25;
            this.label8.Text = "заменить на";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb4_old
            // 
            this.tb4_old.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb4_old.HideSelection = false;
            this.tb4_old.Location = new System.Drawing.Point(90, 903);
            this.tb4_old.Name = "tb4_old";
            this.tb4_old.Size = new System.Drawing.Size(250, 38);
            this.tb4_old.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(84, 868);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(281, 32);
            this.label9.TabIndex = 23;
            this.label9.Text = "замена символа(ов)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb5
            // 
            this.tb5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb5.Location = new System.Drawing.Point(90, 994);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(250, 38);
            this.tb5.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(84, 959);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(237, 32);
            this.label11.TabIndex = 27;
            this.label11.Text = "замена регистра";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb4_new
            // 
            this.tb4_new.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb4_new.Location = new System.Drawing.Point(558, 903);
            this.tb4_new.Name = "tb4_new";
            this.tb4_new.Size = new System.Drawing.Size(250, 38);
            this.tb4_new.TabIndex = 30;
            // 
            // bt_replace
            // 
            this.bt_replace.Location = new System.Drawing.Point(878, 891);
            this.bt_replace.Name = "bt_replace";
            this.bt_replace.Size = new System.Drawing.Size(284, 50);
            this.bt_replace.TabIndex = 31;
            this.bt_replace.Text = "заменить";
            this.bt_replace.UseVisualStyleBackColor = true;
            this.bt_replace.Click += new System.EventHandler(this.bt_replace_Click);
            // 
            // bt_up
            // 
            this.bt_up.Location = new System.Drawing.Point(370, 982);
            this.bt_up.Name = "bt_up";
            this.bt_up.Size = new System.Drawing.Size(284, 50);
            this.bt_up.TabIndex = 33;
            this.bt_up.Text = "верхний";
            this.bt_up.UseVisualStyleBackColor = true;
            this.bt_up.Click += new System.EventHandler(this.bt_up_Click);
            // 
            // bt_down
            // 
            this.bt_down.Location = new System.Drawing.Point(695, 982);
            this.bt_down.Name = "bt_down";
            this.bt_down.Size = new System.Drawing.Size(284, 50);
            this.bt_down.TabIndex = 34;
            this.bt_down.Text = "нижний";
            this.bt_down.UseVisualStyleBackColor = true;
            this.bt_down.Click += new System.EventHandler(this.bt_down_Click);
            // 
            // bt_all_up
            // 
            this.bt_all_up.Location = new System.Drawing.Point(1143, 982);
            this.bt_all_up.Name = "bt_all_up";
            this.bt_all_up.Size = new System.Drawing.Size(284, 50);
            this.bt_all_up.TabIndex = 35;
            this.bt_all_up.Text = "все к верхнему";
            this.bt_all_up.UseVisualStyleBackColor = true;
            this.bt_all_up.Click += new System.EventHandler(this.bt_all_up_Click);
            // 
            // bt_all_down
            // 
            this.bt_all_down.Location = new System.Drawing.Point(1479, 982);
            this.bt_all_down.Name = "bt_all_down";
            this.bt_all_down.Size = new System.Drawing.Size(284, 50);
            this.bt_all_down.TabIndex = 36;
            this.bt_all_down.Text = "все к нижнему";
            this.bt_all_down.UseVisualStyleBackColor = true;
            this.bt_all_down.Click += new System.EventHandler(this.bt_all_down_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2078, 1118);
            this.Controls.Add(this.bt_all_down);
            this.Controls.Add(this.bt_all_up);
            this.Controls.Add(this.bt_down);
            this.Controls.Add(this.bt_up);
            this.Controls.Add(this.bt_replace);
            this.Controls.Add(this.tb4_new);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb4_old);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb3_in);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb2_in);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_get_text);
            this.Controls.Add(this.bt_get_text);
            this.Controls.Add(this.bt_write_text);
            this.Controls.Add(this.tb_write_text);
            this.Controls.Add(this.bt_create);
            this.Controls.Add(this.tb_root);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_root;
        private System.Windows.Forms.Button bt_create;
        private System.Windows.Forms.TextBox tb_write_text;
        private System.Windows.Forms.Button bt_write_text;
        private System.Windows.Forms.Button bt_get_text;
        private System.Windows.Forms.TextBox tb_get_text;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb2_in;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb3_in;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb4_old;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb4_new;
        private System.Windows.Forms.Button bt_replace;
        private System.Windows.Forms.Button bt_up;
        private System.Windows.Forms.Button bt_down;
        private System.Windows.Forms.Button bt_all_up;
        private System.Windows.Forms.Button bt_all_down;
    }
}

