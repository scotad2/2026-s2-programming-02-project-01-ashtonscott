using System.Diagnostics;

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

                if (value.Contains()) 
            }
        }
        public string LastName { get; set; }
    }
}
