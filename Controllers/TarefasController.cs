using Organization_List.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Organization_List.Data;
using Organization_List.Models;


namespace Organization_List.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class Tarefas : ControllerBase
    {
        private readonly DataContext _context;

        [HttpGet("{IdTarefa}")]
        public async Task<IActionResult> GetTarefa (int IdTarefa)
        {
            try
            {
                var result = await _context.TB_TAREFAS.FindAsync(IdTarefa);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        // [HttpGet("{id}")]
        // public async Task<ActionResult<Tarefas>> Get (int id)
        // {
        //     var tarefa = await _context.TB_TAREFAS.FindAsync(id);
        //     if (tarefa == null)
        //     {
        //         return NotFound();
        //     }
        //     return tarefa;
        // }

        [HttpPost]
        public async Task<IActionResult> PostTarefa (Models.Tarefa tarefa)
        {
            try
            {
                _context.TB_TAREFAS.Add(tarefa);
                await _context.SaveChangesAsync();
                return Ok(tarefa);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut("{IdTarefa}")]
        public async Task<IActionResult> PutTarefa (int IdTarefa, Models.Tarefa tarefa)
        {
            try
            {
                if (IdTarefa != tarefa.IdTarefa)
                {
                    return NotFound();
                }
                _context.TB_TAREFAS.Update(tarefa);
                await _context.SaveChangesAsync();
                return Ok(tarefa);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{IdTarefa}")]
        public async Task<IActionResult> DeleteTarefa (int IdTarefa)
        {
            try
            {
                var result = await _context.TB_TAREFAS.FindAsync(IdTarefa);
                if (result == null)
                {
                    return NotFound();
                }
                _context.TB_TAREFAS.Remove(result);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }
    }
}