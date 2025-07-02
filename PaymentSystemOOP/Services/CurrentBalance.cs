using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem.Services
{
    public class CurrentBalance
    {
        private double _balance;
   
        public CurrentBalance()
        {
            _balance = 0;
        }

        public double GetBalance() 
        {
            return _balance;
        }

        public void AddBalance(double amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Bakiye artırmak için tutar 0'dan büyük olmalıdır.", nameof(amount));

            try
            {
                _balance += amount;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bakiye eklenirken hata oluştu: " + ex.Message);
            }
        }


        public void RemoveBalance(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Çekilecek tutar 0'dan büyük olmalıdır.");
            }
            if (amount > _balance) 
            {
                throw new ArgumentException("Çekilecek tutar güncel bakiyeden büyük olamaz.");
            }
            try
            {
                _balance -= amount;
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Bakiye çıkarılırken hata oluştu: " + ex.Message);
            }
            
        }


    }
}
