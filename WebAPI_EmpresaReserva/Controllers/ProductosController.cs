using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_EmpresaReserva
{
    public class ProductosController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {

            Produto[] produtos = new Business.Models.Produto[]
{
            new Produto { Id = 1, Nome = "Camisa", Descricao = "Camisa de Mountain Bike Camisa de manga comprida Jersey Ciclismo" },
            new Produto { Id = 2, Nome = "Calça", Descricao = "Calças Jeans Masculina Almix" },
            new Produto { Id = 3, Nome = "Calçado", Descricao = "Loafer Afterburn M. Fit Wonted, Skechers, masculino" }
            // Tênis Skechers Go Walk Max, Masculino
};
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}