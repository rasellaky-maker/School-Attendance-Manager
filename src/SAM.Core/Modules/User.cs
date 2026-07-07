using System.Text.RegularExpressions;

namespace SAM.Core.Modules
{
    public abstract class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string PasswordSalt { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"{LastName} {FirstName}";
        }
        public string GetUsername()
        {
            return $"{FirstName[0]}{LastName}".ToLower();
        }
        public User() 
        { }
        
        public User(int id, string firstName, string lastName, string username, string passHash, string passSalt)
        {
            Id = id ;
            FirstName = firstName ;
            LastName = lastName ;
            Username = username;
            PasswordHash = passHash ;
            PasswordSalt = passSalt ;
        }
        public User(string firstName, string lastName, string username, string passHash, string passSalt):this(0, firstName, lastName, username, passHash, passSalt)
        { }
    }
}
