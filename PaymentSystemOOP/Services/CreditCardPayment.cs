using PaymentSystem.Interfaces;
using PaymentSystem.Services;
using PaymentSystemOOP.Interfaces;
using PaymentSystemOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystemOOP.Services
{
    public class CreditCardPayment : IPayment,IRefund,ICancel
    {
        private readonly CurrentBalance _balance;
        private readonly EndOfDay _endOfDay;
        public CreditCardPayment(CurrentBalance balance,EndOfDay endOfDay)
        {
            _balance = balance;
            _endOfDay = endOfDay;
        }


        public void Pay(double amount)
        {
            _balance.RemoveBalance(amount);
            Console.WriteLine($"{amount}TL ödeme alındı.");
        }

        public void RefundOrCancel(double amount) 
        {
            try
            {
                if (_endOfDay.IsEndOfDay == false) //Gün sonu gelmediyse
                {
                    Cancel(amount);
                }
                else if (_endOfDay.IsEndOfDay == true) //Gün sonu alındıysa
                {
                    Refund(amount);
                }
                else
                {
                    Console.WriteLine("Seçim yapılamadı.");
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
            }
       
        }

        public void Refund(double amount)
        {
            _balance.AddBalance(amount);
            Console.WriteLine($"{amount}TL ödeme iade edildi.");
        }


        public void Cancel(double amount)
        {
            _balance.AddBalance(amount);
            Console.WriteLine($"{amount}TL ödeme iptal edildi.");
        }
    }
}
