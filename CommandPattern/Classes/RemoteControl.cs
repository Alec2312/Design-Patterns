using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Classes
{
    internal class RemoteControl
    {
        private Command[] onCommands = new Command[7];
        private Command[] offCommands = new Command[7];
        private Stack<Command> undoStack = new Stack<Command>();

        public RemoteControl()
        {
            Command noCommand = new NoCommand();
            for (int i = 0; i < onCommands.Length; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
            undoStack.Push(onCommands[slot]);
        }

        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
            undoStack.Push(offCommands[slot]);
        }

        public void UndoButtonWasPushed()
        {
            Command lastCommand = undoStack.Pop();
            Console.WriteLine("undoing");
            lastCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n----- Remote Control ----- \n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                sb.Append("[slot " + i + "] " + onCommands[i] + " \t\t  " + offCommands[i] + "\n");
            }
            return sb.ToString();
        }
    }
}
