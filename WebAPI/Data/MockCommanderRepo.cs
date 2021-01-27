using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                 new Command { Id = 0, HowTo = "This Way!", Line = "Line String", Platform = "Platform String" },
                 new Command { Id = 1, HowTo = "This Way2!", Line = "Line String2", Platform = "2Platform String" },
                 new Command { Id = 2, HowTo = "This Way3!", Line = "Line String3", Platform = "3Platform String" },
            };
            return commands;
        }

        public Command GetCommandById(int Id)
        {
            return new Command { Id = 0, HowTo = "This Way!", Line = "Line String", Platform = "Platform String" };
        }
    }
}
