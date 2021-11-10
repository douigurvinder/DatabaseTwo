using DatabaseTwo.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseTwo.Client.repostory
{
    public interface IOflineRepostory
    {
        Task CreateGenre(Ofline genre);
    }
}
