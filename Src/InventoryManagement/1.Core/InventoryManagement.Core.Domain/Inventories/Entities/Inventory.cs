using Zamin.Core.Domain.Entities;

namespace InventoryManagement.Core.Domain.Inventories.Entities
{
    public class Inventory : AggregateRoot<int>
    {
        public int Id { get; private set; }
        public int ProductId { get; private set; }
        public double UnitPrice { get; private set; }
        public bool InStock { get; private set; }
        public List<InventoryOperation> Operations { get; private set; }

        public Inventory(int productId, double unitPrice, List<InventoryOperation> operations)
        {
            ProductId = productId;
            UnitPrice = unitPrice;
            Operations = operations;
            InStock = false;
        }

        public void Edit(int productId, double unitPrice, List<InventoryOperation> operations)
        {
            ProductId = productId;
            UnitPrice = unitPrice;
            Operations = operations;
        }

        public long CalculateCurrentCount()
        {
            var plus = Operations.Where(x => x.Operation && x.InventoryId == Id).Sum(x => x.Count);
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
