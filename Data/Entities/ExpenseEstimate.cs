
using System;

namespace SpiritPenguin.Data.Entities
{
    public class ExpenseEstimate
    {
        public Guid Id { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public Guid ExpenseTypeId { get; set; }
        public DateTime CreatedDate {get;set;}
        public bool IsDeleted { get; set; }
    }    
}
