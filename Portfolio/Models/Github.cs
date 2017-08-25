using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Extensions.MonoHttp;
using RestSharp.Newtonsoft.Json.NetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Portfolio.Models
{
    public class Github
    {
        public class Git
        {
            public object Items { get; set; }
            
        }
        public static Git GetGithubRepos()
        {
            //RestSharp.Deserializers.JsonDeserializer deserial = new RestSharp.Deserializers.JsonDeserializer();
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
            //var content = deserial.Deserialize<Git>(response);
            return null;
        }
    }
}
