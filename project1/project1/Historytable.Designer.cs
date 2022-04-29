
namespace project1
{
    partial class Historytable
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
            this.panelhistory = new System.Windows.Forms.Panel();
            this.buttonclean = new System.Windows.Forms.Button();
            this.historytext = new System.Windows.Forms.Label();
            this.panelhistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelhistory
            // 
            this.panelhistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelhistory.Controls.Add(this.buttonclean);
            this.panelhistory.Controls.Add(this.historytext);
            this.panelhistory.Location = new System.Drawing.Point(0, 0);
            this.panelhistory.Name = "panelhistory";
            this.panelhistory.Size = new System.Drawing.Size(332, 47);
            this.panelhistory.TabIndex = 0;
            // 
            // buttonclean
            // 
            this.buttonclean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonclean.Location = new System.Drawing.Point(255, 15);
            this.buttonclean.Name = "buttonclean";
            this.buttonclean.Size = new System.Drawing.Size(75, 23);
            this.buttonclean.TabIndex = 1;
            this.buttonclean.Text = "удалить";
            this.buttonclean.UseVisualStyleBackColor = false;
            this.buttonclean.Click += new System.EventHandler(this.buttonclean_Click);
            // 
            // historytext
            // 
            this.historytext.AutoSize = true;
            this.historytext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.historytext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historytext.Location = new System.Drawing.Point(3, 15);
            this.historytext.Name = "historytext";
            this.historytext.Size = new System.Drawing.Size(57, 20);
            this.historytext.TabIndex = 0;
            this.historytext.Text = "label1";
            // 
            // Historytable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.panelhistory);
            this.Name = "Historytable";
            this.Size = new System.Drawing.Size(333, 48);
            this.panelhistory.ResumeLayout(false);
            this.panelhistory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelhistory;
        private System.Windows.Forms.Label historytext;
        private System.Windows.Forms.Button buttonclean;
    }
}
