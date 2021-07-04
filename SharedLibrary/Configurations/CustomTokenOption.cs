using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Configurations
{
    // Details: https://www.t4h4.net/wp-content/uploads/2021/07/561651561.png
    public class CustomTokenOption
    {
        public List<String> Audience { get; set; }
        public string Issuer { get; set; }

        public int AccessTokenExpiration { get; set; }
        public int RefreshTokenExpiration { get; set; }

        public string SecurityKey { get; set; }
    }
}
