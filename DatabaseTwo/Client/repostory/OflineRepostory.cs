using DatabaseTwo.Client.Http;
using DatabaseTwo.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseTwo.Client.repostory
{
    public class OflineRepostory:IOflineRepostory
    {
        private readonly IHttpServices httpServices;
        private string url = "api/ofline_genre";
        public OflineRepostory(IHttpServices httpServices)
        {
            this.httpServices = httpServices;
        }
        public async Task CreateGenre(Ofline genre)
        {
            var response = await httpServices.Post(url, genre);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
