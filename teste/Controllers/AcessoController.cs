using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using teste.Models;

// Namespaces para conexão com API
using System.Net.Http;
using System.Net.Http.Headers;

// Namespaces para uso dos dados da API
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace teste.Controllers
{
    public class AcessoController : Controller
    {

        // objeto de acesso a API
        HttpClient client;

        // constructor para conexão com a API
        public AcessoController()
        {
            // endereço da API e o tipo de resposta dela

            if (client == null)
            {
                client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:61299/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }
        }

        public async Task<ActionResult> Listar()
        {
            var response = await client.GetAsync("api/alunos/listaralunos");

            if (response.IsSuccessStatusCode)
            {
                var resultado = await response.Content.ReadAsStringAsync();

                var Lista = JsonConvert.DeserializeObject<Alunos[]>(resultado).ToList();

                return View(Lista);
            }
            else
            {
                return View();
            }
        }

    
    }
}