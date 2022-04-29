
namespace project1
{
    partial class Formref
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
            this.textBoxRef = new System.Windows.Forms.TextBox();
            this.buttonAcceptRef = new System.Windows.Forms.Button();
            this.buttoExitRef = new System.Windows.Forms.Button();
            this.textBoxPrev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxRef
            // 
            this.textBoxRef.Location = new System.Drawing.Point(21, 63);
            this.textBoxRef.Name = "textBoxRef";
            this.textBoxRef.Size = new System.Drawing.Size(299, 20);
            this.textBoxRef.TabIndex = 0;
            // 
            // buttonAcceptRef
            // 
            this.buttonAcceptRef.Location = new System.Drawing.Point(348, 51);
            this.buttonAcceptRef.Name = "buttonAcceptRef";
            this.buttonAcceptRef.Size = new System.Drawing.Size(75, 23);
            this.buttonAcceptRef.TabIndex = 1;
            this.buttonAcceptRef.Text = "изменить";
            this.buttonAcceptRef.UseVisualStyleBackColor = true;
            this.buttonAcceptRef.Click += new System.EventHandler(this.buttonAcceptRef_Click);
            // 
            // buttoExitRef
            // 
            this.buttoExitRef.BackColor = System.Drawing.Color.Red;
            this.buttoExitRef.Location = new System.Drawing.Point(348, 12);
            this.buttoExitRef.Name = "buttoExitRef";
            this.buttoExitRef.Size = new System.Drawing.Size(75, 23);
            this.buttoExitRef.TabIndex = 2;
            this.buttoExitRef.Text = "X";
            this.buttoExitRef.UseVisualStyleBackColor = false;
            this.buttoExitRef.Click += new System.EventHandler(this.buttoExitRef_Click);
            // 
            // textBoxPrev
            // 
            this.textBoxPrev.Location = new System.Drawing.Point(21, 25);
            this.textBoxPrev.Name = "textBoxPrev";
            this.textBoxPrev.Size = new System.Drawing.Size(299, 20);
            this.textBoxPrev.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "на";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "поменять это";
            // 
            // Formref
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(452, 86);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrev);
            this.Controls.Add(this.buttoExitRef);
            this.Controls.Add(this.buttonAcceptRef);
            this.Controls.Add(this.textBoxRef);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formref";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formref";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRef;
        private System.Windows.Forms.Button buttonAcceptRef;
        private System.Windows.Forms.Button buttoExitRef;
        private System.Windows.Forms.TextBox textBoxPrev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}