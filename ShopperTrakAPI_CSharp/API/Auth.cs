using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopperTrakAPI_CSharp
{
    public class Credentials
    {
        public string username { get; set; }
        public string password { get; set; }
        public string authString { get; private set; }

        public Credentials(string _username, string _password)
        {
            this.username = _username;
            this.password = _password;
            this.authString = Base64Encode(this.username + ":" + this.password);
        }

        internal string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
