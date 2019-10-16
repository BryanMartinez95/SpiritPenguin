using SpiritPenguin.Data;

namespace SpiritPenguin.Controller
{
    public class PicklistTypeController
    {
        private readonly DatabaseContext _context;
        public PicklistTypeController(DatabaseContext context)
        {
            _context = context;
        }

    }
}