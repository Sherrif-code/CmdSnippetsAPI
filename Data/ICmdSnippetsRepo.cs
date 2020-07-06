using System.Collections.Generic;
using CmdSnippetsAPI.Models;

namespace CmdSnippetsAPI.Data
{
    public interface ICmdSnippetsRepo
    {
         IEnumerable<Command> GetAppCommands();
         Command GetCommandById(int id);
    }
}