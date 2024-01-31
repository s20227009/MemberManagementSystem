using System;
using System.Windows.Forms;

namespace MemberManagementSystem
{
    public partial class InsertClearForm : Form
    {
        private MainForm _main = default;

        public InsertClearForm()
        {
            InitializeComponent();
        }

        private void GoMainButtonClick(object sender, EventArgs e)
        {
            //メインメニューに戻る
            _main = new MainForm();
            _main.Show();
            this.Close();
        }
    }
}
