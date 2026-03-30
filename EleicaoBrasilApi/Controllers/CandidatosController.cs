using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EleicaoBrasilApi.Data;
using EleicaoBrasilApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EleicaoBrasilApi.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class CandidatosControllers : ControllerBase
    {
        private readonly AppDbcontext _context;
        public CandidatosControllers(AppDbcontext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var candidatos = _context.candidatos.ToList();
            return Ok(candidatos);
        }
        [HttpPost]
        public IActionResult Post(Candidato candidato)
        {
            _context.candidatos.Add(candidato);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get),new{ id = candidato.id}, candidato);
        }
        [HttpPut("{Id}")]
        public IActionResult Put(int id, Candidato candidato)
        {
            if (id != candidato.id)
            {
                return BadRequest();
            }
            _context.candidatos.Update(candidato);
            _context.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete (int id)
        {
            var candidato = _context. candidatos.Find(id);
            if (candidato == null)
            {
                return NotFound();
            }
            _context.candidatos.Remove(candidato);
            _context.SaveChanges();
            return NoContent();
        }
    }

}