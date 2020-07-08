using System.Collections.Generic;
using CmdSnippetsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using CmdSnippetsAPI.Data;

namespace CmdSnippetsAPI.Controllers
{
    // api/commands
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICmdSnippetsRepo _repo;

        public CommandsController(ICmdSnippetsRepo repo)
        {
            _repo = repo;
        }
                
        // GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var cmdItems = _repo.GetAllCommands();
            return Ok(cmdItems);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var cmdItem = _repo.GetCommandById(id);
            return Ok(cmdItem);
        }
        
    }
}