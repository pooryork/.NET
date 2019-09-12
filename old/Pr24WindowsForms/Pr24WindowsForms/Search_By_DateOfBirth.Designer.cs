namespace Pr24WindowsForms
{
    partial class Search_By_DateOfBirth
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
            this.search_by_dateOfBirth_button = new System.Windows.Forms.Button();
            this.student_dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // search_by_dateOfBirth_button
            // 
            this.search_by_dateOfBirth_button.Location = new System.Drawing.Point(343, 277);
            this.search_by_dateOfBirth_button.Name = "search_by_dateOfBirth_button";
            this.search_by_dateOfBirth_button.Size = new System.Drawing.Size(133, 56);
            this.search_by_dateOfBirth_button.TabIndex = 0;
            this.search_by_dateOfBirth_button.Text = "Найти";
            this.search_by_dateOfBirth_button.UseVisualStyleBackColor = true;
            this.search_by_dateOfBirth_button.Click += new System.EventHandler(this.search_by_dateOfBirth_button_Click);
            // 
            // student_dateOfBirth
            // 
            this.student_dateOfBirth.Location = new System.Drawing.Point(354, 175);
            this.student_dateOfBirth.Name = "student_dateOfBirth";
            this.student_dateOfBirth.Size = new System.Drawing.Size(200, 22);
            this.student_dateOfBirth.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дата рождения студента";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Search_By_DateOfBirth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.student_dateOfBirth);
            this.Controls.Add(this.search_by_dateOfBirth_button);
            this.Name = "Search_By_DateOfBirth";
            this.Text = "Поиск по дате рождения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search_by_dateOfBirth_button;
        private System.Windows.Forms.DateTimePicker student_dateOfBirth;
        private System.Windows.Forms.Label label1;
    }
}