using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RestAPIClient.Net.Test
{
    [TestClass]
    public class RestApiClientTest
    {
        RestApiClient client;

        [TestInitialize]
        public void Setup()
        {
            client = new RestApiClient("http://192.168.0.200:9090/plugins/restapi/v1", "admin", "admin");
        }

        [TestCleanup]
        public void TearDown()
        {
        }

        [TestMethod]
        public void GetUsers()
        {
            var users = client.GetUsers(null);

            Assert.IsNotNull(users);
            Assert.IsTrue(users.Users.Count > 0);
        }

        [TestMethod]
        public void GetUser()
        {
            var users = client.GetUser("0a2ebf2beda8");

            Assert.IsNotNull(users);
        }

        [TestMethod]
        public void GetRoster()
        {
            var roster = client.GetRoster("08c429e7f1ea");

            Assert.IsNotNull(roster);
            Assert.IsNotNull(roster.Roster);
            Assert.IsTrue(roster.Roster.Count > 0);
        }

        [TestMethod]
        public void GetSessions()
        {
            var sessions = client.GetSessions();

            Assert.IsNotNull(sessions);
            Assert.IsNotNull(sessions.Sessions);
            Assert.IsTrue(sessions.Sessions.Count > 0);
        }

        [TestMethod]
        public void GetSession()
        {
            var sessions = client.GetSessions("08c429e7f1ea");

            Assert.IsNotNull(sessions);
            Assert.IsNotNull(sessions.Sessions);
            Assert.IsTrue(sessions.Sessions.Count > 0);
        }
    }
}
