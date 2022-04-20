using Inventory.Core.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core.Entity
{
    public class Cashier: BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }

        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        
        public string Position { get; set; }
        public int  Age { get; set; }
        public string Gender { get; set; } 


        
    }
}
