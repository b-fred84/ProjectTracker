using ProjectTracker.Core.Interfaces.Services;
using ProjectTracker.Core.Models;
using ProjectTracker.Services;
using System;
using System.Collections;
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
    public partial class ViewProjectForm : Form
    {

        private readonly IProjectViewService _projectViewService;
        private Project _project;
        public ViewProjectForm(IProjectViewService projectViewService, Project project)
        {
            InitializeComponent();
            _projectViewService = projectViewService;
            _project = project;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (!_project.HasTasks)
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this project?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    await _projectViewService.DeleteProjectAsync(_project.Id);
                    MessageBox.Show("Project deleted.");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Cannot delete a project that has active tasks.\n If you want to delete the project please delete tasks first");
            }

            
        }

        private void SetReadOnly(bool isReadOnly)
        {
            tbName.ReadOnly = isReadOnly;
            tbDescription.ReadOnly = isReadOnly;
            dtpStartDate.Enabled = !isReadOnly;
            dtpFinishDate.Enabled = !isReadOnly;
            cmbPriority.Enabled = !isReadOnly;
            cmbStatus.Enabled = !isReadOnly;
            cbPrivate.Enabled = !isReadOnly;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetReadOnly(false);
        }

        private async void btnSubmitEdit_Click(object sender, EventArgs e)
        {
            _project.Name = tbName.Text;
            _project.Description = tbDescription.Text;
            _project.PriorityId = (int)cmbPriority.SelectedValue;
            _project.StatusId = (int)cmbStatus.SelectedValue;
            _project.StartDate = dtpStartDate.Checked ? dtpStartDate.Value.Date : (DateTime?)null;
            _project.FinishDate = dtpFinishDate.Checked ? dtpFinishDate.Value.Date : (DateTime?)null;
            _project.Private = cbPrivate.Checked;

            await _projectViewService.UpdateProjectAsync( _project );

            MessageBox.Show($"{_project.Name} Updated");

            this.Close();
        }

        private async void ViewProject_Load(object sender, EventArgs e)
        {
            var priorities = await _projectViewService.GetPrioritiesAsync();
            cmbPriority.DataSource = priorities;
            cmbPriority.DisplayMember = "Name";
            cmbPriority.ValueMember = "Id";

            var statuses = await _projectViewService.GetStatusesAsync();
            cmbStatus.DataSource = statuses;
            cmbStatus.DisplayMember = "Name";
            cmbStatus.ValueMember = "Id";

            tbName.Text = _project.Name;
            tbDescription.Text = _project.Description;
            dtpStartDate.Value = _project.StartDate ?? DateTime.Now;
            dtpFinishDate.Value = _project.FinishDate ?? DateTime.Now;
            cmbPriority.SelectedValue = _project.PriorityId;
            cmbStatus.SelectedValue = _project.StatusId;
            cbPrivate.Checked = _project.Private;

            SetReadOnly(true);

        }
    }
}
