using Microsoft.Extensions.DependencyInjection;
using ProjectTracker.WinForms.Forms;

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
            AddTaskForm addTaskForm = _serviceProvider.GetRequiredService<AddTaskForm>();
            addTaskForm.ClearTaskForm();
            addTaskForm.ShowDialog();
        }

        private void btnAddIdea_Click(object sender, EventArgs e)
        {
            AddProjectIdeaForm addProjectIdeaForm = _serviceProvider.GetRequiredService<AddProjectIdeaForm>();
            addProjectIdeaForm.ClearIdeaForm();
            addProjectIdeaForm.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewForm viewForm = _serviceProvider.GetRequiredService<ViewForm>();
            
            viewForm.ShowDialog();
        }
    }
}
