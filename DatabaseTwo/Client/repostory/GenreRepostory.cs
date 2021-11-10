using DatabaseTwo.Client.Http;
using DatabaseTwo.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseTwo.Client.repostory
{
    public class GenreRepostory:IGenreRepostory
    {
        private readonly IHttpServices httpServices;
        private string url = "api/genre";
        public GenreRepostory(IHttpServices httpServices)
        {
            this.httpServices = httpServices;
        }

        public async Task CreateGenre(Online genre)
        {
            var response = await httpServices.Post(url, genre);
            if(!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

    }
}
