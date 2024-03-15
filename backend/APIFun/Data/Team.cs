using System;
using System.Collections.Generic;

namespace APIFun
{
    public partial class Team
    {
        public Team()
        {
            Bowlers = new HashSet<Bowlers>();
          
        }

        public long TeamId { get; set; }
        public string TeamName { get; set; } = null!;
        public long? CaptainId { get; set; }

        public virtual ICollection<Bowlers> Bowlers { get; set; }
      
    }
}
