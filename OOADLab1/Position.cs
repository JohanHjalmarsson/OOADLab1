using System;
namespace OOADLab1
{
    public class Position
    {
        int x;
        int y;

        public Position()
        {
            x = 0;
            y = 0;
        }

        public void MoveUp() {
            y++;
            ConsolePosition();
        }

        public void MoveDown() {
            if (y != 0) {
                y--;
            }
            ConsolePosition();

        }

        public void MoveLeft() {
            if (x != 0) {
                x--;
            }
            ConsolePosition();
        }

        public void MoveRight() {
            x++;
            ConsolePosition();
        }

        private void ConsolePosition() {
            Console.WriteLine("Din position är: " + x + ", " + y);
        }
    }
}
