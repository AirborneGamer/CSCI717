using CSCI717.Problem1;
using CSCI717.Problem2;
using System;

namespace CSCI717
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            var problemModel = new ProblemModel();

            program.BeginProgramFlow(problemModel, false);
        }

        public bool objectResponseValid = false;
        public bool computeResponseValid = false;

        public string errorMessage;

        /// <summary>
        /// Main program flow for UI input and output.
        /// Some error handling is done below.  Some edge cases are not accounted for currently.
        /// </summary>
        /// <param name="problemModel"></param>
        public void BeginProgramFlow(ProblemModel problemModel, bool startAllOver)
        {

            if (startAllOver) { problemModel = new ProblemModel(); objectResponseValid = false; computeResponseValid = false; }

            if (!objectResponseValid) { ShowObjectTypeQuestion(problemModel); };
            if (!computeResponseValid) { ShowComputeTypeQuestion(problemModel); };

            GetWidthAndHeight(problemModel);

            if (problemModel.ComputeType.ToUpper() == "COMPUTEAREA")
            {
                Console.WriteLine("Use 'Problem1' or 'Problem2' ?");
                problemModel.ProblemNumber = Console.ReadLine().ToUpper();

            }
            else if (problemModel.ComputeType.ToUpper() == "COMPUTEPREMITER")
            {
                Console.WriteLine("Use 'Problem1' or 'Problem2' ?");
                problemModel.ProblemNumber = Console.ReadLine().ToUpper();
            }

            //Process the results
            if (problemModel.ProblemNumber == "PROBLEM1")
            {
                var squareClass = new Square1(problemModel);
                Console.WriteLine(problemModel.ComputeType + " = " + squareClass.GetResults());
                BeginProgramFlow(problemModel, true);
            }
            else if (problemModel.ProblemNumber == "PROBLEM2")
            {
                var rectangleClass = new Rectangle2(problemModel);
                Console.WriteLine(problemModel.ComputeType + " = " + rectangleClass.GetResults());
                BeginProgramFlow(problemModel, true);
            }

        }

        /// <summary>
        /// Gets user input for height and width
        /// </summary>
        /// <param name="problemModel"></param>
        private void GetWidthAndHeight(ProblemModel problemModel)
        {
            Console.WriteLine("Enter Width?");
            problemModel.Width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Height?");
            problemModel.Height = Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Gets user input for object type (square or rectangle).
        /// </summary>
        /// <param name="problemModel"></param>
        private void ShowObjectTypeQuestion(ProblemModel problemModel)
        {
            objectResponseValid = true;
            Console.WriteLine("Hello, 'Square' or 'Rectangle' " + errorMessage);
            errorMessage = "";
            problemModel.ObjectType = Console.ReadLine().ToUpper();
            if (problemModel.ObjectType != "SQUARE" && problemModel.ObjectType != "RECTANGLE")
            {
                errorMessage = "Your object selection was not valid :(";
                objectResponseValid = false;
                BeginProgramFlow(problemModel, false);
            }
        }

        /// <summary>
        /// Gets user input to compute the Area or Premiter of an object.
        /// </summary>
        /// <param name="problemModel"></param>
        private void ShowComputeTypeQuestion(ProblemModel problemModel)
        {
            computeResponseValid = true;
            Console.WriteLine("'ComputeArea' or 'ComputePremiter' of your " + problemModel.ObjectType + '?' + errorMessage);
            errorMessage = "";
            problemModel.ComputeType = Console.ReadLine().ToUpper();
            if (problemModel.ComputeType != "COMPUTEAREA" && problemModel.ComputeType != "COMPUTEPREMITER")
            {
                errorMessage = "Your compute selection was not valid :(";
                computeResponseValid = false;
                BeginProgramFlow(problemModel, false);
            }
        }
    }
}
