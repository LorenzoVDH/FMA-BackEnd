using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.MAUIFront.Exceptions;
public class InquiryValidationException : Exception {
    public List<string> ValidationErrors { get; set; }
    public InquiryValidationException(List<string> errors) { 
        ValidationErrors = errors; 
    }
}
