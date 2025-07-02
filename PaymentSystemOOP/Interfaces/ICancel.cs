using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem.Interfaces
{
    public interface ICancel
    {
        void Cancel(double amount);
    }
}
