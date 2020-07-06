using System.Collections.Generic;
using CmdSnippetsAPI.Models;

namespace CmdSnippetsAPI.Data
{
    public class MockCmdRepo : ICmdSnippetsRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var cmds = new List<Command>
            {
                new Command {Id = 0, HowTo = "Change a tyre", Line = "Bring a spanner", Platform = "Motoring"},
                new Command {Id = 1, HowTo = "Sing", Line = "Open mouth", Platform = "Music"},
                new Command {Id = 2, HowTo = "Code", Line = "Turn on laptop", Platform = "ICT"}
            };

            return cmds;
        }

        public Command GetCommandById(int id)
        {
            return new Command {Id = 0, HowTo = "Change a tyre", Line = "Bring a spanner", Platform = "Motoring"};
        }
    }
}