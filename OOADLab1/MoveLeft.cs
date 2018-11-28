using System;
namespace OOADLab1
{
    public class MoveLeft : ICommand
    {
        Position p;
        public MoveLeft(Position p)
        {
            this.p = p;
        }

        public void Execute()
        {
            p.MoveLeft();
        }

        public void Redo()
        {
            p.MoveLeft();
        }

        public void Undo()
        {
            p.MoveRight();
        }
    }
}
