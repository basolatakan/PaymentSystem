using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem.Interfaces
{
    public interface IPerson
    {
        int Id { get; set; }
        string Firstname { get; set; }
        string LastName { get; set; }
        int Age { get; set; }

    }
}
