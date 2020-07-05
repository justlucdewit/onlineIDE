using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webIDE {
    public class IDEconnection {
        public DateTime _lastInteraction { get; set; }

        public int _accessCode { get; set; }

        public long _secretID { get; set; }

        public IDEconnection(int accessCode, long secretID) {
            _lastInteraction = DateTime.Now;
            _accessCode = accessCode;
            _secretID = secretID;
        }
    }
}


