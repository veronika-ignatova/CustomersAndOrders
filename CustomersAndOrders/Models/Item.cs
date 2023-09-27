using Core.Enums;
using Core.Interfaces;

namespace Core.Model
{
    public class Item: IItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ItemSize Size { get; set; }
        public double Price { get; set; }
        public List<IDiscount> Discounts { get; set; }
    }
}
