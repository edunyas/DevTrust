using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTrust.Models
{
    public class PersonModel
    {
        public int PersonId { get; set; }

        public int AddressId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string StreetAddress { get; set; } = null!;
        public string City { get; set; } = null!;

        public string FullAddress
        {
            get
            {
                return $"{StreetAddress}, {City}";
            }
        }


    }
}
