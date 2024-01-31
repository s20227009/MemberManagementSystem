using System;
using System.Windows.Forms;

namespace MemberManagementSystem
{
    public partial class CreateConpleteForm : Form
    {
        private MainForm _main = default;
        public CreateConpleteForm()
        {
            InitializeComponent();
        }

        private void MainGoButton_Click(object sender, EventArgs e)
        {
            _main = new MainForm();
            _main.Show();
            this.Close();
        }
    }
}
