using PASI.Api.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASI.Api.Services.Services
{
    public class ClienteService
    {
        public BaseViewModel lista(int id)
        {
            BaseViewModel v = new BaseViewModel();
            v.Mensagem = "Dado listado com sucesso " + id.ToString();
            v.Resultado = true;
            return v;
        }
    }
}