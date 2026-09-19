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

        private void AddLecturerForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Lecturer.EPosition position = (Lecturer.EPosition)PositionComboBox.SelectedIndex;
            Lecturer.ESalary salary = Lecturer.GetSalary(position);
            int courseIndex = CourseComboBox.SelectedIndex;

            _dataHandler.AddLecturer(FirstNameTextBox.Text, LastNameTextBox.Text, position, salary, courseIndex);

            Close();
        }
    }
}
