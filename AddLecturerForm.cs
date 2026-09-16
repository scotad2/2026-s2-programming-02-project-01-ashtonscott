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
        }
    }
}
