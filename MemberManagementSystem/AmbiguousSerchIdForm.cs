using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MemberManagementSystem
{
    public partial class AmbiguousSerchIdForm : Form
    {
        //検索を行うID
        private string _id = default;
        //曖昧検索を行うSQL文
        readonly private string _readonlySql = "SELECT * FROM MS_product WHERE ID LIKE '%' || @ID || '%'";
        //SQLiteにアクセス
        private SQLiteCommand _dbCommand = default;
        private SQLiteDataReader _dbDataReader = default;
        private SQLiteConnection _dbConnection = default;
        private SQLiteTransaction _dbTranscation = default;
        //曖昧検索を行った検索結果を全て表示させる
        private SQLiteCommand _displayCommand = default;
        private SQLiteConnection _displayConnection = default;
        private SQLiteDataAdapter _displayDataAdapter = default;
        private DataTable _displayDataTable = default;
        //別formへ遷移
        private SerchIdForm _Serch = default;
        //作業変数
        int i = default;
        public AmbiguousSerchIdForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// SQLiteのテーブルにアクセスし、曖昧検索を行った後の検索結果を別テーブルに移し表示する
        /// </summary>
        private void SearchGoClick(object sender, EventArgs e)
        {
            //SQLiteに接続する
            using (_dbConnection = new SQLiteConnection("Data Source=System.db"))
            {
                _dbConnection.Open();
                //IDを記述したTextBoxからTextを抽出する
                _id = InputBox.Text;
                _dbCommand = new SQLiteCommand(_readonlySql, _dbConnection);
                _dbCommand.Parameters.AddWithValue("@ID", _id);
                _dbDataReader = _dbCommand.ExecuteReader();
                if (_dbDataReader.HasRows)
                {
                    //検索結果を格納するSQLiteに接続する
                    using (_displayConnection = new SQLiteConnection("Data Source=DisplayTable.db"))
                    {
                        _displayConnection.Open();
                        using (_dbTranscation = _displayConnection.BeginTransaction())
                        {
                            using (_displayCommand = new SQLiteCommand("DELETE FROM Display_product", _displayConnection))
                            {
                                _displayCommand.ExecuteNonQuery();
                                _displayCommand.CommandText = "INSERT INTO Display_product (ID, PASSWORD, NAME, MAILADDRESS, TELEPHONE, ADDRESS) VALUES (@id, @password, @name, @mailaddress, @telephone, @address)";
                                //変数初期化
                                i = 0;
                                //検索結果を格納する
                                while (_dbDataReader.Read())
                                {
                                    _displayCommand.Parameters.Add("id", System.Data.DbType.String);
                                    _displayCommand.Parameters.Add("password", System.Data.DbType.String);
                                    _displayCommand.Parameters.Add("name", System.Data.DbType.String);
                                    _displayCommand.Parameters.Add("mailaddress", System.Data.DbType.String);
                                    _displayCommand.Parameters.Add("telephone", System.Data.DbType.String);
                                    _displayCommand.Parameters.Add("address", System.Data.DbType.String);
                                    //データ追加 
                                    _displayCommand.Parameters["id"].Value = _dbDataReader.GetString(i);
                                    _displayCommand.Parameters["password"].Value = _dbDataReader.GetString(i + 1);
                                    _displayCommand.Parameters["name"].Value = _dbDataReader.GetString(i + 2);
                                    _displayCommand.Parameters["mailaddress"].Value = _dbDataReader.GetString(i + 3);
                                    _displayCommand.Parameters["telephone"].Value = _dbDataReader.GetString(i + 4);
                                    _displayCommand.Parameters["address"].Value = _dbDataReader.GetString(i + 5);
                                    _displayCommand.ExecuteNonQuery();
                                }
                                // コミット
                                _dbTranscation.Commit();
                                // DataTableを生成します。
                                _displayDataTable = new DataTable();
                                // SQLの実行
                                _displayDataAdapter = new SQLiteDataAdapter("SELECT * FROM Display_product", _displayConnection);
                                _displayDataAdapter.Fill(_displayDataTable);
                                dataGridView1.DataSource = _displayDataTable;
                            }
                        }
                    }
                }
                _dbDataReader.Close();
                _dbConnection.Close();
            }

        }


        private void NextClick(object sender, EventArgs e)
        {
            _Serch = new SerchIdForm();
            _Serch.Show();
            this.Close();
        }
    }
}
