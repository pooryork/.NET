namespace Pr24WindowsForms
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
            this.components = new System.ComponentModel.Container();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cоздатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.факультетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.университетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поФамилииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поДатеРожденияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обУниверситетеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оФакультетеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оСтудентеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.факультетToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСтудентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.университетToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьФакультетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cоздатьToolStripMenuItem,
            this.студентToolStripMenuItem1,
            this.факультетToolStripMenuItem1,
            this.университетToolStripMenuItem1,
            this.информацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cоздатьToolStripMenuItem
            // 
            this.cоздатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.студентToolStripMenuItem,
            this.факультетToolStripMenuItem,
            this.университетToolStripMenuItem});
            this.cоздатьToolStripMenuItem.Name = "cоздатьToolStripMenuItem";
            this.cоздатьToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.cоздатьToolStripMenuItem.Text = "Cоздать";
            // 
            // студентToolStripMenuItem
            // 
            this.студентToolStripMenuItem.Name = "студентToolStripMenuItem";
            this.студентToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.студентToolStripMenuItem.Text = "Студент";
            this.студентToolStripMenuItem.Click += new System.EventHandler(this.студентToolStripMenuItem_Click);
            // 
            // факультетToolStripMenuItem
            // 
            this.факультетToolStripMenuItem.Name = "факультетToolStripMenuItem";
            this.факультетToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.факультетToolStripMenuItem.Text = "Факультет";
            this.факультетToolStripMenuItem.Click += new System.EventHandler(this.факультетToolStripMenuItem_Click);
            // 
            // университетToolStripMenuItem
            // 
            this.университетToolStripMenuItem.Name = "университетToolStripMenuItem";
            this.университетToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.университетToolStripMenuItem.Text = "Университет";
            this.университетToolStripMenuItem.Click += new System.EventHandler(this.университетToolStripMenuItem_Click);
            // 
            // студентToolStripMenuItem1
            // 
            this.студентToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.поискToolStripMenuItem});
            this.студентToolStripMenuItem1.Name = "студентToolStripMenuItem1";
            this.студентToolStripMenuItem1.Size = new System.Drawing.Size(74, 24);
            this.студентToolStripMenuItem1.Text = "Студент";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поФамилииToolStripMenuItem,
            this.поДатеРожденияToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // поФамилииToolStripMenuItem
            // 
            this.поФамилииToolStripMenuItem.Name = "поФамилииToolStripMenuItem";
            this.поФамилииToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.поФамилииToolStripMenuItem.Text = "По фамилии";
            this.поФамилииToolStripMenuItem.Click += new System.EventHandler(this.поФамилииToolStripMenuItem_Click);
            // 
            // поДатеРожденияToolStripMenuItem
            // 
            this.поДатеРожденияToolStripMenuItem.Name = "поДатеРожденияToolStripMenuItem";
            this.поДатеРожденияToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.поДатеРожденияToolStripMenuItem.Text = "По дате рождения";
            this.поДатеРожденияToolStripMenuItem.Click += new System.EventHandler(this.поДатеРожденияToolStripMenuItem_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обУниверситетеToolStripMenuItem,
            this.оФакультетеToolStripMenuItem,
            this.оСтудентеToolStripMenuItem});
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // обУниверситетеToolStripMenuItem
            // 
            this.обУниверситетеToolStripMenuItem.Name = "обУниверситетеToolStripMenuItem";
            this.обУниверситетеToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.обУниверситетеToolStripMenuItem.Text = "О университете";
            this.обУниверситетеToolStripMenuItem.Click += new System.EventHandler(this.обУниверситетеToolStripMenuItem_Click);
            // 
            // оФакультетеToolStripMenuItem
            // 
            this.оФакультетеToolStripMenuItem.Name = "оФакультетеToolStripMenuItem";
            this.оФакультетеToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.оФакультетеToolStripMenuItem.Text = "О факультетах";
            this.оФакультетеToolStripMenuItem.Click += new System.EventHandler(this.оФакультетеToolStripMenuItem_Click);
            // 
            // оСтудентеToolStripMenuItem
            // 
            this.оСтудентеToolStripMenuItem.Name = "оСтудентеToolStripMenuItem";
            this.оСтудентеToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.оСтудентеToolStripMenuItem.Text = "О студентах";
            this.оСтудентеToolStripMenuItem.Click += new System.EventHandler(this.оСтудентеToolStripMenuItem_Click);
            // 
            // факультетToolStripMenuItem1
            // 
            this.факультетToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.добавитьСтудентаToolStripMenuItem});
            this.факультетToolStripMenuItem1.Name = "факультетToolStripMenuItem1";
            this.факультетToolStripMenuItem1.Size = new System.Drawing.Size(90, 24);
            this.факультетToolStripMenuItem1.Text = "Факультет";
            // 
            // добавитьСтудентаToolStripMenuItem
            // 
            this.добавитьСтудентаToolStripMenuItem.Name = "добавитьСтудентаToolStripMenuItem";
            this.добавитьСтудентаToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.добавитьСтудентаToolStripMenuItem.Text = "Добавить студента";
            // 
            // университетToolStripMenuItem1
            // 
            this.университетToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem1,
            this.добавитьФакультетToolStripMenuItem});
            this.университетToolStripMenuItem1.Name = "университетToolStripMenuItem1";
            this.университетToolStripMenuItem1.Size = new System.Drawing.Size(109, 24);
            this.университетToolStripMenuItem1.Text = "Университет";
            // 
            // добавитьФакультетToolStripMenuItem
            // 
            this.добавитьФакультетToolStripMenuItem.Name = "добавитьФакультетToolStripMenuItem";
            this.добавитьФакультетToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.добавитьФакультетToolStripMenuItem.Text = "Добавить факультет";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // создатьToolStripMenuItem1
            // 
            this.создатьToolStripMenuItem1.Name = "создатьToolStripMenuItem1";
            this.создатьToolStripMenuItem1.Size = new System.Drawing.Size(223, 26);
            this.создатьToolStripMenuItem1.Text = "Создать";
            this.создатьToolStripMenuItem1.Click += new System.EventHandler(this.создатьToolStripMenuItem1_Click);
            // 
            // addStudentBindingSource
            // 
            this.addStudentBindingSource.DataSource = typeof(Pr24WindowsForms.Add_Student);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(Pr24WindowsForms.Program);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Университет";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cоздатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem факультетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem университетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поФамилииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поДатеРожденияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обУниверситетеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оФакультетеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оСтудентеToolStripMenuItem;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.BindingSource addStudentBindingSource;
        private System.Windows.Forms.ToolStripMenuItem факультетToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСтудентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem университетToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьФакультетToolStripMenuItem;
    }
}

