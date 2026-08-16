namespace WinFormsApp1
{
    /// <summary>
    /// Department
    /// </summary>
    /// <param name="institution"></param>
    /// <param name="name"></param>
    internal class Department(Institution institution, string name)
    {
        public Institution Institution { get; set; } = institution;
        public string Name { get; set; } = name;
    }
}
