using Email.Interfaces;
using System.Text;

namespace Email.Implementations
{
    public class Base64DataSecurerHelper : IDataSecurerHelper
    {
        public string Name => "Base64";

        public string Read(string data)
        {
            var encodedBytes = Convert.FromBase64String(data);
            return Encoding.UTF8.GetString(encodedBytes);
        }

        public string Secure(string data)
        {
            var bytes = Encoding.UTF8.GetBytes(data);
            return Convert.ToBase64String(bytes);
        }
    }
}
