using System;
using System.Collections.Generic;

namespace Yeager.Editor.CommandRunner
{
    public class RunnerBuilder
    {
        private readonly List<Command> commands = new List<Command>();

        public RunnerBuilder AddCommand(string name, Action action)
        {
            var command = new Command(name, action);
            commands.Add(command);
            return this;
        }

        public Runner Build(string name)
        {
            return new Runner(name, commands);
        }
    }
}