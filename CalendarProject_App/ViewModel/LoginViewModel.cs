using System.Windows.Input;
using System.ComponentModel;
using System.Windows;

namespace CalendarProject_App.ViewModel
{
    /// <summary>
    /// ログイン画面ビジネスロジック
    /// </summary>
    public class LoginViewModel : ViewModelBase
    {
        #region プロパティ

        /// <summary>
        /// ログインID
        /// </summary>
        private string userId;
        public string UserId
        {
            get { return userId; }
            set
            {
                if (userId != value)
                {
                    userId = value;
                    OnPropertyChanged(nameof(UserId)); // 修正: プロパティ名を文字列で指定
                }
            }
        }

        /// <summary>
        /// ログインパスワード
        /// </summary>
        private string userPass;
        public string UserPass
        {
            get { return userPass; }
            set
            {
                if (userPass != value)
                {
                    userPass = value;
                    OnPropertyChanged(nameof(UserPass)); // 修正: プロパティ名を文字列で指定
                }
            }
        }

        public ICommand CmdLoginCheck { get; }

        #endregion プロパティ

        public LoginViewModel()
        {
            CmdLoginCheck = new RelayCommand(loginCheck);
        }

        public void loginCheck(object parameter)
        {
            // メッセージボックスでユーザーIDとパスワードを表示
            MessageBox.Show($"ログイン成功: ユーザーID = {UserId}, パスワード = {UserPass}");
        }
    }
}
