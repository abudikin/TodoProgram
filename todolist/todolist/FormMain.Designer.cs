
namespace todolist
{
    partial class FormMain
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button_addProject = new System.Windows.Forms.Button();
            this.listBox_projects = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonBackToMain = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panelFutureTask = new System.Windows.Forms.Panel();
            this.panelFutureLabel = new System.Windows.Forms.Panel();
            this.labelFutureTask = new System.Windows.Forms.Label();
            this.panelToDay = new System.Windows.Forms.Panel();
            this.panelTodayLabel = new System.Windows.Forms.Panel();
            this.labelToday = new System.Windows.Forms.Label();
            this.panelLeftTask = new System.Windows.Forms.Panel();
            this.panelLeftLabel = new System.Windows.Forms.Panel();
            this.LabelLeft = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panelFutureLabel.SuspendLayout();
            this.panelTodayLabel.SuspendLayout();
            this.panelLeftLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.listBox_projects);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 597);
            this.panel2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button_addProject);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 260);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(212, 34);
            this.panel6.TabIndex = 2;
            // 
            // button_addProject
            // 
            this.button_addProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.button_addProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_addProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.button_addProject.Location = new System.Drawing.Point(0, 0);
            this.button_addProject.Name = "button_addProject";
            this.button_addProject.Size = new System.Drawing.Size(212, 34);
            this.button_addProject.TabIndex = 2;
            this.button_addProject.Text = "Добавить проект";
            this.button_addProject.UseVisualStyleBackColor = false;
            this.button_addProject.Click += new System.EventHandler(this.button_addProject_Click);
            // 
            // listBox_projects
            // 
            this.listBox_projects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.listBox_projects.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox_projects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.listBox_projects.FormattingEnabled = true;
            this.listBox_projects.Location = new System.Drawing.Point(0, 100);
            this.listBox_projects.Name = "listBox_projects";
            this.listBox_projects.Size = new System.Drawing.Size(212, 160);
            this.listBox_projects.TabIndex = 0;
            this.listBox_projects.SelectedIndexChanged += new System.EventHandler(this.listBox_projects_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel3.Controls.Add(this.buttonBackToMain);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 100);
            this.panel3.TabIndex = 1;
            // 
            // buttonBackToMain
            // 
            this.buttonBackToMain.Location = new System.Drawing.Point(53, 38);
            this.buttonBackToMain.Name = "buttonBackToMain";
            this.buttonBackToMain.Size = new System.Drawing.Size(75, 23);
            this.buttonBackToMain.TabIndex = 3;
            this.buttonBackToMain.Text = "Назад";
            this.buttonBackToMain.UseVisualStyleBackColor = true;
            this.buttonBackToMain.Visible = false;
            this.buttonBackToMain.Click += new System.EventHandler(this.buttonBackToMain_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.button_refresh.Location = new System.Drawing.Point(70, 38);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 23);
            this.button_refresh.TabIndex = 4;
            this.button_refresh.Text = "Обновить";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.button_add.Location = new System.Drawing.Point(57, 38);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(101, 23);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(824, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 597);
            this.panel1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button_refresh);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(212, 100);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Controls.Add(this.button_add);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 100);
            this.panel4.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel7.Controls.Add(this.buttonFilter);
            this.panel7.Controls.Add(this.buttonSearch);
            this.panel7.Controls.Add(this.textBoxSearch);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(212, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(612, 46);
            this.panel7.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(364, 10);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(17, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(274, 20);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // panel8
            // 
            this.panel8.AutoSize = true;
            this.panel8.Controls.Add(this.panelFutureTask);
            this.panel8.Controls.Add(this.panelFutureLabel);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(212, 72);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(612, 13);
            this.panel8.TabIndex = 15;
            this.panel8.Visible = false;
            // 
            // panelFutureTask
            // 
            this.panelFutureTask.AutoSize = true;
            this.panelFutureTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFutureTask.Location = new System.Drawing.Point(0, 13);
            this.panelFutureTask.Name = "panelFutureTask";
            this.panelFutureTask.Size = new System.Drawing.Size(612, 0);
            this.panelFutureTask.TabIndex = 3;
            this.panelFutureTask.Visible = false;
            // 
            // panelFutureLabel
            // 
            this.panelFutureLabel.AutoSize = true;
            this.panelFutureLabel.Controls.Add(this.labelFutureTask);
            this.panelFutureLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFutureLabel.Location = new System.Drawing.Point(0, 0);
            this.panelFutureLabel.Name = "panelFutureLabel";
            this.panelFutureLabel.Size = new System.Drawing.Size(612, 13);
            this.panelFutureLabel.TabIndex = 2;
            this.panelFutureLabel.Visible = false;
            // 
            // labelFutureTask
            // 
            this.labelFutureTask.AutoSize = true;
            this.labelFutureTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFutureTask.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFutureTask.Location = new System.Drawing.Point(0, 0);
            this.labelFutureTask.Name = "labelFutureTask";
            this.labelFutureTask.Size = new System.Drawing.Size(77, 13);
            this.labelFutureTask.TabIndex = 0;
            this.labelFutureTask.Text = "Предстоящие";
            // 
            // panelToDay
            // 
            this.panelToDay.AutoSize = true;
            this.panelToDay.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToDay.Location = new System.Drawing.Point(212, 72);
            this.panelToDay.Name = "panelToDay";
            this.panelToDay.Size = new System.Drawing.Size(612, 0);
            this.panelToDay.TabIndex = 14;
            this.panelToDay.Visible = false;
            // 
            // panelTodayLabel
            // 
            this.panelTodayLabel.AutoSize = true;
            this.panelTodayLabel.Controls.Add(this.labelToday);
            this.panelTodayLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTodayLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.panelTodayLabel.Location = new System.Drawing.Point(212, 59);
            this.panelTodayLabel.Name = "panelTodayLabel";
            this.panelTodayLabel.Size = new System.Drawing.Size(612, 13);
            this.panelTodayLabel.TabIndex = 13;
            this.panelTodayLabel.Visible = false;
            // 
            // labelToday
            // 
            this.labelToday.AutoSize = true;
            this.labelToday.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelToday.ForeColor = System.Drawing.SystemColors.Control;
            this.labelToday.Location = new System.Drawing.Point(0, 0);
            this.labelToday.Name = "labelToday";
            this.labelToday.Size = new System.Drawing.Size(49, 13);
            this.labelToday.TabIndex = 0;
            this.labelToday.Text = "Сегодня";
            // 
            // panelLeftTask
            // 
            this.panelLeftTask.AutoSize = true;
            this.panelLeftTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeftTask.Location = new System.Drawing.Point(212, 59);
            this.panelLeftTask.Name = "panelLeftTask";
            this.panelLeftTask.Size = new System.Drawing.Size(612, 0);
            this.panelLeftTask.TabIndex = 12;
            this.panelLeftTask.Visible = false;
            // 
            // panelLeftLabel
            // 
            this.panelLeftLabel.AutoSize = true;
            this.panelLeftLabel.Controls.Add(this.LabelLeft);
            this.panelLeftLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeftLabel.Location = new System.Drawing.Point(212, 46);
            this.panelLeftLabel.Name = "panelLeftLabel";
            this.panelLeftLabel.Size = new System.Drawing.Size(612, 13);
            this.panelLeftLabel.TabIndex = 11;
            this.panelLeftLabel.Visible = false;
            // 
            // LabelLeft
            // 
            this.LabelLeft.AutoSize = true;
            this.LabelLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelLeft.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelLeft.Location = new System.Drawing.Point(0, 0);
            this.LabelLeft.Name = "LabelLeft";
            this.LabelLeft.Size = new System.Drawing.Size(68, 13);
            this.LabelLeft.TabIndex = 0;
            this.LabelLeft.Text = "Просрочено";
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.AutoSize = true;
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(212, 85);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(612, 512);
            this.MainPanel.TabIndex = 16;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(531, 10);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilter.TabIndex = 5;
            this.buttonFilter.Text = "фильтр";
            this.buttonFilter.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1036, 597);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panelToDay);
            this.Controls.Add(this.panelTodayLabel);
            this.Controls.Add(this.panelLeftTask);
            this.Controls.Add(this.panelLeftLabel);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panelFutureLabel.ResumeLayout(false);
            this.panelFutureLabel.PerformLayout();
            this.panelTodayLabel.ResumeLayout(false);
            this.panelTodayLabel.PerformLayout();
            this.panelLeftLabel.ResumeLayout(false);
            this.panelLeftLabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox_projects;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button_addProject;
        private TaskControl taskControl1;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonBackToMain;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panelFutureTask;
        private System.Windows.Forms.Panel panelFutureLabel;
        private System.Windows.Forms.Label labelFutureTask;
        private System.Windows.Forms.Panel panelToDay;
        private System.Windows.Forms.Panel panelTodayLabel;
        private System.Windows.Forms.Label labelToday;
        private System.Windows.Forms.Panel panelLeftTask;
        private System.Windows.Forms.Panel panelLeftLabel;
        private System.Windows.Forms.Label LabelLeft;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button buttonFilter;
    }
}

