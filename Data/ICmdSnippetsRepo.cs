using System.Collections.Generic;
using CmdSnippetsAPI.Models;

namespace CmdSnippetsAPI.Data
{
    public interface ICmdSnippetsRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
    }
}