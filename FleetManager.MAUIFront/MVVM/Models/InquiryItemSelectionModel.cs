using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.MAUIFront.MVVM.Models;
public class InquiryItemSelectionModel : ItemSelectionModel {
    public bool NeedsAppointment { get; set; }
    public InquiryItemSelectionModel(int id, string name, bool needsAppointment) : base(id, name) { 
        NeedsAppointment = needsAppointment; 
    }
}
