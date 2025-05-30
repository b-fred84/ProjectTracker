﻿using ProjectTracker.Core.Interfaces.Repos;
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

namespace ProjectTracker.WinForms
{
    public partial class AddTaskForm : Form
    {

        private readonly IProjectViewService _projectViewService;
        private readonly ITaskViewService _taskViewService;

        public AddTaskForm(IProjectViewService projectViewService, ITaskViewService taskViewService)
        {
            InitializeComponent();
            _projectViewService = projectViewService;
            _taskViewService = taskViewService;

        }

        private async void btnSubmitTask_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValid = true;
                string errorMessage = "";

                TaskModel task = new TaskModel()
                {
                    Name = tbName.Text,
                    Details = tbDetails.Text,
                    ProjectId = (int)cmbProject.SelectedValue,
                    PriorityId = (int)cmbPriority.SelectedValue,
                    StatusId = (int)cmbStatus.SelectedValue,
                    StartDate = dtpStartDate.Checked ? dtpStartDate.Value.Date : (DateTime?)null,
                    FinishDate = dtpFinishDate.Checked ? dtpFinishDate.Value.Date : (DateTime?)null,
                    Private = cbPrivate.Checked
                    
                };

                if (string.IsNullOrEmpty(task.Name))
                {
                    isValid = false;
                    errorMessage += "A task name must be entered.\n\r";
                }

                if (dtpStartDate.Checked && dtpFinishDate.Checked && task.FinishDate < task.StartDate)
                {
                    isValid = false;
                    errorMessage += "Incorrect date selection: Finish must be after Start.\n\r";
                }

                if (isValid)
                {
                    await _taskViewService.AddTaskAsync(task);

                    MessageBox.Show($"Task: {task.Name} successfully added for Project: {cmbProject.Text}");

                    //ClearTaskForm();

                    this.Close();   
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void AddTaskForm_Load(object sender, EventArgs e)
        {
            var projects = await _projectViewService.GetAllProjectsAsync();
            cmbProject.DataSource = projects;
            cmbProject.DisplayMember = "Name";
            cmbProject.ValueMember = "Id";

            var priorities = await _projectViewService.GetPrioritiesAsync();
            cmbPriority.DataSource = priorities;
            cmbPriority.DisplayMember = "Name";
            cmbPriority.ValueMember = "Id";

            var statusList = await _projectViewService.GetStatusesAsync();
            cmbStatus.DataSource = statusList;
            cmbStatus.DisplayMember = "Name";
            cmbStatus.ValueMember = "Id";
            
        }
        
        public void ClearTaskForm()
        {
            tbName.Clear();
            cmbProject.SelectedIndex = -1;
            cmbPriority.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            tbDetails.Clear();
            dtpStartDate.Checked = false;
            dtpFinishDate.Checked = false;
            dtpStartDate.Value = DateTime.Today.Date;
            dtpFinishDate.Value = DateTime.Today.Date;
            cbPrivate.Checked = false;
        }
    }
}
