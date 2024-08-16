using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTimer
{
    class RecordModel
    {
        public string UserName { get; set; }
        public string SerialNumber { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan TotalPauseTime { get; set; }
        public TimeSpan TotalUseTime { get; set; }


        public RecordModel()
        {}

    }
}
