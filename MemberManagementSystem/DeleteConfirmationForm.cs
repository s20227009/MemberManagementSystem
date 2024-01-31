using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MemberManagementSystem
{
    public partial class DeleteConfirmationForm : Form
    {
        //前formから削除を行うIDを受け取る
        public string DeleteID { get; set; }
        //SQliteにアクセス
        private SQLiteConnection _dbConnection = default;
        private SQLiteTransaction _dbTransaction = default;
        private SQLiteCommand _dbCommand = default;
        //formを格納
        private DeleteConpleteForm _delete = default;
        private Form _info = default;

        public DeleteConfirmationForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 記述されたIDと同じデータを消す
        /// </summary>
        private void DeleteOkButton_Click(object sender, EventArgs e)
        {
            using (_dbConnection = new SQLiteConnection("Data Source=System.db"))
            {
                _dbConnection.Open();
                using (_dbTransaction = _dbConnection.BeginTransaction())
                {
                    _dbCommand = _dbConnection.CreateCommand();
                    //削除
                    _dbCommand.CommandText = "DELETE FROM MS_product WHERE ID = @id;";
                    _dbCommand.Parameters.Add("id", System.Data.DbType.String);
                    _dbCommand.Parameters["id"].Value = DeleteID;
                    _dbCommand.ExecuteNonQuery();
                    // コミット
                    _dbTransaction.Commit();
                }
                _dbConnection.Close();
            }
            _delete = new DeleteConpleteForm();
            _delete.Show();
            _info = Application.OpenForms["MemberInformationForm"];
            if (_info != null)
            {
                _info.Close();
            }
            this.Close();
        }

        private void DeleteNoButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
