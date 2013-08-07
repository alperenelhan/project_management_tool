using System.ComponentModel;

namespace exp3_342_windowform
{
    public class Person
    {
        private string _addres;
        private string _birthday;
        private string _city;
        private string _email;
        private string _gender;
        private string _name;
        private string _password;
        private string _surname;
        private string _phone;
        private string _userName;
        private string _lastLogin;
        private bool _canLogin;
        private bool _isAdmin;

        public Person(string name, string surname, string birthday, string city, string addres, string gender,
                      string email, string password, bool isAdmin)
        {
            _name = name;
            _surname = surname;
            _birthday = birthday;
            _city = city;
            _addres = addres;
            _gender = gender;
            _email = email;
            _password = password;
            _isAdmin = isAdmin;
            _canLogin = true;
        }

        public Person(string userName, string email, string password)
        {
            _userName = userName;
            _email = email;
            _password = password;
            _isAdmin = false;
            _canLogin = true;
        }

        public Person()
        {
        }

        [DisplayName("User Name")]
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        [DisplayName("Email Address")]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        [DisplayName("Name")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DisplayName("Surname")]
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        [DisplayName("Phone Number")]
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        [DisplayName("Birthday")]
        public string BirthDay
        {
            get { return _birthday; }
            set { _birthday = value; }
        }

        [DisplayName("Entry Clearance")]
        public bool CanLogin
        {
            get { return _canLogin; }
            set { _canLogin = value; }
        }

        [DisplayName("Last Accessed")]
        public string LastLogin
        {
            get { return _lastLogin; }
            set { _lastLogin = value; }
        }

        [Browsable(false)]
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        [Browsable(false)]
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        
        [Browsable(false)]
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        [Browsable(false)]
        public bool IsAdmin
        {
            get { return _isAdmin; }
            set { _isAdmin = value; }
        }

        [Browsable(false)]
        public string Addres
        {
            get { return _addres; }
            set { _addres = value; }
        }

        public override string ToString()
        {
            return _userName;
        }
    }
}