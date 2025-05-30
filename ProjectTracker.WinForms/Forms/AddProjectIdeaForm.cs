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
    public partial class AddProjectIdeaForm : Form
    {
        private readonly IIdeaViewService _ideaViewService;

        public AddProjectIdeaForm(IIdeaViewService ideaViewService)
        {
            InitializeComponent();
            _ideaViewService = ideaViewService;
        }

        

        private async void btnSubmitIdea_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValid = true;
                string errorMessage = "";


                ProjectIdea projectIdea = new ProjectIdea
                {
                    Name = tbName.Text,
                    Description = tbDescription.Text,
                    Notes = tbNotes.Text
                };

                if (string.IsNullOrEmpty(projectIdea.Name))
                {
                    isValid = false;
                    errorMessage += "A name must be entered for the project idea";
                }

                if (isValid)
                {
                    await _ideaViewService.AddIdeaAsync(projectIdea);

                    MessageBox.Show($"Project Idea: {projectIdea.Name} was successfully addeed.");

                    //ClearIdeaForm();
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

        public void ClearIdeaForm()
        {
            tbName.Clear();
            tbDescription.Clear();
            tbNotes.Clear();
        }
    }
}
