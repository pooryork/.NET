namespace Pr24WindowsForms
{
    partial class Delete_Student
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
            this.deleted_student_last_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_student_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleted_student_last_name
            // 
            this.deleted_student_last_name.Location = new System.Drawing.Point(335, 160);
            this.deleted_student_last_name.Name = "deleted_student_last_name";
            this.deleted_student_last_name.Size = new System.Drawing.Size(169, 22);
            this.deleted_student_last_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия студента";
            // 
            // delete_student_button
            // 
            this.delete_student_button.Location = new System.Drawing.Point(355, 271);
            this.delete_student_button.Name = "delete_student_button";
            this.delete_student_button.Size = new System.Drawing.Size(127, 45);
            this.delete_student_button.TabIndex = 2;
            this.delete_student_button.Text = "Удалить";
            this.delete_student_button.UseVisualStyleBackColor = true;
            this.delete_student_button.Click += new System.EventHandler(this.delete_student_button_Click);
            // 
            // Delete_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete_student_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleted_student_last_name);
            this.Name = "Delete_Student";
            this.Text = "Удаление студента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox deleted_student_last_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete_student_button;
    }
}