
using System;

namespace SpiritPenguin.Data.Entities
{
    public class Expense
    {
        public Guid Id { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedDate {get;set;}
        public bool IsDeleted { get; set; }
        public Guid ExpenseCategoryId { get; set; }
        public Picklist ExpenseCategory { get; set; }
        public Guid PayeeId { get; set; }
        public Picklist Payee { get; set; }
    }    
}
