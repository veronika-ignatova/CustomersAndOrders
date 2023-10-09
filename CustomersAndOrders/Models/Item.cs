using Core.Enums;
using Core.Interfaces;

namespace Core.Model
{
    public class Item: IItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ItemSize Size { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public Dictionary<DiscountType, IDiscount<int>> Discounts { get; set; }
        public double TotalPrice
        {
            get
            {
                if (Discounts != null && Discounts.Count > 0)
                {
                    return Price - SumAllAmount(Discounts) * Price / 100;
                }
                return Price;
            }
        }
        private double SumAllAmount(IEnumerable<KeyValuePair<DiscountType, IDiscount<int>>> discounts)
        {
            double sum = 0;
            foreach (var discount in discounts)
            {
                sum += discount.Value.Amount;
            }
            return sum;
        }
        public IItem Clone()
        {
            return new Item()
            {
                Id = Id,
                Description = Description,
                Discounts = Discounts != null ? new Dictionary<DiscountType, IDiscount<int>>(Discounts) : new Dictionary<DiscountType, IDiscount<int>>(),
                Name = Name,
                Price = Price,
                Size = Size
            };
        }
    }
}
