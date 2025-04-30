namespace ProjectTracker.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            AddProjectForm addProjectForm = new AddProjectForm();
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
