using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetAuthServer.Core.Models
{
    public class UserRefreshToken
    {
        public string UserId { get; set; } // RefreshToken owner person id
        public string Code { get; set; }
        public DateTime Expiration { get; set; } // token life time
    }
}
