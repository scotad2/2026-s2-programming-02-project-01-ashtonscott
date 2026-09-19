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
    public partial class AddLearnerForm : Form
    {
        private DataHandler _dataHandler;

        internal AddLearnerForm(DataHandler dataHandler)
        {
            InitializeComponent();

            _dataHandler = dataHandler;

            CourseComboBox.DataSource = _dataHandler.courses;
            CourseComboBox.DisplayMember = "Name";
        }

        private void AddLearnerForm_Load(object sender, EventArgs e)
        {
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            List<int> marks = [int.Parse(Mark1.Text), int.Parse(Mark2.Text), int.Parse(Mark3.Text), int.Parse(Mark4.Text), int.Parse(Mark5.Text)];
            
            foreach (int mark in marks)
            {
                // Check if a mark is negative
                if (mark < 0)
                {
                    MessageBox.Show("You can not input a negative mark.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if a mark is over 100
                if (mark > 100)
                {
                    MessageBox.Show("You can not input a mark over 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            int courseIndex = CourseComboBox.SelectedIndex;

            try
            {
                _dataHandler.AddLearner(FirstNameTextBox.Text, LastNameTextBox.Text, courseIndex, marks);
            }
            catch(Exception ex)
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
