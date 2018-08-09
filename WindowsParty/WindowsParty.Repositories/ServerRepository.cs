using System;
using System.Collections.Generic;
using System.Net.Http;
using WindowsParty.IRepositories;
using WindowsParty.Models;

namespace WindowsParty.Repositories
{
    public class ServerRepository : IServerRepository
    {
        public IEnumerable<Server> GetServers(string accessToken)
        {
            //TODO: get string from config
            using (var client = new HttpClient {BaseAddress = new Uri("http://playground.tesonet.lt/")})
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
                var result = client.GetAsync("v1/servers").Result.Content.ReadAsStringAsync().Result;

                //TODO: UNCOMMENT!!!
                //return JsonConvert.DeserializeObject<IEnumerable<Server>>(result);

                return null;
                //JsonConvert.DeserializeObject<IEnumerable<Server>>(
                //    "[{\"name\":\"AAA Lithuania #51\",\"distance\":1088},{\"name\":\"Lithuania #87\",\"distance\":778},{\"name\":\"Germany #14\",\"distance\":970},{\"name\":\"Lithuania #14\",\"distance\":1316},{\"name\":\"Japan #56\",\"distance\":199},{\"name\":\"Lithuania #12\",\"distance\":903},{\"name\":\"Singapore #25\",\"distance\":1495},{\"name\":\"Japan #90\",\"distance\":69},{\"name\":\"Lithuania #8\",\"distance\":1376},{\"name\":\"United States #55\",\"distance\":103},{\"name\":\"Latvia #22\",\"distance\":1282},{\"name\":\"Lithuania #64\",\"distance\":1070},{\"name\":\"United States #45\",\"distance\":1747},{\"name\":\"Germany #29\",\"distance\":1196},{\"name\":\"Singapore #53\",\"distance\":1742},{\"name\":\"Lithuania #64\",\"distance\":759},{\"name\":\"Singapore #45\",\"distance\":537},{\"name\":\"Lithuania #56\",\"distance\":1291},{\"name\":\"Lithuania #75\",\"distance\":471},{\"name\":\"Germany #87\",\"distance\":306},{\"name\":\"Japan #52\",\"distance\":1281},{\"name\":\"Germany #36\",\"distance\":256},{\"name\":\"United States #44\",\"distance\":41},{\"name\":\"Germany #58\",\"distance\":1784},{\"name\":\"United Kingdom #59\",\"distance\":1695},{\"name\":\"Singapore #75\",\"distance\":1090},{\"name\":\"Japan #97\",\"distance\":25},{\"name\":\"Latvia #83\",\"distance\":340},{\"name\":\"United States #32\",\"distance\":1139},{\"name\":\"Latvia #82\",\"distance\":1646}]");
            }
        }
    }
}