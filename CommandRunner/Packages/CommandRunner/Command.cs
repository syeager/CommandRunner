using System;

namespace Yeager.Editor.CommandRunner
{
    public class Command
    {
        private readonly Action action;

        public string Name { get; }

        public Command(string name, Action action)
        {
            Name = name;
        }

        public void Execute()
        {
            action();
        }
    }
}