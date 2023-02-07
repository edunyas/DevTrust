using System.IO;

namespace DevTrust.Services
{
    public interface IDataAccessService
    {
        void WriteAllText(string path, string contents);
    }

    public class DataAccessService : IDataAccessService
    {
        public void WriteAllText(string path, string contents)
        {
            File.WriteAllText(path, contents);
        }
    }
}
