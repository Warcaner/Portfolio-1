using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class CalculatorClass
    {
        public string CenterShape(int height, int width, int X_Coordinate, int Y_Coordinate) 
        {
            double x_coor = X_Coordinate + width / 2;
            double y_coor = Y_Coordinate + height / 2;

            string result = string.Format("The shape is at the following pixel X: {0} Y: {1}", x_coor, y_coor);

            return result;
        
        }
        // Rectangle 
        public double AreaRectangle(int height, int width)
        {
            double result = height * width;

            return result;
            
        }
        
        public double CircumRectangle(int height, int width) 
        {
            int result = (height * 2) + (width * 2);

            return result;
            
        }


        //Circles
        public double AreaCircle(int height, int width) 
        {
            double result = width * Math.PI;

            return result;
        
        }
        
        public double CircumCircle(int height, int width) 
        {
            double result = 2 * Math.PI * (width / 2);

            return result;
        
        }

        //Triangle
        public double AreaTriangle(int height, int width) 
        {
            double result = (height * width) / 2;

            return result;
        
        }
        
        public double CircumTriangle(int height, int width) 
        {
            double result = ((height * 2) + (width * 2) / 2);

            return result;
        
        }

    }
}
