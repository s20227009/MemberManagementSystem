using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MemberManagementSystem
{
    public partial class MemberInformationForm : Form
    {
        //検索を行った結果を受け取る
        public string[] UserData { get; set; }
        //IDを格納する
        private string _befireID = default;
        //SQLにアクセスする
        private SQLiteConnection _dbConnection = default;
        private SQLiteCommand _dbCommand = default;
        private SQLiteTransaction _dbTransaction = default;
        //遷移先formを格納する
        private UpdateConpleteForm _update = default;
        private DeleteConfirmationForm _Confirmation = default;
        public MemberInformationForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 受け取った値をTextBoxに格納する
        /// </summary>
        public void DisplayOpen()
        {
            IDBox.Text = UserData[0];
            _befireID = UserData[0];
            NameBox.Text = UserData[2];
            TelephoneBox.Text = UserData[4];
            MailaddressBox.Text = UserData[3];
            AddressBox.Text = UserData[5];
            PasswordBox.Text = UserData[1];
        }
        /// <summary>
        /// 変更されたTextBox内の値をテーブル内の値へ更新する
        /// </summary>
        private void UpdateButtonClick(object sender, EventArgs e)
        {
            //SQLiteに接続する
            using (_dbConnection = new SQLiteConnection("Data Source=System.db"))
            {
                _dbConnection.Open();
                using (_dbTransaction = _dbConnection.BeginTransaction())
                {
                    _dbCommand = _dbConnection.CreateCommand();
                    //更新
                    _dbCommand.CommandText = "UPDATE MS_product set ID = @id, PASSWORD = @password, NAME = @name, " +
                        "MAILADDRESS = @mailaddress,  TELEPHONE = @telephone, ADDRESS = @address WHERE ID = @id2;";
                    _dbCommand.Parameters.Add("id", System.Data.DbType.String);
                    _dbCommand.Parameters.Add("password", System.Data.DbType.String);
                    _dbCommand.Parameters.Add("name", System.Data.DbType.String);
                    _dbCommand.Parameters.Add("mailaddress", System.Data.DbType.String);
                    _dbCommand.Parameters.Add("telephone", System.Data.DbType.String);
                    _dbCommand.Parameters.Add("address", System.Data.DbType.String);
                    _dbCommand.Parameters.Add("id2", System.Data.DbType.String);
                    _dbCommand.Parameters["id"].Value = IDBox.Text;
                    _dbCommand.Parameters["password"].Value = PasswordBox.Text;
                    _dbCommand.Parameters["name"].Value = NameBox.Text;
                    _dbCommand.Parameters["mailaddress"].Value = MailaddressBox.Text;
                    _dbCommand.Parameters["telephone"].Value = TelephoneBox.Text;
                    _dbCommand.Parameters["address"].Value = AddressBox.Text;
                    _dbCommand.Parameters["id2"].Value = _befireID;
                    _dbCommand.ExecuteNonQuery();
                    // コミット
                    _dbTransaction.Commit();
                }
                _dbConnection.Close();
            }
            //form遷移
            _update = new UpdateConpleteForm();
            _update.Show();
            this.Close();
        }
        /// <summary>
        /// 表示している会員情報を削除する確認をするformを表示する
        /// </summary>
        private void DeleteButtonClick(object sender, EventArgs e)
        {
            _Confirmation = new DeleteConfirmationForm();
            _Confirmation.Show();
            _Confirmation.DeleteID = _befireID;
        }
    }
}
