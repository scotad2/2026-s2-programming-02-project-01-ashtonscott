namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataHandler dataHandler = new();

            try
            {
                dataHandler.LoadLearners();

                foreach (var learner  in dataHandler.Learners)
                {
                    foreach (var mark in learner.CourseAssessmentMark.GetLowestMarks())
                    {
                        Console.WriteLine($"{mark}");
                    }
                    Console.WriteLine("");
                }
            }
            catch (Exception ex)
            {
                ConsoleDebugger.Log(ex.Message, ConsoleDebugger.LogType.Error);
            }
        }
    }
}
