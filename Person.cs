using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    internal class Person
    {
        private string _firstName;
        private string _lastName;

        public int Id { get; set; }
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (NameIsValid(value))
                {
                    _firstName = value;
                }
                else
                {
                    throw new Exception($"'{value}' is not a valid first name.");
                }
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (NameIsValid(value))
                {
                    _lastName = value;
                }
                else
                {
                    throw new Exception($"'{value}' is not a valid last name.");
                }
            }
        }

        /// <summary>
        /// Regex name validation pattern, checks there are no numbers or special characters except hyphens or apostrophes.
        /// </summary>
        private static readonly Regex invalidPattern = new(@"[^A-Za-z'-]", RegexOptions.Compiled);

        private static bool NameIsValid(string value)
        {
            if (string.IsNullOrEmpty(value) || invalidPattern.IsMatch(value))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
