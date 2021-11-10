using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseTwo.Client.Http
{
    public interface IHttpServices
    {
        Task<HttpResponseWrapper<object>> Post<T>(string url, T data);
    }
}
