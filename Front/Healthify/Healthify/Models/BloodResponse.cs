using System.Collections.Generic;

namespace Healthify.Models
{       
    public class Response
    {        
        public string HName { get; set; }        
        public string HID { get; set; }        
        public string Apos { get; set; }        
        public string Bpos { get; set; }       
        public string Opos { get; set; }        
        public string ABpos { get; set; }        
        public string Aneg { get; set; }        
        public string Bneg { get; set; }        
        public string Oneg { get; set; }        
        public string ABneg { get; set; }
    }
    
    public class BloodResponse
    {        
        public List<Response> response { get; set; }
    }
}
