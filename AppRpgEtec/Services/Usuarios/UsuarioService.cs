using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AppRpgEtec.Models;

namespace AppRpgEtec.Services.Usuarios
{
    public class UsuarioService: Request
    {
        private readonly Request _request;
        private const string apiUrlBase = "http://xyz.somee.com/RpgApi/Usuarios";
        
        public UsuarioService()
        {
            _request = new Request();
        }

        public async Task<Usuario> PostRegistrarUsuarioAsync(Usuario u)
        {
            string urlComplentar = "/Registrar";
            u.Id = await _request.PostReturnIntAsync(apiUrlBase + urlComplentar, u);
            return u;
        }


        public async Task<Usuario> PostAutenticarUsuarioAsync(Usuario u)
        {
            string urlComplementar = "/Autenticar";
            u = await _request.PostAsync(apiUrlBase + urlComplementar, u, String.Empty); 
            return u;
        }
    }

       
}
