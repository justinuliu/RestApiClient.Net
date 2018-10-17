
namespace RestAPIClient.Net.Entity
{
    public class UserProperty
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public UserProperty()
        {

        }

        public UserProperty(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}
