using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Customer
    {
        private int _customerId;
        public int CustomerId { get { return _customerId; } }
        private void _setCustomerId(int customerId)
        {
            if (customerId > 0)
            {
                _customerId = customerId;
            }
            else
            {
                throw new Exception(" ID must be greater than zero.");
            }
        }


        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set
            {
                if (value.Length > 0)
                {
                    _userName = value;
                }
                else
                {
                    throw new Exception("Value cannot be empty.");
                }
            }
        }

        private Order _order { get; set; }
    }
}
