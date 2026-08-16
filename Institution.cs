namespace WinFormsApp1
{
    /// <summary>
    /// Institution
    /// </summary>
    /// <param name="name"></param>
    /// <param name="region"></param>
    /// <param name="country"></param>
    internal class Institution(string name, string region, string country)
    {
        public string Name { get; set; } = name;
        public string Region { get; set; } = region;
        public string Country { get; set; } = country;
    }
}
