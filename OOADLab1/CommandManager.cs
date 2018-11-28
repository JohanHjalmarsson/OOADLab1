using System;
using System.Collections.Generic;

namespace OOADLab1
{
    public class CommandManager
    {
        Stack<ICommand> undoStack;
        Stack<ICommand> redoStack;

        public CommandManager()
        {
            undoStack = new Stack<ICommand>();
            redoStack = new Stack<ICommand>();
        }

        public void ExecuteCommand(ICommand c) 
        {
            Console.WriteLine("Executing command");
            c.Execute();
            undoStack.Push(c);
        }

        public void UndoCommand()
        {
            if (undoStack.Count <= 0)
            {
                return;
            }
            Console.WriteLine("Undoing command");
            undoStack.Peek().Undo();
            redoStack.Push(undoStack.Peek());
            undoStack.Pop();

        }

        public void RedoCommand()
        {
            if (redoStack.Count <= 0)
            {
                return;
            }
            Console.WriteLine("Redoing command");
            redoStack.Peek().Redo();
            undoStack.Push(redoStack.Peek());
            redoStack.Pop();
        }
    }
}
