using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2.Models
{
    
    public class Dealer
    {
        private string _address = "Rouppeplein 16, 1000 Brussel";
        private double _moneyInAccount = 473491.0;
        private int _carsAvailable;

        public string Address 
        {
            get { return _address; }
            set { _address = value; }
        }
        public double MoneyInAccount
        { 
            get { return _moneyInAccount; }
            set { _moneyInAccount = value; }
        }

        //public Dealer(string address, double moneyInAccount)
        //{
        //    this.Address = address;
        //    this.MoneyInAccount = moneyInAccount;
        //}

    }
}
