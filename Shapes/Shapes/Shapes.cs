using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Shapes
    {
        public int height { get; set; }
        public int width { get; set; }
        public string color { get; set; }
        public int X_Coordinate { get; set; }
        public int Y_Coordinate { get; set; }

        public Shapes(int height, int width, string color, int xCoordinate, int yCoordinate)
        {
            this.height = height;
            this.width = width;
            this.color = color;
            X_Coordinate = xCoordinate;
            Y_Coordinate = yCoordinate;
        }
    }


}
