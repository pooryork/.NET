namespace Pr24WindowsForms
{
    partial class Add_Student
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
            this.student_add = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.date_of_birth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // student_add
            // 
            this.student_add.Location = new System.Drawing.Point(312, 341);
            this.student_add.Name = "student_add";
            this.student_add.Size = new System.Drawing.Size(172, 51);
            this.student_add.TabIndex = 0;
            this.student_add.Text = "Добавить студента";
            this.student_add.UseVisualStyleBackColor = true;
            this.student_add.Click += new System.EventHandler(this.student_add_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(259, 114);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(310, 22);
            this.name.TabIndex = 1;
            // 
            // date_of_birth
            // 
            this.date_of_birth.Location = new System.Drawing.Point(259, 233);
            this.date_of_birth.Name = "date_of_birth";
            this.date_of_birth.Size = new System.Drawing.Size(310, 22);
            this.date_of_birth.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата рождения";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Add_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_of_birth);
            this.Controls.Add(this.name);
            this.Controls.Add(this.student_add);
            this.Name = "Add_Student";
            this.Text = "Добавить студента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button student_add;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.DateTimePicker date_of_birth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}