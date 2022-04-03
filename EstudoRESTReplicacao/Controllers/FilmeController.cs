using EstudoRESTReplicacao.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EstudoRESTReplicacao.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();
        private static int id = 1;

        [HttpPost]
        public IActionResult AdicionaFilme([FromBody] Filme filme)
        {
            filme.Id = id++;
            filmes.Add(filme);
            return CreatedAtAction(nameof(RecuperaFilmePorId), new { Id = filme.Id}, filme);
        }
        
        [HttpGet]
        public IEnumerable<Filme> RecuperaFilmes()
        {
            return filmes;
        }
        
        [HttpGet("{id}")]
        public IActionResult RecuperaFilmePorId(int id)
        {
            Filme filme = filmes.FirstOrDefault(filmes => filmes.Id == id);
            if (filme == null)
                return NotFound();
            return Ok(filme);
        }
    }
}
