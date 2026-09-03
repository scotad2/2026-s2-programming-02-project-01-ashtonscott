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
            get
            {
                return _firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }

                if (invalid.IsMatch(value))
                {
                    throw new ArgumentException();
                }

                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }

                if (invalid.IsMatch(value))
                {
                    throw new ArgumentException();
                }

                _lastName = value;
            }
        }

        /// <summary>
        /// Regex name validation pattern, checks there are no numbers or special characters except hyphens or apostrophes.
        /// </summary>
        private static readonly Regex invalid = new(@"[^A-Za-z'-]", RegexOptions.Compiled);
    }
}
