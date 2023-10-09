using Core.Enums;

namespace Core.Interfaces
{
    public interface IItem
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        ItemSize Size { get; set; }
        double Price { get; set; }
        double TotalPrice { get; }
        Dictionary<DiscountType,IDiscount<int>> Discounts { get; set; }
        IItem Clone();
    }
}
