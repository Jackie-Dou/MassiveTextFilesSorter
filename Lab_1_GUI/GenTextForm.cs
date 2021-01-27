using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenerationLib;

namespace Lab_1_GUI
{
    public partial class GenTextForm : Form
    {
        public GenTextForm()
        {
            InitializeComponent();
            saveGenFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        string str;
        string path;
        

        private void txtboxSize_TextChanged(object sender, EventArgs e)
        {
            str = txtboxSize.Text;
        }

        private void SaveGenFile_Click(object sender, EventArgs e)
        {
            if (saveGenFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            path = saveGenFileDialog.FileName;
           // lblWarning.Text = "Пожалуйста, подождите, идёт генерация файла...";
            GenText generator = new GenText();
            generator.CreateText(path, str);           
            MessageBox.Show("Файл сохранен", "Уведомление", MessageBoxButtons.OK);
        }

        private void txtboxSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
