using System.Collections.Generic;

namespace RestAPIClient.Net.Entity
{

    public class UserEntities
    {
        public List<UserEntity> Users { get; set; }

        public UserEntities()
        {

        }

        public UserEntities(List<UserEntity> users)
        {
            this.Users = users;
        }
    }
}
