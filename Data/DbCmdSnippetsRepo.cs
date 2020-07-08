using System.Collections.Generic;
using CmdSnippetsAPI.Models;
using CmdSnippetsAPI.Database;
using System.Linq;

namespace CmdSnippetsAPI.Data
{
    public class DbCmdSnippetsRepo : ICmdSnippetsRepo
    {
        private readonly CmdSnippetsAPIContext _context;

        public DbCmdSnippetsRepo(CmdSnippetsAPIContext context)
        {
            _context = context;
        }
        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(x => x.Id == id);
        }
    }
}