using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AGROTIEND.Data;
using AGROTIEND.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace TEST.Controllers
{
   [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly MyDbContext _context;

        public UsuarioController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuarios>>> GetUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Usuarios>> CrearUsuario(Usuarios usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetUsuarios), new { id = usuario.Id }, usuario);
        }
    }   
  
}