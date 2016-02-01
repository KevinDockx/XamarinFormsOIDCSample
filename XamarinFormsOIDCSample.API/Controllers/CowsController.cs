using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace XamarinFormsOIDCSample.API.Controllers
{
    public class CowsController : ApiController
    {
        [Route("api/cows")]
        public IHttpActionResult Get()
        {
            return Ok(new [] { new { Name = "Bella", SoundsLike = "Moooh" } });
        }
    }
}
