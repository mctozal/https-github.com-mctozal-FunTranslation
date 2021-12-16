using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.DatabaseInfrastructure
{
    public class FunTranslationResult
    {
        [Key]
        public int Id { get; set; }
        public string EventType { get; set; }
        public string Source { get; set; }
        public DateTime EventTime { get; set; }
        public string EventCode { get; set; }
        public string IpAddress { get; set; }
    }
}
