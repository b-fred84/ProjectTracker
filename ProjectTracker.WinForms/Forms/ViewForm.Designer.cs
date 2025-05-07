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
            tabControl1 = new TabControl();
            tabProjects = new TabPage();
            dgvProjects = new DataGridView();
            tabTasks = new TabPage();
            dgvTasks = new DataGridView();
            tabIdeas = new TabPage();
            dgvIdeas = new DataGridView();
            tabControl1.SuspendLayout();
            tabProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProjects).BeginInit();
            tabTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            tabIdeas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIdeas).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabProjects);
            tabControl1.Controls.Add(tabTasks);
            tabControl1.Controls.Add(tabIdeas);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(868, 424);
            tabControl1.TabIndex = 0;
            // 
            // tabProjects
            // 
            tabProjects.Controls.Add(dgvProjects);
            tabProjects.Location = new Point(4, 24);
            tabProjects.Name = "tabProjects";
            tabProjects.Padding = new Padding(3);
            tabProjects.Size = new Size(860, 396);
            tabProjects.TabIndex = 0;
            tabProjects.Text = "Projects";
            tabProjects.UseVisualStyleBackColor = true;
            // 
            // dgvProjects
            // 
            dgvProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProjects.Dock = DockStyle.Fill;
            dgvProjects.Location = new Point(3, 3);
            dgvProjects.Name = "dgvProjects";
            dgvProjects.Size = new Size(854, 390);
            dgvProjects.TabIndex = 0;
            // 
            // tabTasks
            // 
            tabTasks.Controls.Add(dgvTasks);
            tabTasks.Location = new Point(4, 24);
            tabTasks.Name = "tabTasks";
            tabTasks.Padding = new Padding(3);
            tabTasks.Size = new Size(860, 396);
            tabTasks.TabIndex = 1;
            tabTasks.Text = "Tasks";
            tabTasks.UseVisualStyleBackColor = true;
            // 
            // dgvTasks
            // 
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Dock = DockStyle.Fill;
            dgvTasks.Location = new Point(3, 3);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.Size = new Size(854, 390);
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
            Controls.Add(tabControl1);
            Name = "ViewForm";
            Text = "ViewForm";
            Load += ViewForm_Load;
            tabControl1.ResumeLayout(false);
            tabProjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProjects).EndInit();
            tabTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            tabIdeas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvIdeas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabProjects;
        private TabPage tabTasks;
        private TabPage tabIdeas;
        private DataGridView dgvProjects;
        private DataGridView dgvTasks;
        private DataGridView dgvIdeas;
    }
}