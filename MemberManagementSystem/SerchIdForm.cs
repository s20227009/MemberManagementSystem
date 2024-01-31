using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MemberManagementSystem
{

    public partial class SerchIdForm : Form
    {
        //検索するIDを格納する
        private string _id = default;
        //検索するSQL文
        readonly private string _readonlySql = "SELECT * FROM MS_product WHERE ID = @ID";
        //別formに検索結果を送る値を格納する
        private string[] _sendText = default;
        //SQLにアクセス
        private SQLiteConnection _dbconection = default;
        private SQLiteCommand _dbCommand = default;
        private SQLiteDataReader _dbDataReader = default;
        //遷移するform
        private MainForm _main = default;
        private AmbiguousSerchIdForm _ambiguous = default;
        private MemberInformationForm _info = default;
        private NotfoundIdForm _notfound = default;
        //作業用変数
        private int i = 0;

        public SerchIdForm()
        {
            InitializeComponent();
        }

        private void AmbiguousLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ambiguous = new AmbiguousSerchIdForm();
            _ambiguous.Show();
            this.Close();
        }
        /// <summary>
        /// IDを検索して別formに検索結果を送る
        /// </summary>
        private void DecisionButtonClick(object sender, EventArgs e)
        {
            using (_dbconection = new SQLiteConnection("Data Source=System.db"))
            {
                _dbconection.Open();
                //TextBoxから検索を行うIDを抽出する
                _id = InputBox.Text;
                _dbCommand = new SQLiteCommand(_readonlySql, _dbconection);
                _dbCommand.Parameters.AddWithValue("@ID", _id);
                _dbDataReader = _dbCommand.ExecuteReader();
                //検索が成功した場合
                if (_dbDataReader.HasRows)
                {

                    _info = new MemberInformationForm();
                    _info.Show();
                    i = 0;
                    _sendText = default;
                    _dbDataReader.Read();
                    //検索結果を格納し、送る
                    _sendText = new string[] { _dbDataReader.GetString(i), _dbDataReader.GetString(i + 1), _dbDataReader.GetString(i + 2), _dbDataReader.GetString(i + 3), _dbDataReader.GetString(i + 4), _dbDataReader.GetString(i + 5)};
                    _info.UserData = _sendText;
                    _info.DisplayOpen();
                    _dbDataReader.Close();
                    _dbconection.Close();
                    this.Close();
                }
                //検索が失敗した場合
                else
                {
                    _notfound = new NotfoundIdForm();
                    _notfound.Show();
                    this.Close();
                }
            }
        }

        private void GoMainButtonClick(object sender, EventArgs e)
        {
            _main = new MainForm();
            _main.Show();
            this.Close();
        }
    }
}
