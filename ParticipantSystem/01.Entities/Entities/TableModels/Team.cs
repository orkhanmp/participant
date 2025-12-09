using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TableModels
{
    public class Team: BaseEntity
    {
                
            public int Id { get; set; }
            public string TeamName { get; set; }
            public string Country { get; set; }
            public int FoundedYear { get; set; }            
            public virtual ICollection<Participant> Participants { get; set; }
        
    }
}
