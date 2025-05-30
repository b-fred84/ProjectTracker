using Microsoft.Extensions.DependencyInjection;
using ProjectTracker.Core.Interfaces.Services;
using ProjectTracker.WinForms.Forms;

namespace ProjectTracker.WinForms
{
    public partial class MainForm : Form
    {


        private readonly IServiceProvider _serviceProvider;
        private readonly IExportService _exportService;
        public MainForm(IServiceProvider serviceProvider, IExportService exportService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _exportService = exportService;
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

        private async void btnExport_Click(object sender, EventArgs e)
        {
            using SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                FileName = "ProjectExport.txt",
                Title = "Save Export File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    await _exportService.ExportProjectsWithTasksToFileAsync(saveFileDialog.FileName);
                    MessageBox.Show("Export successful");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Export failed: {ex.Message}");
                }
            }
        }

        private async void btnExportAll_Click(object sender, EventArgs e)
        {
            using SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                FileName = "AllProjectExport.txt",
                Title = "Save Export File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    await _exportService.ExportAllToFileAsync(saveFileDialog.FileName);
                    MessageBox.Show("Export successful");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Export failed: {ex.Message}");
                }
            }

        }
    }
}
