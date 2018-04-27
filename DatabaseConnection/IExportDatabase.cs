namespace DatabaseConnection
{
    public interface IExportDatabase : IDatabaseConnection
    {
        bool ExportData();
        bool ExportData(string filepath);
    }
}
