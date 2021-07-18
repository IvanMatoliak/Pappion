using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pappion.Domain.Entities
{
    class User
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Avatar { get; set; }
        public DateTime RegistrationTime { get; set; }

        public byte Password { get; set; }
        public byte Salt { get; set; }

        public UserStatus Status { get; set; }

        [NotMapped] public string FullName => $"{FirstName} {LastName}";
    }
    public enum UserStatus
    {
        Active,
        Blocked,
    }
}
