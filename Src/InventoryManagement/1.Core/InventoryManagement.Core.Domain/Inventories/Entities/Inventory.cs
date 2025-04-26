using InventoryManagement.Core.Domain.InventoryOperations.Entities;
using Zamin.Core.Domain.Entities;

namespace InventoryManagement.Core.Domain.Inventories.Entities
{
    public class Inventory : AggregateRoot<int>
    {
        public int Id { get; set; }
        public long ProductId { get; private set; }
        public double UnitPrice { get; private set; }
        public bool InStock { get; private set; }
        public List<InventoryOperation> Operations { get; private set; }

        public Inventory(long productId, double unitPrice)
        {
            ProductId = productId;
            UnitPrice = unitPrice;
            InStock = false;
        }

        public void Edit(long productId, double unitPrice)
        {
            ProductId = productId;
            UnitPrice = unitPrice;
        }

        public long CalculateCurrentCount()
        {
            var plus = Operations.Where(x => x.Operation).Sum(x => x.Count);
            var minuse = Operations.Where(x => !x.Operation).Sum(x => x.Count);
            return plus - minuse;
        }

        public void Increase(long count, long operatorId, string description)
        {
            var currentCount = CalculateCurrentCount() + count;
            var operation = new InventoryOperation(true, count, operatorId, currentCount, description, 0, Id);
            Operations.Add(operation);

            //if (currentCount > 0)
            //{
            //    InStock = true;
            //}
            //else
            //{
            //    InStock = false;

            InStock = currentCount > 0;
        }

        public void Reduce(long count, long operatoprId, string description, long orderId)
        {
            var currentCount = CalculateCurrentCount() - count;
            var operation = new InventoryOperation(false, count, operatoprId, currentCount, description, orderId, Id);
            Operations.Add(operation);
            InStock = currentCount > 0;
        }
    }
}
