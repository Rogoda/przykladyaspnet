using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingDemo.Tests {

    [TestClass]
    public class AdminControllerTests {

        [TestMethod]
        public void CanChangeLoginName() {

            // przygotowanie (skonfigurowanie scenariusza)
            User user = new User() { LoginName = "Bob" };
            FakeRepository repositoryParam = new FakeRepository();
            repositoryParam.Add(user);
            AdminController target = new AdminController(repositoryParam);
            string oldLoginParam = user.LoginName;
            string newLoginParam = "Joe";

            // działanie (wykonanie operacji)
            target.ChangeLoginName(oldLoginParam, newLoginParam);

            // asercje (weryfikacja wyniku)
            Assert.AreEqual(newLoginParam, user.LoginName);
            Assert.IsTrue(repositoryParam.DidSubmitChanges);
        }
    }

    class FakeRepository : IUserRepository {
        public List<User> Users = new List<User>();
        public bool DidSubmitChanges = false;

        public void Add(User user) {
            Users.Add(user);
        }

        public User FetchByLoginName(string loginName) {
            return Users.First(m => m.LoginName == loginName);
        }

        public void SubmitChanges() {
            DidSubmitChanges = true;
        }
    }
}
