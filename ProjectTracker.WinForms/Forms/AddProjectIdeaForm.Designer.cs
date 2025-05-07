namespace ProjectTracker.WinForms
{
    partial class AddProjectIdeaForm
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
            btnSubmitIdea = new Button();
            tbDescription = new TextBox();
            tbNotes = new TextBox();
            lbDescription = new Label();
            lbNotes = new Label();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(27, 52);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 15);
            lbName.TabIndex = 0;
            lbName.Text = "Name";
            // 
            // tbName
            // 
            tbName.Location = new Point(100, 52);
            tbName.Name = "tbName";
            tbName.Size = new Size(229, 23);
            tbName.TabIndex = 1;
            // 
            // btnSubmitIdea
            // 
            btnSubmitIdea.Location = new Point(735, 361);
            btnSubmitIdea.Name = "btnSubmitIdea";
            btnSubmitIdea.Size = new Size(75, 23);
            btnSubmitIdea.TabIndex = 2;
            btnSubmitIdea.Text = "SUBMIT";
            btnSubmitIdea.UseVisualStyleBackColor = true;
            btnSubmitIdea.Click += btnSubmitIdea_Click;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(100, 112);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.ScrollBars = ScrollBars.Vertical;
            tbDescription.Size = new Size(452, 108);
            tbDescription.TabIndex = 3;
            // 
            // tbNotes
            // 
            tbNotes.Location = new Point(100, 255);
            tbNotes.Multiline = true;
            tbNotes.Name = "tbNotes";
            tbNotes.ScrollBars = ScrollBars.Vertical;
            tbNotes.Size = new Size(452, 108);
            tbNotes.TabIndex = 4;
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(27, 115);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(67, 15);
            lbDescription.TabIndex = 5;
            lbDescription.Text = "Description";
            // 
            // lbNotes
            // 
            lbNotes.AutoSize = true;
            lbNotes.Location = new Point(27, 258);
            lbNotes.Name = "lbNotes";
            lbNotes.Size = new Size(38, 15);
            lbNotes.TabIndex = 6;
            lbNotes.Text = "Notes";
            // 
            // AddProjectIdeaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 424);
            Controls.Add(lbNotes);
            Controls.Add(lbDescription);
            Controls.Add(tbNotes);
            Controls.Add(tbDescription);
            Controls.Add(btnSubmitIdea);
            Controls.Add(tbName);
            Controls.Add(lbName);
            Margin = new Padding(2);
            Name = "AddProjectIdeaForm";
            Text = "AddProjectIdeaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName;
        private TextBox tbName;
        private Button btnSubmitIdea;
        private TextBox tbDescription;
        private TextBox tbNotes;
        private Label lbDescription;
        private Label lbNotes;
    }
}