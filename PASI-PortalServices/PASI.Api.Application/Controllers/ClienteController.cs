using PASI.Api.Services.Services;
using PASI.Api.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace PASI.Api.Application.Controllers
{
    public class ClienteController : ApiController
    {
        ClienteService clienteService = new ClienteService();

        // GET api/cliente
        public IEnumerable<string> Get()
        {
            return new string[] { "a", "b" };
        }

        // GET api/cliente/5
        [Route("api/Cliente/Danado")]
        [HttpGet]
        public BaseViewModel Get(int id)
        {
            return clienteService.lista(id);
        }
    }
}