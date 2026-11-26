using MyWebDomain.Models;

namespace MyWebDomain.RepositoryInterfaces
{
    public interface IUserRepowitory
    {
        /// <summary>
        /// 取得
        /// </summary>
        /// <param name="id">ユーザID</param>
        /// <returns>ユーザ</returns>
        public User Find(Guid id);

        /// <summary>
        /// アカウント名で取得
        /// </summary>
        /// <param name="accountName">アカウント名</param>
        /// <returns>ユーザ</returns>
        public User FindByLoginName(string accountName);

        /// <summary>
        /// 追加
        /// </summary>
        /// <param name="model">追加対象ユーザ</param>
        public void Insert(User model);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="model">更新対象ユーザ</param>
        public void Update(User model);
    }
}
