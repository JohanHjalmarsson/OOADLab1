using System;
namespace OOADLab1
{
    public interface ICommand
    {
        void Execute();
        void Undo();
        void Redo();
    }
}
