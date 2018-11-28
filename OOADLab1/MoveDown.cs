using System;
namespace OOADLab1
{
    public class MoveDown : ICommand
    {
        Position p;

        public MoveDown(Position p)
        {
            this.p = p;
        }

        public void Execute()
        {
            p.MoveDown();
        }

        public void Redo()
        {
            p.MoveDown();
        }

        public void Undo()
        {
            p.MoveUp();
        }
    }
}
