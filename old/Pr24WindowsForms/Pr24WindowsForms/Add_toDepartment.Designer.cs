namespace Pr24WindowsForms
{
    partial class Add_toDepartment
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
            this.add_student_to_department_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.specialty = new System.Windows.Forms.TextBox();
            this.group_number = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.student_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.department_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_student_to_department_button
            // 
            this.add_student_to_department_button.Location = new System.Drawing.Point(276, 309);
            this.add_student_to_department_button.Name = "add_student_to_department_button";
            this.add_student_to_department_button.Size = new System.Drawing.Size(162, 63);
            this.add_student_to_department_button.TabIndex = 17;
            this.add_student_to_department_button.Text = "Добавить";
            this.add_student_to_department_button.UseVisualStyleBackColor = true;
            this.add_student_to_department_button.Click += new System.EventHandler(this.add_student_to_department_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Специальность/направление";
            // 
            // specialty
            // 
            this.specialty.Location = new System.Drawing.Point(366, 233);
            this.specialty.Name = "specialty";
            this.specialty.Size = new System.Drawing.Size(292, 22);
            this.specialty.TabIndex = 15;
            // 
            // group_number
            // 
            this.group_number.Location = new System.Drawing.Point(366, 180);
            this.group_number.Name = "group_number";
            this.group_number.Size = new System.Drawing.Size(292, 22);
            this.group_number.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Номер группы";
            // 
            // student_name
            // 
            this.student_name.Location = new System.Drawing.Point(366, 136);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(292, 22);
            this.student_name.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "ФИО студента";
            // 
            // department_name
            // 
            this.department_name.Location = new System.Drawing.Point(366, 79);
            this.department_name.Name = "department_name";
            this.department_name.Size = new System.Drawing.Size(292, 22);
            this.department_name.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Название факультета";
            // 
            // Add_toDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add_student_to_department_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.specialty);
            this.Controls.Add(this.group_number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.student_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.department_name);
            this.Controls.Add(this.label1);
            this.Name = "Add_toDepartment";
            this.Text = "Add_toDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_student_to_department_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox specialty;
        private System.Windows.Forms.TextBox group_number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox student_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox department_name;
        private System.Windows.Forms.Label label1;
    }
}