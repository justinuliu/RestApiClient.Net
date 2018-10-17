using System.Collections.Generic;

namespace RestAPIClient.Net.Entity
{
    public class SessionEntities
    {
        public List<SessionEntity> Sessions { get; set; }

        public SessionEntities()
        {

        }

        public SessionEntities(List<SessionEntity> sessions)
        {
            this.Sessions = sessions;
        }
    }
}
