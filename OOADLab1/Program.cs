using System;

namespace OOADLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Position p = new Position();
            CommandManager cm = new CommandManager();

            MoveUp moveUp = new MoveUp(p);
            MoveDown moveDown = new MoveDown(p);
            MoveRight moveRight = new MoveRight(p);
            MoveLeft moveLeft = new MoveLeft(p);

            cm.ExecuteCommand(moveUp);
            cm.ExecuteCommand(moveUp);
            cm.ExecuteCommand(moveUp);
            cm.ExecuteCommand(moveUp);
            cm.ExecuteCommand(moveRight);
            cm.ExecuteCommand(moveRight);
            cm.ExecuteCommand(moveRight);
            cm.ExecuteCommand(moveRight);
            cm.ExecuteCommand(moveDown);
            cm.ExecuteCommand(moveDown);
            cm.ExecuteCommand(moveLeft);
            cm.ExecuteCommand(moveLeft);

            cm.UndoCommand();
            cm.UndoCommand();
            cm.RedoCommand();

        }
    }
}
