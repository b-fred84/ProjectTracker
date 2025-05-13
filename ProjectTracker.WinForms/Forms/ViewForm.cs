using ProjectTracker.Core.Interfaces.Repos;
using ProjectTracker.Core.Interfaces.Services;
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
    public partial class ViewForm : Form
    {
      
        private readonly IProjectViewService _projectViewService;

        public ViewForm(IProjectViewService projectViewService)
        {
            InitializeComponent();
            _projectViewService = projectViewService;
        }

        private async void ViewForm_Load(object sender, EventArgs e)
        {
            try
            {
                var projects = await _projectViewService.GetAllProjectsAsync();

                DataGridViewButtonColumn expandButtonColumn = new DataGridViewButtonColumn();
                expandButtonColumn.Name = "View Details";
                expandButtonColumn.Text = "Expand";
                expandButtonColumn.UseColumnTextForButtonValue = true; 

                DataGridViewButtonColumn viewTasksButtonColumn = new DataGridViewButtonColumn();
                viewTasksButtonColumn.Name = "View Tasks";
                viewTasksButtonColumn.Text = "Tasks";
                viewTasksButtonColumn.UseColumnTextForButtonValue = true;
                

                dgvProjects.DataSource = projects;

                dgvProjects.Columns["Id"].Visible = false;
               
                dgvProjects.Columns.Add(expandButtonColumn);
                dgvProjects.Columns.Add(viewTasksButtonColumn);
                //dgvProjects.Columns["View/Edit"].DisplayIndex = dgvProjects.Columns.Count - 1;

                dgvProjects.CellContentClick += dgvProjects_CellContentClick;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProjects.Columns["View Details"].Index)
            {
                MessageBox.Show("The EXPAND button works, add some logic to it!");
            }
            else if (e.ColumnIndex == dgvProjects.Columns["View Tasks"].Index)
            {
                MessageBox.Show("The TASKS button works, add some logic to it!");
            }
        }
    }
}
