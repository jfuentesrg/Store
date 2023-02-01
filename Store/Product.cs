using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Product
    {
        //name, product id, and stock
        
        private int _productId;
        public int ProductId { get { return _productId; } }
        private void _setProductId(int productId)
        {
            if (productId > 0)
            {
                _productId = productId;
            }
            else
            {
                throw new Exception(" ID must be greater than zero.");
            }
        }
        //private  string _name;
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                if (value.Length > 0)
                {
                    _Name = value;
                }
                else
                {
                    throw new Exception("Value cannot be empty.");
                }
            }
        }

        // private  int    _stock=0;
        private int _stock;
        public int Stock { get { return _stock; } }
        private void _setStock(int stock)
        {
            if (stock > 0)
            {
                _stock = stock;
            }
            else
            {
                throw new Exception("Stock must be greater than zero.");
            }
        }
    }

}
