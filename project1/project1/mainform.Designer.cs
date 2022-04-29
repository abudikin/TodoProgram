
namespace project1
{
    partial class mainform
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
            this.mainpanek = new System.Windows.Forms.Panel();
            this.mainbutton = new System.Windows.Forms.Button();
            this.maintext = new System.Windows.Forms.TextBox();
            this.buttonrefresh = new System.Windows.Forms.Button();
            this.buttonref = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainpanek
            // 
            this.mainpanek.AutoScroll = true;
            this.mainpanek.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainpanek.Location = new System.Drawing.Point(3, 3);
            this.mainpanek.Name = "mainpanek";
            this.mainpanek.Size = new System.Drawing.Size(486, 287);
            this.mainpanek.TabIndex = 0;
            // 
            // mainbutton
            // 
            this.mainbutton.Location = new System.Drawing.Point(416, 296);
            this.mainbutton.Name = "mainbutton";
            this.mainbutton.Size = new System.Drawing.Size(73, 20);
            this.mainbutton.TabIndex = 2;
            this.mainbutton.Text = "добавить";
            this.mainbutton.UseVisualStyleBackColor = true;
            this.mainbutton.Click += new System.EventHandler(this.mainbutton_Click);
            // 
            // maintext
            // 
            this.maintext.Location = new System.Drawing.Point(3, 296);
            this.maintext.Name = "maintext";
            this.maintext.Size = new System.Drawing.Size(245, 20);
            this.maintext.TabIndex = 3;
            // 
            // buttonrefresh
            // 
            this.buttonrefresh.Location = new System.Drawing.Point(335, 295);
            this.buttonrefresh.Name = "buttonrefresh";
            this.buttonrefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonrefresh.TabIndex = 4;
            this.buttonrefresh.Text = "обновить";
            this.buttonrefresh.UseVisualStyleBackColor = true;
            this.buttonrefresh.Click += new System.EventHandler(this.buttonrefresh_Click);
            // 
            // buttonref
            // 
            this.buttonref.Location = new System.Drawing.Point(254, 296);
            this.buttonref.Name = "buttonref";
            this.buttonref.Size = new System.Drawing.Size(75, 23);
            this.buttonref.TabIndex = 5;
            this.buttonref.Text = "изменить";
            this.buttonref.UseVisualStyleBackColor = true;
            this.buttonref.Click += new System.EventHandler(this.buttonref_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.buttonref);
            this.Controls.Add(this.buttonrefresh);
            this.Controls.Add(this.maintext);
            this.Controls.Add(this.mainbutton);
            this.Controls.Add(this.mainpanek);
            this.Name = "mainform";
            this.Size = new System.Drawing.Size(492, 319);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainpanek;
        private System.Windows.Forms.Button mainbutton;
        private System.Windows.Forms.TextBox maintext;
        private System.Windows.Forms.Button buttonrefresh;
        private System.Windows.Forms.Button buttonref;
    }
}
