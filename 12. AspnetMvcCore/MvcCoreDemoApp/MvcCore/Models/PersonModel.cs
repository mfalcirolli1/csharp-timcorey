using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore.Models
{
    public class PersonModel
    {
        [DisplayName("Primeiro Nome")]
        public string FirstName { get; set; }
        
        [DisplayName("Último Nome")]
        public string LastName { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Número de telefone")]
        public string PhoneNumber{ get; set; }
    }
}
