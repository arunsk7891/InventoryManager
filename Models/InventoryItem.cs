using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManager.Models
{
    public class InventoryItem
    {
        public DateTime Created { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
