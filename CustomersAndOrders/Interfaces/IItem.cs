using Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IItem
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        ItemSize Size { get; set; }
        double Price { get; set; }
        List<IDiscount<int>> Discounts { get; set; }
    }
}
