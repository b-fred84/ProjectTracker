using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTracker.Core;
using ProjectTracker.Core.Interfaces.Repos;
using ProjectTracker.Core.Models;


namespace ProjectTracker.WinForms
{
    public partial class AddProjectForm : Form
    {

        private readonly IProjectRepository _projectRepository;
        private readonly IPriorityRepository _priorityRepository;
        private readonly IStatusRepository _statusRepository;
        public AddProjectForm(IProjectRepository projectRepository, IPriorityRepository priorityRepository, IStatusRepository statusRepository)
        {
            InitializeComponent();
            _projectRepository = projectRepository;
            _priorityRepository = priorityRepository;
            _statusRepository = statusRepository;
        }

        private async void btnSubmitProject_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValid = true;
                string errorMessage = "";
                

                Project project = new Project
                {
                    Name = tbName.Text,
                    Description = tbDescription.Text,
                    StatusId = (int)cmbStatus.SelectedValue, 
                    PriorityId = (int)cmbPriority.SelectedValue, 
                    StartDate = dtpStartDate.Checked ? dtpStartDate.Value.Date : (DateTime?)null,
                    FinishDate = dtpFinishDate.Checked ? dtpFinishDate.Value.Date : (DateTime?)null,
                    Private = cbPrivate.Checked
                };

                if (string.IsNullOrEmpty(project.Name))
                {
                    isValid = false;
                    errorMessage += "A project name must be entered.\n\r";
                }

                if (dtpStartDate.Checked && dtpFinishDate.Checked && project.FinishDate < project.StartDate)
                {
                    isValid = false;
                    errorMessage += "Incorrect date selection: Finish must be after Start.\n\r";
                }

                if (isValid)
                {
                    await _projectRepository.AddProjectAsync(project);

                    MessageBox.Show($"Project: {project.Name} successfully added.");

                    //ClearProjectForm();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        public void ClearProjectForm()
        {
            tbName.Clear();
            tbDescription.Clear();
            cmbPriority.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            dtpStartDate.Checked = false;
            dtpFinishDate.Checked = false;
            dtpStartDate.Value = DateTime.Today.Date;
            dtpFinishDate.Value = DateTime.Today.Date;
            cbPrivate.Checked = false;
        }

        private async void AddProjectForm_Load(object sender, EventArgs e)
        {
            var priorties = await _priorityRepository.GetAllPriorityAsync();
            cmbPriority.DataSource = priorties;
            cmbPriority.DisplayMember = "Name";
            cmbPriority.ValueMember = "Id";

            var statusList = await _statusRepository.GetAllStatusAsync();
            cmbStatus.DataSource = statusList;
            cmbStatus.DisplayMember = "Name";
            cmbStatus.ValueMember = "Id";
        }
    }
}
