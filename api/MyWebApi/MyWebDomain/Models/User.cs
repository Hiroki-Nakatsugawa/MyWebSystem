namespace MyWebDomain.Models
{
    public class User
    {
        #region Properties

        /// <summary>
        /// ユーザID
        /// </summary>
        public Guid UserId { get; private set; }

        /// <summary>
        /// アカウント名
        /// </summary>
        public string AccountName { get; private set; }

        /// <summary>
        /// ユーザ名
        /// </summary>
        public string UserName { get; private set; }

        /// <summary>
        /// パスワード
        /// </summary>
        public string Password { get; private set; }

        /// <summary>
        /// 最終ログイン日時
        /// </summary>
        public DateTime? LastLogin { get; private set; }

        /// <summary>
        /// 有効無効フラグ
        /// (true:有効,false:無効)
        /// </summary>
        public bool Enabled { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public User()
        {
            UserId = Guid.NewGuid();
            AccountName = string.Empty;
            UserName = string.Empty;
            Password = string.Empty;
            LastLogin = null;
            Enabled = false;
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="userId">ユーザID</param>
        /// <param name="accountName">アカウント名</param>
        /// <param name="userName">ユーザ名</param>
        /// <param name="password">パスワード</param>
        /// <param name="lastLogin">最終更新日時</param>
        /// <param name="enabled">有効無効フラグ</param>
        public User(Guid userId, string accountName, string userName, string password, DateTime? lastLogin, bool enabled)
        {
            this.UserId = userId;
            this.AccountName = accountName;
            this.UserName = userName;
            this.Password = password;
            this.LastLogin = lastLogin;
            this.Enabled = enabled;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// ユーザ作成
        /// </summary>
        /// <param name="userId">ユーザID</param>
        /// <param name="accountName">アカウント名</param>
        /// <param name="userName">ユーザ名</param>
        /// <param name="password">パスワード</param>
        /// <returns>ユーザ</returns>
        public static User CreateUser(Guid userId, string accountName, string userName, string password)
        {
            return new User(userId, accountName, userName, password, null, false);
        }

        /// <summary>
        /// ログイン
        /// </summary>
        /// <param name="password">パスワード</param>
        /// <exception cref="Exception">例外</exception>
        public void Login(string password)
        {
            if (Password != this.Password)
            {
                // パスワードが一致しない場合例外
                throw new Exception();
            }
            // 最終ログイン日時を更新
            this.LastLogin = DateTime.Now;
        }

        /// <summary>
        /// ユーザ編集
        /// </summary>
        /// <param name="accountName">アカウント名</param>
        /// <param name="userName">ユーザ名</param>
        public void EditUser(string accountName, string userName)
        {
            this.AccountName = accountName;
            this.UserName = userName;
        }

        /// <summary>
        /// パスワード初期化
        /// </summary>
        /// <param name="initialPassword">初期パスワード</param>
        public void ResetPassword(string initialPassword)
        {
            // パスワード初期化
            this.Password = initialPassword;
        }

        /// <summary>
        /// パスワード変更
        /// </summary>
        /// <param name="oldPassword">旧パスワード</param>
        /// <param name="newPassword">新パスワード</param>
        /// <param name="newPasswordConfirm">新パスワード(確認)</param>
        public void ChangePassword(string oldPassword, string newPassword, string newPasswordConfirm)
        {
            if (Password != this.Password)
            {
                // パスワードが一致しない場合例外
                throw new Exception();
            }
            if (newPassword != newPasswordConfirm) 
            {
                // パスワードが一致しない場合例外
                throw new Exception();
            }
            // パスワードを変更
            this.Password = newPassword;
        }

        /// <summary>
        /// ユーザ有効化
        /// </summary>
        public void EnableUser()
        {
            // ユーザ有効化
            this.Enabled = true;
        }

        /// <summary>
        /// ユーザ無効化
        /// </summary>
        public void DisableUser()
        {
            // ユーザ無効化
            this.Enabled = false;
        }
        #endregion
    }
}
