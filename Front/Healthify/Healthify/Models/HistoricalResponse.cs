using System.Collections.Generic;

namespace Healthify.Models
{        
    public class hissResponse
    {
        public string DUID { get; set; }
        public string DName { get; set; }
        public string Disease { get; set; }
        public string Date { get; set; }
        public string Duration { get; set; }
        public string Medicine { get; set; }
    }

    public class HistoricalResponse
    {        
        public List<hissResponse> response { get; set; }
    }
}
