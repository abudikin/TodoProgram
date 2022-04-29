
namespace project1
{
    partial class Список_дел
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
            this.components = new System.ComponentModel.Container();
            this.button_history = new System.Windows.Forms.Button();
            this.Main_text = new System.Windows.Forms.TextBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonSearch = new System.Windows.Forms.Button();
            this.mainform1 = new project1.mainform();
            this.SuspendLayout();
            // 
            // button_history
            // 
            this.button_history.Location = new System.Drawing.Point(12, 397);
            this.button_history.Name = "button_history";
            this.button_history.Size = new System.Drawing.Size(105, 41);
            this.button_history.TabIndex = 4;
            this.button_history.Text = "история задач";
            this.button_history.UseVisualStyleBackColor = true;
            this.button_history.Click += new System.EventHandler(this.button_history_Click);
            // 
            // Main_text
            // 
            this.Main_text.BackColor = System.Drawing.Color.SlateGray;
            this.Main_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Main_text.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Main_text.Location = new System.Drawing.Point(41, 8);
            this.Main_text.Name = "Main_text";
            this.Main_text.Size = new System.Drawing.Size(122, 26);
            this.Main_text.TabIndex = 5;
            this.Main_text.Text = "Список дел";
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Red;
            this.exit_button.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(464, 1);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(40, 37);
            this.exit_button.TabIndex = 10;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(379, 397);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(88, 23);
            this.buttonSearch.TabIndex = 22;
            this.buttonSearch.Text = "поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // mainform1
            // 
            this.mainform1.AutoScroll = true;
            this.mainform1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mainform1.Location = new System.Drawing.Point(9, 40);
            this.mainform1.Name = "mainform1";
            this.mainform1.Size = new System.Drawing.Size(495, 325);
            this.mainform1.TabIndex = 18;
            // 
            // Список_дел
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.mainform1);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.Main_text);
            this.Controls.Add(this.button_history);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Список_дел";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список_дел";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_history;
        private System.Windows.Forms.TextBox Main_text;
        private System.Windows.Forms.Button exit_button;
        private mainform mainform1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonSearch;
    }
}