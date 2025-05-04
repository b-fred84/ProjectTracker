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
using ProjectTracker.Core.Interfaces;
using ProjectTracker.Core.Models;
using ProjectTracker.DataAccess;

namespace ProjectTracker.WinForms
{
    public partial class AddProjectForm : Form
    {

        private readonly IProjectRepository _projectRepository;
        public AddProjectForm(IProjectRepository projectRepository)
        {
            InitializeComponent();
            _projectRepository = projectRepository;

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
                    await _projectRepository.AddAsync(project);

                    MessageBox.Show($"Project: {project.Name} successfully added to the db.");

                    ClearProjectForm();
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
            var priorties = await _projectRepository.GetAllPriorityAsync();
            cmbPriority.DataSource = priorties;
            cmbPriority.DisplayMember = "Name";
            cmbPriority.ValueMember = "Id";

            var stutusList = await _projectRepository.GetAllStatusAsync();
            cmbStatus.DataSource = stutusList;
            cmbStatus.DisplayMember = "Name";
            cmbStatus.ValueMember = "Id";
        }
    }
}
