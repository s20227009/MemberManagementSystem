using System;
using System.Windows.Forms;

namespace MemberManagementSystem
{
    public partial class NotfoundIdForm : Form
    {
        private SerchIdForm serch = default;

        public NotfoundIdForm()
        {
            InitializeComponent();
        }

        private void ReturnButtonClick(object sender, EventArgs e)
        {
            serch = new SerchIdForm();
            serch.Show();
            this.Close();
        }
    }
}
