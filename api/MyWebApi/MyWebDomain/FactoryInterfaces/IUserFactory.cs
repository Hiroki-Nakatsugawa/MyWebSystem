using MyWebDomain.Models;

namespace MyWebDomain.FactoryInterfaces
{
    public interface IUserFactory
    {
        public User Create(string accountName, string userName);
    }
}
