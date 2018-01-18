using InvoiceOTC.Model;
using FSCollections;

namespace InvoiceOTC.Repository.API
{
    public interface ILog4NetRepository
    {
        void Save(Logs data);
        FSBindingList<Logs> GetAll();
    }
}
