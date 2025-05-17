using ProjectTracker.Core.Interfaces.Repos;
using ProjectTracker.Core.Interfaces.Services;
using ProjectTracker.Core.Models;
using ProjectTracker.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProjectTracker.WinForms.Forms
{
    public partial class ViewForm : Form
    {

        private readonly IProjectViewService _projectViewService;
        private readonly ITaskViewService _taskViewService;

        //note maybe add a method to projectViewService to get status and priority and then only inject that rather than the repos
        public ViewForm(IProjectViewService projectViewService, ITaskViewService taskViewService)
        {
            InitializeComponent();
            _projectViewService = projectViewService;
            _taskViewService = taskViewService;

        }

        private string _currentSortColumn = "Name";
        private string _currentSortOrder = "ASC";
        private int? _projectTabSelectedStatus = null;
        private int? _projectTabSelectedPriority = null;
        private int? _taskTabSelectedStatus = null;
        private int? _taskTabSelectedPriority = null;
        private int? _taskTabSelectedProject = null;

        private async void ViewForm_Load(object sender, EventArgs e)
        {
            try
            {
                await ProjectsTab_Load();
                await TasksTab_Load();
            }
            catch (Exception ex)
            {

            }
        }

        //PROJECT VIEW TAB
        private async Task ProjectsTab_Load()
        {
            try
            {

                var projects = await _projectViewService.GetAllProjectsFilteredAsync(statusId: null, priorityId: null, sortBy: "Name", sortOrder: "ASC");

                //add buttons to form
                DataGridViewButtonColumn expandButtonColumn = new DataGridViewButtonColumn();
                expandButtonColumn.Name = "View Details";
                expandButtonColumn.Text = "Expand";
                expandButtonColumn.UseColumnTextForButtonValue = true;

                DataGridViewButtonColumn viewTasksButtonColumn = new DataGridViewButtonColumn();
                viewTasksButtonColumn.Name = "View Tasks";
                viewTasksButtonColumn.Text = "Tasks";
                viewTasksButtonColumn.UseColumnTextForButtonValue = true;

                //populate form
                dgvProjects.DataSource = projects;

                dgvProjects.Columns["Id"].Visible = false;

                dgvProjects.Columns.Add(expandButtonColumn);
                dgvProjects.Columns.Add(viewTasksButtonColumn);
                //dgvProjects.Columns["View/Edit"].DisplayIndex = dgvProjects.Columns.Count - 1;



                //set up combo boxes
                var priorities = (await _projectViewService.GetPrioritiesAsync()).ToList();

                priorities.Insert(0, new Priority { Id = 0, Name = "Select Priority" });

                cmbPriorityProject.DataSource = priorities;
                cmbPriorityProject.DisplayMember = "Name";
                cmbPriorityProject.ValueMember = "Id";


                var statuses = (await _projectViewService.GetStatusesAsync()).ToList();

                statuses.Insert(0, new Status { Id = 0, Name = "Select Status" });

                cmbStatusProject.DataSource = statuses;
                cmbStatusProject.DisplayMember = "Name";
                cmbStatusProject.ValueMember = "Id";


                //add button click/filetering methods
                dgvProjects.CellContentClick += dgvProjects_ButtonColumnsCellClick;
                dgvProjects.ColumnHeaderMouseClick += dgvProjects_ColumnHeadMouseClick;
                cmbStatusProject.SelectedIndexChanged += cmbStatusProject_SelectedIndexChanged;
                cmbPriorityProject.SelectedIndexChanged += cmbPriorityProject_SelectedIndexChanged;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //METHODS FOR PROJECTS GRID

        //cell buttons for columns task and view individual
        private async void dgvProjects_ButtonColumnsCellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dgvProjects.Columns["View Details"].Index)
            {
                MessageBox.Show("The EXPAND button works, add some logic to it!");
            }
            else if (e.ColumnIndex == dgvProjects.Columns["View Tasks"].Index)
            {
                MessageBox.Show("The TASKS button works, add some logic to it!");
            }
        }

        //sorting by column heads
        private async void dgvProjects_ColumnHeadMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string clickedColumn = dgvProjects.Columns[e.ColumnIndex].Name;

            string[] sortableColumns = { "Name", "StartDate", "FinishDate", "Status", "Priority" };

            if (!sortableColumns.Contains(clickedColumn))
            {
                return;
            }

            if (_currentSortColumn == clickedColumn)
            {
                _currentSortOrder = _currentSortOrder == "ASC" ? "DESC" : "ASC";
            }
            else
            {
                _currentSortColumn = clickedColumn;
                _currentSortOrder = "ASC";
            }

            await ReloadProjectsAsync();

        }


        //map to correct db names and reload page with sorting
        private async Task ReloadProjectsAsync()
        {
            string sortByDbColumn = _currentSortColumn switch
            {
                "Status" => "StatusId",
                "Priority" => "PriorityId",
                _ => _currentSortColumn
            };

            var projects = await _projectViewService.GetAllProjectsFilteredAsync(_projectTabSelectedStatus, _projectTabSelectedPriority, sortByDbColumn, _currentSortOrder);
            dgvProjects.DataSource = projects;
        }

        //filtering by status/priority combo boxes
        private async void cmbStatusProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatusProject.SelectedValue is int statusId && statusId != 0)
            {
                _projectTabSelectedStatus = statusId;
            }
            else
            {
                _projectTabSelectedStatus = null;
            }

            await ReloadProjectsAsync();
        }

        private async void cmbPriorityProject_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbPriorityProject.SelectedValue is int priorityId && priorityId != 0)
            {
                _projectTabSelectedPriority = priorityId;
            }
            else
            {
                _projectTabSelectedPriority = null;
            }

            await ReloadProjectsAsync();
        }


        // TASK VIEW TAB

        private async Task TasksTab_Load()
        {
            var tasks = await _taskViewService.GetAllTasksFilteredAsync(null, null, null, "Name", "ASC");

            //add buttons to form
            DataGridViewButtonColumn expandButtonColumn = new DataGridViewButtonColumn();
            expandButtonColumn.Name = "View Details";
            expandButtonColumn.Text = "Expand";
            expandButtonColumn.UseColumnTextForButtonValue = true;

            //populate form
            dgvTasks.DataSource = tasks;

            dgvTasks.Columns["Id"].Visible = false;

            dgvTasks.Columns.Add(expandButtonColumn);




            //set up combo boxes
            var projects = (await _projectViewService.GetAllProjectsAsync()).ToList();

            projects.Insert(0, new Project { Id = 0, Name = "Select Project" });

            cmbProjectTask.DataSource = projects;
            cmbProjectTask.DisplayMember = "Name";
            cmbProjectTask.ValueMember = "Id";


            var priorities = (await _projectViewService.GetPrioritiesAsync()).ToList();

            priorities.Insert(0, new Priority { Id = 0, Name = "Select Priority" });

            cmbPriorityTask.DataSource = priorities;
            cmbPriorityTask.DisplayMember = "Name";
            cmbPriorityTask.ValueMember = "Id";


            var statuses = (await _projectViewService.GetStatusesAsync()).ToList();

            statuses.Insert(0, new Status { Id = 0, Name = "Select Status" });

            cmbStatusTask.DataSource = statuses;
            cmbStatusTask.DisplayMember = "Name";
            cmbStatusTask.ValueMember = "Id";


            //add methods for button clicks, filtering etc

            dgvTasks.CellContentClick += dgvTasks_ButtonColumnsCellClick;
            dgvTasks.ColumnHeaderMouseClick += dgvTasks_ColumnHeadMouseClick;
            cmbStatusTask.SelectedIndexChanged += cmbStatusTask_SelectedIndexChanged;
            cmbProjectTask.SelectedIndexChanged += cmbProjectTask_SelectedIndexChanged;
            cmbPriorityTask.SelectedIndexChanged += cmbPriorityTask_SelectedIndexChanged;

        }

        private void CmbStatusProject_SelectedIndexChanged(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        //METHODS FOR TASK GRID


        //buttons column cell click 
        private async void dgvTasks_ButtonColumnsCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            

          
            if (e.ColumnIndex == dgvTasks.Columns["View Details"].Index)
            {
                MessageBox.Show("The EXPAND button works, add some logic to it!");
            }
        }



        //sorting by column heads
        private async void dgvTasks_ColumnHeadMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string clickedColumn = dgvTasks.Columns[e.ColumnIndex].Name;

            string[] sortableColumns = { "ProjectName", "Name", "StartDate", "FinishDate", "Status", "Priority" };

            if (!sortableColumns.Contains(clickedColumn))
            {
                return;
            }

            if (_currentSortColumn == clickedColumn)
            {
                _currentSortOrder = _currentSortOrder == "ASC" ? "DESC" : "ASC";
            }
            else
            {
                _currentSortColumn = clickedColumn;
                _currentSortOrder = "ASC";
            }

            await ReloadTasksAsync();

        }


        //map to correct db names and reload page with sorting
        private async Task ReloadTasksAsync()
        {
            string sortByDbColumn = _currentSortColumn switch
            {
                
                "Status" => "StatusId",
                "Priority" => "PriorityId",
                _ => _currentSortColumn
            };

            var tasks = await _taskViewService.GetAllTasksFilteredAsync(_taskTabSelectedProject, _taskTabSelectedStatus, _taskTabSelectedPriority, sortByDbColumn, _currentSortOrder);
            dgvTasks.DataSource = tasks;
        }

        //filtering by status/priority combo boxes

        private async void cmbStatusTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatusTask.SelectedValue is int statusId && statusId != 0)
            {
                _taskTabSelectedStatus = statusId;
            }
            else
            {
                _taskTabSelectedStatus = null;
            }

            await ReloadTasksAsync();
        }

        private async void cmbPriorityTask_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (cmbPriorityTask.SelectedValue is int priorityId && priorityId != 0)
            {
                _taskTabSelectedPriority = priorityId;
            }
            else
            {
                _taskTabSelectedPriority = null;
            }

            await ReloadTasksAsync();
        }

        private async void cmbProjectTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProjectTask.SelectedValue is int projectId && projectId != 0)
            {
                _taskTabSelectedProject = projectId;
            }
            else
            {
                _taskTabSelectedProject = null;
            }

            await ReloadTasksAsync();
        }
    }
}
