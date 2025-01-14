using System.Runtime.InteropServices;

namespace autoclicker
{
    internal class Program
    {
        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int X, int Y);
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);


        static void Main(string[] args)
        {
            Random rnd = new Random();
            int firstNum = rnd.Next(1, 400);
            int secondNum = rnd.Next(1,600);

            DisplayPos();
            SetCursorPos(firstNum, secondNum);

        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;
        }

        public static POINT GetMousePosition()
        {
            GetCursorPos(out POINT point);
            return point;
        }

        public static void DisplayPos()
        {
            POINT point = GetMousePosition();
            Console.WriteLine($"Mouse position is at: x {point.X}, y {point.Y}");
        }


    }
}
