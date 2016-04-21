using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.SetBufferSize(109, 25);
            Console.SetWindowSize(110, 26);
            Rectangle rekt = new Rectangle(45, 15, 10, 10);
            Rectangle rekt2 = new Rectangle(75, 17, 2, 2);
            var rekt3 = new Rectangle(5, 5, 5, 5);
            rekt3._Filled = true;
            Dot dot = new Dot(108,25);
            HorizontalLine hL = new HorizontalLine(19, 23, 20);
            VerticalLine vL = new VerticalLine(80,10,5);
            ShapeControl ShapeController = new ShapeControl();
            ShapeController.AddShape(rekt);
            ShapeController.AddShape(rekt2);
            ShapeController.AddShape(dot);
            ShapeController.AddShape(hL);
            ShapeController.AddShape(vL);
            ShapeController.AddShape(rekt3);

            do
            {
                Console.Clear();
                
                ShapeController.PrintShapes();
                ShapeController.MoveShapes();
                Console.ReadKey();

            } while (true);


        }
    }
}
