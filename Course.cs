namespace WinFormsApp1
{
    /// <summary>
    /// Course
    /// </summary>
    /// <param name="department"></param>
    /// <param name="code"></param>
    /// <param name="name"></param>
    /// <param name="description"></param>
    /// <param name="credits"></param>
    /// <param name="fees"></param>
    internal class Course(Department department,
                          int code,
                          string name,
                          string description,
                          int credits,
                          int fees)
    {
        public Department Department { get; set; } = department;
        public int Code { get; set; } = code;
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
        public int Credits { get; set; } = credits;
        public int Fees { get; set; } = fees;
    }
}
