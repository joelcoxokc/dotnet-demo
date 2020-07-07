using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 1, HowTo = "Boil and Egg", Line = "Boil water", Platform = "Node.js" },
                new Command { Id = 2, HowTo = "make coffee", Line = "make some coffee", Platform = "Node.js" },
                new Command { Id = 3, HowTo = "make tee", Line = "make some tee", Platform = "Node.js" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil and Egg", Line = "Boil water", Platform = "Node.js" };
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