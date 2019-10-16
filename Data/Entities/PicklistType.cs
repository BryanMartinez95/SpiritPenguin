
using System;

namespace SpiritPenguin.Data.Entities
{
    public class PicklistType
    {
        public Guid Id { get; set; }
        public string Value { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate {get;set;}
    }    
}
