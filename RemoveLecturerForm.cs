using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class RemoveLecturerForm : Form
    {
        private DataHandler _dataHandler;

        internal RemoveLecturerForm(DataHandler dataHandler)
        {
            InitializeComponent();

            _dataHandler = dataHandler;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IdTextBox.Text);

            _dataHandler.RemoveLecturer(id);

            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
