using System;
namespace OOADLab1
{
    public class MoveUp : ICommand
    {
        Position p;

        public MoveUp(Position p)
        {
            this.p = p;
        }

        public void Execute()
        {
            p.MoveUp();
        }

        public void Redo()
        {
            p.MoveUp();
        }

        public void Undo()
        {
            p.MoveDown();
        }
    }
}
