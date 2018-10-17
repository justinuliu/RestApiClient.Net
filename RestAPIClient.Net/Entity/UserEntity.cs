using System.Collections.Generic;

namespace RestAPIClient.Net.Entity
{
    public class UserEntity
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public List<UserProperty> Properties { get; set; }

        public UserEntity()
        {

        }

        public UserEntity(string username, string name, string email, string password)
        {
            this.Username = username;
            this.Name = name;
            this.Email = email;
            this.Password = password;
        }
    }
}
