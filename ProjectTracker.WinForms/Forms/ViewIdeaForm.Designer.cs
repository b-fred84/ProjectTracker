namespace ProjectTracker.WinForms.Forms
{
    partial class ViewIdeaForm
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
            lbNotes = new Label();
            lbDescription = new Label();
            tbNotes = new TextBox();
            tbDescription = new TextBox();
            btnSubmitIdeaEdit = new Button();
            tbName = new TextBox();
            lbName = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            SuspendLayout();
            // 
            // lbNotes
            // 
            lbNotes.AutoSize = true;
            lbNotes.Location = new Point(43, 252);
            lbNotes.Name = "lbNotes";
            lbNotes.Size = new Size(38, 15);
            lbNotes.TabIndex = 13;
            lbNotes.Text = "Notes";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(43, 109);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(67, 15);
            lbDescription.TabIndex = 12;
            lbDescription.Text = "Description";
            // 
            // tbNotes
            // 
            tbNotes.Location = new Point(116, 249);
            tbNotes.Multiline = true;
            tbNotes.Name = "tbNotes";
            tbNotes.ScrollBars = ScrollBars.Vertical;
            tbNotes.Size = new Size(553, 108);
            tbNotes.TabIndex = 11;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(116, 106);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.ScrollBars = ScrollBars.Vertical;
            tbDescription.Size = new Size(553, 108);
            tbDescription.TabIndex = 10;
            // 
            // btnSubmitIdeaEdit
            // 
            btnSubmitIdeaEdit.Location = new Point(751, 355);
            btnSubmitIdeaEdit.Name = "btnSubmitIdeaEdit";
            btnSubmitIdeaEdit.Size = new Size(75, 23);
            btnSubmitIdeaEdit.TabIndex = 9;
            btnSubmitIdeaEdit.Text = "SUBMIT";
            btnSubmitIdeaEdit.UseVisualStyleBackColor = true;
            btnSubmitIdeaEdit.Click += btnSubmitIdeaEdit_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(116, 46);
            tbName.Name = "tbName";
            tbName.Size = new Size(229, 23);
            tbName.TabIndex = 8;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(43, 46);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 15);
            lbName.TabIndex = 7;
            lbName.Text = "Name";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(751, 270);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(751, 314);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // ViewIdeaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 424);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(lbNotes);
            Controls.Add(lbDescription);
            Controls.Add(tbNotes);
            Controls.Add(tbDescription);
            Controls.Add(btnSubmitIdeaEdit);
            Controls.Add(tbName);
            Controls.Add(lbName);
            Name = "ViewIdeaForm";
            Text = "ViewIdea";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNotes;
        private Label lbDescription;
        private TextBox tbNotes;
        private TextBox tbDescription;
        private Button btnSubmitIdeaEdit;
        private TextBox tbName;
        private Label lbName;
        private Button btnDelete;
        private Button btnEdit;
    }
}