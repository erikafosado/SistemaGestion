using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaGestion.Models;
using SistemaGestion.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SistemaGestion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private UsuarioRepository repositorio = new UsuarioRepository();
        [HttpGet]
        public ActionResult<List<Usuario>> Get()
        {
             try
             {
                List<Usuario> lista = repositorio.getUsuario();
                return Ok(lista);
             }
             catch (Exception ex)
             {
                return Problem(ex.Message);
             }
        }

        private List<Usuario> getUsuario()
        {
            throw new NotImplementedException();
        }
    }
}

