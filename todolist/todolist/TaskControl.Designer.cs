
namespace todolist
{
    partial class TaskControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.taskText = new System.Windows.Forms.Label();
            this.button_Done = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelProjectName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // taskText
            // 
            this.taskText.AutoSize = true;
            this.taskText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.taskText.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.taskText.Location = new System.Drawing.Point(44, 14);
            this.taskText.Name = "taskText";
            this.taskText.Size = new System.Drawing.Size(35, 20);
            this.taskText.TabIndex = 0;
            this.taskText.Text = "text";
            // 
            // button_Done
            // 
            this.button_Done.Location = new System.Drawing.Point(8, 14);
            this.button_Done.Name = "button_Done";
            this.button_Done.Size = new System.Drawing.Size(21, 23);
            this.button_Done.TabIndex = 2;
            this.button_Done.UseVisualStyleBackColor = true;
            this.button_Done.Click += new System.EventHandler(this.button_Done_Click);
            // 
            // button_del
            // 
            this.button_del.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
            this.button_del.Location = new System.Drawing.Point(285, 14);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(81, 30);
            this.button_del.TabIndex = 3;
            this.button_del.Text = "Удалить";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.labelDescription.Location = new System.Drawing.Point(5, 49);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(81, 19);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "Deskription";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.labelDay.Location = new System.Drawing.Point(5, 78);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(38, 19);
            this.labelDay.TabIndex = 5;
            this.labelDay.Text = "Date";
            // 
            // labelProjectName
            // 
            this.labelProjectName.AutoSize = true;
            this.labelProjectName.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelProjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.labelProjectName.Location = new System.Drawing.Point(281, 78);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(53, 19);
            this.labelProjectName.TabIndex = 6;
            this.labelProjectName.Text = "Project";
            // 
            // TaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.labelProjectName);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_Done);
            this.Controls.Add(this.taskText);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "TaskControl";
            this.Size = new System.Drawing.Size(409, 104);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TaskControl_MouseDoubleClick);
            this.MouseLeave += new System.EventHandler(this.TaskControl_MouseLeave);
            this.MouseHover += new System.EventHandler(this.TaskControl_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskText;
        private System.Windows.Forms.Button button_Done;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelProjectName;
    }
}
