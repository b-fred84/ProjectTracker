namespace ProjectTracker.WinForms.Forms
{
    partial class ViewTaskForm
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
            lbProject = new Label();
            cmbProject = new ComboBox();
            lbFinishDate = new Label();
            lbStartDate = new Label();
            dtpFinishDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            lbStatus = new Label();
            cmbStatus = new ComboBox();
            lbPriority = new Label();
            cmbPriority = new ComboBox();
            cbPrivate = new CheckBox();
            btnSubmitEdit = new Button();
            tbDetails = new TextBox();
            lbDetails = new Label();
            tbName = new TextBox();
            lbName = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lbProject
            // 
            lbProject.AutoSize = true;
            lbProject.Location = new Point(32, 89);
            lbProject.Name = "lbProject";
            lbProject.Size = new Size(44, 15);
            lbProject.TabIndex = 49;
            lbProject.Text = "Project";
            // 
            // cmbProject
            // 
            cmbProject.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProject.FormattingEnabled = true;
            cmbProject.Location = new Point(105, 89);
            cmbProject.Name = "cmbProject";
            cmbProject.Size = new Size(229, 23);
            cmbProject.TabIndex = 48;
            // 
            // lbFinishDate
            // 
            lbFinishDate.AutoSize = true;
            lbFinishDate.Location = new Point(32, 365);
            lbFinishDate.Name = "lbFinishDate";
            lbFinishDate.Size = new Size(38, 15);
            lbFinishDate.TabIndex = 47;
            lbFinishDate.Text = "Finish";
            // 
            // lbStartDate
            // 
            lbStartDate.AutoSize = true;
            lbStartDate.Location = new Point(32, 321);
            lbStartDate.Name = "lbStartDate";
            lbStartDate.Size = new Size(31, 15);
            lbStartDate.TabIndex = 46;
            lbStartDate.Text = "Start";
            // 
            // dtpFinishDate
            // 
            dtpFinishDate.Location = new Point(105, 365);
            dtpFinishDate.Name = "dtpFinishDate";
            dtpFinishDate.ShowCheckBox = true;
            dtpFinishDate.Size = new Size(200, 23);
            dtpFinishDate.TabIndex = 45;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(105, 321);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.ShowCheckBox = true;
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 44;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(314, 266);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(39, 15);
            lbStatus.TabIndex = 43;
            lbStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(359, 266);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(153, 23);
            cmbStatus.TabIndex = 42;
            // 
            // lbPriority
            // 
            lbPriority.AutoSize = true;
            lbPriority.Location = new Point(32, 266);
            lbPriority.Name = "lbPriority";
            lbPriority.Size = new Size(45, 15);
            lbPriority.TabIndex = 41;
            lbPriority.Text = "Priority";
            // 
            // cmbPriority
            // 
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(105, 266);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(153, 23);
            cmbPriority.TabIndex = 40;
            // 
            // cbPrivate
            // 
            cbPrivate.AutoSize = true;
            cbPrivate.Location = new Point(462, 37);
            cbPrivate.Name = "cbPrivate";
            cbPrivate.Size = new Size(62, 19);
            cbPrivate.TabIndex = 39;
            cbPrivate.Text = "Private";
            cbPrivate.UseVisualStyleBackColor = true;
            // 
            // btnSubmitEdit
            // 
            btnSubmitEdit.Location = new Point(766, 365);
            btnSubmitEdit.Name = "btnSubmitEdit";
            btnSubmitEdit.Size = new Size(75, 23);
            btnSubmitEdit.TabIndex = 38;
            btnSubmitEdit.Text = "SUBMIT";
            btnSubmitEdit.UseVisualStyleBackColor = true;
            btnSubmitEdit.Click += btnSubmitEdit_Click;
            // 
            // tbDetails
            // 
            tbDetails.Location = new Point(105, 143);
            tbDetails.Multiline = true;
            tbDetails.Name = "tbDetails";
            tbDetails.ScrollBars = ScrollBars.Vertical;
            tbDetails.Size = new Size(532, 108);
            tbDetails.TabIndex = 37;
            // 
            // lbDetails
            // 
            lbDetails.AutoSize = true;
            lbDetails.Location = new Point(28, 143);
            lbDetails.Name = "lbDetails";
            lbDetails.Size = new Size(42, 15);
            lbDetails.TabIndex = 36;
            lbDetails.Text = "Details";
            // 
            // tbName
            // 
            tbName.Location = new Point(105, 38);
            tbName.Name = "tbName";
            tbName.Size = new Size(229, 23);
            tbName.TabIndex = 35;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(32, 38);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 15);
            lbName.TabIndex = 34;
            lbName.Text = "Name";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(766, 323);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 50;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(766, 280);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 51;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ViewTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 424);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
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
            Controls.Add(btnSubmitEdit);
            Controls.Add(tbDetails);
            Controls.Add(lbDetails);
            Controls.Add(tbName);
            Controls.Add(lbName);
            Name = "ViewTaskForm";
            Text = "ViewTask";
            Load += ViewTaskForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbProject;
        private ComboBox cmbProject;
        private Label lbFinishDate;
        private Label lbStartDate;
        private DateTimePicker dtpFinishDate;
        private DateTimePicker dtpStartDate;
        private Label lbStatus;
        private ComboBox cmbStatus;
        private Label lbPriority;
        private ComboBox cmbPriority;
        private CheckBox cbPrivate;
        private Button btnSubmitEdit;
        private TextBox tbDetails;
        private Label lbDetails;
        private TextBox tbName;
        private Label lbName;
        private Button btnEdit;
        private Button btnDelete;
    }
}