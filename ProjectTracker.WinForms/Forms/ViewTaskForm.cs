using ProjectTracker.Core.Interfaces.Services;
using ProjectTracker.Core.Models;
using ProjectTracker.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectTracker.WinForms.Forms
{
    public partial class ViewTaskForm : Form
    {
        private readonly ITaskViewService _taskViewService;
        private readonly IProjectViewService _projectViewService;
        private TaskModel _task;
        public ViewTaskForm(ITaskViewService taskViewService, IProjectViewService projectViewService, TaskModel task)
        {
            InitializeComponent();
            _taskViewService = taskViewService;
            _projectViewService = projectViewService;
            _task = task;    
        }

        private void SetReadOnly(bool isReadOnly)
        {
            tbName.ReadOnly = isReadOnly;
            tbDetails.ReadOnly = isReadOnly;
            dtpStartDate.Enabled = !isReadOnly;
            dtpFinishDate.Enabled = !isReadOnly;
            cmbPriority.Enabled = !isReadOnly;
            cmbStatus.Enabled = !isReadOnly;
            cmbProject.Enabled = !isReadOnly;
            cbPrivate.Enabled = !isReadOnly;
        }

       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to delete this task?", "Confirm Delete", MessageBoxButtons.YesNo);
            
            if (confirm == DialogResult.Yes)
            {
                _taskViewService.DeleteTaskAsync(_task.Id);
            }

            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetReadOnly(false);
        }

        private void btnSubmitEdit_Click(object sender, EventArgs e)
        {
            _task.Name = tbName.Text;
            _task.Details = tbDetails.Text;
            _task.ProjectId = (int)cmbProject.SelectedValue;
            _task.PriorityId = (int)cmbPriority.SelectedValue;
            _task.StatusId = (int)cmbStatus.SelectedValue;
            _task.StartDate = dtpStartDate.Checked ? dtpStartDate.Value.Date : (DateTime?)null;
            _task.FinishDate = dtpFinishDate.Checked ? dtpFinishDate.Value.Date : (DateTime?)null;
            _task.Private = cbPrivate.Checked;
            _taskViewService.UpdateTaskAsync(_task);

            MessageBox.Show($"{_task.Name} Updated");

            this.Close();
        }

        private async void ViewTaskForm_Load(object sender, EventArgs e)
        {
            var projects = await _projectViewService.GetAllProjectsAsync();
            cmbProject.DataSource = projects;
            cmbProject.DisplayMember = "Name";
            cmbProject.ValueMember = "Id";

            var priorities = await _projectViewService.GetPrioritiesAsync();
            cmbPriority.DataSource = priorities;
            cmbPriority.DisplayMember = "Name";
            cmbPriority.ValueMember = "Id";

            var statuses = await _projectViewService.GetStatusesAsync();
            cmbStatus.DataSource = statuses;
            cmbStatus.DisplayMember = "Name";
            cmbStatus.ValueMember = "Id";

            tbName.Text = _task.Name;
            tbDetails.Text = _task.Details;
            dtpStartDate.Value = _task.StartDate ?? DateTime.Now;
            dtpFinishDate.Value = _task.FinishDate ?? DateTime.Now;
            cmbPriority.SelectedValue = _task.PriorityId;
            cmbStatus.SelectedValue = _task.StatusId;
            cmbProject.SelectedValue = _task.ProjectId;
            cbPrivate.Checked = _task.Private;

            SetReadOnly(true);

        }
    }
}
