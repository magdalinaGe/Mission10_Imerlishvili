using System;
using System.Collections.Generic;

namespace APIFun
{
    public partial class Team
    {
        public Team()
        {
            Bowlers = new HashSet<Bowler>();
          
        }

        public long TeamId { get; set; }
        public string TeamName { get; set; } = null!;
        public long? CaptainId { get; set; }

        public virtual ICollection<Bowler> Bowlers { get; set; }
      
    }
}
