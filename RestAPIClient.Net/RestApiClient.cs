using RestAPIClient.Net.Entity;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;

namespace RestAPIClient.Net
{
    public class RestApiClient
    {
        private RestClient client = new RestClient();

        public RestApiClient()
        {
        }

        public RestApiClient(string url)
        {
            client.BaseUrl = new Uri(url);
        }

        public RestApiClient(string url, string username, string password) : this(url)
        {
            client.Authenticator = new HttpBasicAuthenticator(username, password);
        }

        public UserEntities GetUsers(IDictionary<string, object> parameters)
        {
            return Call<UserEntities>("users", parameters);
        }

        public UserEntity GetUser(string username)
        {
            return Call<UserEntity>("users/" + username, null);
        }

        public RosterEntities GetRoster(string username)
        {
            return Call<RosterEntities>("users/" + username + "/roster", null);
        }

        public SessionEntities GetSessions()
        {
            return Call<SessionEntities>("sessions", null);
        }

        public SessionEntities GetSessions(string username)
        {
            return Call<SessionEntities>("sessions/" + username, null);
        }

        private T Call<T>(string resource, IDictionary<string, object> parameters) where T : new()
        {
            var request = new RestRequest();
            request.Resource = resource;

            if (parameters != null)
            {
                foreach (var kv in parameters)
                {
                    request.AddParameter(kv.Key, kv.Value);
                }
            }

            var response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response.  Check inner details for more info.";
                var twilioException = new ApplicationException(message, response.ErrorException);
                throw twilioException;
            }

            return response.Data;
        }


    }
}
