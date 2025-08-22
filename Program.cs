using System;
using System.Threading;

class Program
{
    static void Main()
    {
        const int width = 80;     
        const int height = 25;    
        const double freq = 0.2;  
        const double speed = 0.3; 

        Console.CursorVisible = false;

        double offset = 0;

        while (true)
        {
            Console.Clear();

            for (int x = 0; x < width; x++)
            {
               
                double radians = (x * freq) + offset;
                double sinY = Math.Sin(radians);

               
                int y = (int)((sinY + 1) * (height / 2.0));

                Console.SetCursorPosition(x, y);
                Console.Write("*");
            }

            offset += speed;         
            Thread.Sleep(50);       
        }
    }
}
