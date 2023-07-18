
using System;
using WindowsInput;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

/*
class Program
{  
    [DllImport("user32.dll")]
    public static extern bool GetCursorPos(out POINT lpPoint);

    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int X;
        public int Y;
    }

    static async Task Main()
    {
        POINT cursorPosition;
        GetCursorPos(out cursorPosition);

        await Task.Delay(5000);

        InputSimulator s = new InputSimulator();

        double x = 32750;
        double y = 32750;
        double r = 10000;

        s.Mouse.MoveMouseTo(x + r, y);

        s.Mouse.LeftButtonDown();

        for (int i = 1; i < 360; i++)
        {
           double engle = i * Math.PI / 180;
           double newX = x + r * Math.Cos(engle);
           double newY = y + r * 1.78 * Math.Sin(engle);

           s.Mouse.MoveMouseTo(newX, newY);
           await Task.Delay(9); 
        }


        s.Mouse.LeftButtonUp();
    }
    static void MouseClick(int x, int y)  
    {
        InputSimulator sim = new InputSimulator();
        sim.Mouse.MoveMouseTo(x,y);
        sim.Mouse.LeftButtonClick();
    }
    static void KeyPress(string key)
    {
        InputSimulator sim = new InputSimulator();
        sim.Keyboard.TextEntry(key);
    }
    
}*/