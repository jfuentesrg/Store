using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Order
    {
        //TrackingId, Quantity
        private int _trackingId;
        // readonly -- only define at start
        public int TrackingId { get { return _trackingId; } }
        private void _setTrackingId(int trackingId)
        {          
                _trackingId = trackingId;
        }

        private int _quantity;
        public int Quantity { get { return _quantity; } }
        private void _setQuantity(int quantity)
        {
            if (quantity > 0)
            {
               _quantity = quantity;
            }
            else
            {
                throw new Exception("Quantity must be greater than zero.");
            }
        }
    }
}
