using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.BLL.Exceptions;
public class AssociatedRecordException : Exception {
    public AssociatedRecordException() { }
    public AssociatedRecordException(string message) : base(message) { }
    public AssociatedRecordException(string message, Exception innerException) : base(message, innerException) { }

}
