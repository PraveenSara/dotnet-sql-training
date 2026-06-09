using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_Assessment.Models;

namespace WebApi_Assessment.Controllers
{
    [RoutePrefix("api/Country")]
    public class CountryController : ApiController
    {
        static List<Country> countries = new List<Country>()
        {
            new Country{Id=1, CountryName="India", Capital="New Delhi"},
            new Country{Id=2, CountryName="USA", Capital="Washington D.C"},
            new Country{Id=3, CountryName="Japan", Capital="Tokyo"}
        };

        [HttpGet]
        [Route("All")]
        public IEnumerable<Country> Get()
        {
            return countries;
        }

        [HttpGet]
        [Route("ById")]
        public IHttpActionResult GetById(int id)
        {
            var countryId = countries.FirstOrDefault(c => c.Id == id);

            if (countryId == null)
                return NotFound();

            return Ok(countryId);
        }

        [HttpPost]
        [Route("Add")]
        public IEnumerable<Country> Post([FromBody] Country country)
        {
            countries.Add(country);
            return countries;
        }

        [HttpPut]
        [Route("Update")]
        public IHttpActionResult Put(int id, [FromBody] Country country)
        {
            var UpdId = countries.FirstOrDefault(c => c.Id == id);

            if (UpdId == null)
                return NotFound();

            UpdId.CountryName = country.CountryName;
            UpdId.Capital = country.Capital;

            return Ok(UpdId);
        }

        [HttpDelete]
        [Route("Delete")]
        public IHttpActionResult Delete(int id)
        {
            var delId = countries.FirstOrDefault(c => c.Id == id);

            if (delId == null)
            {
                return NotFound();
            }
            
            countries.Remove(delId);

            return Ok(countries);
        }
    }
}
