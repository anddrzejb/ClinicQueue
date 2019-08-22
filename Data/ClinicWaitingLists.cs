using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicQueue.Data
{
    public class ClinicWaitingLists    
    {
        public List<RoomQueue> Queues { get; set; }

        public ClinicWaitingLists()
        {
            Queues = new List<RoomQueue>
            {
                new RoomQueue(1, "G1"),
                new RoomQueue(2, "G2")
            };
        }
    }
}
