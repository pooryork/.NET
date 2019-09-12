namespace Pr24WindowsForms
{
    partial class Search_By_LastName
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
            this.search_by_lastName_button = new System.Windows.Forms.Button();
            this.needed_student_lastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // search_by_lastName_button
            // 
            this.search_by_lastName_button.Location = new System.Drawing.Point(353, 252);
            this.search_by_lastName_button.Name = "search_by_lastName_button";
            this.search_by_lastName_button.Size = new System.Drawing.Size(137, 55);
            this.search_by_lastName_button.TabIndex = 0;
            this.search_by_lastName_button.Text = "Найти";
            this.search_by_lastName_button.UseVisualStyleBackColor = true;
            this.search_by_lastName_button.Click += new System.EventHandler(this.search_by_lastName_button_Click);
            // 
            // needed_student_lastName
            // 
            this.needed_student_lastName.Location = new System.Drawing.Point(395, 174);
            this.needed_student_lastName.Name = "needed_student_lastName";
            this.needed_student_lastName.Size = new System.Drawing.Size(176, 22);
            this.needed_student_lastName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фамилия студента";
            // 
            // Search_By_LastName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.needed_student_lastName);
            this.Controls.Add(this.search_by_lastName_button);
            this.Name = "Search_By_LastName";
            this.Text = "Поиск по фамилии";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search_by_lastName_button;
        private System.Windows.Forms.TextBox needed_student_lastName;
        private System.Windows.Forms.Label label1;
    }
}