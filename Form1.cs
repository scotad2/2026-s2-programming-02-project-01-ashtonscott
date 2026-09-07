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

                foreach (var learner in dataHandler.learners)
                {
                    Console.WriteLine(learner.ToString());
                    Console.WriteLine("");
                }
                
                dataHandler.LoadLecturers();

                foreach (var lecturer in dataHandler.lecturers)
                {
                    Console.WriteLine(lecturer.ToString());
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
