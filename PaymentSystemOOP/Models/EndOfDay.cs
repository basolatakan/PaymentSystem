using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystemOOP.Models
{
    public class EndOfDay
    {
        private bool _endOfDay = false;
        //False ise gün sonu gelmedi.
        //True ise gün sonu alındı.
        public bool IsEndOfDay 
        {
            get 
            {
                return _endOfDay;
            }
            set 
            {
                _endOfDay = value;
                Console.WriteLine("Gün sonu durumu değiştirildi.");
            }
        }
        
    }
}
