namespace Pr24WindowsForms
{
    partial class Add_Department
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
            this.department_add = new System.Windows.Forms.Button();
            this.department_name = new System.Windows.Forms.TextBox();
            this.name_of_head = new System.Windows.Forms.TextBox();
            this.date_of_foundation = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // department_add
            // 
            this.department_add.Location = new System.Drawing.Point(310, 353);
            this.department_add.Name = "department_add";
            this.department_add.Size = new System.Drawing.Size(192, 45);
            this.department_add.TabIndex = 0;
            this.department_add.Text = "Добавить факультет";
            this.department_add.UseVisualStyleBackColor = true;
            // 
            // department_name
            // 
            this.department_name.Location = new System.Drawing.Point(213, 124);
            this.department_name.Name = "department_name";
            this.department_name.Size = new System.Drawing.Size(369, 22);
            this.department_name.TabIndex = 1;
            // 
            // name_of_head
            // 
            this.name_of_head.Location = new System.Drawing.Point(213, 215);
            this.name_of_head.Name = "name_of_head";
            this.name_of_head.Size = new System.Drawing.Size(369, 22);
            this.name_of_head.TabIndex = 2;
            // 
            // date_of_foundation
            // 
            this.date_of_foundation.Location = new System.Drawing.Point(213, 281);
            this.date_of_foundation.Name = "date_of_foundation";
            this.date_of_foundation.Size = new System.Drawing.Size(369, 22);
            this.date_of_foundation.TabIndex = 3;
            // 
            // Add_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.date_of_foundation);
            this.Controls.Add(this.name_of_head);
            this.Controls.Add(this.department_name);
            this.Controls.Add(this.department_add);
            this.Name = "Add_Department";
            this.Text = "Добавить факультет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button department_add;
        private System.Windows.Forms.TextBox department_name;
        private System.Windows.Forms.TextBox name_of_head;
        private System.Windows.Forms.DateTimePicker date_of_foundation;
    }
}