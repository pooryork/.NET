namespace Pr24WindowsForms
{
    partial class Add_toUniversity
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
            this.add_student_to_university_button = new System.Windows.Forms.Button();
            this.department_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.university_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_student_to_university_button
            // 
            this.add_student_to_university_button.Location = new System.Drawing.Point(276, 309);
            this.add_student_to_university_button.Name = "add_student_to_university_button";
            this.add_student_to_university_button.Size = new System.Drawing.Size(162, 63);
            this.add_student_to_university_button.TabIndex = 26;
            this.add_student_to_university_button.Text = "Добавить";
            this.add_student_to_university_button.UseVisualStyleBackColor = true;
            this.add_student_to_university_button.Click += new System.EventHandler(this.add_student_to_university_button_Click);
            // 
            // department_name
            // 
            this.department_name.Location = new System.Drawing.Point(360, 216);
            this.department_name.Name = "department_name";
            this.department_name.Size = new System.Drawing.Size(292, 22);
            this.department_name.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Название факультета";
            // 
            // university_name
            // 
            this.university_name.Location = new System.Drawing.Point(360, 159);
            this.university_name.Name = "university_name";
            this.university_name.Size = new System.Drawing.Size(292, 22);
            this.university_name.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Название университета";
            // 
            // Add_toUniversity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add_student_to_university_button);
            this.Controls.Add(this.department_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.university_name);
            this.Controls.Add(this.label1);
            this.Name = "Add_toUniversity";
            this.Text = "Добавление факультета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_student_to_university_button;
        private System.Windows.Forms.TextBox department_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox university_name;
        private System.Windows.Forms.Label label1;
    }
}