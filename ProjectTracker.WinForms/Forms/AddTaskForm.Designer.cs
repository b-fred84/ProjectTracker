namespace ProjectTracker.WinForms
{
    partial class AddTaskForm
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
            lbFinishDate = new Label();
            lbStartDate = new Label();
            dtpFinishDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            lbStatus = new Label();
            cmbStatus = new ComboBox();
            lbPriority = new Label();
            cmbPriority = new ComboBox();
            cbPrivate = new CheckBox();
            btnSubmitTask = new Button();
            tbDetails = new TextBox();
            lbDetails = new Label();
            tbName = new TextBox();
            lbName = new Label();
            cmbProject = new ComboBox();
            lbProject = new Label();
            SuspendLayout();
            // 
            // lbFinishDate
            // 
            lbFinishDate.AutoSize = true;
            lbFinishDate.Location = new Point(30, 365);
            lbFinishDate.Name = "lbFinishDate";
            lbFinishDate.Size = new Size(38, 15);
            lbFinishDate.TabIndex = 31;
            lbFinishDate.Text = "Finish";
            // 
            // lbStartDate
            // 
            lbStartDate.AutoSize = true;
            lbStartDate.Location = new Point(30, 321);
            lbStartDate.Name = "lbStartDate";
            lbStartDate.Size = new Size(31, 15);
            lbStartDate.TabIndex = 30;
            lbStartDate.Text = "Start";
            // 
            // dtpFinishDate
            // 
            dtpFinishDate.Location = new Point(103, 365);
            dtpFinishDate.Name = "dtpFinishDate";
            dtpFinishDate.ShowCheckBox = true;
            dtpFinishDate.Size = new Size(200, 23);
            dtpFinishDate.TabIndex = 29;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(103, 321);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.ShowCheckBox = true;
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 28;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(312, 266);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(39, 15);
            lbStatus.TabIndex = 27;
            lbStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(357, 266);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(153, 23);
            cmbStatus.TabIndex = 26;
            // 
            // lbPriority
            // 
            lbPriority.AutoSize = true;
            lbPriority.Location = new Point(30, 266);
            lbPriority.Name = "lbPriority";
            lbPriority.Size = new Size(45, 15);
            lbPriority.TabIndex = 25;
            lbPriority.Text = "Priority";
            // 
            // cmbPriority
            // 
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(103, 266);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(153, 23);
            cmbPriority.TabIndex = 24;
            // 
            // cbPrivate
            // 
            cbPrivate.AutoSize = true;
            cbPrivate.Location = new Point(460, 37);
            cbPrivate.Name = "cbPrivate";
            cbPrivate.Size = new Size(62, 19);
            cbPrivate.TabIndex = 23;
            cbPrivate.Text = "Private";
            cbPrivate.UseVisualStyleBackColor = true;
            // 
            // btnSubmitTask
            // 
            btnSubmitTask.Location = new Point(764, 365);
            btnSubmitTask.Name = "btnSubmitTask";
            btnSubmitTask.Size = new Size(75, 23);
            btnSubmitTask.TabIndex = 22;
            btnSubmitTask.Text = "SUBMIT";
            btnSubmitTask.UseVisualStyleBackColor = true;
            btnSubmitTask.Click += btnSubmitTask_Click;
            // 
            // tbDetails
            // 
            tbDetails.Location = new Point(103, 143);
            tbDetails.Multiline = true;
            tbDetails.Name = "tbDetails";
            tbDetails.ScrollBars = ScrollBars.Vertical;
            tbDetails.Size = new Size(452, 108);
            tbDetails.TabIndex = 21;
            // 
            // lbDetails
            // 
            lbDetails.AutoSize = true;
            lbDetails.Location = new Point(26, 143);
            lbDetails.Name = "lbDetails";
            lbDetails.Size = new Size(42, 15);
            lbDetails.TabIndex = 20;
            lbDetails.Text = "Details";
            // 
            // tbName
            // 
            tbName.Location = new Point(103, 38);
            tbName.Name = "tbName";
            tbName.Size = new Size(229, 23);
            tbName.TabIndex = 19;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(30, 38);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 15);
            lbName.TabIndex = 18;
            lbName.Text = "Name";
            // 
            // cmbProject
            // 
            cmbProject.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProject.FormattingEnabled = true;
            cmbProject.Location = new Point(103, 89);
            cmbProject.Name = "cmbProject";
            cmbProject.Size = new Size(229, 23);
            cmbProject.TabIndex = 32;
            // 
            // lbProject
            // 
            lbProject.AutoSize = true;
            lbProject.Location = new Point(30, 89);
            lbProject.Name = "lbProject";
            lbProject.Size = new Size(44, 15);
            lbProject.TabIndex = 33;
            lbProject.Text = "Project";
            // 
            // AddTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 424);
            Controls.Add(lbProject);
            Controls.Add(cmbProject);
            Controls.Add(lbFinishDate);
            Controls.Add(lbStartDate);
            Controls.Add(dtpFinishDate);
            Controls.Add(dtpStartDate);
            Controls.Add(lbStatus);
            Controls.Add(cmbStatus);
            Controls.Add(lbPriority);
            Controls.Add(cmbPriority);
            Controls.Add(cbPrivate);
            Controls.Add(btnSubmitTask);
            Controls.Add(tbDetails);
            Controls.Add(lbDetails);
            Controls.Add(tbName);
            Controls.Add(lbName);
            Margin = new Padding(2);
            Name = "AddTaskForm";
            Text = "AddTaskForm";
            Load += AddTaskForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbFinishDate;
        private Label lbStartDate;
        private DateTimePicker dtpFinishDate;
        private DateTimePicker dtpStartDate;
        private Label lbStatus;
        private ComboBox cmbStatus;
        private Label lbPriority;
        private ComboBox cmbPriority;
        private CheckBox cbPrivate;
        private Button btnSubmitTask;
        private TextBox tbDetails;
        private Label lbDetails;
        private TextBox tbName;
        private Label lbName;
        private ComboBox cmbProject;
        private Label lbProject;
    }
}