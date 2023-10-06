using Core.Interfaces;
namespace Core.Model
{
    public class Order : OrderBase, IOrder
    {
        public override void AddNewItem(IItem item)
        {
            if (item != null)
            {
                Items.Add(item);
                OnAddItem(item);
            }
        }
    }
}
