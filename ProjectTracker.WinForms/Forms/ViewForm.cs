using ProjectTracker.Core.Interfaces;
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
        private readonly IProjectRepository _projectRepository;

        public ViewForm(IProjectRepository projectRepository)
        {
            InitializeComponent();
            _projectRepository = projectRepository;
        }

        private async void ViewForm_Load(object sender, EventArgs e)
        {
            try
            {
                var projects = await _projectRepository.GetAllAsync();

                DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
                viewButtonColumn.Name = "View/Edit";
                viewButtonColumn.Text = "View";
                viewButtonColumn.UseColumnTextForButtonValue = true;
                
                

                dgvProjects.DataSource = projects;
                dgvProjects.Columns["Description"].Visible = false;
                //dgvProjects.Columns["Private"].Visible = false;
                dgvProjects.Columns.Add(viewButtonColumn);
                //dgvProjects.Columns["View/Edit"].DisplayIndex = dgvProjects.Columns.Count - 1;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
