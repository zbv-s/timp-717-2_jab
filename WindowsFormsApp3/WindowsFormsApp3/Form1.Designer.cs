namespace WindowsFormsApp3
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menu_start = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_level = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_level_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_level_4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_level_5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_level_6 = new System.Windows.Forms.ToolStripMenuItem();
            this.tema6 = new System.Windows.Forms.ToolStripMenuItem();
            this.tema1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tema2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tema3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tema4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tema5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tema7 = new System.Windows.Forms.ToolStripMenuItem();
            this.tema8 = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_help_rules = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_help_about = new System.Windows.Forms.ToolStripMenuItem();
            this.рейтингToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.SystemColors.Control;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_start,
            this.menu_level,
            this.tema6,
            this.помощьToolStripMenuItem,
            this.рейтингToolStripMenuItem,
            this.exit});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(638, 52);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // menu_start
            // 
            this.menu_start.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_start.Name = "menu_start";
            this.menu_start.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menu_start.Size = new System.Drawing.Size(88, 48);
            this.menu_start.Text = "Новая игра";
            this.menu_start.Click += new System.EventHandler(this.menu_start_Click);
            // 
            // menu_level
            // 
            this.menu_level.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_level_3,
            this.menu_level_4,
            this.menu_level_5,
            this.menu_level_6});
            this.menu_level.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_level.Name = "menu_level";
            this.menu_level.Size = new System.Drawing.Size(71, 48);
            this.menu_level.Text = "Уровень";
            // 
            // menu_level_3
            // 
            this.menu_level_3.Name = "menu_level_3";
            this.menu_level_3.Size = new System.Drawing.Size(112, 24);
            this.menu_level_3.Text = "3 x 3";
            this.menu_level_3.Click += new System.EventHandler(this.menu_level_3_Click);
            // 
            // menu_level_4
            // 
            this.menu_level_4.Name = "menu_level_4";
            this.menu_level_4.Size = new System.Drawing.Size(112, 24);
            this.menu_level_4.Text = "4 x 4";
            this.menu_level_4.Click += new System.EventHandler(this.menu_level_4_Click);
            // 
            // menu_level_5
            // 
            this.menu_level_5.Name = "menu_level_5";
            this.menu_level_5.Size = new System.Drawing.Size(112, 24);
            this.menu_level_5.Text = "5 x 5";
            this.menu_level_5.Click += new System.EventHandler(this.menu_level_5_Click);
            // 
            // menu_level_6
            // 
            this.menu_level_6.Name = "menu_level_6";
            this.menu_level_6.Size = new System.Drawing.Size(112, 24);
            this.menu_level_6.Text = "6 x 6";
            this.menu_level_6.Click += new System.EventHandler(this.menu_level_6_Click);
            // 
            // tema6
            // 
            this.tema6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tema1,
            this.tema2,
            this.tema3,
            this.tema4,
            this.tema5,
            this.toolStripMenuItem2,
            this.tema7,
            this.tema8});
            this.tema6.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tema6.Name = "tema6";
            this.tema6.Size = new System.Drawing.Size(51, 48);
            this.tema6.Text = "Тема";
            // 
            // tema1
            // 
            this.tema1.Name = "tema1";
            this.tema1.Size = new System.Drawing.Size(87, 24);
            this.tema1.Text = "1";
            this.tema1.Click += new System.EventHandler(this.tema1_Click);
            // 
            // tema2
            // 
            this.tema2.Name = "tema2";
            this.tema2.Size = new System.Drawing.Size(87, 24);
            this.tema2.Text = "2";
            this.tema2.Click += new System.EventHandler(this.tema2_Click);
            // 
            // tema3
            // 
            this.tema3.Name = "tema3";
            this.tema3.Size = new System.Drawing.Size(87, 24);
            this.tema3.Text = "3";
            this.tema3.Click += new System.EventHandler(this.tema3_Click);
            // 
            // tema4
            // 
            this.tema4.Name = "tema4";
            this.tema4.Size = new System.Drawing.Size(87, 24);
            this.tema4.Text = "4";
            this.tema4.Click += new System.EventHandler(this.tema4_Click);
            // 
            // tema5
            // 
            this.tema5.Name = "tema5";
            this.tema5.Size = new System.Drawing.Size(87, 24);
            this.tema5.Text = "5";
            this.tema5.Click += new System.EventHandler(this.tema5_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(87, 24);
            this.toolStripMenuItem2.Text = "6";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // tema7
            // 
            this.tema7.Name = "tema7";
            this.tema7.Size = new System.Drawing.Size(87, 24);
            this.tema7.Text = "7";
            this.tema7.Click += new System.EventHandler(this.tema7_Click);
            // 
            // tema8
            // 
            this.tema8.Name = "tema8";
            this.tema8.Size = new System.Drawing.Size(87, 24);
            this.tema8.Text = "8";
            this.tema8.Click += new System.EventHandler(this.tema8_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_help_rules,
            this.menu_help_about});
            this.помощьToolStripMenuItem.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(69, 48);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // menu_help_rules
            // 
            this.menu_help_rules.Name = "menu_help_rules";
            this.menu_help_rules.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.menu_help_rules.Size = new System.Drawing.Size(214, 24);
            this.menu_help_rules.Text = "Правила игры";
            this.menu_help_rules.Click += new System.EventHandler(this.menu_help_rules_Click);
            // 
            // menu_help_about
            // 
            this.menu_help_about.Name = "menu_help_about";
            this.menu_help_about.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menu_help_about.Size = new System.Drawing.Size(214, 24);
            this.menu_help_about.Text = "Об авторе";
            this.menu_help_about.Click += new System.EventHandler(this.menu_help_about_Click);
            // 
            // рейтингToolStripMenuItem
            // 
            this.рейтингToolStripMenuItem.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.рейтингToolStripMenuItem.Name = "рейтингToolStripMenuItem";
            this.рейтингToolStripMenuItem.Size = new System.Drawing.Size(72, 48);
            this.рейтингToolStripMenuItem.Text = "Рекорды";
            this.рейтингToolStripMenuItem.Click += new System.EventHandler(this.рейтингToolStripMenuItem_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Name = "exit";
            this.exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exit.Size = new System.Drawing.Size(58, 48);
            this.exit.Text = "Выход";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 414);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(52, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(521, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(435, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Счет";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(528, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 13);
            this.labelName.TabIndex = 5;
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 466);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пятнашки с изображениями";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menu_start;
        private System.Windows.Forms.ToolStripMenuItem menu_level;
        private System.Windows.Forms.ToolStripMenuItem menu_level_3;
        private System.Windows.Forms.ToolStripMenuItem menu_level_4;
        private System.Windows.Forms.ToolStripMenuItem menu_level_5;
        private System.Windows.Forms.ToolStripMenuItem menu_level_6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tema6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem tema1;
        private System.Windows.Forms.ToolStripMenuItem tema2;
        private System.Windows.Forms.ToolStripMenuItem tema3;
        private System.Windows.Forms.ToolStripMenuItem tema4;
        private System.Windows.Forms.ToolStripMenuItem tema5;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_help_rules;
        private System.Windows.Forms.ToolStripMenuItem menu_help_about;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tema7;
        private System.Windows.Forms.ToolStripMenuItem tema8;
        private System.Windows.Forms.ToolStripMenuItem рейтингToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelName;
    }
}

