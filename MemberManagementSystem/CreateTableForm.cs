using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MemberManagementSystem
{
    public partial class CreateTableForm : Form
    {
        //SQLiteへアクセス
        private SQLiteConnection _dbConnection = default;
        private SQLiteCommand _dbCommand = default;
        //遷移先form
        private MainForm _main = default;

        public CreateTableForm()
        {
            InitializeComponent();
        }

        private void MainGoButton_Click(object sender, EventArgs e)
        {
            _main = new MainForm();
            _main.Show();
            this.Close();
        }
        /// <summary>
        /// 会員情報テーブルを作成する
        /// </summary>
        private void CreateMemberSystem_Click(object sender, EventArgs e)
        {
            using (_dbConnection = new SQLiteConnection("Data Source=System.db"))
            {
                _dbConnection.Open();
                using (_dbCommand = _dbConnection.CreateCommand())
                {
                    _dbCommand.CommandText =
                        "create table MS_product(ID TEXT PRIMARY KEY, PASSWORD TEXT,NAME TEXT,MAILADDRESS TEXT,TELEPHONE TEXT,ADDRESS TEXT)";
                    _dbCommand.ExecuteNonQuery();
                }
                _dbConnection.Close();
            }
        }
        /// <summary>
        /// 曖昧検索結果を表示するテーブルを作成する
        /// </summary>
        private void CreateDisplay_Click(object sender, EventArgs e)
        {
            using (_dbConnection = new SQLiteConnection("Data Source=DisplayTable.db"))
            {
                _dbConnection.Open();
                using (_dbCommand = _dbConnection.CreateCommand())
                {
                    _dbCommand.CommandText =
                        "create table Display_product(ID TEXT, PASSWORD TEXT,NAME TEXT,MAILADDRESS TEXT,TELEPHONE TEXT,ADDRESS TEXT)";
                    _dbCommand.ExecuteNonQuery();
                }
                _dbConnection.Close();
            }
        }
    }
}
