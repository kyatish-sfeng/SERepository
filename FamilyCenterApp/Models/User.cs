using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FamilyCenterApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string State { get; set; }
        public string City { get; set; }
    }
}