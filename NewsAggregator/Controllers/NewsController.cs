using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewsAggregator.Controllers
{
    public class NewsController : ApiController
    {
        [HttpGet]
        [Route("api/news")]
        public HttpResponseMessage Newses()
        {
            try
            {
                var data = NewsService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex) {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/news/{id}/comments")]
        public HttpResponseMessage NewsComment(int id)
        {
            try
            {
                var data = NewsService.GetNewsComment(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        


    }
}
