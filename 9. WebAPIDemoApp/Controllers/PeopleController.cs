using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemoApp.Models;
using HtmlAgilityPack;

namespace WebAPIDemoApp.Controllers
{
    /// <summary>
    /// Classe PeopleController
    /// </summary>
    
    public class PeopleController : ApiController
    {
        List<Pearson> people = new List<Pearson>();

        /// <summary>
        /// Construtor
        /// </summary>
        
        public PeopleController()
        {
            people.Add(new Pearson { FirstName = "Matheus", LastName = "Falcirolli", Id = 1 });
            people.Add(new Pearson { FirstName = "Joice", LastName = "Silva", Id = 2 });
            people.Add(new Pearson { FirstName = "Luke", LastName = "Skywalker", Id = 3 });
        }

        /// <summary>
        /// Visualizar o primeiro nome de cada pessoa cadastrada
        /// </summary>
        /// <returns> Lista de todos os primeiros nomes </returns>

        [Route("api/People/GetFirstNames")]
        [HttpGet]
        public List<string> GetFirstNames()
        {
            List<string> output = new List<string>();

            foreach (var item in people)
            {
                output.Add(item.FirstName);
            }

            return output;
        }

        /// <summary>
        /// Visualizar o primeiro nome de cada pessoa cadastrada com variáveis
        /// </summary>
        /// <param name="userId"> Código único para cada pessoa </param>
        /// <param name="age"> Idade de cada pessoa </param>
        /// <returns> Lista de todos os primeiros nomes </returns>
        
        [Route("api/People/GetFirstNames/{userId:int}/{age:int}")]
        [HttpGet]
        public List<string> GetFirstNamesWithVariables(int userId, int age)
        {
            List<string> output = new List<string>();

            foreach (var item in people)
            {
                output.Add(item.FirstName);
            }

            return output;
        }

        /// <summary>
        /// Visualizar o cadastro de todas as pessoas
        /// </summary>
        
        /// <returns></returns>
        // GET: api/People
        public List<Pearson> Get()
        {
            return people;
        }

        /// <summary>
        /// Visualizar o cadastro de uma pessoa específica
        /// </summary>
        /// <param name="id"> Código único para cada pessoa </param>
        /// <returns></returns>

        // GET: api/People/5
        public Pearson Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        /// <summary>
        /// Inserir cadastro de pessoas
        /// </summary>
        /// <param name="val"></param>
        
        // POST: api/People
        public void Post(Pearson val)
        {
            people.Add(val);
        }

        /// <summary>
        /// Deletar cadastro de pessoas
        /// </summary>
        /// <param name="id"> Código único para cada pessoa </param>

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
