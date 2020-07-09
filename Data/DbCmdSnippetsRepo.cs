using System.Collections.Generic;
using CmdSnippetsAPI.Models;
using CmdSnippetsAPI.Database;
using System.Linq;
using System;

namespace CmdSnippetsAPI.Data
{
    public class DbCmdSnippetsRepo : ICmdSnippetsRepo
    {
        private readonly CmdSnippetsAPIContext _context;

        public DbCmdSnippetsRepo(CmdSnippetsAPIContext context)
        {
            _context = context;
        }

        public void CreateCommand(Command cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Commands.Add(cmd);
        }

        public void DeleteCommand(Command cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Commands.Remove(cmd);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(x => x.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges()) >= 0;
        }

        public void UpdateCommand(Command cmd)
        {
            // Because of how DbContext works, we do not
            // actually have to implement Update here
        }
    }
}