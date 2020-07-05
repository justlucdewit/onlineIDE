using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webIDE.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class ideController : ControllerBase {
        List<IDEconnection> connections = new List<IDEconnection>();
        static int currentAccesCode = 0;

        [HttpGet()]
        [Route("newConnection/{secretID:long}")]
        public IDEconnection newConnection(long secretID) {
            if (secretID == null) {
                return new IDEconnection(-1, -1);
            }

            var con = new IDEconnection(currentAccesCode++, secretID);
            connections.Add(con);

            return con;
        }
    }
}
