using System;
using System.Collections.Generic;
using System.Text;

namespace CSCI717.Problem2
{
    public abstract class Square2
    {
        public int Height { get; set; }
        public string ComputeType { get; set; }

        /// <summary>
        /// Simple area computation
        /// </summary>
        /// <returns>Int, given the height of a square</returns>
        public int ComputeArea()
        {
            return Height * Height;
        }

        /// <summary>
        /// Simple perimeter computation
        /// </summary>
        /// <returns>Int, given the height , this method will requn the perimeter of the square</returns>
        public int ComputePerimeter()
        {
            return (Height * 4);
        }

    }
}
