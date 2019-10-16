
using System;

namespace SpiritPenguin.Data.Entities
{
    public class Period
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedDate {get;set;}
        public bool IsDeleted { get; set; }

    }    
}
