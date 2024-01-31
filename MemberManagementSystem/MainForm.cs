using System;
using System.Windows.Forms;

namespace MemberManagementSystem
{
    public partial class MainForm : Form
    {
        private AddTableForm _addtable = default;
        private SerchIdForm _serch = default;
        private CreateTableForm _create = default;
        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateButtonClick(object sender, EventArgs e)
        {
            _addtable = new AddTableForm();
            _addtable.Show();
            this.Hide();
        }

        private void kakuninnClick(object sender, EventArgs e)
        {
            _create = new CreateTableForm();
            _create.Show();
            this.Hide();
        }

        private void SeachButtonClick(object sender, EventArgs e)
        {
            _serch = new SerchIdForm();
            _serch.Show();
            this.Hide();
        }
    }
}
