namespace ProjectTracker.WinForms.Forms
{
    partial class ViewForm
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
            tabControlViews = new TabControl();
            tabProjects = new TabPage();
            panel1 = new Panel();
            cmbPriorityProject = new ComboBox();
            cmbStatusProject = new ComboBox();
            dgvProjects = new DataGridView();
            tabTasks = new TabPage();
            panel2 = new Panel();
            cmbPriorityTask = new ComboBox();
            cmbStatusTask = new ComboBox();
            cmbProjectTask = new ComboBox();
            dgvTasks = new DataGridView();
            tabIdeas = new TabPage();
            dgvIdeas = new DataGridView();
            tabControlViews.SuspendLayout();
            tabProjects.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProjects).BeginInit();
            tabTasks.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            tabIdeas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIdeas).BeginInit();
            SuspendLayout();
            // 
            // tabControlViews
            // 
            tabControlViews.Controls.Add(tabProjects);
            tabControlViews.Controls.Add(tabTasks);
            tabControlViews.Controls.Add(tabIdeas);
            tabControlViews.Dock = DockStyle.Fill;
            tabControlViews.Location = new Point(0, 0);
            tabControlViews.Name = "tabControlViews";
            tabControlViews.SelectedIndex = 0;
            tabControlViews.Size = new Size(868, 424);
            tabControlViews.TabIndex = 0;
            // 
            // tabProjects
            // 
            tabProjects.Controls.Add(panel1);
            tabProjects.Controls.Add(dgvProjects);
            tabProjects.Location = new Point(4, 24);
            tabProjects.Name = "tabProjects";
            tabProjects.Padding = new Padding(3);
            tabProjects.Size = new Size(860, 396);
            tabProjects.TabIndex = 0;
            tabProjects.Text = "Projects";
            tabProjects.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbPriorityProject);
            panel1.Controls.Add(cmbStatusProject);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(854, 24);
            panel1.TabIndex = 1;
            // 
            // cmbPriorityProject
            // 
            cmbPriorityProject.FormattingEnabled = true;
            cmbPriorityProject.Location = new Point(127, 0);
            cmbPriorityProject.Name = "cmbPriorityProject";
            cmbPriorityProject.Size = new Size(121, 23);
            cmbPriorityProject.TabIndex = 1;
            // 
            // cmbStatusProject
            // 
            cmbStatusProject.FormattingEnabled = true;
            cmbStatusProject.Location = new Point(0, 0);
            cmbStatusProject.Name = "cmbStatusProject";
            cmbStatusProject.Size = new Size(121, 23);
            cmbStatusProject.TabIndex = 0;
            // 
            // dgvProjects
            // 
            dgvProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProjects.Dock = DockStyle.Bottom;
            dgvProjects.Location = new Point(3, 24);
            dgvProjects.Name = "dgvProjects";
            dgvProjects.Size = new Size(854, 369);
            dgvProjects.TabIndex = 0;
            // 
            // tabTasks
            // 
            tabTasks.Controls.Add(panel2);
            tabTasks.Controls.Add(dgvTasks);
            tabTasks.Location = new Point(4, 24);
            tabTasks.Name = "tabTasks";
            tabTasks.Padding = new Padding(3);
            tabTasks.Size = new Size(860, 396);
            tabTasks.TabIndex = 1;
            tabTasks.Text = "Tasks";
            tabTasks.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(cmbPriorityTask);
            panel2.Controls.Add(cmbStatusTask);
            panel2.Controls.Add(cmbProjectTask);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(854, 24);
            panel2.TabIndex = 2;
            // 
            // cmbPriorityTask
            // 
            cmbPriorityTask.FormattingEnabled = true;
            cmbPriorityTask.Location = new Point(254, 1);
            cmbPriorityTask.Name = "cmbPriorityTask";
            cmbPriorityTask.Size = new Size(121, 23);
            cmbPriorityTask.TabIndex = 2;
            // 
            // cmbStatusTask
            // 
            cmbStatusTask.FormattingEnabled = true;
            cmbStatusTask.Location = new Point(127, 0);
            cmbStatusTask.Name = "cmbStatusTask";
            cmbStatusTask.Size = new Size(121, 23);
            cmbStatusTask.TabIndex = 1;
            // 
            // cmbProjectTask
            // 
            cmbProjectTask.FormattingEnabled = true;
            cmbProjectTask.Location = new Point(0, 0);
            cmbProjectTask.Name = "cmbProjectTask";
            cmbProjectTask.Size = new Size(121, 23);
            cmbProjectTask.TabIndex = 0;
            // 
            // dgvTasks
            // 
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Dock = DockStyle.Bottom;
            dgvTasks.Location = new Point(3, 24);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.Size = new Size(854, 369);
            dgvTasks.TabIndex = 0;
            // 
            // tabIdeas
            // 
            tabIdeas.Controls.Add(dgvIdeas);
            tabIdeas.Location = new Point(4, 24);
            tabIdeas.Name = "tabIdeas";
            tabIdeas.Padding = new Padding(3);
            tabIdeas.Size = new Size(860, 396);
            tabIdeas.TabIndex = 2;
            tabIdeas.Text = "Ideas";
            tabIdeas.UseVisualStyleBackColor = true;
            // 
            // dgvIdeas
            // 
            dgvIdeas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIdeas.Dock = DockStyle.Fill;
            dgvIdeas.Location = new Point(3, 3);
            dgvIdeas.Name = "dgvIdeas";
            dgvIdeas.Size = new Size(854, 390);
            dgvIdeas.TabIndex = 0;
            // 
            // ViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 424);
            Controls.Add(tabControlViews);
            Name = "ViewForm";
            Text = "ViewForm";
            Load += ViewForm_Load;
            tabControlViews.ResumeLayout(false);
            tabProjects.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProjects).EndInit();
            tabTasks.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            tabIdeas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvIdeas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlViews;
        private TabPage tabProjects;
        private TabPage tabTasks;
        private TabPage tabIdeas;
        private DataGridView dgvProjects;
        private DataGridView dgvTasks;
        private DataGridView dgvIdeas;
        private Panel panel1;
        private ComboBox cmbStatusProject;
        private ComboBox cmbPriorityProject;
        private Panel panel2;
        private ComboBox cmbStatusTask;
        private ComboBox cmbProjectTask;
        private ComboBox cmbPriorityTask;
    }
}