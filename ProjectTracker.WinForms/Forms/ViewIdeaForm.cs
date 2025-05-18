using ProjectTracker.Core.Interfaces.Repos;
using ProjectTracker.Core.Interfaces.Services;
using ProjectTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTracker.WinForms.Forms
{
    public partial class ViewIdeaForm : Form
    {
        private readonly IIdeaViewService _ideaViewService;
        private ProjectIdea _idea;
        
       
        public ViewIdeaForm(IIdeaViewService ideaViewService, ProjectIdea idea)
        {
            InitializeComponent();
            _ideaViewService = ideaViewService; 
            _idea = idea;

            tbName.Text = idea.Name;
            tbDescription.Text = idea.Description;
            tbNotes.Text = idea.Notes;

            SetReadOnly(true);

        }

        public void SetReadOnly(bool readOnly)
        {
            tbName.ReadOnly = readOnly;
            tbDescription.ReadOnly = readOnly;
            tbNotes.ReadOnly = readOnly;

        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to delete this idea?", "Confirm Delete", MessageBoxButtons.YesNo);
            
            if(confirm == DialogResult.Yes)
            {
                var id = _idea.Id;
                _ideaViewService.DeleteIdeaAsync(id);
            }

            this.Close();
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetReadOnly(false); 
        }

        private void btnSubmitIdeaEdit_Click(object sender, EventArgs e)
        {
            _idea.Name = tbName.Text;
            _idea.Description = tbDescription.Text;
            _idea.Notes = tbNotes.Text;
            _ideaViewService.UpdateIdeaAsync(_idea);

            MessageBox.Show($"{_idea.Name} Updated");

            this.Close();
          
        }
    }
}
