
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
            this.PriorityText = new System.Windows.Forms.Label();
            this.button_Done = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskText
            // 
            this.taskText.AutoSize = true;
            this.taskText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.taskText.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskText.Location = new System.Drawing.Point(44, 14);
            this.taskText.Name = "taskText";
            this.taskText.Size = new System.Drawing.Size(35, 20);
            this.taskText.TabIndex = 0;
            this.taskText.Text = "text";
            // 
            // PriorityText
            // 
            this.PriorityText.AutoSize = true;
            this.PriorityText.Location = new System.Drawing.Point(209, 19);
            this.PriorityText.Name = "PriorityText";
            this.PriorityText.Size = new System.Drawing.Size(38, 13);
            this.PriorityText.TabIndex = 1;
            this.PriorityText.Text = "Priority";
            // 
            // button_Done
            // 
            this.button_Done.Location = new System.Drawing.Point(8, 14);
            this.button_Done.Name = "button_Done";
            this.button_Done.Size = new System.Drawing.Size(21, 23);
            this.button_Done.TabIndex = 2;
            this.button_Done.UseVisualStyleBackColor = true;
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(285, 14);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(66, 22);
            this.button_del.TabIndex = 3;
            this.button_del.Text = "Удалить";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // TaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_Done);
            this.Controls.Add(this.PriorityText);
            this.Controls.Add(this.taskText);
            this.Name = "TaskControl";
            this.Size = new System.Drawing.Size(409, 43);
            this.MouseLeave += new System.EventHandler(this.TaskControl_MouseLeave);
            this.MouseHover += new System.EventHandler(this.TaskControl_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskText;
        private System.Windows.Forms.Label PriorityText;
        private System.Windows.Forms.Button button_Done;
        private System.Windows.Forms.Button button_del;
    }
}
