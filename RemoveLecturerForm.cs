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
            // Check if ID is valid
            if (!int.TryParse(IdTextBox.Text, out int id))
            {
                MessageBox.Show("Please enter a valid lecturer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Try and get the lecturer by ID
            Lecturer lecturer = _dataHandler.lecturers.FirstOrDefault(l => l.Id == id);

            // If the above search did not match a result tell the user
            if (lecturer == null)
            {
                MessageBox.Show($"Lecturer with ID {id} was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the user wants to delete the lecturer at the given ID
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete {lecturer.FirstName} {lecturer.LastName}?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                _dataHandler.RemoveLecturer(lecturer);
                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
