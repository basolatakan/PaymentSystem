using PaymentSystem.Models;
using PaymentSystem.Services;
using PaymentSystemOOP.Models;
using PaymentSystemOOP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem
{
    public class Program
    {
        static void Main(string[] args)  
        {
            Customer customer = new Customer(1, "Atakan", "Başol",27);
            CurrentBalance balance = new CurrentBalance();
            EndOfDay endOfDay = new EndOfDay();

            Console.WriteLine("*******************************************");

            Console.WriteLine("Sepete eklediğiniz ürün kaç TL?");
            string userPrice = Console.ReadLine();
            double price = Convert.ToDouble(userPrice);

            balance.AddBalance(price);
            double currentBalance = balance.GetBalance();

            CreditCardPayment creditCard = new CreditCardPayment(balance, endOfDay);
            creditCard.Pay(12.75);
            Console.WriteLine("Bakiye = " + balance.GetBalance());

            creditCard.RefundOrCancel(15.25);
            Console.WriteLine("Bakiye = " + balance.GetBalance());

        }
    }
}
