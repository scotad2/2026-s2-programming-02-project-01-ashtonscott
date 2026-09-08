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
                dataHandler.LoadLecturers();
            }
            catch (Exception ex)
            {
                ConsoleDebugger.Log(ex.Message, ConsoleDebugger.LogType.Error);
            }

            foreach (var learner in dataHandler.learners)
            {
                ConsoleDebugger.Log($"\n{learner.ToString()}", ConsoleDebugger.LogType.Info);
                Console.WriteLine();
            }

            foreach (var lecturer in dataHandler.lecturers)
            {
                ConsoleDebugger.Log($"\n{lecturer.ToString()}", ConsoleDebugger.LogType.Info);
                Console.WriteLine();
            }
        }
    }
}
