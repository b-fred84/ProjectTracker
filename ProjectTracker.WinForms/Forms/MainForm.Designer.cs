namespace ProjectTracker.WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddProject = new Button();
            btnAddTask = new Button();
            btnAddIdea = new Button();
            btnView = new Button();
            SuspendLayout();
            // 
            // btnAddProject
            // 
            btnAddProject.Location = new Point(124, 76);
            btnAddProject.Margin = new Padding(2);
            btnAddProject.Name = "btnAddProject";
            btnAddProject.Size = new Size(160, 58);
            btnAddProject.TabIndex = 0;
            btnAddProject.Text = "Add Project";
            btnAddProject.UseVisualStyleBackColor = true;
            btnAddProject.Click += btnAddProject_Click;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(363, 76);
            btnAddTask.Margin = new Padding(2);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(160, 58);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnAddIdea
            // 
            btnAddIdea.Location = new Point(605, 76);
            btnAddIdea.Margin = new Padding(2);
            btnAddIdea.Name = "btnAddIdea";
            btnAddIdea.Size = new Size(160, 58);
            btnAddIdea.TabIndex = 2;
            btnAddIdea.Text = "Add Project Idea";
            btnAddIdea.UseVisualStyleBackColor = true;
            btnAddIdea.Click += btnAddIdea_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(124, 247);
            btnView.Margin = new Padding(2);
            btnView.Name = "btnView";
            btnView.Size = new Size(160, 58);
            btnView.TabIndex = 3;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 424);
            Controls.Add(btnView);
            Controls.Add(btnAddIdea);
            Controls.Add(btnAddTask);
            Controls.Add(btnAddProject);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddProject;
        private Button btnAddTask;
        private Button btnAddIdea;
        private Button btnView;
    }
}
