using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClienteAPINT3.Dados;
using ClienteAPINT3.Models;

namespace ClienteAPINT3.Controllers
{
    [RoutePrefix("api/alunos")]
    public class AlunosController : ApiController
    {
        [HttpGet, Route("ListarMaterias")]
        //[HttpGet, Route("api/alunos/ListarMaterias")]
        public IEnumerable<string> GetMaterias()
        {
            return DB.ListarMaterias();
        }

        [HttpGet, Route("ListarAlunos")]
        public IEnumerable<Alunos> GetAlunos()
        {
            return DB.ListarAlunos();
        }

        [HttpGet, Route("PesquisarMateria/{id}")]
        public string PesqMateria(string id)
        {
            List<string> Mats = (List<string>)DB.ListarMaterias();
            return Mats.Find(p => p.Contains(id));
        }

        [HttpGet, Route("PesquisarAluno/{id}")]
        public Alunos PesqAluno(int id)
        {
            List<Alunos> alunos = (List<Alunos>)DB.ListarAlunos();
            return alunos.Find(p => p.Codigo == id);
        }
    }
}






