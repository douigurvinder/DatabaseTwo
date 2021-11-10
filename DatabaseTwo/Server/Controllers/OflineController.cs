using DatabaseTwo.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseTwo.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OflineController:ControllerBase
    {
        private readonly ApplicationDBcontext context;
        public OflineController(ApplicationDBcontext context)
        {
            this.context = context;
        }
        [HttpPost]
        public async Task<ActionResult<int>> Post(Ofline genre)
        {
            context.Add(genre);
            await context.SaveChangesAsync();
            return genre.Id;
        }
    }
}
