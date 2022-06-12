
namespace todolist
{
    partial class FormTaskEdit
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
            this.textBoxTaskEdit = new System.Windows.Forms.TextBox();
            this.comboBoxEditProject = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxEditPriority = new System.Windows.Forms.ComboBox();
            this.textBoxDesckiptionEdit = new System.Windows.Forms.TextBox();
            this.buttonEditTask = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTaskEdit
            // 
            this.textBoxTaskEdit.Location = new System.Drawing.Point(18, 29);
            this.textBoxTaskEdit.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTaskEdit.Name = "textBoxTaskEdit";
            this.textBoxTaskEdit.Size = new System.Drawing.Size(267, 25);
            this.textBoxTaskEdit.TabIndex = 0;
            // 
            // comboBoxEditProject
            // 
            this.comboBoxEditProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditProject.FormattingEnabled = true;
            this.comboBoxEditProject.Location = new System.Drawing.Point(313, 29);
            this.comboBoxEditProject.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEditProject.Name = "comboBoxEditProject";
            this.comboBoxEditProject.Size = new System.Drawing.Size(160, 25);
            this.comboBoxEditProject.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 153);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 25);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // comboBoxEditPriority
            // 
            this.comboBoxEditPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditPriority.FormattingEnabled = true;
            this.comboBoxEditPriority.Location = new System.Drawing.Point(487, 29);
            this.comboBoxEditPriority.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEditPriority.Name = "comboBoxEditPriority";
            this.comboBoxEditPriority.Size = new System.Drawing.Size(160, 25);
            this.comboBoxEditPriority.TabIndex = 3;
            // 
            // textBoxDesckiptionEdit
            // 
            this.textBoxDesckiptionEdit.Location = new System.Drawing.Point(16, 94);
            this.textBoxDesckiptionEdit.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDesckiptionEdit.Name = "textBoxDesckiptionEdit";
            this.textBoxDesckiptionEdit.Size = new System.Drawing.Size(631, 25);
            this.textBoxDesckiptionEdit.TabIndex = 4;
            // 
            // buttonEditTask
            // 
            this.buttonEditTask.Location = new System.Drawing.Point(542, 148);
            this.buttonEditTask.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditTask.Name = "buttonEditTask";
            this.buttonEditTask.Size = new System.Drawing.Size(105, 30);
            this.buttonEditTask.TabIndex = 5;
            this.buttonEditTask.Text = "Изменить";
            this.buttonEditTask.UseVisualStyleBackColor = true;
            this.buttonEditTask.Click += new System.EventHandler(this.buttonEditTask_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(14, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Задача";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(14, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(309, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Проект";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(483, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Приоритет";
            // 
            // FormTaskEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(671, 191);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEditTask);
            this.Controls.Add(this.textBoxDesckiptionEdit);
            this.Controls.Add(this.comboBoxEditPriority);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxEditProject);
            this.Controls.Add(this.textBoxTaskEdit);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTaskEdit";
            this.Text = "Редактирование задач";
            this.Load += new System.EventHandler(this.FormTaskShow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTaskEdit;
        private System.Windows.Forms.ComboBox comboBoxEditProject;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxEditPriority;
        private System.Windows.Forms.TextBox textBoxDesckiptionEdit;
        private System.Windows.Forms.Button buttonEditTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}