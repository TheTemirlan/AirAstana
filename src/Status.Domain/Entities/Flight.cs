using Status.Domain.Common;
using Status.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Status.Domain.Entities
{
    public class Flight : BaseEntity
    {
        public string? Origin { get; set; }

        public string? Destination { get; set; }

        public DateTimeOffset Departure { get; set; }

        public DateTimeOffset Arrival { get; set; }

        public FlightStatus Status { get; set; }
    }
}
