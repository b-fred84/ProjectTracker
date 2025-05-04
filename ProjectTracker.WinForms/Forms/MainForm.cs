using Microsoft.Extensions.DependencyInjection;

namespace ProjectTracker.WinForms
{
    public partial class MainForm : Form
    {


        private readonly IServiceProvider _serviceProvider;
        public MainForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            AddProjectForm addProjectForm = _serviceProvider.GetRequiredService<AddProjectForm>();
            addProjectForm.ClearProjectForm();
            addProjectForm.ShowDialog();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm();
            addTaskForm.ShowDialog();
        }

        private void btnAddIdea_Click(object sender, EventArgs e)
        {
            AddProjectIdeaForm addProjectIdeaForm = new AddProjectIdeaForm();
            addProjectIdeaForm.ShowDialog();
        }
    }
}
