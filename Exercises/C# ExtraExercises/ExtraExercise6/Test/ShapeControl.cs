using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class ShapeControl
    {
        List<Shapes> ShapeList = new List<Shapes>();

        public void PrintShapes()
        {
            Console.CursorVisible = false;
            foreach (var Shape in ShapeList)
            {
           
                Console.SetCursorPosition(Shape._StartPosY, Shape._StartPosX);
                for (int i = 0; i < Shape._DimensionX; i++)
                {
                    for (int j = 0; j < Shape._DimensionY; j++)
                    {
                        var positionY = Shape._StartPosY + i;
                        var positionX = Shape._StartPosX + j;


                        if (positionY < Console.BufferWidth && positionX < Console.BufferHeight)
                        {
                            if (Shape._Filled == true)
                            {
                                writeAt(positionY, positionX);
                            }
                            else if (Shape._Filled == false)
                            {
                                if (i == 0 || i == Shape._DimensionX - 1)
                                {
                                    writeAt(positionY, positionX);
                                }
                                if (j == 0 || j == Shape._DimensionY - 1)
                                {
                                    writeAt(positionY, positionX);
                                }
                            } 
                        }
                    } 
                }
            }
            Console.CursorTop = 0;
            Console.CursorLeft = 0;
        }
        public void MoveShapes()
        {
            Random rnd = new Random();
            foreach (var item in ShapeList)
            {
                var nextDirection = rnd.Next(0, 8);
                if(nextDirection == (int)Directions.North && item._StartPosY != 0)
                {
                        item._StartPosY -= 1;
                }
                if (nextDirection == (int)Directions.South && (item._StartPosY + item._DimensionY) < Console.BufferWidth)
                {
                    item._StartPosY += 1;
                }
                if(nextDirection == (int)Directions.East && (item._StartPosX + item._DimensionX) < Console.BufferHeight)
                {
                    item._StartPosX += 1;
                }
                if (nextDirection == (int)Directions.West && item._StartPosX != 0)
                {
                    item._StartPosX -= 1;
                }
                if (nextDirection == (int)Directions.NorthEast && item._StartPosY != 0 && (item._StartPosX + item._DimensionX) < Console.BufferHeight)
                {
                    item._StartPosY -= 1;
                    item._StartPosX += 1;
                }
                if (nextDirection == (int)Directions.NorthWest && item._StartPosY != 0 && item._StartPosX != 0)
                {
                    item._StartPosY -= 1;
                    item._StartPosX -= 1;
                }
                if (nextDirection == (int)Directions.SouthEast && (item._StartPosY + item._DimensionY) < Console.BufferWidth && (item._StartPosX + item._DimensionX) < Console.BufferHeight)
                {
                    item._StartPosY += 1;
                    item._StartPosX += 1;
                }
                if (nextDirection == (int)Directions.SouthWest && (item._StartPosY + item._DimensionY) < Console.BufferWidth && item._StartPosX != 0)
                {
                    item._StartPosY += 1;
                    item._StartPosX -= 1;
                }

            }
        }
        public void AddShape(Shapes shape)
        {
            ShapeList.Add(shape);
        }
        public void writeAt(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("X");
        }
    }
    enum Directions
    {
        North,
        East,
        West,
        South,
        NorthWest,
        NorthEast,
        SouthWest,
        SouthEast

    }
}
