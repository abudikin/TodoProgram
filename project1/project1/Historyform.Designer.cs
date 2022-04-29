
namespace project1
{
    partial class Historyform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHistoryClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(15, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 353);
            this.panel1.TabIndex = 0;
            // 
            // buttonHistoryClose
            // 
            this.buttonHistoryClose.BackColor = System.Drawing.Color.Red;
            this.buttonHistoryClose.Location = new System.Drawing.Point(506, 7);
            this.buttonHistoryClose.Name = "buttonHistoryClose";
            this.buttonHistoryClose.Size = new System.Drawing.Size(28, 23);
            this.buttonHistoryClose.TabIndex = 1;
            this.buttonHistoryClose.Text = "X";
            this.buttonHistoryClose.UseVisualStyleBackColor = false;
            this.buttonHistoryClose.Click += new System.EventHandler(this.buttonHistoryClose_Click);
            // 
            // Historyform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(549, 405);
            this.Controls.Add(this.buttonHistoryClose);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Historyform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historyform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHistoryClose;
    }
}