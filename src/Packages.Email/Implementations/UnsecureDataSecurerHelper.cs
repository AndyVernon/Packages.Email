using Email.Interfaces;

namespace Email.Implementations
{
    public class UnsecureDataSecurerHelper : IDataSecurerHelper
    {
        public string Name => "Unsecure";

        public string Read(string data)
        {
            return data;
        }

        public string Secure(string data)
        {
            return data;
        }
    }
}
