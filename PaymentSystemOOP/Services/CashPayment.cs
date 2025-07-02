using PaymentSystem.Interfaces;
using PaymentSystem.Services;
using PaymentSystemOOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystemOOP.Services
{
    public class CashPayment : IPayment, IRefund
    {
        private readonly CurrentBalance _balance;

        public CashPayment(CurrentBalance balance) 
        {
            _balance = balance;
        }

        public void Pay(double amount)
        {
            _balance.RemoveBalance(amount);
            Console.WriteLine($"{amount}TL ödeme alındı.");
        }

        public void Refund(double amount)
        {
            _balance.AddBalance(amount);
            Console.WriteLine($"{amount}TL ödeme iade edildi.");
        }
    }
}
