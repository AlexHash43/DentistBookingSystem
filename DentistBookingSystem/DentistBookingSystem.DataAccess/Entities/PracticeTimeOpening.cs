using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.DataAccess.Entities
{
    public class PracticeTimeOpening : EntityBase
    {
        public string DayOfTheWeek { get; set; }
        public TimeSpan? TimeOpenInTheMorning { get; set; }
        public TimeSpan? TimeClosedInTheMorning { get; set; }
        public TimeSpan? TimeOpenAfternoon{ get; set; }
        public TimeSpan? TimeClosedAfternoon { get; set; }
        public TimeSpan? BreakTimeStart { get; set; }
        public TimeSpan? BreakTimeStop { get; set; }
    }
}
