namespace TestingDemo {

    public class User {
        public string LoginName { get; set; }
    }

    public interface IUserRepository {
        void Add(User newUser);
        User FetchByLoginName(string loginName);
        void SubmitChanges();
    }

    public class DefaultUserRepository : IUserRepository {

        public void Add(User newUser) {
            // miejsce na implementację
        }

        public User FetchByLoginName(string loginName) {
            // miejsce na implementację
            return new User() { LoginName = loginName };
        }

        public void SubmitChanges() {
            // miejsce na implementację
        }
    }
}