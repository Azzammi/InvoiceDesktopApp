
namespace DatabaseConnection
{
    public interface IImportDatabase : IDatabaseConnection
    {
        bool ImportDatabase();
        bool ImportDatabase(string filename);
    }
}
