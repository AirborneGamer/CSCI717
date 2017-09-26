
namespace CSCI717.Problem1
{
    /// <summary>
    /// Base class for Square 1.  
    /// </summary>
    public abstract class Rectangle1
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public string ComputeType { get; set; }

        /// <summary>
        /// Simple area computation
        /// </summary>
        /// <returns>Int, given the width and height of a rectangle</returns>
        public int ComputeArea()
        {
            return Height * Width;
        }

        /// <summary>
        /// Simple perimeter computation
        /// </summary>
        /// <returns>Int, given the height and width, this method will requn the perimeter of the rectangle</returns>
        public int ComputePerimeter()
        {
            return (Height * 2) + (Width * 2);
        }

    }
}
