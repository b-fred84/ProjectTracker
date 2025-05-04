namespace ProjectTracker.WinForms
{
    partial class AddProjectForm
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
            lbName = new Label();
            tbName = new TextBox();
            lbDescription = new Label();
            tbDescription = new TextBox();
            btnSubmitProject = new Button();
            cbPrivate = new CheckBox();
            cmbPriority = new ComboBox();
            lbPriority = new Label();
            cmbStatus = new ComboBox();
            lbStatus = new Label();
            dtpStartDate = new DateTimePicker();
            dtpFinishDate = new DateTimePicker();
            lbStartDate = new Label();
            lbFinishDate = new Label();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(23, 45);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 15);
            lbName.TabIndex = 1;
            lbName.Text = "Name";
            // 
            // tbName
            // 
            tbName.Location = new Point(96, 45);
            tbName.Name = "tbName";
            tbName.Size = new Size(229, 23);
            tbName.TabIndex = 2;
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(23, 108);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(67, 15);
            lbDescription.TabIndex = 6;
            lbDescription.Text = "Description";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(96, 108);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.ScrollBars = ScrollBars.Vertical;
            tbDescription.Size = new Size(452, 108);
            tbDescription.TabIndex = 7;
            // 
            // btnSubmitProject
            // 
            btnSubmitProject.Location = new Point(757, 372);
            btnSubmitProject.Name = "btnSubmitProject";
            btnSubmitProject.Size = new Size(75, 23);
            btnSubmitProject.TabIndex = 8;
            btnSubmitProject.Text = "SUBMIT";
            btnSubmitProject.UseVisualStyleBackColor = true;
            btnSubmitProject.Click += btnSubmitProject_Click;
            // 
            // cbPrivate
            // 
            cbPrivate.AutoSize = true;
            cbPrivate.Location = new Point(453, 44);
            cbPrivate.Name = "cbPrivate";
            cbPrivate.Size = new Size(62, 19);
            cbPrivate.TabIndex = 9;
            cbPrivate.Text = "Private";
            cbPrivate.UseVisualStyleBackColor = true;
            // 
            // cmbPriority
            // 
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(96, 251);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(153, 23);
            cmbPriority.TabIndex = 10;
            // 
            // lbPriority
            // 
            lbPriority.AutoSize = true;
            lbPriority.Location = new Point(23, 251);
            lbPriority.Name = "lbPriority";
            lbPriority.Size = new Size(45, 15);
            lbPriority.TabIndex = 11;
            lbPriority.Text = "Priority";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(360, 251);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(153, 23);
            cmbStatus.TabIndex = 12;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(315, 251);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(39, 15);
            lbStatus.TabIndex = 13;
            lbStatus.Text = "Status";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(96, 310);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.ShowCheckBox = true;
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 14;
            // 
            // dtpFinishDate
            // 
            dtpFinishDate.Location = new Point(96, 359);
            dtpFinishDate.Name = "dtpFinishDate";
            dtpFinishDate.ShowCheckBox = true;
            dtpFinishDate.Size = new Size(200, 23);
            dtpFinishDate.TabIndex = 15;
            // 
            // lbStartDate
            // 
            lbStartDate.AutoSize = true;
            lbStartDate.Location = new Point(23, 310);
            lbStartDate.Name = "lbStartDate";
            lbStartDate.Size = new Size(31, 15);
            lbStartDate.TabIndex = 16;
            lbStartDate.Text = "Start";
            // 
            // lbFinishDate
            // 
            lbFinishDate.AutoSize = true;
            lbFinishDate.Location = new Point(23, 359);
            lbFinishDate.Name = "lbFinishDate";
            lbFinishDate.Size = new Size(38, 15);
            lbFinishDate.TabIndex = 17;
            lbFinishDate.Text = "Finish";
            // 
            // AddProjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 424);
            Controls.Add(lbFinishDate);
            Controls.Add(lbStartDate);
            Controls.Add(dtpFinishDate);
            Controls.Add(dtpStartDate);
            Controls.Add(lbStatus);
            Controls.Add(cmbStatus);
            Controls.Add(lbPriority);
            Controls.Add(cmbPriority);
            Controls.Add(cbPrivate);
            Controls.Add(btnSubmitProject);
            Controls.Add(tbDescription);
            Controls.Add(lbDescription);
            Controls.Add(tbName);
            Controls.Add(lbName);
            Margin = new Padding(2);
            Name = "AddProjectForm";
            Text = "AddProjectForm";
            Load += AddProjectForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbName;
        private TextBox tbName;
        private Label lbDescription;
        private TextBox tbDescription;
        private Button btnSubmitProject;
        private CheckBox cbPrivate;
        private ComboBox cmbPriority;
        private Label lbPriority;
        private ComboBox cmbStatus;
        private Label lbStatus;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpFinishDate;
        private Label lbStartDate;
        private Label lbFinishDate;
    }
}