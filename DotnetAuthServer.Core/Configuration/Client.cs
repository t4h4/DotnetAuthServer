using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetAuthServer.Core.Configuration
{
    public class Client // spa, mobile or mvc
    {
        public string Id { get; set; }

        public string Secret { get; set; }

        //api1.net, api2.net only access
        public List<String> Audiences { get; set; }
    }
}
