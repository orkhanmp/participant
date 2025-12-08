using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public abstract class BaseEntity
    {
        public int Id { get; set; } 
        public int Deleted { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;
    }
}
