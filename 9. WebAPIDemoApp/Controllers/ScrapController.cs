using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebAPIDemoApp.Controllers
{
    public class ScrapController : ApiController
    {
        // GET: api/Scrap
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Scrap/5
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Raspagem de informações
        /// </summary>
        /// <returns> Retorna todos os assuntos mais falados no Twitter </returns>

        [Route("api/Scrap/twitter")]
        [HttpGet]
        public string TwitterTopTrend()
        {
            string url = "https://twitter.com/explore/tabs/trending";
            var response = CallUrl(url).Result;
            return response;
        }

        private static async Task<string> CallUrl(string fullUrl)
        {
            HttpClient client = new HttpClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            client.DefaultRequestHeaders.Accept.Clear();
            var response = Task.Run(() => client.GetStringAsync(fullUrl));
            return await response;
        }

        // POST: api/Scrap
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Scrap/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Scrap/5
        public void Delete(int id)
        {
        }
    }
}
