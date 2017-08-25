using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Extensions.MonoHttp;
using RestSharp.Authenticators;
using RestSharp.Newtonsoft.Json.NetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Portfolio.Models
{
    public class Repo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Html_Url { get; set; }
        public string Description { get; set; }


        public static List<Repo> GetRepos()
        {
            RestSharp.Deserializers.JsonDeserializer deserial = new RestSharp.Deserializers.JsonDeserializer();
            //Get base url
            var client = new RestClient(" https://api.github.com");
            var request = new RestSharp.RestRequest("search/repositories", Method.GET);

            //Add headers
            request.AddHeader("User-Agent", "kimlan1510");
            request.AddHeader("Authorization", "token " + EnvironmentVariable.AccessToken);

            //Add params
            var  param = HttpUtility.UrlDecode("user:kimlan1510+stars:>=1");
            request.AddParameter("q", param);
            request.AddParameter("per_page", "3");

            //Execute
            IRestResponse response = client.Execute(request);
            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(response.Content);
            var repoList = JsonConvert.DeserializeObject<List<Repo>>(jsonResponse["items"].ToString());
            return repoList;
        }
    }
}
