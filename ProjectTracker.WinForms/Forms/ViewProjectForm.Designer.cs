namespace ProjectTracker.WinForms.Forms
{
    partial class ViewProjectForm
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
            btnSubmitEdit = new Button();
            tbDescription = new TextBox();
            lbDescription = new Label();
            tbName = new TextBox();
            lbName = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lbFinishDate
            // 
            lbFinishDate.AutoSize = true;
            lbFinishDate.Location = new Point(30, 352);
            lbFinishDate.Name = "lbFinishDate";
            lbFinishDate.Size = new Size(38, 15);
            lbFinishDate.TabIndex = 31;
            lbFinishDate.Text = "Finish";
            // 
            // lbStartDate
            // 
            lbStartDate.AutoSize = true;
            lbStartDate.Location = new Point(30, 303);
            lbStartDate.Name = "lbStartDate";
            lbStartDate.Size = new Size(31, 15);
            lbStartDate.TabIndex = 30;
            lbStartDate.Text = "Start";
            // 
            // dtpFinishDate
            // 
            dtpFinishDate.Location = new Point(103, 352);
            dtpFinishDate.Name = "dtpFinishDate";
            dtpFinishDate.ShowCheckBox = true;
            dtpFinishDate.Size = new Size(200, 23);
            dtpFinishDate.TabIndex = 29;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(103, 303);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.ShowCheckBox = true;
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 28;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(322, 244);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(39, 15);
            lbStatus.TabIndex = 27;
            lbStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(367, 244);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(153, 23);
            cmbStatus.TabIndex = 26;
            // 
            // lbPriority
            // 
            lbPriority.AutoSize = true;
            lbPriority.Location = new Point(30, 244);
            lbPriority.Name = "lbPriority";
            lbPriority.Size = new Size(45, 15);
            lbPriority.TabIndex = 25;
            lbPriority.Text = "Priority";
            // 
            // cmbPriority
            // 
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(103, 244);
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
            // btnSubmitEdit
            // 
            btnSubmitEdit.Location = new Point(764, 365);
            btnSubmitEdit.Name = "btnSubmitEdit";
            btnSubmitEdit.Size = new Size(75, 23);
            btnSubmitEdit.TabIndex = 22;
            btnSubmitEdit.Text = "SUBMIT";
            btnSubmitEdit.UseVisualStyleBackColor = true;
            btnSubmitEdit.Click += btnSubmitEdit_Click;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(103, 101);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.ScrollBars = ScrollBars.Vertical;
            tbDescription.Size = new Size(514, 108);
            tbDescription.TabIndex = 21;
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(30, 101);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(67, 15);
            lbDescription.TabIndex = 20;
            lbDescription.Text = "Description";
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
            // btnEdit
            // 
            btnEdit.Location = new Point(764, 326);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 32;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(764, 285);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 33;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ViewProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 424);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
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
            Controls.Add(tbDescription);
            Controls.Add(lbDescription);
            Controls.Add(tbName);
            Controls.Add(lbName);
            Name = "ViewProject";
            Text = "ViewProject";
            Load += ViewProject_Load;
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
        private Button btnSubmitEdit;
        private TextBox tbDescription;
        private Label lbDescription;
        private TextBox tbName;
        private Label lbName;
        private Button btnEdit;
        private Button btnDelete;
    }
}