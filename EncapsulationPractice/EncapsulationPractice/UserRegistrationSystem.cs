namespace Encapsultion
{
    public class UserRegistrationSystem
    {
        private string _username;
        private string _password;

        public UserRegistrationSystem(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || username.Length < 3)
                throw new ArgumentException("Invalid Username");

            _username = username;

            SetPassword(password);
        }

        private void SetPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
                throw new ArgumentException("Password must be at least 6 characters");

            _password = password;
        }

        public void ChangePassword(string newPassword)
        {
            if (_password == newPassword)
                throw new InvalidOperationException("New password cannot be same as old password");

            SetPassword(newPassword);
        }

        public bool CheckPassword(string inputPassword)
        {
            return _password == inputPassword;
        }



        public void DisplayUser()
        {
            Console.WriteLine($"Username: {_username}");
        
        }
    }
}








