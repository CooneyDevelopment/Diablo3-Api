using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WilliamCooney.Diablo3.Domain.Entities;
using WilliamCooney.Diablo3.Domain.Repositories;

namespace WilliamCooney.Diablo3.Data.Repositories
{
    public class BaseRepository : IBaseRepository
    {
        private const string BaseBlizzardUrl = @"https://us.battle.net";

        private const string GetCareerPath = @"/d3/profile/";
        private const string GetHeroPath = @"/hero/";
        private const string GetItemPath = @"/d3/data/item/";

        private const string ApiKey = @"g757ptnep3ktw5jf8pzpnku2ynws9g9b";
        private const string ApiKeyPath = @"?locale=en_US&apikey=" + ApiKey;

        private HttpClient _client;

        public BaseRepository()
        {
            CreateHttpClient();
        }

        private void CreateHttpClient()
        {
            _client = new HttpClient
            {
                //BaseAddress = new Uri(BaseBlizzardUrl),
                Timeout = new TimeSpan(0, 5, 0)
            };
        }

        public async Task<CareerProfile> GetCareerProfile(string battletag)
        {
            var url = BaseBlizzardUrl + GetCareerPath + battletag;
            var response = await ExecuteGetRequestAsync(url);
        }

        public async Task<HeroProfile> GetHeroProfile(string battletag, string id)
        {
            var url = BaseBlizzardUrl + GetCareerPath + battletag + GetHeroPath + id;
            var response = await ExecuteGetRequestAsync(url);
        }

        public async Task<ItemData> GetItemData(string id)
        {
            var url = BaseBlizzardUrl + GetItemPath + id;
            var response = await ExecuteGetRequestAsync(url);
            dynamic data = JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync());
            return MapItemDataFromDynamic(data);
        }

        private async Task<HttpResponseMessage> ExecuteGetRequestAsync(string fullUrl)
        {
            fullUrl += ApiKeyPath;
            var request = new HttpRequestMessage(HttpMethod.Get, fullUrl);
            var response = await _client.SendAsync(request);
            return response;
        }

        private ItemData MapItemDataFromDynamic(dynamic data)
        {
            var result = new ItemData();
            if (data == null) return result;
            result.Id = data.Id;
        }
    }
}

/*
      HttpClient client = this.GetHttpClient(useCache);
      string fullUrl = this.BuildFullUrl(client, urlPath, urlArguments);
      HttpRequestMessage request = new HttpRequestMessage(method, fullUrl);
      this.AddCredentials(request, user);
      if (headers != null)
      {
        foreach (string name in headers.AllKeys)
          request.Headers.Add(name, headers[name]);
        bool flag;
        int num = flag ? 1 : 0;
      }
      if (jsonString != null)
      {
        request.Content = (HttpContent) new StringContent(jsonString);
        request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
      }
      await this.OnRequestAsync(request).ConfigureAwait(false);
      HttpResponseMessage responseMessage = await client.SendAsync(request).ConfigureAwait(false);
      await this.OnResponseAsync(responseMessage).ConfigureAwait(false);
      await this.ValidateHttpReponseAsync(responseMessage).ConfigureAwait(false);
      return responseMessage;
*/