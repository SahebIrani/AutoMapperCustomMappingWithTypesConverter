using Simple.Models.Enums;

using System;

namespace Simple.Models.Entities
{
    public class UserEntity
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
    }
}
