using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IDelivery
    {
        public int Id { get; set; }
        public DeliveryCompany DeliveryCompany { get; set; }
        public double Price { get; set; }
    }
}
