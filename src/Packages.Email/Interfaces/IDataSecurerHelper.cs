namespace Email.Interfaces
{
    public interface IDataSecurerHelper
    {
        string Secure(string data);

        string Read(string data);

        string Name { get; }
    }
}
