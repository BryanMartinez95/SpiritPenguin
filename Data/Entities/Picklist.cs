
using System;

namespace SpiritPenguin.Data.Entities
{
    public class Picklist
    {
        public Guid Id { get; set; }
        public Guid PicklistTypeId { get; set; }
        public string Value { get; set; }
        public DateTime CreatedDate {get;set;}
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }


        public PicklistType PicklistType { get; set; }

    }    
}
