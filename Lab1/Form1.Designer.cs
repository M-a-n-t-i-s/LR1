namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.обучениеСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.служебныеСловаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.структурныеДаннеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.массивыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.множестваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обучениеСToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(819, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // обучениеСToolStripMenuItem
            // 
            this.обучениеСToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.служебныеСловаToolStripMenuItem,
            this.типыДанныхToolStripMenuItem,
            this.структурныеДаннеToolStripMenuItem});
            this.обучениеСToolStripMenuItem.Name = "обучениеСToolStripMenuItem";
            this.обучениеСToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.обучениеСToolStripMenuItem.Text = "Обучение С++";
            // 
            // служебныеСловаToolStripMenuItem
            // 
            this.служебныеСловаToolStripMenuItem.Name = "служебныеСловаToolStripMenuItem";
            this.служебныеСловаToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.служебныеСловаToolStripMenuItem.Text = "Служебные слова";
            this.служебныеСловаToolStripMenuItem.Click += new System.EventHandler(this.служебныеСловаToolStripMenuItem_Click);
            // 
            // типыДанныхToolStripMenuItem
            // 
            this.типыДанныхToolStripMenuItem.Name = "типыДанныхToolStripMenuItem";
            this.типыДанныхToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.типыДанныхToolStripMenuItem.Text = "Типы данных";
            this.типыДанныхToolStripMenuItem.Click += new System.EventHandler(this.типыДанныхToolStripMenuItem_Click);
            // 
            // структурныеДаннеToolStripMenuItem
            // 
            this.структурныеДаннеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.массивыToolStripMenuItem,
            this.множестваToolStripMenuItem});
            this.структурныеДаннеToolStripMenuItem.Name = "структурныеДаннеToolStripMenuItem";
            this.структурныеДаннеToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.структурныеДаннеToolStripMenuItem.Text = "Структурные данне";
            // 
            // массивыToolStripMenuItem
            // 
            this.массивыToolStripMenuItem.Name = "массивыToolStripMenuItem";
            this.массивыToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.массивыToolStripMenuItem.Text = "Массивы";
            this.массивыToolStripMenuItem.Click += new System.EventHandler(this.массивыToolStripMenuItem_Click);
            // 
            // множестваToolStripMenuItem
            // 
            this.множестваToolStripMenuItem.Name = "множестваToolStripMenuItem";
            this.множестваToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.множестваToolStripMenuItem.Text = "Множества";
            this.множестваToolStripMenuItem.Click += new System.EventHandler(this.множестваToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.helpToolStripMenuItem.Text = "Help-справка";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(658, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Программа для обучения языку С++";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(819, 475);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem обучениеСToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem служебныеСловаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem структурныеДаннеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem массивыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem множестваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

