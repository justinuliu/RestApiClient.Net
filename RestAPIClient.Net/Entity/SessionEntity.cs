using System;

namespace RestAPIClient.Net.Entity
{
    public class SessionEntity
    {
        public string SessionId;
        public string Username;
        public string Resource;
        public string Node;
        public string SessionStatus;
        public string PresenceStatus;
        public int Priority;
        public string HostAddress;
        public string HostName;

        public DateTime CreateDate;
        public DateTime LastActionDate;

        public bool Secure;

        public SessionEntity()
        {

        }
    }
}
