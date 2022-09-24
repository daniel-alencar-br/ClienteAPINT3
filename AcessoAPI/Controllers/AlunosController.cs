using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using AcessoAPI.Models;

// Conexao com a API
using System.Net.Http;
using System.Net.Http.Headers;

// utilização do JSON
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.Json;


namespace AcessoAPI.Controllers
{
    public class AlunosController : Controller
    {
        // objeto de acesso a API
        HttpClient client;
     
        public AlunosController()
        {
            if (client == null)
            {
                client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:61299/");
                client.DefaultRequestHeaders.Accept.Add(new    MediaTypeWithQualityHeaderValue("application/json"));
            }
        }

        public async Task<ActionResult> Listar()
        {
            var response = await client.GetAsync("api/alunos/listaralunos");

            if (response.IsSuccessStatusCode)
            {
                var Resultado = await response.Content.ReadAsStringAsync();

                var Lista = 
                  JsonConvert.DeserializeObject<Alunos[]>(Resultado).ToList();

                return View(Lista);
            }
            else
              return View();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}


