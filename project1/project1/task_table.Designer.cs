
namespace project1
{
    partial class task_table
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
            this.task_text = new System.Windows.Forms.Label();
            this.deletebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // task_text
            // 
            this.task_text.AutoSize = true;
            this.task_text.BackColor = System.Drawing.SystemColors.Control;
            this.task_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task_text.Location = new System.Drawing.Point(17, 13);
            this.task_text.Name = "task_text";
            this.task_text.Size = new System.Drawing.Size(39, 20);
            this.task_text.TabIndex = 4;
            this.task_text.Text = "task";
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.Red;
            this.deletebutton.Location = new System.Drawing.Point(280, 10);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(22, 23);
            this.deletebutton.TabIndex = 5;
            this.deletebutton.Text = "X";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // task_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.task_text);
            this.Name = "task_table";
            this.Size = new System.Drawing.Size(315, 49);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label task_text;
        private System.Windows.Forms.Button deletebutton;
    }
}
