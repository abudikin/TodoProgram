
namespace todolist
{
    partial class FormTaskShow
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
            this.SuspendLayout();
            // 
            // textBoxTaskEdit
            // 
            this.textBoxTaskEdit.Location = new System.Drawing.Point(12, 22);
            this.textBoxTaskEdit.Name = "textBoxTaskEdit";
            this.textBoxTaskEdit.Size = new System.Drawing.Size(201, 20);
            this.textBoxTaskEdit.TabIndex = 0;
            // 
            // comboBoxEditProject
            // 
            this.comboBoxEditProject.FormattingEnabled = true;
            this.comboBoxEditProject.Location = new System.Drawing.Point(235, 22);
            this.comboBoxEditProject.Name = "comboBoxEditProject";
            this.comboBoxEditProject.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEditProject.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // comboBoxEditPriority
            // 
            this.comboBoxEditPriority.FormattingEnabled = true;
            this.comboBoxEditPriority.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBoxEditPriority.Location = new System.Drawing.Point(365, 22);
            this.comboBoxEditPriority.Name = "comboBoxEditPriority";
            this.comboBoxEditPriority.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEditPriority.TabIndex = 3;
            // 
            // textBoxDesckiptionEdit
            // 
            this.textBoxDesckiptionEdit.Location = new System.Drawing.Point(11, 62);
            this.textBoxDesckiptionEdit.Name = "textBoxDesckiptionEdit";
            this.textBoxDesckiptionEdit.Size = new System.Drawing.Size(345, 20);
            this.textBoxDesckiptionEdit.TabIndex = 4;
            // 
            // buttonEditTask
            // 
            this.buttonEditTask.Location = new System.Drawing.Point(365, 96);
            this.buttonEditTask.Name = "buttonEditTask";
            this.buttonEditTask.Size = new System.Drawing.Size(121, 23);
            this.buttonEditTask.TabIndex = 5;
            this.buttonEditTask.Text = "Изменить";
            this.buttonEditTask.UseVisualStyleBackColor = true;
            this.buttonEditTask.Click += new System.EventHandler(this.buttonEditTask_Click);
            // 
            // FormTaskShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 131);
            this.Controls.Add(this.buttonEditTask);
            this.Controls.Add(this.textBoxDesckiptionEdit);
            this.Controls.Add(this.comboBoxEditPriority);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxEditProject);
            this.Controls.Add(this.textBoxTaskEdit);
            this.Name = "FormTaskShow";
            this.Text = "FormTaskShow";
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
    }
}