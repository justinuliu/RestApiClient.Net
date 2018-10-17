using RestSharp.Deserializers;
using System.Collections.Generic;

namespace RestAPIClient.Net.Entity
{
    public class RosterEntities
    {
        [DeserializeAs(Name = "rosterItem")]
        public List<RosterItemEntity> Roster { get; set; }

        public RosterEntities()
        {

        }

        public RosterEntities(List<RosterItemEntity> roster)
        {
            this.Roster = roster;
        }
    }
}
