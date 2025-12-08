using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TableModels
{
    public class Participant: BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public string TeamName { get; set; }
    }
}
