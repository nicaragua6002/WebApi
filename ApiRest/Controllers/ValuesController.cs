using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiRest.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        //public IEnumerable<string> Post([FromBody]string value)
        //{
        //    return new string[] { value+"uno", value+"dos", "tres", "cuatro" };
        //}
        [HttpPost]
        [Route("api/lista")]
        public IEnumerable<Person> Lista()
        {
            List<Person> lista= new List<Person> { (new Person() { name = "Juan", ape = "Fome" }) };
            return lista;
        }


        public IEnumerable<string> Post([FromBody]JObject data)
        {
            string value = data["UserName"].ToObject<string>();
            string pass = data["Password"].ToObject<string>();
            return new string[] { value + "uno", value + "dos"+pass, "tres"+pass, "cuatro"+pass };
        }

        // PUT api/values/5
        public string Put(int id, [FromBody]string value)
        {
            return id + "no mames;";
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }

    public class Person
    {
        public string name{ get; set;}
        public string ape { get; set; }
    }
}
