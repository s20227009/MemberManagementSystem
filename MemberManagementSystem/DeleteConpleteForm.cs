using System;
using System.Windows.Forms;

namespace MemberManagementSystem
{
    public partial class DeleteConpleteForm : Form
    {
        private MainForm _main = default;

        public DeleteConpleteForm()
        {
            InitializeComponent();
        }

        private void MainGoButtonClick(object sender, EventArgs e)
        {
            _main = new MainForm();
            _main.Show();
            this.Close();
        }
    }
}
