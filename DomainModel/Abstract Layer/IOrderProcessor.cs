using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel.Abstract_Layer
{
    public interface IOrderProcessor
    {
        void ProcessOrder(Cart cart, ShippingDetails shippingDetails);
    }
}
