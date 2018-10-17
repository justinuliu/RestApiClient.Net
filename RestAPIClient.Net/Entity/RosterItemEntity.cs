using System.Collections.Generic;

namespace RestAPIClient.Net.Entity
{
    public class RosterItemEntity
    {
        public string Jid { get; set; }
        public string Nickname { get; set; }
        public int SubscriptionType { get; set; }
        public List<string> Groups { get; set; }

        public RosterItemEntity()
        {

        }

        public RosterItemEntity(string jid, string nickname, int subscriptionType)
        {
            this.Jid = jid;
            this.Nickname = nickname;
            this.SubscriptionType = subscriptionType;
        }
    }
}
