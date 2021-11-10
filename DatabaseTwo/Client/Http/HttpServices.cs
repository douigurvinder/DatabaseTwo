using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DatabaseTwo.Client.Http
{
    public class HttpServices : IHttpServices
    {
        private readonly HttpClient httpclient;
        public HttpServices(HttpClient httpclient)
        {
            this.httpclient = httpclient;
        }
        public async Task<HttpResponseWrapper<object>>Post<T>(string url,T data)
        {

            var dataJson = JsonSerializer.Serialize(data);
            var stringContent = new StringContent(dataJson, Encoding.UTF8, "application/json");
            var response = await httpclient.PostAsync(url, stringContent);
            return new HttpResponseWrapper<object>(null, response.IsSuccessStatusCode, response);

        }

    }
}
