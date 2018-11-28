using System;
namespace OOADLab1
{
    public class MoveRight : ICommand
    {
        Position p;
        public MoveRight(Position p)
        {
            this.p = p;
        }

        public void Execute()
        {
            p.MoveRight();
        }

        public void Redo()
        {
            p.MoveRight();
        }

        public void Undo()
        {
            p.MoveLeft();
        }
    }
}
