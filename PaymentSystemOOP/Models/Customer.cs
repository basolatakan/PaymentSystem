using PaymentSystem.Interfaces;
using PaymentSystemOOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem.Models
{
    public class Customer : IPerson
    {
        private int _id;
        private string _name;
        private string _surname;
        private int _age;

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Customer(int _id, string _name, string _surname, int _age) 
        {
            Console.WriteLine("Müşteri bilgileri;\n" +
                              "Müşteri No : " + _id + "\n" +
                              "Ad : " + _name + "\n" +
                              "Soyad : " + _surname + "\n" +
                              "Ad : " + _age);


        }
    }
}
