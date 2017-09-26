
using System;

namespace CSCI717.Problem2
{
    public class Rectangle2 : Square2
    {
        public int Width { get; set; }
        public string ObjectType { get; set; }

        public Rectangle2(ProblemModel pm)
        {
            Height = pm.Height;
            Width = pm.Width;
            ComputeType = pm.ComputeType;
            ObjectType = pm.ObjectType;
        }

        /// <summary>
        /// This method gets area or perimeter for a square or rectangle
        /// Since Square base class only deals with height, must write our own (duplicate to problem1) compute functions below....
        /// </summary>
        /// <returns></returns>
        public int GetResults()
        {
            switch (ComputeType)
            {
                case "COMPUTEAREA":
                    if (ObjectType == "SQUARE")
                    {
                        return ComputeArea();
                    }
                    else if (ObjectType == "RECTANGLE")
                    {
                        return ComputeRectangleArea();
                    }
                    else
                    {
                    return 0;
                    }
                case "COMPUTEPREMITER":
                    if (ObjectType == "SQUARE")
                    {
                        return ComputePerimeter();
                    }
                    else if (ObjectType == "RECTANGLE")
                    {
                        return ComputeRectanglePerimeter();
                    }
                    else
                    {
                    return 0;
                    }
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Duplicate compute funciton to handle limited base class
        /// </summary>
        /// <returns></returns>
        private int ComputeRectangleArea()
        {
            return Height * Width;
        }

        /// <summary>
        /// Duplicate compute funciton to handle limited base class
        /// </summary>
        /// <returns></returns>
        private int ComputeRectanglePerimeter()
        {
            return (Height * 2) + (Width * 2);
        }
    }
}
