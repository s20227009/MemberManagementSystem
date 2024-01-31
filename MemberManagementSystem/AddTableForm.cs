using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MemberManagementSystem
{
    public partial class AddTableForm : Form
    {
        //遷移先form
        private MainForm _main = default;
        private InsertClearForm _clear = default;
        private ErrorIdForm _errorId = default;
        //SQLiteアクセス
        private SQLiteConnection _dbConnection = default;
        private SQLiteTransaction _dbTransaction = default;
        private SQLiteCommand _dbCommand = default;
        //遷移先変更bool
        private bool _existsInsert = default;
        //重複判定をする
        private int _result = default;
        public AddTableForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// テーブルにデータを追加する
        /// </summary>
        private void NextBottonClick(object sender, EventArgs e)
        {
            //  TextBoxからIDを抽出する
            _existsInsert = true;
            using (_dbConnection = new SQLiteConnection("Data Source=System.db"))
            {
                _dbConnection.Open();
                using (_dbTransaction = _dbConnection.BeginTransaction())
                {
                    _dbCommand = _dbConnection.CreateCommand();
                    // インサート
                    _dbCommand.CommandText = "INSERT INTO MS_product (ID, PASSWORD, NAME, MAILADDRESS, TELEPHONE, ADDRESS)" +
                        " SELECT @id, @password, @name, @mailaddress, @telephone, @address WHERE NOT EXISTS (SELECT 1 FROM MS_product WHERE ID = @id)";
                    // パラメータセット
                    _dbCommand.Parameters.Add("id", System.Data.DbType.String);
                    _dbCommand.Parameters.Add("password", System.Data.DbType.String);
                    _dbCommand.Parameters.Add("name", System.Data.DbType.String);
                    _dbCommand.Parameters.Add("mailaddress", System.Data.DbType.String);
                    _dbCommand.Parameters.Add("telephone", System.Data.DbType.String);
                    _dbCommand.Parameters.Add("address", System.Data.DbType.String);
                    //データ追加 
                    _dbCommand.Parameters["id"].Value = MemberIDIn.Text;
                    _dbCommand.Parameters["password"].Value = MemberPasswordIn.Text;
                    _dbCommand.Parameters["name"].Value = NameInBox.Text;
                    _dbCommand.Parameters["mailaddress"].Value = MailAdressIn.Text;
                    _dbCommand.Parameters["telephone"].Value = TelephoneIn.Text;
                    _dbCommand.Parameters["address"].Value = MemberAddressIn.Text;
                    _result = _dbCommand.ExecuteNonQuery();
                    // コミット
                    _dbTransaction.Commit();
                    //重複判定
                    if (_result == 0)
                    {
                        _errorId = new ErrorIdForm();
                        _errorId.Show();
                        _existsInsert = false;
                    }
                    if (_existsInsert)
                    {
                        _clear = new InsertClearForm();
                        _clear.Show();
                    }

                }
                _dbConnection.Close();
            }
            this.Close();
        }

        /// <summary>
        /// メインメニューに戻る
        /// </summary>
        private void MainGoButtonClick(object sender, EventArgs e)
        {
            _main = new MainForm();
            _main.Show();
            this.Close();
        }

    }
}
