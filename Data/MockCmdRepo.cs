using System.Collections.Generic;
using CmdSnippetsAPI.Models;

namespace CmdSnippetsAPI.Data
{
    public class MockCmdRepo : ICmdSnippetsRepo
    // This class is for testing purposes
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
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

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}