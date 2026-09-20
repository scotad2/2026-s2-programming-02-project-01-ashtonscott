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
    public partial class AddLecturerForm : Form
    {
        private DataHandler _dataHandler;

        internal AddLecturerForm(DataHandler dataHandler)
        {
            InitializeComponent();

            _dataHandler = dataHandler;

            CourseComboBox.DataSource = _dataHandler.courses;
            CourseComboBox.DisplayMember = "Name";

            PositionComboBox.DataSource = Enum.GetValues<Lecturer.EPosition>().Select(Lecturer.PositionToString).ToList();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Lecturer.EPosition position = (Lecturer.EPosition)PositionComboBox.SelectedIndex;
            Lecturer.ESalary salary = Lecturer.GetSalary(position); // Calculate the salary from the position

            int courseIndex = CourseComboBox.SelectedIndex;

            try
            {
                _dataHandler.AddLecturer(FirstNameTextBox.Text, LastNameTextBox.Text, position, salary, courseIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
