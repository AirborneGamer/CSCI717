
namespace CSCI717.Problem1
{
    /// <summary>
    /// Subclass for Rectangle 1
    /// </summary>
    public class Square1 : Rectangle1
    {
        /// <summary>
        /// Constructor for class.  There should be a full ProblemModel being passed into this constructor.
        /// Object type does not matter here as the base class can handle both rectangles and squares completely
        /// </summary>
        /// <param name="pm"></param>
        public Square1(ProblemModel pm)
        {
            Height = pm.Height;
            Width = pm.Width;
            ComputeType = pm.ComputeType;
        }

        /// <summary>
        /// Takes an already defined (user defined) set of input and calls base class to get results.
        /// </summary>
        /// <returns>Int: either the area or premiter based on user selection</returns>
        public int GetResults()
        {
            switch (ComputeType)
            {
                case "COMPUTEAREA":
                    return ComputeArea();
                case "COMPUTEPREMITER":
                    return ComputePerimeter();
                default:
                    return 0;

            }
        }
    }
}
