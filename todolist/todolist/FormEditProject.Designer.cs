
namespace todolist
{
    partial class FormEditProject
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
            this.textBoxProjectEdit = new System.Windows.Forms.TextBox();
            this.buttonEditProject = new System.Windows.Forms.Button();
            this.labelProjectName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxProjectEdit
            // 
            this.textBoxProjectEdit.Location = new System.Drawing.Point(17, 64);
            this.textBoxProjectEdit.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProjectEdit.Name = "textBoxProjectEdit";
            this.textBoxProjectEdit.Size = new System.Drawing.Size(283, 25);
            this.textBoxProjectEdit.TabIndex = 3;
            // 
            // buttonEditProject
            // 
            this.buttonEditProject.Location = new System.Drawing.Point(361, 64);
            this.buttonEditProject.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditProject.Name = "buttonEditProject";
            this.buttonEditProject.Size = new System.Drawing.Size(100, 30);
            this.buttonEditProject.TabIndex = 2;
            this.buttonEditProject.Text = "Изменить";
            this.buttonEditProject.UseVisualStyleBackColor = true;
            this.buttonEditProject.Click += new System.EventHandler(this.buttonEditProject_Click);
            // 
            // labelProjectName
            // 
            this.labelProjectName.AutoSize = true;
            this.labelProjectName.ForeColor = System.Drawing.Color.White;
            this.labelProjectName.Location = new System.Drawing.Point(14, 25);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(54, 17);
            this.labelProjectName.TabIndex = 4;
            this.labelProjectName.Text = "Проект";
            // 
            // FormEditProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(480, 143);
            this.Controls.Add(this.labelProjectName);
            this.Controls.Add(this.textBoxProjectEdit);
            this.Controls.Add(this.buttonEditProject);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEditProject";
            this.Text = "Изменение проекта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProjectEdit;
        private System.Windows.Forms.Button buttonEditProject;
        private System.Windows.Forms.Label labelProjectName;
    }
}