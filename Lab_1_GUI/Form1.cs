using System;
using System.Windows.Forms;
using GenerationLib;

namespace Lab_1_GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGenerateText_Click(object sender, EventArgs e)
        {
            GenTextForm newForm = new GenTextForm();
            newForm.ShowDialog();
        }

        private void btnSortText_Click(object sender, EventArgs e)
        {
            SortTextForm newForm = new SortTextForm();
            newForm.ShowDialog();

        }
    }
}
